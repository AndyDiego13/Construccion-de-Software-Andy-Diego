/* para crear puntos 
Manuel Barrera 
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class points : MonoBehaviour
{
[SerializeField] int point; 

    void OnCollisionEnter2D(Collision2D col) {
        if(col.gameObject.tag == "Ball"){
       point++;         
    }
    }
    void OnTriggerEnter2D(Collider2D col) {
      Destroy(col.gameObject);  
      point += 5; 
     }

}

