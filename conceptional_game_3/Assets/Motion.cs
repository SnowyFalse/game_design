using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Motion : MonoBehaviour
{

    float getRandomValue()
    {
        return Random.Range(-5, 5);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Rigidbody rb = GetComponent<Rigidbody>();
            rb.velocity = new Vector3(getRandomValue(), getRandomValue(), getRandomValue());
        }
    }
}
