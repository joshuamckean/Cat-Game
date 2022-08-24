using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodFoodScript : MonoBehaviour
{
    public GameObject goodFoodPrefab;
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

    void SpawnGoodFood()
    {
        var foodPosition = transform.position;
        foodPosition.x = Random.Range(-9, 9);
        foodPosition.y = Random.Range(-5,5);

        /*Vector3 position = new Vector3(Random.Range(-10, 10),
            Random.Range(-10,10), 0);*/
        Instantiate(goodFoodPrefab, foodPosition, transform.rotation);
    }
}
