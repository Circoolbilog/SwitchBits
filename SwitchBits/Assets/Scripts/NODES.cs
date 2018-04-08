using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class NODES : MonoBehaviour
{

    public Transform cameraPosition;

    public List<NODES> reachableNodes = new List<NODES>();

    [HideInInspector]
    public Collider col;


    // Use this for initialization
    void Start()
    {
        col = GetComponent<Collider>();

    }

  
}