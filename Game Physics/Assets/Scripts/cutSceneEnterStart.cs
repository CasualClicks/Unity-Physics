using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cutSceneEnterStart : MonoBehaviour
{
    public GameObject thePlayer;
    public Camera mainCamera;
    public Camera cutsceneCam;
    public Animator animator;
    public AudioSource before;
    public AudioSource trigger;

    void OnTriggerEnter(Collider other)
    {
        int count = -1;
        if (other.gameObject.tag == "Player" && count == -1)
        {
            this.gameObject.GetComponent<BoxCollider>().enabled = false;
            cutsceneCam.enabled = true;
            animator.enabled = true;
            before.Pause();
            trigger.Play();
            mainCamera.enabled = false;
            thePlayer.SetActive(false);
            StartCoroutine(FinishCut());
            count = 0;
        }
    }

    IEnumerator FinishCut()
    {
        yield return new WaitForSeconds(18);
        mainCamera.enabled = true;
        thePlayer.SetActive(true);
        trigger.Pause();
        before.Play();
        cutsceneCam.enabled = false;
        animator.enabled = false;
    }
}
