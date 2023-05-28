# Recoil System

The Recoil System is a script designed for Unity game development. It provides a mechanism for applying recoil effects to a gun in response to user input.

## Getting Started

To use the Recoil System in your Unity project, follow these steps:

1. Attach the `RecoilSystem` script to the game object that represents the gun.
2. Assign the gun game object to the `Gun` variable in the Inspector.
3. Ensure that the gun game object has an Animator component attached to it.
4. If the gun has an automatic firing mode, set the `isAuto` flag to `true` in the attached `Gun` script.
5. If you have a player manager script to track ammunition, assign it to the `pullet` variable in the Inspector.
6. Customize the recoil animation by creating appropriate states and transitions in the Animator component attached to the gun game object.

## How It Works

The Recoil System script consists of the following components and functions:

### Components

- `Gun`: This component represents the gun and is assumed to be attached to the same game object as the Recoil System script. It provides information about the gun's firing mode (automatic or not) through the `isAuto` flag.

- `PlayerManager`: This component tracks the player's ammunition count. If available, assign this component to the `pullet` variable in the Inspector.

### Functions

- `Start()`: This function is called before the first frame update. It initializes references to the Animator component and the Gun script attached to the gun game object.

- `Update()`: This function is called once per frame. It handles the logic for applying recoil effects based on user input and the state of the gun and ammunition.

  - If the left mouse button is pressed and the gun is set to automatic fire and there is ammunition available, the "AutoFire" parameter of the Animator is set to true, triggering the recoil animation.

  - If the ammunition count reaches zero, the "AutoFire" parameter of the Animator is set to false, disabling the recoil animation.

  - If the left mouse button is released, the "AutoFire" parameter of the Animator is set to false.

  - If the left mouse button is pressed and the gun is not set to automatic fire, the `startRecoil()` coroutine is started to play the recoil animation.

- `startRecoil()`: This coroutine plays the recoil animation. It checks if there is ammunition available, plays the "RecoilAnimation" state in the Animator, waits for a short duration, and then plays the "New State" state in the Animator. This provides a visual effect simulating recoil.

## Notes

- The Recoil System script assumes that the gun game object has an Animator component with appropriate states and transitions for the recoil animation. You can customize the recoil animation by modifying the Animator component attached to the gun game object.

- The script supports both automatic and single-shot firing modes. If the gun is set to automatic fire, the recoil animation will play as long as the user holds down the left mouse button and there is ammunition available.

- The script works in conjunction with a player manager script (`PlayerManager`) that tracks ammunition count. If you have a player manager script in your project, you can assign it to the `pullet` variable in the Inspector to enable ammunition tracking.

- The script includes a commented out method (`startRecoilauto()`) that seems to be a placeholder for implementing automatic fire recoil. However, this method is currently not utilized in the code and can be ignored unless you decide to implement automatic fire recoil in the future.

Thanks for using my code
