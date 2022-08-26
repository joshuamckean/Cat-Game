using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BadFoodScript : MonoBehaviour
{
    public StrengthTextScript strengthScript, poisonScript;
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
        if (collision.gameObject.tag == "cat")
        {
            if (strengthScript.strength <= 0) {
                poisonScript.poison++;
            }
            Destroy(gameObject);
            strengthScript.strength--;
        }
    }
}
