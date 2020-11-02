using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermove : MonoBehaviour
{
    private Animator anim;
    private Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rb=GetComponent<Rigidbody2D>();

        
    }

    // Update is called once per frame
    void Update()
    {
        float xVelocity = 0;
        float yVelocity = 0;
        float speed = 5; 
        

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            anim.SetBool("Leftwalk",true);
            xVelocity=-speed;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            anim.SetBool("Rightwalk", true);
            xVelocity=speed;
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            anim.SetBool("Upwalk", true);
            yVelocity=speed;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            anim.SetBool("Downwalk", true);
            yVelocity=-speed;
        }

        if ((xVelocity == 0) && (yVelocity == 0))
        {
            anim.SetBool("Downwalk", false);
            anim.SetBool("Upwalk", false);
            anim.SetBool("Leftwalk", false);
            anim.SetBool("Rightwalk", false);
        }

        rb.velocity = new Vector2(xVelocity, yVelocity);
        
    }
}
