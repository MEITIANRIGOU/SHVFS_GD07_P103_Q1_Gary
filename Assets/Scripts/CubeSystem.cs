using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSystem : MonoBehaviour
{
    float timer;
    public float timeInterval;

    public GameObject Cube;
    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= timeInterval)
        {
            Instantiate(Cube);
            timer = 0;
        }
    }
}
