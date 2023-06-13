using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ball : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    public Vector3 startPosition;
    private bool pause = false;
    public Text welcome;

    void Start()
    {
        startPosition = transform.position;
        welcome.text = "Welcome to PONG\n Player 1 : W,S \n Player 2 : Arrow Up, Down \nEsc to quit game";
        Time.timeScale = !pause ? 0f : 1f;
        Launch();
    }
    public void Reset()
    {
        rb.velocity = Vector2.zero;
        transform.position = startPosition;
        Launch();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            
            Time.timeScale = pause ? 0f : 1f;
            welcome.text = "";
        }
        else
        {
            Time.timeScale = pause ? 0f : 1f;
            welcome.text = "";
        }
    }

    private void Launch()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        rb.velocity = new Vector2(speed * x, speed * y);
    }
}
