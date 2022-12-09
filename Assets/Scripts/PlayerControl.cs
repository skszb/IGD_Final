using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [SerializeField]
    private Transform spawnPoint;
    
    
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    
 

    private void OnTriggerStay(Collider other)
    {
        if (other.transform.CompareTag("Monster"))
        {
            print("died");
            transform.position = spawnPoint.position;
        }    
    }
}
