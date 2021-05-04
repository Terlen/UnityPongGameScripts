using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPaddle_Move : MonoBehaviour
{
    Rigidbody2D paddle_rigid;
    public float adjust;
    public bool moveUp = true;
    public bool moveDown = true;
    public string collision;

    // Start is called before the first frame update
    void Start()
    {
        paddle_rigid = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("up") && !(Input.GetKey("down")) && moveUp){
            Vector2 position = paddle_rigid.transform.position;
            position.y += adjust;
            paddle_rigid.position = position;
        }
        if (Input.GetKey("down") && !(Input.GetKey("up")) && moveDown){
            Vector2 position = paddle_rigid.transform.position;
            position.y -= adjust;
            paddle_rigid.position = position;
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
