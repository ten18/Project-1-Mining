using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mining : MonoBehaviour
{
    public static int bronzeSupply;
    public static int silverSupply;
    public static int goldSupply;
    public static int bronzeXPos;
    public static int silverXPos, silverYPos;
    public static int goldXPos, goldYPos;
    float mineNow;
    public GameObject myCube;
    public float miningSpeed;
    public GameObject cubePrefab;
    Vector3 cubePos;
    public Material bronzeColor;
    public Material goldColor;
    public static int bronzePoints;
    public static int silverPoints;
    public static int goldPoints;
    public static int score;
    int goldResetTimer;
    void Start()
    {
        bronzeSupply = 0;
        silverSupply = 0;
        goldSupply = 0;
        miningSpeed = 3;
        mineNow = miningSpeed;
        bronzeXPos = 0;
        silverXPos = 0;
        goldXPos = 0;
        bronzePoints = 1;
        silverPoints = 10;
        goldPoints = 100;
        score = 0;
        goldResetTimer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > mineNow)
        {
            mineNow += miningSpeed;

            if (goldResetTimer > 0)
            {
                goldResetTimer -= 1;
            }

            if (bronzeSupply == 2 && silverSupply == 2 && goldResetTimer == 0) //spawn a gold ONLY if this is true
            {
                goldSupply++;
                cubePos = new Vector3(-7f+goldXPos, -4f, 0);
                myCube = Instantiate(cubePrefab, cubePos, Quaternion.identity);
                myCube.GetComponent<CubeController>().oreType = "Gold";
                myCube.GetComponent<Renderer>().material = goldColor;
                goldXPos = goldXPos + 2;
                goldResetTimer += 2;
            }

            else if (bronzeSupply < 4 && goldResetTimer < 2) //nothing but bronze spawns if there is not enough of it
            {
                bronzeSupply++;
                cubePos = new Vector3(-7f+bronzeXPos, 4f, 0);
                myCube = Instantiate(cubePrefab, cubePos, Quaternion.identity);
                myCube.GetComponent<CubeController>().oreType = "Bronze";
                myCube.GetComponent<Renderer>().material = bronzeColor;
                bronzeXPos = bronzeXPos + 2; //spawn next bronze to the right of the previous
            }

            else //silver spawns when there is enough bronze
            {
                if (goldResetTimer < 2)
                {
                    silverSupply++;
                    cubePos = new Vector3(-7f + silverXPos, 0, 0);
                    myCube = Instantiate(cubePrefab, cubePos, Quaternion.identity);
                    myCube.GetComponent<CubeController>().oreType = "Silver";
                    silverXPos = silverXPos + 2;
                }
            }





            print("Bronze: " + bronzeSupply + "  Silver: " + silverSupply + "  Gold: " + goldSupply);
            print("Score: " + score);
        }
    }
}
