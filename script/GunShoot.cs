using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunShoot : MonoBehaviour
{
    public GameObject bullet;
    public GameObject bulletLeftPos;
    public GameObject bulletRightPos;
   // private float gameTime;
    private GameObject bullet_left;
    private GameObject bullet_right;
    public GameObject bulletPool;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Shoot();
    }

    void Shoot()
    {
        if (bulletPool.transform.childCount > 50)
        {
            bullet_left = bulletPool.transform.GetChild(0).gameObject;

            bullet_right = bulletPool.transform.GetChild(1).gameObject;

            bullet_left.transform.parent = null;
            bullet_left.SetActive(true);

            bullet_right.transform.parent = null;
            bullet_right.SetActive(true);
        }
        else
        {
            bullet_left = Instantiate<GameObject>(bullet);
            bullet_right = Instantiate<GameObject>(bullet);
        }

        bullet_left.transform.position = bulletLeftPos.transform.position;
        bullet_left.transform.rotation = bulletLeftPos.transform.rotation;

        bullet_right.transform.position = bulletRightPos.transform.position;
        bullet_right.transform.rotation = bulletRightPos.transform.rotation;
    }
    private void FixedUpdate()
    {
       // gameTime = Time.time;

    }

}




