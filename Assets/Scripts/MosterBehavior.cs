using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MosterBehavior : MonoBehaviour
{
    [SerializeField] private Transform targetTransform;
    public NavMeshAgent _agent;
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        _agent.destination = targetTransform.position;
    }
}
