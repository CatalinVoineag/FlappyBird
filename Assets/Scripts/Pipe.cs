using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    public bool moving;
    void Start()
    {
    }

    void Update()
    {
        if (moving)
        {
            gameObject.transform.position += Vector3.left * 1f * Time.deltaTime;
        }
    }
}
