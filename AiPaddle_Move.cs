using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiPaddle_Move : MonoBehaviour
{
    Rigidbody2D paddle_rigid;
    public float adjust;
    public bool moveUp = true;
    public bool moveDown = true;
    public string collision;
    public Ball_instantiate ballSpawn;
    public PlayerPaddle_Move playerPaddle;
    float ballheight;
    float balldistance;

    // Start is called before the first frame update
    void Start()
    {
        paddle_rigid = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (balldistance < 0){
            adjust = playerPaddle.adjust / 2;
        }
        else if (balldistance > 0){
            adjust = playerPaddle.adjust / 1.5f;
        }
        ballheight = ballSpawn.ballClone.transform.position.y;
        balldistance = ballSpawn.ballClone.transform.position.x;
        if ((paddle_rigid.transform.position.y < (ballheight-0.2f)) || (paddle_rigid.transform.position.y > (ballheight+0.2f)) /*&& balldistance > 0*/){
            if ((paddle_rigid.transform.position.y < ballheight) && moveUp){
                Vector2 position = paddle_rigid.transform.position;
                position.y += (adjust*Random.Range(0.8f,1.1f));
                paddle_rigid.position = position;
            }
            else if ((paddle_rigid.transform.position.y > ballheight) && moveDown){
                Vector2 position = paddle_rigid.transform.position;
                position.y -= (adjust*Random.Range(0.8f,1.1f));
                paddle_rigid.position = position;
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D other){
        collision = other.name;
        if (other.name == "Top Border"){
            moveUp = false;
        }
        if (other.name == "Bottom Border"){
            moveDown = false;
        }
    }
    private void OnTriggerExit2D(Collider2D other){
        moveDown = true;
        moveUp = true;
    } 
}
