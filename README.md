# Recoil-System-with-code
Recoil system code for your FPS games

Start() method: Called before the first frame update. It initializes the animator and gun variables by getting the Animator component and Gun script, respectively.

Update() method: Called once per frame. It handles the logic for recoil based on user input and the state of the gun and ammunition.

If the left mouse button is pressed (Input.GetMouseButton(0)) and the gun is set to automatic fire (gun.isAuto) and there is ammunition available (pullet.bullet > 0), it sets the "AutoFire" parameter of the Animator to true. This triggers the recoil animation.
If the ammunition reaches zero (pullet.bullet <= 0), it sets the "AutoFire" parameter of the Animator to false.
If the left mouse button is released (Input.GetKeyUp(KeyCode.Mouse0)), it sets the "AutoFire" parameter of the Animator to false.
If the left mouse button is pressed (Input.GetMouseButtonDown(0)) and the gun is not set to automatic fire (!gun.isAuto), it starts the coroutine startRecoil() to play the recoil animation.
startRecoil() method: A coroutine that plays the recoil animation. It checks if there is ammunition available (pullet.bullet != 0), plays the "RecoilAnimation" state in the Animator, waits for 0.10 seconds using yield return new WaitForSeconds(0.10f), and then plays the "New State" state in the Animator.
