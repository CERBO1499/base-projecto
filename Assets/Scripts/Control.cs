// using System.Numerics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    protected Joystick joystick;
    protected Joybutton joybutton;
    protected bool Shoot;
    private PlayerShoot playerShoot; 
    private float counterShoot=0f;
    [SerializeField] private float timeToshoot;
    Vector3 move;
    Rigidbody rb;
    [SerializeField] float speed =5f;

    void Start()
    {
        joystick = FindObjectOfType<Joystick>();
        joybutton = FindObjectOfType<Joybutton>();
        playerShoot=FindObjectOfType<PlayerShoot>();
        rb=GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        counterShoot-=Time.deltaTime;

        move.x=joystick.Horizontal;
        move.z=joystick.Vertical;

        float hAxis=joystick.Vertical;
        float vAxis=joystick.Horizontal;
        float zAxis=Mathf.Atan2(-hAxis,-vAxis)*Mathf.Rad2Deg;
        transform.eulerAngles=new Vector3(0,-zAxis,-270);
        // var rigidbody = GetComponent<Rigidbody>();

        // Vector3 direction = new Vector3 (joystick.Horizontal*10f,rb.velocity.y,joystick.Vertical*10f);
        // rb.velocity = direction; 

        rb.MovePosition(rb.position+move*speed*Time.fixedDeltaTime);




        

        




        print(joystick.Vertical); 

        if(!Shoot && joybutton.Pressed && counterShoot<=0)
        {

            playerShoot.Shooty();
            counterShoot=timeToshoot;
            Shoot = true;
            // rigidbody.velocity += Vector3.up*10f;
        }
        if(Shoot && !joybutton.Pressed)
        {
            Shoot = false;
        }
    }
    
}
