using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceScript : MonoBehaviour
{
    static Rigidbody rb;
    public static Vector3 diceVelocity;
    public static string diceNumber;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float velX = Random.Range(0f, 300f);
        float velY = Random.Range(0f, 300f);
        float velZ = Random.Range(0f, 300f);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            diceNumber = "99";
            rb.AddForce(transform.up * 400f);
            transform.position = new Vector3(0f, 1f, 0f);
            transform.rotation = Quaternion.identity; // new Vector3(0,5,5)
            rb.AddTorque(velX, velY, velZ);
        }
    }
}
