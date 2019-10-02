using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mining : MonoBehaviour
{
    int bronze, bronzeShift;
    int silver, silverShift;
    int gold, goldShift;
    float mineNow;
    public float miningSpeed;
    public Material bronzeColor;
    public Material goldColor;
    void Start()
    {
        bronze = 0;
        silver = 0;
        gold = 0;
        miningSpeed = 3;
        mineNow = miningSpeed;
        bronzeShift = 0;
        silverShift = 0;
        goldShift = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > mineNow)
        {
            mineNow += miningSpeed;

            if (bronze < 4) //nothing but bronze spawns if there is not enough of it
            {
                bronze++;
                GameObject bronzeOre = GameObject.CreatePrimitive(PrimitiveType.Cube);
                bronzeOre.GetComponent<Renderer>().material = bronzeColor;
                bronzeOre.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
                bronzeOre.transform.position = new Vector3(-7f+bronzeShift, 0, 0);
                bronzeShift = bronzeShift + 2; //spawn next bronze to the right of the previous
            }
            else //silver spawns when there is enough bronze
            {
                silver++;
                GameObject silverOre = GameObject.CreatePrimitive(PrimitiveType.Cube);
                silverOre.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
                silverOre.transform.position = new Vector3(3f+silverShift, 0, 0);
                silverShift = silverShift + 2; 
            }

            if (bronze == 2 && silver == 2) //spawn a gold ONLY if this is true
            {
                gold++;
                GameObject goldOre = GameObject.CreatePrimitive(PrimitiveType.Cube);
                goldOre.GetComponent<Renderer>().material = goldColor;
                goldOre.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
                goldOre.transform.position = new Vector3(1f+goldShift, 3f, 0);
                goldShift = goldShift + 2;
            }



            print("Bronze: " + bronze + "  Silver: " + silver + "  Gold: " + gold);
        }
    }
}
