using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(Random.Range(-10, 10), Random.Range(-10, 10));
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0,Input.GetAxis("Vertical")*0.08f,0);
        transform.Translate(Input.GetAxis("Horizontal")*0.08f,0,0);
    }
}
