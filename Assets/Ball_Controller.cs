using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Controller : MonoBehaviour
{
   Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
     
        StartCoroutine(Pause());

     
      
    }

    // Update is called once per frame
    void Update()
    {   
       
    }
 

    void moveBall () {
        
       
        rb = GetComponent<Rigidbody> ();
        int x = Random.Range(-11,11);
        int y = Random.Range(-11,11);
      // x = 210;
      // y = 210;
        while( x == 0)
            x = Random.Range(-11,11);
        rb.velocity = new Vector3(x,y,0);
    }


    IEnumerator Pause () {
           // Debug.Log(Time.time);
            Debug.Log("In Pause");
            //rb.velocity = new Vector3 (0f,0f,0f);
            //rb.velocity = Vector3.zero;
            transform.position  = Vector3.zero;
            
            yield return new WaitForSeconds (3.0f);
            moveBall();
            Debug.Log("Finished Pauise");
         //   Debug.Log(Time.time);

    }



    void OnCollisionEnter (Collision hit){

            float x = 0;
            float y = 0;


            if(hit.gameObject.name == "Top Bound"){

                //Debug.Log("Hit the top Boundry");

            }
            if(hit.gameObject.name == "Bot Bound"){

                //Debug.Log("Hit the Bot Boundry");

            }

            if(hit.gameObject.name == "Player Paddle"){


                if(transform.position.y > hit.gameObject.transform.position.y + 0.5) {
                  //  Debug.Log("Upper third hit");
                    y = Random.Range(6,11);
                    x = rb.velocity.x;
                    rb.velocity = new Vector3(x,y,0);

                } 
                else if (transform.position.y < hit.gameObject.transform.position.y - 0.5){

                    //Debug.Log("Lower third hit");
                    y = Random.Range(-6,-11);
                    x = rb.velocity.x;
                    rb.velocity = new Vector3(x,y,0);

                }
                else if (transform.position.y < hit.gameObject.transform.position.y + 0.5 
                        && transform.position.y > hit.gameObject.transform.position.y - 0.5){

                    //Debug.Log("Middle Third hit");

                }



            }
if(hit.gameObject.name == "Op Paddle"){


                if(transform.position.y > hit.gameObject.transform.position.y + 0.5) {
                    //Debug.Log("Upper third hit");
                    y = Random.Range(6,11);
                    x = rb.velocity.x;
                    rb.velocity = new Vector3(x,y,0);

                } 
                else if (transform.position.y < hit.gameObject.transform.position.y - 0.5){

                    //Debug.Log("Lower third hit");
                    y = Random.Range(-6,-11);
                    x = rb.velocity.x;
                    rb.velocity = new Vector3(x,y,0);

                }
                else if (transform.position.y < hit.gameObject.transform.position.y + 0.5 
                        && transform.position.y > hit.gameObject.transform.position.y - 0.5){

                    //Debug.Log("Middle Third hit");

                }

                



            } 
            //Debug.Log("Hit a boundry");

    if (hit.gameObject.name == "Left Bound" ) {
                    //Debug.Log("Hit sie boundary");
                    rb.velocity = new Vector3 (0f,0f,0f);
                    Score_Controller.score.oppPoint();
                    StartCoroutine(Pause());

                }
        else if(hit.gameObject.name == "Right Bound") {
                    //Debug.Log("Hit sie boundary");
                    rb.velocity = new Vector3 (0f,0f,0f);
                    Score_Controller.score.playerPoint();
                    StartCoroutine(Pause());


        }

        }


}
