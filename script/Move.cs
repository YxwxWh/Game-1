using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Move : MonoBehaviour
{
    public GameObject GameCamer;
    private float speed = 50;
    private Transform aimImage;


    //private float turnSpeed = 100;
    // Use this for initialization
    void Start()
    {
        aimImage = GameObject.Find("aimPoint").GetComponent<Transform>();


    }

    // Update is called once per frame
    void Update()
    {


        float h = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(h, 0, 0) * Time.deltaTime * speed, Space.World);

        //transform.rotation = Quaternion.Lerp(this.transform.rotation, Quaternion.Euler(0, 0, -180*h), 0.05f);

        if (h > 0)
        {
            aimImage.Rotate(new Vector3(0, 0, -1));
            transform.rotation = Quaternion.Lerp(this.transform.rotation, Quaternion.Euler(0, 0, -30), 0.1f);

        }
        else if (h < 0)
        {
            aimImage.Rotate(new Vector3(0, 0, 1));
            transform.rotation = Quaternion.Lerp(this.transform.rotation, Quaternion.Euler(0, 0, 30), 0.1f);

        }
        else
        {
            transform.rotation = Quaternion.Lerp(this.transform.rotation, Quaternion.Euler(0, 0, 0), 0.1f);
        }


    }
}
