using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dogChase : MonoBehaviour
{
    [SerializeField] private GameObject cat;
    [SerializeField] private float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector2(Random.Range(-5, 5), Random.Range(-5, 5));
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, cat.transform.position, speed * Time.deltaTime);
    }
}
