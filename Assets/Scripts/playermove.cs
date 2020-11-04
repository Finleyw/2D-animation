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
        float speed = 2.5f; 
        

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            anim.SetBool("Leftwalk",true);
            xVelocity=-speed;
        }
        else
        {
            anim.SetBool("Leftwalk", false);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            anim.SetBool("Rightwalk", true);
            xVelocity=speed;
        }
        else
        {
            anim.SetBool("Rightwalk", false);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            anim.SetBool("Upwalk", true);
            yVelocity=speed;
        }
        else
        {
           anim.SetBool("Upwalk", false); 
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            anim.SetBool("Downwalk", true);
            yVelocity=-speed;
        }
        else
        {
            anim.SetBool("Downwalk", false);
        }

        if((xVelocity>0)&&(yVelocity>0))
        {
        
    
            anim.SetBool("Upwalk", false);
            anim.SetBool("Rightwalk", false);
            anim.SetBool("uprightwalk",true);
        
        }
        else
        {
            anim.SetBool("uprightwalk",false);
        }

        if((xVelocity<0)&&(yVelocity>0))
        {
            
            anim.SetBool("Upwalk", false);
            anim.SetBool("Leftwalk", false);
            anim.SetBool("upleftwalk",true);
           
        }
        else
        {
            anim.SetBool("upleftwalk",false);
        }

        if(xVelocity>0&&yVelocity<0)
        {
        
            anim.SetBool("Downwalk", false);
            anim.SetBool("Rightwalk", false);
            anim.SetBool("downrightwalk",true);
            
        }
        else
        {
            anim.SetBool("downrightwalk",false);
        }

        if(xVelocity<0&&yVelocity<0)
        {
        
            anim.SetBool("Downwalk", false);
            anim.SetBool("Leftwalk", false);
            anim.SetBool("downleftwalk",true);
            
        }
        else
        {
            anim.SetBool("downleftwalk",false);
        }

        //if ((xVelocity == 0) && (yVelocity == 0))
       // {
       //     anim.SetBool("Downwalk", false);
       //     anim.SetBool("Upwalk", false);
       //     anim.SetBool("Leftwalk", false);
       //     anim.SetBool("Rightwalk", false);
       // }

        rb.velocity = new Vector2(xVelocity, yVelocity);
        
    }
}
