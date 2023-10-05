using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public float jumpForce = 5.0f;
    private Rigidbody rb;
    private bool onGround;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && onGround)
        {
            //rb.AddForce(Vector3.up * jumpForce);
            rb.AddForce(new Vector3(0, .8f, 0.2f) * jumpForce, ForceMode.Impulse);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        onGround = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        onGround = false;
    }
}
