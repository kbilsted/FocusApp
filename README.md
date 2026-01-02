# FocusApp
Focus any windows application with a click of a button... or key.


# 1. Installation

* Download the code and build the exe file. 
* or download a binary from the relases. Requires .net 6, 8, or 10.

place the exe file whereever you want.



# 2. Setup

## 2.1 Figure out what names to use
This program can only give focus to already open appliations. To find out the names of the applications you want to jump to/focus all with the list parameter. Names are case sensitive.

```
> focus.exe list

 6708: chrome             title: Supreme cooking with frogs
24416: devenv             title: Focus - Program.cs - Microsoft Visual Studio
 9056: explorer           title:
 3908: explorer           title: C:\flowers - File Explorer
 5088: firefox            title: The billion dollar race to replace Windows - YouTube - Mozilla Firefox
29020: ms-teams           title: Microsoft Teams
11340: notepad++          title: *readme.md - Notepad++
16984: NVIDIA Share       title: NVIDIA GeForce Overlay
15588: TextInputHost      title: Windows Input Experience
20920: WindowsTerminal    title: C:\games
```

## 2.2 Testing
Before automating ensure the tool works as intended. For example in the console, jump to firefox

```
> Focus.exe firefox
```


## 2.3 Setup your hot keys
This application cannot bind your hot keys, for that you need a hotkey/keyboard tool. Fortunately, there are many good ones freely available. I recommend using "Keymapper" from https://github.com/houmain/keymapper if you don't like keymapper, perhaps you will like AutoHotKey. 

I have bound key combinations with tab, such that holding Tab-N brings me to notepad++, Tab-O brings me to outlook, Tab-T brings me to teams, ... I chose tab since alt-tab jumps between apps. Nedless to say you can use any short cut. 

My keymapper configuration looks as follows

```
Tab{T}		>> $("C:\temp\Focus.exe ms-teams")
Tab{F}		>> $("C:\temp\Focus.exe firefox")
Tab{N}		>> $("C:\temp\Focus.exe notepad++")
Tab{O}		>> $("C:\temp\Focus.exe outlook")
Tab{C}		>> $("C:\temp\Focus.exe WindowsTerminal")
```


# 3. Bugs
The program cannot focus the `explorer` task for some reason. 



# 4. Research
Perhaps it doesn't seem like a big thing to alt-tab-tab-tab or reach for the mouse and find the icon in your task bar. The importance is not the few seconds you save each time! It is that you are able to perform tasks without having to spend mental energy finding a specific app, or calculating how many times to press alt-tab.

Paraphrasing reasearch, I hope to convince you that this journey is totally worth it!


*Reducing Cognitive Load:* from cognitive psychology, "Learning and problem-solving are hindered when working memory is overloaded."
    By automating frequent actions with shortcuts, you reduce the mental effort needed for routine tasks, allowing your brain to focus on more complex issues instead of juggling multiple steps.

*Automation and Habit Formation:*
    "Repeated practice transforms controlled processes into automatic ones, freeing up cognitive resources."
    Shortcuts help turn repeated tasks into habits, enabling you to perform them effortlessly, almost instinctively.

*Priming and Mental Readiness:*
    "Exposure to certain cues or repeated actions prepares the brain for faster response." 
    When you habitually use shortcuts, your brain becomes "primed" to execute these actions without conscious effort, maintaining a smooth workflow.

*Flow and Work Continuity:*
    "Any interruption or friction in the process can break this flow."
    Shortcuts eliminate the friction caused by navigation or manual input, helping you stay in that optimal zone of productivity.

*Avoiding Frustration and Distraction:*
    "Task switching incurs a cognitive cost, called switch cost, which reduces overall performance."
    Shortcuts reduce the need to switch contexts or use the mouse, thereby minimizing switch costs and maintaining focus.



have fun :-)

Kasper B. Graversen

