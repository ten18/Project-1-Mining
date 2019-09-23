using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mining : MonoBehaviour
{
    int bronze, bronzeSupply, bronzeShift;
    int silver, silverSupply, silverShift;
    float mineNow;
    float miningSpeed;
    public Material bronzeColor;
    //public GameObject cubePrefab;
    void Start()
    {
        bronze = 0;
        silver = 0;
        miningSpeed = 3;
        mineNow = miningSpeed;
        bronzeSupply = 3;
        silverSupply = 2;
        bronzeShift = 0;
        silverShift = 0;
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
                //cubePosition = new Vector3(0,0,0);
                //Instantiate(cubePrefab, cubePosition, Quaternion.identity);
                GameObject bronzeOre = GameObject.CreatePrimitive(PrimitiveType.Cube);
                bronzeOre.GetComponent<Renderer>().material = bronzeColor;
                bronzeOre.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
                bronzeOre.transform.position = new Vector3(-7f+bronzeShift, 0, 0);
                bronzeShift = bronzeShift + 2;
            }
            else if (silverSupply > 0)
            {
                silverSupply--;
                silver++;
                GameObject silverOre = GameObject.CreatePrimitive(PrimitiveType.Cube);
                silverOre.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
                silverOre.transform.position = new Vector3(3f+silverShift, 0, 0);
                silverShift = silverShift + 2;
            }

            print("Bronze: " + bronze + " ... Silver: " + silver);
        }
    }
}
