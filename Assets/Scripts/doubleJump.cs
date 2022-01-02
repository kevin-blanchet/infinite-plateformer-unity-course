using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleJump : MonoBehaviour
{
    public float jumpForce = 5;
    private int timesJumped = 0;
    private int maxTimesJumped = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && timesJumped < maxTimesJumped)
        {
            Jump();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        timesJumped = 0;
    }

    void Jump()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.up * jumpForce;
        timesJumped++;
    }
}
