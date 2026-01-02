using System.Diagnostics;
using System.Runtime.InteropServices;

class Program
{
    [DllImport("user32.dll")]
    static extern bool SetForegroundWindow(IntPtr hWnd);

    [DllImport("user32.dll")]
    static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

    [DllImport("user32.dll")]
    static extern bool IsIconic(IntPtr hWnd);

    // Det her er tricket: Vi bruger "SystemParametersInfo" til midlertidigt 
    // at deaktivere fokus-spærren i Windows helt.
    [DllImport("user32.dll", SetLastError = true)]
    static extern bool SystemParametersInfo(uint uiAction, uint uiParam, IntPtr pvParam, uint fWinIni);

    static int Main(string[] args)
    {
        if (args.Length == 0 || args[0] == "-h")
        {
            Help();
            return 0;
        }

        if (args.Length == 0 || args[0] == "-l" || args[0] == "list")
        {
            ListProcesses();
            return 0;
        }

        var procs = Process.GetProcessesByName(args[0]);
        if (procs.Length > 0)
        {
            FocusProcessWindow(procs);
            return 0;
        }
        else
        {
            Console.WriteLine($"Process not found '{args[0]}'");
            return -1;
        }
    }

    private static void FocusProcessWindow(Process[] procs)
    {
        const uint SPI_GETFOREGROUNDLOCKTIMEOUT = 0x2000;
        const uint SPI_SETFOREGROUNDLOCKTIMEOUT = 0x2001;
        const int SW_RESTORE = 9;

        IntPtr hWnd = procs[0].MainWindowHandle;

        // 1. Gem den nuværende timeout-værdi for fokus
        IntPtr timeout = IntPtr.Zero;
        SystemParametersInfo(SPI_GETFOREGROUNDLOCKTIMEOUT, 0, timeout, 0);

        // 2. Sæt timeout til 0 (dvs. tillad fokus-skift med det samme)
        SystemParametersInfo(SPI_SETFOREGROUNDLOCKTIMEOUT, 0, IntPtr.Zero, 0);

        // 3. Bring vinduet frem
        if (IsIconic(hWnd)) ShowWindow(hWnd, SW_RESTORE);
        SetForegroundWindow(hWnd);

        // 4. Sæt timeout tilbage til hvad den var (valgfrit, men god stil)
        SystemParametersInfo(SPI_SETFOREGROUNDLOCKTIMEOUT, 0, timeout, 0);
    }

    private static void ListProcesses()
    {
        Process.GetProcesses()
            .Where(x => x.MainWindowHandle != IntPtr.Zero)
            .OrderBy(x => x.ProcessName)
            .Select(x => $"{x.Id,5}: {x.ProcessName,-18} title: {x.MainWindowTitle}")
            .ToList()
            .ForEach(x => Console.WriteLine(x));
    }

    private static void Help()
    {
        Console.WriteLine(@"
Focus, (c) 2026 by Kasper B. Graversen
======================================

Help

focus [list|-l] processname

    list           List all applications that can be made focusable
    processname    Focus the given process name - the name has to be exact
");
    }
}