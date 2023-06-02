using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourChanger : MonoBehaviour
{
    public MeshRenderer currentObject;
    private int counter;
    public Material darkBlue;
    public Material lightBlue;
    public Material lightGreen;
    public Material darkGreen;
    public Material white;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 100))
            {
                
                switch (counter)
                {
                    case 0:
                        currentObject.material = darkBlue;
                        counter++;
                        break;
                    case 1:
                        currentObject.material = lightBlue;
                        counter++;
                        break;
                    case 2:
                        currentObject.material = darkGreen;
                        counter++;
                        break;
                    case 3:
                        currentObject.material = lightGreen;
                        counter++;
                        break;
                    case 4:
                        currentObject.material = white;
                        counter = 0;
                        break;
                    default:
                        currentObject.material = white;
                        counter = 0;
                        break;
                }
            }
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.localScale += new Vector3(0.1f,0,0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            if (transform.lossyScale.x > 0)
            {
                Debug.Log("test");
                transform.localScale -= new Vector3(0.1f,0,0);
            }
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.localScale += new Vector3(0,0.1f,0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            if (transform.lossyScale.y > 0)
            {
                transform.localScale -= new Vector3(0,0.1f,0);
            }
            
        }
    }
}
