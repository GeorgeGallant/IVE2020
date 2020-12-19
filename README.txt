This project uses the SteamVR SDK to piggyback some assets into scenes

The canvas options on the notebook are enabled after a timer which can be set in the inspector before play
There is a prefab varient of the player with the notebook to be used in each separate scene it is needed
In other words, the options and timer for the canvas will need to be set within the inspector for each scene

I removed the pointer finger being used the select an item in the canvas, it was far too unreliable for release
The player still needs to use their hand to press the button but it can be with any part of the hand once the timer is up

The radio is set up to have an "On trigger down" event in the inspector which can be set to enable whichever script is added to it
The player just has to pick up the radio with their right hand and press the index trigger to set off the event

