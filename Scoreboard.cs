using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoreboard : MonoBehaviour
{
    public string scoreBoardAI;
    public string scoreBoardPlayer;
    public int scorePlayer;
    public int aiScore;
    // Start is called before the first frame update
    void Start()
    {
        scorePlayer = 0;
        aiScore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void scorePoint(GameObject score, int sideFlag){
        if (sideFlag == 1){
           // Debug.Log("Player Score =" + score.GetComponent<UnityEngine.UI.Text>().text);
            scorePlayer++;
            score.GetComponent<UnityEngine.UI.Text>().text = scorePlayer.ToString();
        }
        else if (sideFlag == 0){
            aiScore++;
            score.GetComponent<UnityEngine.UI.Text>().text = aiScore.ToString();
        }
        
    }

    
}
