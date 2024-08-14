using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StckScript : MonoBehaviour
{

    [SerializeField] private float speed;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float MaxX;
    public Score score;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");

        if (x == 0)
        {
            Stop();

        }

        if (x > 0)
        {
            Right();
        }
        if (x < 0)
        {

            Left();
        }

        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, -MaxX, MaxX);
        transform.position = pos;


    }

    private void Left()
    {
        rb.velocity = new Vector2(-speed, 0);
    }

    private void Right()
    {
        rb.velocity = new Vector2(speed, 0);
    }

    private void Stop()
    {
        rb.velocity = Vector2.zero;
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            score.addScore(1);
        }
        

    }
        



    
}

