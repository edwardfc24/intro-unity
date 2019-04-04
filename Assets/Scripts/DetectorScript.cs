using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectorScript : MonoBehaviour
{
    Vector3 velocity;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        velocity = DiceScript.diceVelocity;
    }

    void OnTriggerStay(Collider col)
    {
        if (velocity.x == 0f && velocity.y == 0f && velocity.z == 0f)
        {
            switch (col.gameObject.name)
            {
                case "Side1":
                    DiceScript.diceNumber = "6";
                    break;
                case "Side2":
                    DiceScript.diceNumber = "5";
                    break;
                case "Side3":
                    DiceScript.diceNumber = "4";
                    break;
                case "Side4":
                    DiceScript.diceNumber = "3";
                    break;
                case "Side5":
                    DiceScript.diceNumber = "2";
                    break;
                case "Side6":
                    DiceScript.diceNumber = "1";
                    break;
            }
        }
    }
}
