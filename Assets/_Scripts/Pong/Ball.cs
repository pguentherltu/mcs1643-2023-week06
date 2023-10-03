using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float startForce = 12.0f;

    private Rigidbody rb;
    private ParticleSystem burst;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(new Vector3(1, 0, 1) * startForce, ForceMode.Impulse);

        burst = GetComponentInChildren<ParticleSystem>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(burst != null)
        {
            if(collision.transform.tag != "Floor")
            //if (collision.transform.name != "Floor")
            {
                burst.Play();
            }
        }
    }
}
