using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Motion : MonoBehaviour
{

    public Material white;
    public Material highlight;
    private bool isReversedGravity = false;
    float getRandomValue()
    {
        return Random.Range(-5, 5);
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        MeshRenderer colour = GetComponent<MeshRenderer>();

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            rb.velocity = new Vector3(getRandomValue(), getRandomValue(), getRandomValue());
        }

        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            colour.material = isReversedGravity ? white : highlight;
            rb.useGravity= isReversedGravity;
            isReversedGravity = !isReversedGravity;
        }
    }
}
