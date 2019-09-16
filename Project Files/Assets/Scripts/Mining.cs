using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mining : MonoBehaviour
{
    int bronze, bronzeSupply;
    int silver, silverSupply;
    float mineNow;
    float miningSpeed;
    void Start()
    {
        bronze = 0;
        silver = 0;
        miningSpeed = 3;
        mineNow = miningSpeed;
        bronzeSupply = 3;
        silverSupply = 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > mineNow)
        {
            mineNow += miningSpeed;

            if (bronzeSupply > 0)
            {
                bronzeSupply--;
                bronze++;
            }
            else if (silverSupply > 0)
            {
                silverSupply--;
                silver++;
            }

            print("Bronze: " + bronze + " ... Silver: " + silver);
        }
    }
}
