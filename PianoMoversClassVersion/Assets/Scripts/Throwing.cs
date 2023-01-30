using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throwing : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().AddForce(transform.right * 135);
        print("hello");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
