using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cutSceneEnterStart : MonoBehaviour
{
    public GameObject thePlayer;
    public Camera mainCamera;
    public Camera cutsceneCam;
    public Animator animator;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            this.gameObject.GetComponent<BoxCollider>().enabled = false;
            cutsceneCam.enabled = true;
            animator.enabled = true;
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
        cutsceneCam.enabled = false;
        animator.enabled = false;
    }
}
