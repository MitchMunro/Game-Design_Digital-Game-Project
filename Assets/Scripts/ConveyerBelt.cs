using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyerBelt : MonoBehaviour
{
    public float boostRate = 5;
    public bool isGoRight = true;


    private void OnCollisionStay2D(Collision2D collision)
    {
        Debug.Log(collision);

        if (collision.collider.tag == "ScoringObject")
        {
            var rb = collision.gameObject.GetComponent<Rigidbody2D>();
            float direction = isGoRight ? 1 : -1;
            rb.AddForce(new Vector2(boostRate * direction, 0));

        }
    }

    private void FixedUpdate()
    {
        
    }
}
