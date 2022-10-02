using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    private Rigidbody playerRb;
    public float jummpForce = 10;
    public float gravityModifier;
    public bool isOnGround = true;
    public bool isGameOver = false;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;


    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isOnGround && isGameOver == false )
        {
            playerRb.AddForce(Vector3.up * jummpForce, ForceMode.Impulse);
            isOnGround = false;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }
        else if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Game Over");
            isGameOver = true;
        }
    }
}