# CQ3 >> Monster Hunter Portable 3rd Custom Quest Editor

Not gonna lie, this code is very old, not commented and very messy and I don't think it will be of any use to anybody but... who knows? I'm uploading it on GitHub after such a long time for archive purposes

# What it this?
Let me give a little introduction first: Monster Hunter is a game developed by Capcom and it's very popular in Japan.
The game concept is simple and straightforward: you choose a weapon of your likeness, use it to defeat huge monster and gather materials from them which you use to craft new gears and the cycle continues.
In order to take down a specific monster you have to complete quests and while the game came with a lot of them and Capcom released new ones as DLCs every once in a while it wasn't just enough -- or hard enough.
And that's when I came in: I developed this tool to allow anyone to easily create and play their own custom quests, to upload them on my own [Custom Quests Store](https://github.com/nyirsh/MH3P-CQS) allowing people from all over the world to play them.
What you're looking at right now is the source code of the applicaton, or at least what's left of it.

Story time!
> I sadly was young and naive when I developed this stuff and never really took backups seriously and well, thru the age of time the code was lost and this is what I was able to recover on a very old drive of mine I randomly found one day.
> It is definitively not the latest version that was available to the public but it is in an already working and highly shared stage that, for archiving purposes, is more than enough to me

# How did you manage to get it done?
I took several RAM dumps of the game running and I started looking for strings that were part of a DLC quest I selected for testing such as its title, description and so on and I noticed that in the dumps taken while looking at a DLC quest in the selection menu those strings were always loaded in the same memory address, even thru multiple console restarts. It was then just a matter of time before I figure out where exactly the quest file structure started and even more memory dumps were taken, of quests that had similar properties (the same monster, fighting conditions etc) so I could compare them in a hexadecimal editor hoping to find some common elements between them. As you might expect, by fiddling around with the ram I slowly started to figure out the entire memory structure of quests and this tool was born and it was initially able to generate RAM patches to temporary swap an original DLC quest with a custom made one.
At that time I was also working with other people to make tools for this game that allowed us to unpack and repack it (later used to make translation patches for this game is japanese only) and when matching an extracted DLC quest file with its RAM dump I was able to adjust the tool so it could generate quest files as they were signed by Capcom itself and THAT- was a gamechanger.
From that moment on even players with an original console or an unpatched game were able to create, share and play custom quests with people from all around the world.
