using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private float horizontalInput;
    public float speed = 15f;
    //private float verticalInput;
    //public float advancespeed = 10f;
    public float xRange = 17f;
    public GameObject municionprefab;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(municionprefab, transform.position, municionprefab.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * speed * Time.deltaTime * horizontalInput);

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        //verticalInput = Input.GetAxis("Vertical");
        //transform.Translate(Vector3.forward * advancespeed * Time.deltaTime * verticalInput);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(municionprefab, transform.position, municionprefab.transform.rotation);
        }
    }
}
   