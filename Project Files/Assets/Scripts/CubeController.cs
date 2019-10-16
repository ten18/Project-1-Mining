using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    public string oreType;
    Vector3 lastPos; // This is where I started to implement a way to make sure that when an ore with other ores around it is destroyed
    // another ore will spawn in the empty spot instead of overlapping another ore.
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        //lastPos = GetComponent<Transform>.position;
        Destroy(gameObject);
        if (oreType == "Bronze")
        {
            Mining.bronzeSupply--;
            Mining.bronzeXPos -= 2; // Make sure that the next ore is spawning on the end of the row.
            Mining.score += Mining.bronzePoints;
        }
        if (oreType == "Silver")
        {
            Mining.silverSupply--;
            Mining.silverXPos -= 2;
            Mining.score += Mining.silverPoints;
        }
        if (oreType == "Gold")
        {
            Mining.goldSupply--;
            Mining.goldXPos -= 2;
            Mining.score += Mining.goldPoints;
        }
    }
}
