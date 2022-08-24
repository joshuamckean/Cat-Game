using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public Text MyText;
    private int strength;
    // Start is called before the first frame update
    void Start()
    {
        MyText.text = strength + "/8 strength";
    }

    // Update is called once per frame
    void Update()
    {
        MyText.text = strength + "/8 strength";
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        strength += 1;
    }
}
