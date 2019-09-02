using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Score_Controller : MonoBehaviour
{
    public static Score_Controller score;

    public int playerScoreValue;
    public int oppScoreValue;
    public Text playerScore;
    public Text oppScore;

    // Start is called before the first frame update
    void Start()
    {

     score = this;

    }

    // Update is called once per frame
    void Update()
    {
        


    }

    public void playerPoint() {
        playerScoreValue++;
        playerScore.text = playerScoreValue.ToString();

        //Player Victory Screen
        if (playerScoreValue > 6)
            SceneManager.LoadScene(2);
        
    
    }
    public void oppPoint() {
        oppScoreValue++;
        oppScore.text = oppScoreValue.ToString();

        if(oppScoreValue > 6)
            SceneManager.LoadScene(3);
    }

    

}
