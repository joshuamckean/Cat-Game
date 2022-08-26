using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatScript : MonoBehaviour
{
    [SerializeField] private DogScript dogScript;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(Random.Range(-10, 10), Random.Range(-8, 8));
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(0, Input.GetAxis("Vertical") * 0.16f, 0);
        transform.Translate(0, 0, Input.GetAxis("Horizontal") * 0.16f);

        if (dogScript.dogDead)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                Application.LoadLevel(0);
            }
        }
    }
}
