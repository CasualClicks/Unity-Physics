using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cutSceneEnterStart : MonoBehaviour
{
    public GameObject thePlayer;
    public GameObject cutsceneCam;

    void onTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            this.gameObject.GetComponent<BoxCollider>().enabled = false;
            cutsceneCam.SetActive(true);
            thePlayer.SetActive(false);
            StartCoroutine(FinishCut());
        }
    }

    IEnumerator FinishCut()
    {
        yield return new WaitForSeconds(5);
        thePlayer.SetActive(true);
        cutsceneCam.SetActive(false);
    }
}
