using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
   
{
    private float upperLim = 40f;
    private float lowerLim = -10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > upperLim)
        {
            Destroy(gameObject);
        }
        
        if (transform.position.z < lowerLim)
        {
            Destroy(gameObject);
        }
    }
}
