# CQ3 >> Monster Hunter Portable 3rd Custom Quest Editor

Not gonna lie, this project is very old and I don't think it will be any useful for new MH games but... who knows?
Maybe one day I'll come back to the scene and I realize their new quest structure isn't changed that much and I can simply re-adapt this one.
I'm uploading it on GitHub after such a long time just to make sure I don't lose it if I swap drives or something like that. Just don't judge it, I was 16 y/o when I wrote this.

# What it is?
Let me give a little introduction first: Monster Hunter is a game developed by Capcom and it's very popular in Japan.
The game concept is simple and straightforward: you choose a weapon of your likeness, use it to defeat huge monster and gather materials from them which you use to craft new gears and the cycle continues.
In order to take down a specific monster you have to take part of quests and even if Capcom released from time to time new event quests to keep the game alive, it wasn't just enough. 
Point is: I developed a tool to allow anyone to easily create their own custom quests and upload them on my store so that anyone could play them, even on original consoles / games and what you're looking at is the source code of my custom quest editor.

# How did you manage to do it?
While looking at RAM dumps of the game I found every single structure used by the game: armor/weapon stats, shops, monster stats, strings and quest definitions too.
It took a lot of time of RAM patching experiments to actually understand what each and every byte of the structure were used for but I managed to track everything down.
This piece of software was initially able to generate RAM patches to temporary swap an original DLC quest with a custom made one.
The reason why I choose a DLC quest was that all the DLC contents were always loaded in the same RAM address while legacy quests were not.
Another reason why I went for a DLC quest is that if you "posted" it in a multiplayer session, all the other players were able to join it even if they didn't downloaded it on their system.
I was able to spread the custom quests within the community without any extra effort!
However, I was working on several projects related to this game and one of them was a file unpacker/patcher/packer, it didn't took much long to be able to export the quest files from the original game and DLC data.
By crossing all the information I had, I was then able to open, edit and then save quest files just as they were signed by Capcom itself (yup, I reversed their key!).
That was gamechanging, from that moment on even players with an unmodified console or an unpatched game were able to make, share and play custom quests with people all around the world.
