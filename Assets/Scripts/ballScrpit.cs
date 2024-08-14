using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballScrpit : MonoBehaviour
{

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float ballForce;
    [SerializeField] private float ForceIns;
    
    public float ballfall = -4;
    public Ui ui;


    // Start is called before the first frame update
    private void Start()
    {

        rb.AddForce(new Vector2(ballForce, ballForce));


    }

    // Update is called once per frame
    private void Update()
    {

        

        OutOfBounds();


    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.name == "stick")
        {
            rb.AddForce(new Vector2(ForceIns, ForceIns));
        }
    }



    public void OutOfBounds()
    {

        if(transform.position.y < ballfall)
        {
            ui.GameOver();
        }
    }

}

