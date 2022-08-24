using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StrengthTextScript : MonoBehaviour
{
    public Text MyText;
    public int strength;
    // Start is called before the first frame update
    void Start()
    {
        strength = 0;
        MyText.text = strength + "/8 strength";
    }

    // Update is called once per frame
    void Update()
    {
        MyText.text = strength + "/8 strength";
    }
}
