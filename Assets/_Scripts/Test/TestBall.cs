using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestBall : MonoBehaviour
{
    public float startForce = 12.0f;

    private Rigidbody rb;
    private ParticleSystem effect;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(new Vector3(1, 0, 1) * startForce, ForceMode.Impulse);
        effect = GetComponentInChildren<ParticleSystem>();
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision coll)
    {
        effect.Play();
    }


}
