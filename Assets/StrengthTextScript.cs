using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StrengthTextScript : MonoBehaviour
{
    public TextMeshProUGUI MyText;
    public int strength;
    // Start is called before the first frame update
    void Start()
    {
        strength = 0;
        MyText.SetText(strength + "/8 strength");
    }

    // Update is called once per frame
    void Update()
    {
        if (strength < 0) strength = 0;
        MyText.SetText(strength + "/8 strength");
    }
}
