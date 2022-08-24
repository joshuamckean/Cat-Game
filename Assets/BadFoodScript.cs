using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadFoodScript : MonoBehaviour
{
    public GameObject badFoodPrefab;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 6; i++)
        {
            Vector3 position = new Vector3(Random.Range(-15.0F,15.0F),
                 Random.Range(-10.0F,10.0F), 0);
            Instantiate(badFoodPrefab,position,Quaternion.identity);
        }
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
