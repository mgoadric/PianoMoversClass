using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour
{

    public GameObject piano;

    // Start is called before the first frame update
    void Start()
    {
        //InvokeRepeating("DropPiano", 0.1f, 3);
        StartCoroutine("DropPiano2");
    }

    void DropPiano() {
        Instantiate(piano);
    }

    IEnumerator DropPiano2() {
        for(;;) {
            Instantiate(piano);
            yield return new WaitForSeconds(Random.Range(2f, 4f));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
