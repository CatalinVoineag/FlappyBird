using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    // Update is called once per frame
    {
        gameObject.transform.position += Vector3.left * 1f * Time.deltaTime;
    }
}
