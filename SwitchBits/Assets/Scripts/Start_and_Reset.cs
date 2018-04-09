using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start_and_Reset : MonoBehaviour
{
    public GameObject pusher;
    bool simStart = false;
    public float moveSpeed = 60f;
    bool move = false;

    void Update()
    {
        
        bool down = Input.GetButtonDown("Jump");
        if (down)
        {
            StartR();
        }
        if (move == true)
        {
            pusher.transform.position += transform.right * Time.deltaTime;
        }
    }
    public void StartR()
    {
        if (simStart == false)
        {
            simStart = true;
            Debug.Log(simStart);
            move = true;
        }
        else if (simStart == true)
        {
            simStart = false;
            Debug.Log(simStart);

        }
    }

}