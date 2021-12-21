using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstructionView : MonoBehaviour
{
    public GameObject enterText;
    void Start()
    {
        enterText.SetActive(false);
    }

    // Update is called once per frame
    void OnTriggerStay(Collider plyr)
    {
        if (plyr.gameObject.tag == "Player")
        {
            enterText.SetActive(true);
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
