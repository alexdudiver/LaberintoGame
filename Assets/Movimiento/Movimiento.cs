using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

public class Movimiento : MonoBehaviour
{  
    // variables
    float speed = 9.0f;
   float originalXposition,originalYposition,originalZposition;
    
   // Start is called before the first frame update
    void Start()
    {
        originalXposition= transform.position.x;
        originalYposition= transform.position.y;
        originalZposition= transform.position.z;
    }


    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
    }

  void PlayerMovement()
    {
        transform.Translate(Input.GetAxis("Horizontal") *speed*Time.deltaTime, Input.GetAxis("Vertical")*speed*Time.deltaTime,0);

    }
    private void RestarPositionPlayer() 
    
        
    

    
    

    {
        transform.position = new Vector3(originalXposition,originalYposition,originalZposition);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "enemie") ;
        {
            RestarPositionPlayer();

        }
        if (collision.tag == "Ganaste ;D") ;
        {
            RestarPositionPlayer();

        }



        
    }

    }




