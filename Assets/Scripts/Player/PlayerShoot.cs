using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    PoolBAlas _poolBalas;
    [SerializeField] Transform transInstanceBalas;
    [SerializeField] Rigidbody myBala;
    private float counterShoot=0f;
    [SerializeField] private float timeToshoot;

    // Update is called once per frame
    void Update()
    {
      // counterShoot-=Time.deltaTime;

      if(Input.GetKeyDown(KeyCode.Space) && counterShoot<=0){
          Shooty();
      }
    }

   public void Shooty() {
        
        // myBala=_poolBalas.GetPooledObject();
        
        // Vector3 myVector3 = transInstanceBalas.transform.position+transInstanceBalas.transform.forward;
            
            // myBala.transform.position=transInstanceBalas.transform.position+transInstanceBalas.transform.forward;
            // myBala.transform.forward=transInstanceBalas.transform.forward;     

            Rigidbody bala = Instantiate(myBala,transInstanceBalas.position,transInstanceBalas.rotation) as Rigidbody; 
            bala.velocity=10f*transInstanceBalas.up;
            // counterShoot=timeToshoot;
            

            // Instantiate(myBala,new Vector3(transInstanceBalas.transform.position.x,transInstanceBalas.transform.position.y,/*transInstanceBalas.transform.position.z*/0f), Quaternion.identity);

            // myBala.SetActive(true);
           
       

   }
}

