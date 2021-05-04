using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBounce : MonoBehaviour
{

    Rigidbody2D ball_rigidbody;
    Vector2 direction;
    float vertDistanceFromCenter;
    float paddleVertCenter;
    Vector2 touch;
    public Rect sprite;
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("TYest");
        sprite = GetComponent<SpriteRenderer>().sprite.rect;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D rebound){
            //Debug.Log("Collision: " + rebound.gameObject.name);
        
        if (rebound.gameObject.name == "Player Paddle"){
            ball_rigidbody = this.GetComponent<Rigidbody2D>();
            paddleVertCenter = rebound.gameObject.transform.position.y;
            touch = rebound.GetContact(0).point;
            ball_rigidbody.velocity = Vector2.zero;
            ball_rigidbody.angularVelocity = 0;
            direction = new Vector2 (Mathf.Cos((touch.y - paddleVertCenter)*1.0472f),Mathf.Sin((touch.y - paddleVertCenter)*1.309f));
            direction.Normalize();
            direction*=GetComponent<Ball_Init>().startSpeed;
            ball_rigidbody.AddForce(direction);
            
        }

    }
}