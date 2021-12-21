using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class semi_endCamTrigger : MonoBehaviour
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
            this.gameObject.GetComponent<BoxCollider>().enabled = false;
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
        yield return new WaitForSeconds(9);
        mainCamera.enabled = true;
        thePlayer.SetActive(true);
        cutsceneCam.enabled = false;
        animator.enabled = false;
    }
}
