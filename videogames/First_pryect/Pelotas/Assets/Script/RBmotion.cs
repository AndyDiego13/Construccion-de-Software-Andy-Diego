/*
Movement rigid body

Manuel Barrera
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RBmotion : MonoBehaviour
{
    [SerializeField] float speed; 
    
    Rigidbody2D rb2D; 
    Vector3 move; 
    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        move.x = Input.GetAxis("Horizontal")*speed;
        move.y = Input.GetAxis("Vertical")*speed; 
        rb2D.AddForce(move);
    }
}
