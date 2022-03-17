using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    float timer;
    Rigidbody rb;
    public float timeInterval;
    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= timeInterval)
        {
            rb.AddForce(Vector3.up * 5);
            timer = 0;
        }
    }
}
