using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{

    public int score;

    GameObject player;
    GameManager data;

    void Start()
    {
        GameObject.DontDestroyOnLoad(gameObject);


        player = GameObject.FindWithTag("player");
        data = player.GetComponent<GameManager>();
    }


    void Update()
    {
        if (score==0)
        {
            if (player == null || data == null)
            {
                player = GameObject.FindWithTag("player");
                data = player.GetComponent<GameManager>();
            }
        }
        
        score = data.m_date.playerScore;
       // Debug.Log(score);
    }
}
