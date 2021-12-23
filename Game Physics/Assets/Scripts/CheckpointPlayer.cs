using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointPlayer : MonoBehaviour
{

    private GameMaster gm;
    Vector3 spawn;

    void Start()
    {
        spawn = gameObject.transform.position;
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.transform.position.y < 47f)
        {
            gameObject.transform.position = spawn;  
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Checkpoint"))
        {
            spawn = gm.lastcheckpos;
        }
    }
}
