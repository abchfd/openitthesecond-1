﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class value : MonoBehaviour
{
    
	public int mvalue;
    

    void ShowMyPrice(Text priceTxt)
    {
        priceTxt.text = mvalue.ToString() + "$";
    }
}
