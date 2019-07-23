using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class bullerFly : MonoBehaviour
{
    public float speed;
    private GameObject player;
    GameManager gm;
    public GameObject bulletPool;
   // float bulletLeft;
    public void Awake()
    {
        speed = 8;
    }
    private void OnEnable()
    {
        Invoke("ResBullet",0.5f);
    }
    void Start()
    {
        player = GameObject.Find("Player");
        gm = player.GetComponent<GameManager>();

    }


    void Update()
    {
        transform.Translate(Vector3.forward * speed);
    }

    private void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.CompareTag("enemy"))
        {
            //Destroy(other.gameObject);

            GameObject go = GameObject.Find(other.gameObject.name);
            enemyMove em = go.GetComponent<enemyMove>();
            em.Injured(gm.m_date.playerAtk);

            gm.m_date.playerScore++;
            Destroy(this.gameObject);

        }
    }

    void ResBullet()
    {
        //bulletLeft += Time.deltaTime;  
        if (bulletPool == null)
        {
            bulletPool = GameObject.FindWithTag("bulletPool");
        }
        transform.parent = bulletPool.transform;
        //bulletLeft = 0;
        gameObject.SetActive(false);
    }
}
