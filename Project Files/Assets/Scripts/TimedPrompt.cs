using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedPrompt : MonoBehaviour
{
    bool promptPrinted;
    // Start is called before the first frame update
    void Start()
    {
        promptPrinted = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > 3 && promptPrinted)
        {
            print("It's been three seconds!");
            promptPrinted = false;
        }
    }
}
