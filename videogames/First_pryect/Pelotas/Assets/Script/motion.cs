using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class motion : MonoBehaviour
{
    float speed = 0.5f;
    Vector3 move;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Read the input of the keyboard
        move.x = Input.GetAxis("Horizontal");
        move.y = Input.GetAxis("Vertical");
        //Apply the new data to the object transform
        transform.Translate(move * speed);
    }
}
