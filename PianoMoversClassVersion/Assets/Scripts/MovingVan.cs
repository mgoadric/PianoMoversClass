using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingVan : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col) {
        print("collision with truck!");

        if (col.gameObject.tag == "Piano") {
            GameManager.instance.IncScore();
            Destroy(col.gameObject);
        }
    }
}
