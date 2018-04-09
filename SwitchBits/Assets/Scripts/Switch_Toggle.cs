using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch_Toggle : MonoBehaviour
{
    public bool toggle = false;
    public float turnSpeed = 100f;
    public GameObject other;


    void OnMouseDown()
    {
        Debug.Log("mouse clicked");

        if (toggle == false)
        {
            transform.Rotate(Vector3.forward, turnSpeed * Time.deltaTime);
            toggle = true;
            Debug.Log(toggle);
            other.SetActive(true);

        }

        else if (toggle == true)
        {
            transform.Rotate(-Vector3.forward, turnSpeed * Time.deltaTime);
            toggle = false;
            Debug.Log(toggle);
            other.SetActive(false);

        }
    }
   
}
