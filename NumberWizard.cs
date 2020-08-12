using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int max = 1000;
        int min = 1;

        Debug.Log("Welcome to Number Wizard, yo");
        Debug.Log("Pick a number, but don't tell me what it is");
        Debug.Log("Highest number you may pick is: " + max);
        Debug.Log("Lowest number you may pick is: " + min);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
