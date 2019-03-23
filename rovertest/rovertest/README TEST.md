
Write a program which controls the movement of the Mars rover. Please do not spend more than 90 minutes on this task ! !

## The application should be a console app which prompts the controller for the instruction.

    Rotate Left : L
    Rotate Right: R
    Forward: F

## The current rover position should be output in the console.

## Requirements

As a controller user I want the rover to be able to rotate left

- Given the rover is facing North, when  the river rotates Left, Then the rover is facing West.
- Given the rover is facing West, when  the river rotates Left, Then the rover is facing South.
- Given the rover is facing South, when  the river rotates Left, Then the rover is facing East.
- Given the rover is facing East, when  the river rotates Left, Then the rover is facing  North.

As a controller user I want the rover to be able to rotate right

- Given the rover is facing North, when the rover rotates right, Then the rover is facing East.
- Given the rover is facing East, when the rover rotates right, Then the rover is facing South.
- Given the rover is facing South, when the rover rotates right, Then the rover is facing West.
- Given the rover is facing West, when the rover rotates right, Then the rover is facing North.

As a controller user I want the rover to be able to move forward

- Given the Is at position 1.1 and the rover is facing North, when the rover moves forward, the rover is in position 0,1.

As a controller I want to be able to see the rover’s position once it has moved

- When the user moves the rover to (1,1), the rover’s position is displayed in the format(1,1)

As a controller I don’t want the rover to be able to move outside the confines of the grid

- Given the Rover is facing West and is at position (0,0), when the user tries to move forward, the rovers position does not change
