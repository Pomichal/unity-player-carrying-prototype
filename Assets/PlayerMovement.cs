using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 1000;
    public float jumpSpeed = 10;
    public string axisName = "Horizontal";
    public KeyCode jumpButton;

    Rigidbody2D rb;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        float hor = Input.GetAxis(axisName);

        rb.velocity = new Vector2(hor * speed * Time.deltaTime, rb.velocity.y);

        if(Input.GetKeyDown(jumpButton))
        {
            rb.velocity += new Vector2(0, jumpSpeed);
        }

        
    }
}
