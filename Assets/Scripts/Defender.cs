﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour
{

    // ===================================================================
    // Variables
    // ===================================================================

    public int starCost;


    // ===================================================================
    // Methods
    // ===================================================================

    // Statics

    public static bool IsObjectDefender(GameObject obj)
    {
        return ((obj.GetComponent<Defender>()) ? true : false);
    }


    // Instances

    public int GetStarCost()
    {
        return this.starCost;
    }

}
