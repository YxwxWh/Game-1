using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public class PlayerDate
    {
        public int playerHp;
        public int playerScore;
        public int playerAtk;
        public int hurt;
    }

    GameObject blood;
    public PlayerDate m_date;
    ParticleSystem Boom;
    void Awake()
    {
        m_date = new PlayerDate();
        m_date.playerHp = 100;
        m_date.playerScore = 0;
        m_date.playerAtk = 1;
        m_date.hurt = 5;

        blood = GameObject.Find("Slider");
    }
    GameObject rw;
    private void Start()
    {
        rw = Resources.Load<GameObject>("GameOver");
        Boom = Resources.Load<ParticleSystem>("Boom");
    }
    public void Injured()
    {
        float time = Time.time;
        if (time % 20 == 0)
        {
            m_date.hurt++;
            Debug.Log(m_date.hurt);
        }
        m_date.playerHp -= m_date.hurt;
        Slider sl = blood.GetComponent<Slider>();
        sl.value = m_date.playerHp * 0.01f;
        if (m_date.playerHp <= 0)
        {
            //GUI.Label(new Rect(50,50,100,100),"游戏结束");
            ParticleSystem boom = Instantiate<ParticleSystem>(Boom);
            boom.transform.position = this.transform.position;
            boom.Play();
            Time.timeScale = 0.05f;

            GameObject go = Instantiate<GameObject>(rw);
            go.transform.SetParent(GameObject.FindWithTag("UI").transform);
            go.transform.position = new Vector3(950, 400, 0);


        }
    }
    void BackToStar()
    {

        SceneManager.LoadScene("end");
    }

    public void AddBlood()
    {
        m_date.playerHp += 20;
        Slider sl = blood.GetComponent<Slider>();
        sl.value = m_date.playerHp * 0.01f;
        if (m_date.playerHp > 100)
        {
            m_date.playerHp = 100;
        }
    }



    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {


            Invoke("BackToStar", 0);
        }
    }
    private void FixedUpdate()
    {

    }
}
