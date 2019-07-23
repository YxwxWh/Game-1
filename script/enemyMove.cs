using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMove : MonoBehaviour
{
    //public GameObject target;
    // Use this for initialization
    private int hp;
    public int hp_m;
    private float speed;
    public  int atk;
    FllowPlayer c;

    GameObject cubeBlood;
    GameObject addBlood;
    GameObject cubeAtk;
    GameObject addAtk;
    public GUIStyle style;

    ParticleSystem boom;

    private void Awake()
    {
        addBlood = Resources.Load<GameObject>("addBlood");
        addAtk = Resources.Load<GameObject>("addAtk");
    }
    void Start()
    {
        hp = 100*hp_m;
        speed = 0.2f;
        atk = 1;

        

        //GameObject go = GameObject.FindWithTag("PlayerCamer");
        // c = go.GetComponent<FllowPlayer>();
        c = FllowPlayer.Instance;
        boom= Resources.Load<ParticleSystem>("Boom");
       
    }
    public void Injured(int atk)
    {

        hp -= atk;
        if (hp <= 0)
        {
            if (Random.Range(1, 3) == 1)
            {
                cubeBlood = Instantiate<GameObject>(addBlood);
                cubeBlood.transform.position = this.transform.position;
            }
            else if (Random.Range(1, 3) == 2)
            {
                cubeAtk = Instantiate<GameObject>(addAtk);
                cubeAtk.transform.position = this.transform.position;
            }
          
            Destroy(this.gameObject);
            ParticleSystem eboom = Instantiate<ParticleSystem>(boom);
            eboom.transform.position = this.transform.position;
            eboom.Play();

            c.enemysCount--;//时不时会报错！！
        }
    }
    // Update is called once per frame
    void Update()
    {

        transform.Translate(Vector3.right * speed);

        //Debug.Log(hp);
        //Debug.Log(speed);
    }

    private void FixedUpdate()
    {
        float time = Time.time;
        if (time % 30 == 0)
        {
            hp += 100;
            atk++;
        }

        if (time % 5 == 0)
        {
            if (Random.Range(1, 3) == 1)
            {
                speed = 0.2f;
            }
            else
            {
                speed = -0.2f;
            }


        }

    }

   
}
