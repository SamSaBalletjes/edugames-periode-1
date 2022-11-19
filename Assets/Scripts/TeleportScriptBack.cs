using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportScriptBack : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        player.transform.position = new Vector3(0, 0, 0);
    }
}
