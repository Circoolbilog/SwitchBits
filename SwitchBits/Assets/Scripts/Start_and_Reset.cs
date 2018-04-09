using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start_and_Reset : MonoBehaviour
{
    public GameObject pusher;
    bool simStart = false;
    public float moveSpeed = 60f;

    void Update()
    {
        
        bool down = Input.GetButtonDown("Jump");
        if (down)
        {
            StartR();
        }
    }
    public void StartR()
    {
        if (simStart == false)
        {
            simStart = true;
            Debug.Log(simStart);
            pusher.transform.Translate(new Vector3(1, 0, 0) * Time.deltaTime);
        }
        else if (simStart == true)
        {
            simStart = false;
            Debug.Log(simStart);

        }
    }

}