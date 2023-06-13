using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class paddle : MonoBehaviour
{
    public bool isPlayer1;
    public float speed;
    public Rigidbody2D rb;
    private float movement;
    public Vector3 startPosition;
    

    private void Start()
    {
        startPosition = transform.position;
        
    }

    void Update()
    {
        if (isPlayer1)
        {
            movement = Input.GetAxisRaw("Vertical");
          
        }
        else
        {
            movement = Input.GetAxisRaw("Vertical2");
            
        }
        rb.velocity = new Vector2(rb.velocity.x, movement * speed);
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    public void Reset()
    {
        rb.velocity = Vector2.zero;
        transform.position = startPosition;
    }
}
