using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FllowPlayer : MonoBehaviour {
    public GameObject target;
    public  GameObject[] enemy;
    private int enemyCount;
    public  int enemysCount;

    private GameObject player;
    GameManager gm;

    public static FllowPlayer Instance;

    private void Awake()
    {
        Instance = this;
    }
    void Start () {
        player = GameObject.Find("Player");
        gm = player.GetComponent<GameManager>();
        enemyCount = 0;
        enemysCount = 0;
    }
	
	// Update is called once per frame
	void Update () {
        transform.LookAt(target.transform.position);

      

    }
    private void FixedUpdate()
    {
        float gameTime = Time.time;
        if (gm.m_date.playerScore == 500)
        {
            GameObject enemys = Instantiate<GameObject>(enemy[3]);
            enemys.transform.position = new Vector3(0, 5, 150);
            enemys.transform.Rotate(0, -180, 0);
        }
        if (gm.m_date.playerScore == 1000)
        {
            GameObject enemys = Instantiate<GameObject>(enemy[3]);
            enemys.transform.position = new Vector3(0, 5, 150);
            enemys.transform.Rotate(0, -180, 0);
        }
        if (gm.m_date.playerScore == 1500)
        {
            GameObject enemys = Instantiate<GameObject>(enemy[3]);
            enemys.transform.position = new Vector3(0, 5, 150);
            enemys.transform.Rotate(0, -180, 0);
        }

        if (gameTime % 1 == 0 && enemyCount==0)
        {
            GameObject enemys = Instantiate<GameObject>(enemy[Random.Range(0, 3)]);
            enemys.transform.position = new Vector3(Random.Range(-80, 80), 5, Random.Range(80, 160));
            enemys.transform.Rotate(0, -180, 0);
            enemysCount++;
        }

        if (enemysCount >= 8)
        {
            enemyCount = 1;
        }
        else
        {
            enemyCount = 0;
        }
    }
}
