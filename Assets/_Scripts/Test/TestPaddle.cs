using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPaddle : MonoBehaviour
{
    public float speed = 2.0f;
    public KeyCode upKey;
    public KeyCode downKey;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(upKey))
        {
            transform.position += new Vector3(0, 0, speed * Time.deltaTime);
        }
        else if (Input.GetKey(downKey))
        {
            transform.position -= new Vector3(0, 0, speed * Time.deltaTime);
        }
    }
}
