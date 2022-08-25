using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogScript : MonoBehaviour
{
    public bool catStrong;
    [SerializeField] private GameObject cat;
    public Rigidbody2D rigidBody;
    public float minDistance = 0.09f;
    public float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        catStrong = false;
        transform.position = new Vector2(Random.Range(-5, 5), Random.Range(-5, 5));
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Debug.Log(cat.transform.position);
        if (cat == null)
        {

        }
        else
        {
            Vector3 dir = (cat.transform.position - rigidBody.transform.position).normalized;
            if (Vector3.Distance(cat.transform.position, rigidBody.transform.position) > minDistance)
                rigidBody.MovePosition(rigidBody.transform.position + dir * speed * Time.fixedDeltaTime);
        }
        
        //transform.position = Vector2.MoveTowards(transform.position, cat.transform.position, speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D collission)
    {
        if (catStrong)
        {

        }
        else
        {
            if (collission.gameObject.tag == "cat")
            {
                Destroy(collission.gameObject);
            }
        }
    }
}
