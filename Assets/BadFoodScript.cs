using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadFoodScript : MonoBehaviour
{
    public GameObject badFoodPrefab;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
    }
}
