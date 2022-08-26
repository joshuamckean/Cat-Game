using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoodFoodScript : MonoBehaviour
{
    public StrengthTextScript strengthScript;
    AudioSource eatenGood;
    // Start is called before the first frame update
    void Start()
    {
        eatenGood = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "cat")
        {
            Destroy(gameObject);
            strengthScript.strength++;
            eatenGood.Play();
        }
    }
}
