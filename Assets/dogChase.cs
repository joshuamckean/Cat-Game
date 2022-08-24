using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dogChase : MonoBehaviour
{
    [SerializeField] private GameObject cat;
    [SerializeField] private float speed = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, cat.transform.position, speed);
        transform.right = cat.transform.position - transform.position;
    }
}
