# FocusApp
Focus any windows application with a click of a button... this utility enables you to quickly jump between the apps you want.


# 1. Installation

* Download the code and build the exe file. 
* or download a binary from the relases. Requires .net 6, 8, or 10.
* perhaps you need the .net runtime - not sure if windows is shipping rudimentary packages nowadays.
  
place the exe file whereever you want.



# 2. Setup

## 2.1 Figure out what names to use
This program can only give focus to already open appliations and it does this by finding the process names you specify. To find out the names of the applications you want to jump to/focus, call the tool using the `list` parameter.  Names are case sensitive!

example:

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
Before automating ensure the tool works as intended. Open a terminal/console as administrator and try jumping to any of the applications in your list. For example, jump to firefox

```
> Focus.exe firefox
```


## 2.3 Setup your hot keys
Now that we know things are working, it is time to automate. Our application cannot bind your hot keys, howerver. For that you need a hotkey/keyboard tool. There are many good tools freely available and you can use your favorite! I recommend using, and personally use,  "Keymapper" from https://github.com/houmain/keymapper  If you don't like keymapper, perhaps you will like AutoHotKey. 

I have bound key combinations with tab, such that holding Tab-N brings me to notepad++, Tab-O brings me to outlook, Tab-T brings me to teams, ... I chose tab since alt-tab jumps between apps. Nedless to say you can use any short cut. 

My keymapper configuration looks as follows

```
Tab{T}		>> $("C:\temp\Focus.exe ms-teams")
Tab{F}		>> $("C:\temp\Focus.exe firefox")
Tab{N}		>> $("C:\temp\Focus.exe notepad++")
Tab{O}		>> $("C:\temp\Focus.exe outlook")
Tab{C}		>> $("C:\temp\Focus.exe WindowsTerminal")
```


## 2.4 Running keymapper
In order for this to work, you have to start keymapper from a terminal with **run as administrator** otherwise it is not allowed to change focus.

I have not played with running keymapper as a winodws service, but there are possibly solutions on that front too.




# 3. Known bugs
The program cannot focus the `explorer` task for some reason. 



# 4. Why is quick task switching important
Perhaps it doesn't seem like a big thing to alt-tab-tab-tab or reach for the mouse and find the icon in your task bar. The importance is not the few seconds you save each time! It is that you are able to perform tasks without having to spend mental energy finding a specific app, or calculating how many times to press alt-tab.

Paraphrasing reasearch, I hope to convince you, that this journey is totally worth it!


**Reducing Cognitive Load:** from cognitive psychology, *"Learning and problem-solving are hindered when working memory is overloaded."*
    By automating frequent actions with shortcuts, you reduce the mental effort needed for routine tasks, allowing your brain to focus on more complex issues instead of juggling multiple steps.

**Automation and Habit Formation:**
    *"Repeated practice transforms controlled processes into automatic ones, freeing up cognitive resources."*
    Shortcuts help turn repeated tasks into habits, enabling you to perform them effortlessly, almost instinctively.

**Priming and Mental Readiness:**
    *"Exposure to certain cues or repeated actions prepares the brain for faster response."* 
    When you habitually use shortcuts, your brain becomes "primed" to execute these actions without conscious effort, maintaining a smooth workflow.

**Flow and Work Continuity:**
    *"Any interruption or friction in the process can break this flow."*
    Shortcuts eliminate the friction caused by navigation or manual input, helping you stay in that optimal zone of productivity.

**Avoiding Frustration and Distraction:**
    *"Task switching incurs a cognitive cost, called switch cost, which reduces overall performance."*
    Shortcuts reduce the need to switch contexts or use the mouse, thereby minimizing switch costs and maintaining focus.


---


have fun :-)

Kasper B. Graversen

