This project uses the SteamVR SDK to piggyback some assets into scenes

The canvas options on the notebook are enabled after a timer which can be set in the inspector before play
There is a unique prefab of a player for each scene, each one will need to be added to its correct scene and the info will need to be added in the inspector
In other words, the options and timer for the canvas will need to be set within the inspector for each scene
The timer is located inside the player prefab and can be adjusted in the scene view, you just need to find the "TimerContoller" object and
input the number of seconds needed before the user can select the buttons
The canvas buttons will need to be adjusted on each individual notebook, they are all named to match the correct player/scene and adjusting one will not affect the others


I removed the pointer finger being used the select an item in the canvas, it was far too unreliable for release
The player still needs to use their hand to press the button but it can be with any part of the hand once the timer is up


The radio is set up to have an "On trigger down" event in the inspector which can be set to enable whichever script is added to it
The player just has to pick up the radio with their right hand and press the index trigger to set off the event

*Any scenes with a "Main Camera" object will need to have that object removed*
*Any scenes that do not use a specific player with a notebook prefab will need to use a generic one ("VRPlayer")


****DO NOT REIMPORT STEAMVR AT ANY POINT**** This WILL break the whole build!