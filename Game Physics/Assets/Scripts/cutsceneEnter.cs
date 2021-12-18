using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cutsceneEnter : MonoBehaviour
{
    public GameObject thePlayer;
    public GameObject cutsceneCam;

    void onTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            cutsceneCam.SetActive(true);
            thePlayer.SetActive(false);

        }
    }

  
}
