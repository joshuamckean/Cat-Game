using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StrengthTextScript : MonoBehaviour
{
    public TextMeshProUGUI strengthText, statusText, poisonText;
    AudioSource catPoisoned;
    public int strength, poison;
    [SerializeField] private GameObject cat;
    // Start is called before the first frame update
    void Start()
    {
        catPoisoned = GetComponent<AudioSource>();
        strength = 0;
        strengthText.SetText(strength + "/8 strength");
        poisonText.SetText(poison + "/2 poison");
        statusText.SetText("");
    }

    // Update is called once per frame
    void Update()
    {
        if (poison >= 2)
        {
            Destroy(cat);
            //catPoisoned.Play();
            statusText.SetText("Game Over! You were poisoned to death! Press 'R' to restart.");
            if (Input.GetKeyDown(KeyCode.R))
            {
                Application.LoadLevel(0);
            }
        }
        if (strength < 0) strength = 0;
        strengthText.SetText(strength + "/8 strength");
        poisonText.SetText(poison + "/2 poison");
    }
}
