using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncySurface : MonoBehaviour
{

    [SerializeField]
    private float bounceStrength;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "ball") {
            //when the ball collides with a surface, it will collide
            //at multiple points. normal is the vector at 90 degrees on the
            //surface pointing away from the surface. GetContact(0) will get the
            //0th position, i.e., the center of the player and .normal will get the
            //normal on that plane at that position... 
            Vector2 normal = collision.GetContact(0).normal;
            collision.transform.GetComponent<Ball>().AddForce(-normal * bounceStrength);
        }
    }
}
