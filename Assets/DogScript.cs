using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DogScript : MonoBehaviour
{
    public bool catStrong;
    public StrengthTextScript strengthScript;
    [SerializeField] private GameObject dog, cat;
    [SerializeField] TextMeshProUGUI statusText;
    public Rigidbody2D rigidBody;
    public float minDistance = 0.09f;
    public float speed = 5f;
    public bool catDead, dogDead = false;

    // Start is called before the first frame update
    void Start()
    {
        catStrong = false;
        transform.position = new Vector2(Random.Range(-10, 10), Random.Range(-8, 8));
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Debug.Log(cat.transform.position);
        if (cat == null)
        {

        }
        else if (!(catStrong))
        {
            Vector3 dir = (cat.transform.position - rigidBody.transform.position).normalized;
            if (Vector3.Distance(cat.transform.position, rigidBody.transform.position) > minDistance)
                rigidBody.MovePosition(rigidBody.transform.position + dir * speed * Time.fixedDeltaTime);
        }
        else if (catStrong)
        {
            //Dog runs away when cat is strong
            Vector3 dir = (cat.transform.position - rigidBody.transform.position).normalized;
            if (Vector3.Distance(cat.transform.position, rigidBody.transform.position) > minDistance)
                rigidBody.MovePosition(rigidBody.transform.position + dir * -0.5f * speed * Time.fixedDeltaTime);
        }
        if (strengthScript.strength >= 8)
        {
            catStrong = true;
        }
        if (strengthScript.strength < 8)
        {
            catStrong = false;
        }
        if (catDead)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                Application.LoadLevel(0);
            }
        }
        //transform.position = Vector2.MoveTowards(transform.position, cat.transform.position, speed * Time.deltaTime);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (catStrong)
        {
            if (collision.gameObject.tag == "cat")
            {
                Destroy(dog);
                dogDead = true;
                statusText.SetText("You ate the dog! You WIN! Press 'R' to restart.");
                statusText.color = new Color32(0, 100, 0, 255);
            }
        }
        else
        {
            if (collision.gameObject.tag == "cat")
            {
                Destroy(cat);
                catDead = true;
                statusText.SetText("The dog ate you! You LOSE! Press 'R' to restart.");
            }
        }
    }
}
