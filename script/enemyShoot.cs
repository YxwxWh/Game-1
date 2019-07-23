using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyShoot : MonoBehaviour
{

    public GameObject bullet;
    public GameObject target;
    public GameObject bulletPool;

    //public float deg;
    //public float deg_1;


    private GameObject bullets;
    public int type;

    private float gameTime;
    void Start()
    {

    }


    void Update()
    {

    }

    void Shoot()
    {
        for (int i = 0; i < 5; i++)
        {
            Vector3 dir = Quaternion.AngleAxis(300 + 30 * i, Vector3.up) * transform.forward;


            if (bulletPool.transform.childCount > 0)
            {
                bullets = bulletPool.transform.GetChild(0).gameObject;
                bullets.transform.parent = null;
                bullets.SetActive(true);
                bullets.transform.position = target.transform.position;
                bullets.transform.rotation = Quaternion.LookRotation(dir);
            }
            else
            {
                bullets = Instantiate<GameObject>(bullet);
                bullets.transform.position = target.transform.position;
                bullets.transform.rotation = Quaternion.LookRotation(dir);
            }

        }
    }

    void Shoot_1()
    {
        for (int i = 0; i < 20; i++)
        {

            //Vector3 die = target.transform.position - transform.position;
            Vector3 q = Quaternion.AngleAxis(30 * i, Vector3.up) * transform.forward;


            if (bulletPool.transform.childCount > 0)
            {
                bullets = bulletPool.transform.GetChild(0).gameObject;
                bullets.transform.parent = null;
                bullets.SetActive(true);
                bullets.transform.position = target.transform.position;
                bullets.transform.rotation = Quaternion.LookRotation(q);

            }
            else
            {
                bullets = Instantiate<GameObject>(bullet);
                bullets.transform.position = target.transform.position;
                bullets.transform.rotation = Quaternion.LookRotation(q);
            }

        }

    }

    void Shoot_2()
    {

        for (int i = 0; i < 36; i++)
        {
            Vector3 dir = Quaternion.AngleAxis(300 + 10 * i, Vector3.up) * transform.forward;


            if (bulletPool.transform.childCount > 0)
            {
                bullets = bulletPool.transform.GetChild(0).gameObject;
                bullets.transform.parent = null;
                bullets.SetActive(true);
                bullets.transform.position = target.transform.position;
                bullets.transform.rotation = Quaternion.LookRotation(dir);
            }
            else
            {
                bullets = Instantiate<GameObject>(bullet);
                bullets.transform.position = target.transform.position;
                bullets.transform.rotation = Quaternion.LookRotation(dir);
            }

        }


    }

    void Shoot_3()
    {
        Shoot_1();
        Shoot_2();
    }
    IEnumerator Shoot_4()
    {
        Shoot_1();
        yield return null;
        Shoot_2();
    }

    private void FixedUpdate()
    {
        gameTime = Time.time;
        type = Random.Range(1, 3);
        int count = 0;
        if (gameTime % 2 == 0)
        {
            if (count < 2)
            {
                switch (type)
                {
                    case 1:
                        Shoot();
                        count++;
                        break;

                    case 2:
                        Shoot_1();
                        count++;
                        break;
                }
            }
            else
            {
                Shoot_3();
                //StartCoroutine("Shoot_4");
                //count = 0;
            }
        }


    }

}
