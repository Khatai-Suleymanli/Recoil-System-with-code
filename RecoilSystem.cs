using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecoilSystem : MonoBehaviour
{
    public GameObject Gun; // Reference to the Gun game object
    private Gun gun; // Reference to the Gun script attached to the same game object
    public PlayerManager pullet; // Reference to the PlayerManager script

    Animator animator; // Reference to the Animator component attached to the same game object

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>(); // Get the Animator component attached to the game object
        gun = GetComponent<Gun>(); // Get the Gun script attached to the game object
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0) && gun.isAuto && pullet.bullet > 0)
        {
            animator.SetBool("AutoFire", true); // Set the "AutoFire" parameter of the Animator to true
            // StartCoroutine(startRecoilauto());
            //Gun.GetComponent<Animator>().Play("RecoilAnimation");
        }

        if (pullet.bullet <= 0)
        {
            animator.SetBool("AutoFire", false); // Set the "AutoFire" parameter of the Animator to false
        }

        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            animator.SetBool("AutoFire", false); // Set the "AutoFire" parameter of the Animator to false
        }

        if (Input.GetMouseButtonDown(0) && !gun.isAuto)
        {
            StartCoroutine(startRecoil()); // Start the coroutine for recoil effect
            //Gun.GetComponent<Animator>().Play("RecoilAnimation");
            //Gun.GetComponent<Animator>().Play("New State");
        }
    }

    IEnumerator startRecoil()
    {
        if (pullet.bullet != 0)
        {
            Gun.GetComponent<Animator>().Play("RecoilAnimation"); // Play the "RecoilAnimation" state in the Animator
            yield return new WaitForSeconds(0.10f); // Wait for 0.10 seconds
            Gun.GetComponent<Animator>().Play("New State"); // Play the "New State" state in the Animator
        }
    }

    /*IEnumerator startRecoilauto()
    {
        if (pullet.bullet!=0)
        {
            //Gun.GetComponent<Animator>().Play("RecoilAnimation");
            //yield return new WaitForSeconds(0.1f);
            //Gun.GetComponent<Animator>().Play("New State");
        }
    }*/
}
