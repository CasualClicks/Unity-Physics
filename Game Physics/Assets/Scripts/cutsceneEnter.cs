using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cutsceneEnter : MonoBehaviour
{
    public GameObject thePlayer;
    public Camera mainCamera;
    public Camera cutsceneCam;
    public Animator animator;
    public AudioSource before;
    public AudioSource trigger;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            cutsceneCam.enabled = true;
            animator.enabled = true;
            before.Pause();
            trigger.Play();
            mainCamera.enabled = false;
            thePlayer.SetActive(false);
            StartCoroutine(FinishCut());
        }
    }

    IEnumerator FinishCut()
    {
        yield return new WaitForSeconds(27);
        // code from here to change scene to end scene (above code will wait for 27 sec to let camera animation finish then will execute below code)
    }
}
