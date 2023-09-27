using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public MeshRenderer mesh;

    // Start is called before the first frame update
    void Start()
    {
        mesh.enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        mesh.enabled = true;
    }

    private void OnTriggerExit(Collider other)
    {
        mesh.enabled = false;
    }
}
