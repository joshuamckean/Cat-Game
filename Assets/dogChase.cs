using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dogChase : MonoBehaviour
{
    [SerializeField] private GameObject cat;
    public Rigidbody2D rigidBody;
    public float minDistance = 0.09f;
    public float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        transform.position = new Vector2(Random.Range(-5, 5), Random.Range(-5, 5));
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 dir = (cat.transform.position - rigidBody.transform.position).normalized;
        if (Vector3.Distance(cat.transform.position, rigidBody.transform.position) > minDistance)
            rigidBody.MovePosition(rigidBody.transform.position + dir * speed * Time.fixedDeltaTime);
        //transform.position = Vector2.MoveTowards(transform.position, cat.transform.position, speed * Time.deltaTime);
    }
}
