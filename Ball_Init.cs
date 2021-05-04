using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Init : MonoBehaviour
{
    Rigidbody2D ball_rigidbody;
    Vector2 direction;
    public float startSpeed;
    // Start is called before the first frame update
    void Start()
    {
        ball_rigidbody = GetComponent<Rigidbody2D>();
        float radiants = 0;
        while (radiants == 0){
            radiants = Random.Range(0.7f, 1.3f) * Mathf.PI;
        }    
        direction = new Vector2(Mathf.Cos(radiants), Mathf.Sin(radiants));
        direction.Normalize();
        direction *= startSpeed;
        ball_rigidbody.AddForce(direction);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
