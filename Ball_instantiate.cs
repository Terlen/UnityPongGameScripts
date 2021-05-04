using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball_instantiate : MonoBehaviour

{

    public GameObject Ball;
    public GameObject ballClone;
    public Scoreboard ScoreManager;
    public GameObject win;
    public GameObject lose;
    int playerScore;
    int aiScore;
    // Start is called before the first frame update
    void Start()
    {
        SpawnBall();

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnBall(){
        playerScore = ScoreManager.scorePlayer;
        aiScore = ScoreManager.aiScore;
        if (playerScore < 5 && aiScore < 5){
            StartCoroutine(BallDelay());

            IEnumerator BallDelay(){
                yield return new WaitForSeconds(2);
                ballClone = Instantiate(Ball);
                ballClone.SetActive(true);
            }

        

        

        }
        else{
            if (playerScore == 5){
                win.gameObject.SetActive(true);
                StartCoroutine(EndDelay());
                IEnumerator EndDelay(){
                    yield return new WaitForSeconds(2);
                    SceneManager.LoadScene("MainMenu");
                }
            }
            else if (aiScore == 5){
                lose.gameObject.SetActive(true);
                StartCoroutine(EndDelay());
                IEnumerator EndDelay(){
                    yield return new WaitForSeconds(2);
                    SceneManager.LoadScene("MainMenu");
            }

            }
        
        }

    void OnGUI(){
        GUI.Label(new Rect(0, 0, 100, 100), (1.0f / Time.smoothDeltaTime).ToString());        
    }


    }
}
