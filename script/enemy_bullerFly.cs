using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_bullerFly : MonoBehaviour
{
    private float speed;
   // float bulletTime;
    private GameObject bulletPool;

    private GameObject player;
    GameManager gm;

    GameObject em;
    //private enemyMove enemy;
    private void OnEnable()
    {
        Invoke("ResBullet",5);
    }
    void Start()
    {
        speed = 1f;
        player = GameObject.Find("Player");
        gm = player.GetComponent<GameManager>();

        
        em = Resources.Load<GameObject>("enemy_1");
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed);
    }

    private void FixedUpdate()
    {
        


    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("player"))
        {    
            gm.Injured();
            Destroy(this.gameObject);
        }
    }

    void ResBullet()
    {
        if (bulletPool == null)
        {
            bulletPool = GameObject.FindWithTag("enemy_bulletPool");
        }
        transform.parent = bulletPool.transform;
        gameObject.SetActive(false);
    }
}
