using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Start_and_Reset : MonoBehaviour
{
    public GameObject pusher;
    public GameObject pointLight;
    public float moveSpeed = 60f;
    public float fractionWay;
    bool simStart = false;
    bool move = false;
    private Scene scene;
    Vector3 startPos;
    Vector3 endPos;


    private void Start()
    {
        scene = SceneManager.GetActiveScene();
        startPos = transform.position;
        endPos = transform.position + new Vector3(10,0,0);
    }

    void Update()
    {
       
        bool down = Input.GetButtonDown("Jump");            //checks if space is pressed
        if (down)
        {
            StartR();
        }
        if (move == true)
        {
          
            //pusher.transform.position += -transform.right * Time.deltaTime;
            fractionWay += 0.01f;
            pusher.transform.position = Vector3.Lerp(startPos, endPos, fractionWay);  //will push the pusher to start the level

        }
    }
    
    public void StartR()        //will start or reset the level
    {
        if(pointLight.activeSelf == true)
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
                SceneManager.LoadScene(scene.name);

            }
        }
        else if (simStart == true)
        {
            simStart = false;
            Debug.Log(simStart);
            SceneManager.LoadScene(scene.name);

        }
    }

}