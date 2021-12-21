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
        if (other.gameObject.tag == "Player")
        {
            this.gameObject.GetComponent<BoxCollider>().enabled = false;
            cutsceneCam.enabled = true;
            animator.enabled = true;
            RenderSettings.fog = false;
            before.Pause();
            trigger.Play();
            mainCamera.enabled = false;
            thePlayer.SetActive(false);
            StartCoroutine(FinishCut());
        }
    }

    IEnumerator FinishCut()
    {
        yield return new WaitForSeconds(18);
        mainCamera.enabled = true;
        thePlayer.SetActive(true);
        RenderSettings.fog = true;
        trigger.Pause();
        before.Play();
        cutsceneCam.enabled = false;
        animator.enabled = false;
    }
}
