using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerPaddle : Paddle
{
    [SerializeField]
    private GameObject ball;

    // Update is called once per frame
    private void FixedUpdate()
    {
        transform.position = new Vector3(transform.position.x,ball.transform.position.y,0);
    }
}
