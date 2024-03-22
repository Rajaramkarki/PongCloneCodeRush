using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Racket LeftRacket, RightRacket;
    public Rigidbody2D ballRigidBody;
    public float moveSpeed;

    void Start()
    {
        //ball start
        ballRigidBody.velocity = new Vector2(1, 1) * moveSpeed;

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        TagForWalls tagForWalls = collision.gameObject.GetComponent<TagForWalls>();


        //checks tag for the walls
        if (tagForWalls == null)
        {
            return;
        }

        Tag tag = tagForWalls.wallTag;

        if (tag.Equals(Tag.leftWall))
        {
            RightRacket.GetScore();
        }

        if (tag.Equals(Tag.rightWall))
        {
            LeftRacket.GetScore();
        }
        if (tag.Equals(Tag.leftRacket))
        {
            wayBall(collision, 1);
        }
        if (tag.Equals(Tag.rightRacket))
        {
            wayBall(collision, -1);
        }
    }


    //controls mvoement of ball in 2d physics
    private void wayBall(Collision2D collision, int x)
    {
        //vertical distance between the ball's current position and the position of the object it collided with 
        float a = transform.position.y - collision.gameObject.transform.position.y;

        //ges y comp of the object that the ball collided with
        float b = collision.collider.bounds.size.y;

        //normalized value - relative posisiton of the collision point with y axis of the collided object
        float y = a / b;
        ballRigidBody.velocity = new Vector2(x, y)*moveSpeed;
    }
}
