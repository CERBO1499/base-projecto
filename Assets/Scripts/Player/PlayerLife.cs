using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLife : MonoBehaviour
{    

    
    [SerializeField] private int lifes;

    public int Lifes{
        get{return lifes;}
        set{lifes=value;}
    }

    public void CheckLifes(){
        if(lifes<1){
            Destroy(gameObject);
        }
    }

    



}
