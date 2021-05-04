using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScorePoint : MonoBehaviour
{
public Ball_instantiate createball;
public Scoreboard ScoreManager;
public GameObject leftScore;
public GameObject rightScore;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D score){
        if (this.gameObject.name == "Left Score Zone"){
            //Debug.Log("Left Zone Collision");
            ScoreManager.scorePoint(rightScore, 0);
        }
        else if (this.gameObject.name == "Right Score Zone"){
            ScoreManager.scorePoint(leftScore,1);
        }
        Destroy(score.gameObject);
        createball.SpawnBall();
    }
}
