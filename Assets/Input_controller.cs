using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Input_controller : MonoBehaviour
{
        public GameObject leftPaddle;
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        leftPaddle.GetComponent<Rigidbody>().velocity = new Vector3 ( 0f, 0f, 0f);

        if (Input.GetKey (KeyCode.UpArrow)) {
            
            //Debug.Log("Up Arrow Input");
            leftPaddle.GetComponent<Rigidbody>().velocity = new Vector3 (0f, 7f, 0f);
        

        } else 
        if (Input.GetKey (KeyCode.DownArrow)) {
            //Debug.Log("Down Arrow Input");
            leftPaddle.GetComponent<Rigidbody>().velocity = new Vector3 (0f,-7f,0f);
        }


    }
}
