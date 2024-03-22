using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HumanRacket : Racket
{

    protected override void Movement()
    {
        
        float moveAxes = Input.GetAxis(AxesName) * moveSpeed;

        rigidBody.velocity = new Vector2(0, moveAxes);
    }
}
