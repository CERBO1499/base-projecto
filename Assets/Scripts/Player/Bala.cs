using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    private PlayerLife playerLife;
//    private void Ontrigg(Collision other) {

//        if(other.gameObject.tag=="Player"){

//            playerLife=other.gameObject.GetComponentInParent<PlayerLife>();
//            playerLife.Lifes-=1;    
//            playerLife.CheckLifes();
//            Destroy(gameObject);      

//        }
       
//    }
   private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag=="Player"){

           playerLife=other.gameObject.GetComponentInParent<PlayerLife>();
           playerLife.Lifes-=1;    
           playerLife.CheckLifes();
           Destroy(gameObject);      

       }
   }
}

