# Platformer Reflection
## Platformer-1
In this prototype I was experimenting with fall damage and calculating fall hight. I was quite proud of myself for finding a way to save the peak of a jump (or start of a fall) and then compare it to the end of a fall to calculate the distance and then apply damage. I learned how to detect when a players vertical velocity changes from positive to negative, along with learning how to lock movememnt controls to the perspective of the camera rather than tank controls (thank goodness). 

[Play platformer version 1](https://cc3265a.github.io/game-dev-spring2025/builds/platformer-1/)

<img src="./images/platformer-1.png" alt="Platformer gameplay, its just 2 platforms and a bright blue rectangle" align="right" width="350">

## Platformer-2
In this version I added collectables ("memories"), "enemies" (spike balls), and an attack (slash in front of player). I also added a hat and the ability to change which direction the player model was facing based off of movement. I learned how to make an aspect of the player disappear and reappear at will (disabling and re-enabling a child object). 

[Play platformer version 2](https://cc3265a.github.io/game-dev-spring2025/builds/platformer-2/)

<img src="./images/platformer-1.png" alt="Platformer gameplay, there are now 7 platforms, 3 spike balls blocking the players way, and 1 red cube which is a memory to collect. The player now has a wizard hat and there is a sign explaining the controls." align="right" width="350">

## Platformer-final
In this version I edited the "slash" to be a game object rather than a png on an object (were I making this a game for real I would attempt to animate this but thats not the point of this class). I also locked the player movement so you can no longer go forwards and back, only side to side and up and down. I did this because I wanted a 2.5D game rather than a 3D one. In part I chose this because I felt the depth perception was clunky and difficult, but also because the platformers we talked about in class were almost all 2D, so it felt more faithful somehow. I learned how to restrict player movement.

[Play platformer final version](https://cc3265a.github.io/game-dev-spring2025/builds/platformer-final/)

<img src="./images/platformer-1.png" alt="Platformer gameplay, the visuals of this version didn't change, but this time the camera view shows the starting position of the player and the new slash visual." align="right" width="350">



