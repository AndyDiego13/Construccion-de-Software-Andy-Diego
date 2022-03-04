using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oscilacion : MonoBehaviour
{
    [SerializeField] Vector3 move;
    // Start is called before the first frame update
    // Update is called once per frame
    void Update()
    {
        transform.Translate(move * Time.deltaTime);  
    }
    void OnTriggerEnter2D(Collider2D col) {
        move = -move;     
    }
}
