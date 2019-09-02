using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ai_Controller : MonoBehaviour
{
    public GameObject ai;
    public GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ai.GetComponent<Rigidbody>().velocity = new Vector3 ( 0f, 0f, 0f);

        if(ai.transform.position.y < ball.transform.position.y) {
           // Debug.Log("Ai Paddle moving upward");
            ai.GetComponent<Rigidbody>().velocity = new Vector3(0f,5f,0f);
        }
        else if(ai.transform.position.y > ball.transform.position.y) {
           // Debug.Log("Ai Paddle moving downward");
            ai.GetComponent<Rigidbody>().velocity = new Vector3(0f,-5f,0f);

        }
        

    }
}
