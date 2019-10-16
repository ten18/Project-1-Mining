using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    public string oreType;
    Vector3 lastPos;
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
            Mining.bronzeXPos -= 2;
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
