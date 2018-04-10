using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour
{
    public GameObject WinScreen;

    void OnTriggerEnter(Collider other)
    {
        WinScreen.SetActive(true);
    }
}
