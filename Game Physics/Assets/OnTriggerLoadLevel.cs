using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnTriggerLoadLevel : MonoBehaviour
{

    public GameObject enterText;
    public string levelToLoad;
    private GameMaster gm;
    void Start()
    {
        enterText.SetActive(false);
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
    }

    // Update is called once per frame
    void OnTriggerStay(Collider plyr)
    {
        if (plyr.gameObject.tag == "Player")
        {
            enterText.SetActive(true);
            SceneManager.LoadScene(levelToLoad);
            transform.position = gm.lastcheckpos;
            
        }
    }
    void OnTriggerExit(Collider plyr)
    {
        if (plyr.gameObject.tag == "Player")
        {
            enterText.SetActive(false);
        }
    }
}