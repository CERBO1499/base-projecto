using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeToDestroy : MonoBehaviour
{
    
private void Start() {
    StartCoroutine("destroyBall");

    
}
    IEnumerator destroyBall(){
       yield return new WaitForSeconds(2f);
       Destroy(gameObject);

    }    
}
