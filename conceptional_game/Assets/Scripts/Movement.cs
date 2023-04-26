using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Camera cam;
    Collider planeCollider;
    RaycastHit hit;
    Ray ray;
    public MeshRenderer player;
    public Material blue;
    public Material red;
    public Material green;

    // Start is called before the first frame update
    void Start()
    {
        cam = GameObject.Find("Main Camera").GetComponent<Camera>();
        planeCollider = GameObject.Find("Ground").GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 5f));
        ray = cam.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            if(hit.collider == planeCollider)
            {
                transform.position = Vector3.MoveTowards(transform.position, hit.point, Time.deltaTime * 5);
                transform.LookAt(new Vector3(hit.point.x, transform.position.y, hit.point.z));
            }
        }
    }

    private void OnTriggerEnter(Collider c)
    {
        switch(c.gameObject.name)
        {
            case "MakeBlue":
                if(player.material != blue)
                {
                    player.material = blue;
                    c.gameObject.SetActive(false);
                }
                break;
            case "MakeGreen":
                if (player.material != green)
                {
                    player.material = green;
                    c.gameObject.SetActive(false);
                }
                break;
            case "MakeRed":
                if (player.material != red)
                {
                    player.material = red;
                    c.gameObject.SetActive(false);
                }
                break;
        }
    }
    
}
