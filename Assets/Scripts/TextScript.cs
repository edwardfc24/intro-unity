﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextScript : MonoBehaviour
{
    Text texto;
    // Start is called before the first frame update
    void Start()
    {
        texto = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        texto.text = DiceScript.diceNumber;
    }
}
