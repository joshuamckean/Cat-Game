using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StrengthTextScript : MonoBehaviour
{
    public TextMeshProUGUI strengthText, statusText;
    public int strength;
    [SerializeField] private GameObject cat;
    // Start is called before the first frame update
    void Start()
    {
        strength = 0;
        strengthText.SetText(strength + "/8 strength");
        statusText.SetText("");
    }

    // Update is called once per frame
    void Update()
    {
        if (strength < 0) 
        {
            Destroy(cat);
            strength = 0;
            statusText.SetText("Game Over! You lose!");
        }
        strengthText.SetText(strength + "/8 strength");
    }
}
