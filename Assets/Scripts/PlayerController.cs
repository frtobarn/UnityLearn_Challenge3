using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W)){
            playerRb.AddForce(Vector3.forward * speed);
        }
        if(Input.GetKeyDown(KeyCode.S)){
            playerRb.AddForce(Vector3.back * speed);
        }
        if(Input.GetKeyDown(KeyCode.A)){
            playerRb.AddForce(Vector3.left * speed);
        }
        if(Input.GetKeyDown(KeyCode.D)){
            playerRb.AddForce(Vector3.right * speed);
        }
    }
}
