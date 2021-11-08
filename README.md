# Assignment-4---Tetris-Racing
This is the second part of assignment 4


# Second part 

I chose to make the Tetris Racing game.

There are 4 lines on the road, Each of them has random cars which appears and moving from top to bottom each car in it's line is different by color , size and speed of moving, The player goal is to dodge all the coming cars.

Movement of the car - Arrow keys - Left and Right 

The red car is the player's car.

![1](https://user-images.githubusercontent.com/57447475/140756046-45803369-f76b-408b-a5a6-2e97cdbdb314.jpeg)


The goal is to dodge all the coming enemy cars .

When crushing into an enemy car - the game is over and an according message is displying.


![2](https://user-images.githubusercontent.com/57447475/140756175-a0cc1372-c55d-4d6b-ba35-33a6420d18f1.jpeg)


# How the game was built :
* I placed a road picture which the camera is on.
* In addition i made a player car which can move to left and right on X axis , this is done by a simple mover Script and a rigidbody2d.
* Also i gave to the car On destroy trigger script - which in case of crushing with the enemy cars , a text mesh pro will display a text of "Game over".
* Finally i did an enemy cars respanwer which holds 4 prefrabs cars , each of them has Random spwaner script which allows them to apper every 'x' seconds and i can
* control on the speed of the coming car and the time between creation of every car.



[link for the game](https://eladwd.itch.io/tetris-racing)







