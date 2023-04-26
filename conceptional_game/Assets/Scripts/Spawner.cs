using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    int randomX;
    int randomZ;
    public GameObject makeBlue;
    public GameObject makeRed;
    public GameObject makeGreen;
    Vector3 newPos; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        randomX = Random.Range(-5, 5);
        randomZ = Random.Range(-5, 5);
        newPos = new Vector3(randomX, 0, randomZ);

        if (makeBlue.activeSelf == false)
        {
            makeBlue.transform.position = newPos;
            makeBlue.SetActive(true);
        } else if(makeRed.activeSelf == false)
        {
            makeRed.transform.position = newPos;
            makeRed.SetActive(true);
        }
        else if (makeGreen.activeSelf == false)
        {
            makeGreen.transform.position = newPos;
            makeGreen.SetActive(true);
        }
    }
}
