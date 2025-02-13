# Breakout Reflection
## Breakout-1
The goal of breakout version 1 was to create something that resembled the game of breakout in basic function. These goals included a ball that bounces, bricks that break, and a paddle that moves. While these are very low standards, they are the foundations upon which everything else is built. 

In the making of this version I reaquainted myself with the basics of unity. I learned how to destroy gameobjects, lock movement onto certain axes, and create gameobjects at runtime with an array. More broadly I learned the true scope of even a "simple" game like breakout and how many variables there are that one can tune to totally change the way the game plays. Variables include: brick size and spacing, ball speed, paddle size and speed, ball bounce angle, width of playing field, and many more. 

From my playtesters I learned mostly about a lot of small issues. The way the paddle movement felt and the speed of the ball, for example. Mostly though the changes I would make for version 2 were from my own observations.

[Play breakout version 1](https://cc3265a.github.io/game-dev-spring2025/builds/breakout-1/)

<img src="./images/breakout-1-image.png" alt="Breakout gameplay" align="right" width="350">

## Breakout-2
The goal of version 2 was to fix the errors that had been previously identified, as well as something that could (generously) be called levels. I am relatively sure that in the course of making this version I acccidentally saved over version 1, making the two nigh identical. I added points and a very simple UI to keep track of them and lives, which I increased. I added the capacity for "levels" in which, upon each new level the number of bricks would decrease. I initially, and indeed sank a good few hours into, trying to make several different types of bricks which would gradually increase the speed of the ball as in the original version of breakout. However I ran into issues with the speed increasing too quickly and becoming unplayable, or the ball not moving at all. In retrospect I think I could have resolved these with not much more work than I had already done, but instead I tossed the idea to instead make the decreasing number of bricks up to "level" 5. 

Mostly with this version I learned patience. Its a lesson I've learned many times with coding and I'll learn it many more. I learned that the small details of breakout come together to create a much more fun version of the game than a version without the invisible details. I reviewed how to create and use tags to change the behavior upon collisions. 

This time I seem to have deleted the notes I made about the comments from playtesters. The biggest one, though, was that the ball could get stuck going back and forth with very little or no vertical movement, which was boring at best, and a softlock at worst. I also admitted to myself that my levels were bad, and I needed a gimmick for the game. 

[Play breakout version 2](https://cc3265a.github.io/game-dev-spring2025/builds/breakout-2/)
<img src="./images/breakout-2-image.png" alt="Breakout gameplay" align="right" width="350">

## Breakout-3
This version recieved the most important change: falling blocks. Now instead of bricks breaking when hit by the ball, they began to fall. If bricks collided with the paddle you would be slowed. The other change was the addition of bricks which made the ball faster, which I had abandoned in version 2. I also fixed the issue of no vertical movement, added a "sprint" function for the paddle, and changed what constituted levels. Version 3 levels would increase the rates of the randomly spawning magenta bricks, which made you faster. This would increase the difficulty of each level as you progressed because the ball would get faster and faster and harder to keep up with. These changes came together to create something that someone could "get good" at, or gain mastery over. It also created a marginal sense of progression.

From this version I learned how to control the different axes of a velocity vertex and how to directly alter them. I also learned how to utilize the random function in such a way to determine block spawning, and how to better have my different scripts "communicate" with each other. 

My playtesters had valuable feedback. The playing field was too wide, which meant longer times of waiting for the ball to reach the bricks or paddle. It also meant that there were more bricks which slowed down the gameplay and any sense of progression. They also told me that the paddle needed in indicator for when you were slowed, because without it it could feel like you lost control for no reason, which pulls the player out of the game. Addditionally, my playtesters gave me several ideas, upon my request, for what additional features my game could include. These ideas were new brick variants which would either spawn more balls or create one large wrecking ball.

[Play breakout version 3](https://cc3265a.github.io/game-dev-spring2025/builds/breakout-3/)
<img src="./images/breakout-3-image.png" alt="Breakout gameplay" align="right" width="350">

## Breakout-final
This was the most visually striking change. I'm not sure if I was meant to save over breakout-3 with these final changes but I didn't. In this version I changed the size of playing field, moved the UI, added a brick that spawns temporary extra balls, changed the paddle color when you are slowed, and tweaked ball movement to ensure fast paced gameplay. I also changed the way levels work so now the proportion of special to normal blocks increases as you progress. 

I less learned and more put together the skills I had already been practicing. Using bits and pieces from my previous code was the predominant method for executing the new behaviors. Even with that, it still took quite a while. Class was cancelled this week, so no new feedback, but thats okay because there is no time to make changes anyway.

[Play breakout version final](https://cc3265a.github.io/game-dev-spring2025/builds/breakout-final/)
<img src="./images/breakout-final-image.png" alt="Breakout gameplay" align="right" width="350">

Controls: arrow keys to move and left shift to move paddle faster
For debugging (and grading) purposes: press space to skip to next level
