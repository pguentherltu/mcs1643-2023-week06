using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestBall : MonoBehaviour
{
    public float startForce = 12.0f;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().AddForce(startForce * new Vector3(1, 0, 1), ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
