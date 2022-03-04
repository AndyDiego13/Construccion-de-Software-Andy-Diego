using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinGen : MonoBehaviour
{
    // Start is called before the first frame update
[SerializeField] GameObject coinPrefab; 
    void Start()
    {
        InvokeRepeating("MakeCoin",1,2); 
    }

    // Update is called once per frame
    void MakeCoin(){
        Instantiate(coinPrefab, Vector3.zero,Quaternion.identity);
    }
}
