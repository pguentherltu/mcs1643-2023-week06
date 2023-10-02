using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public KeyCode upKey;
    public KeyCode downKey;
    public float speed = 6.0f;
    public float zLimit = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(upKey))
        {
            transform.position += new Vector3(0, 0, speed * Time.deltaTime);
            if (transform.position.z > zLimit)
            {
                transform.position = new Vector3(transform.position.x,
                    transform.position.y, zLimit);
            }
        }
        else if (Input.GetKey(downKey))
        {
            transform.position -= new Vector3(0, 0, speed * Time.deltaTime);
            if (transform.position.z < -1 * zLimit)
            {
                transform.position = new Vector3(transform.position.x,
                    transform.position.y, -1 * zLimit);
            }
        }
    }
}
