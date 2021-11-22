using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveForward : MonoBehaviour
{
    public float speed = 20f;
    //public GameObject player;

    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        
    }
}
