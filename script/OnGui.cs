using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnGui : MonoBehaviour
{
    GameObject player;
    GameManager gm;
    public GUIStyle style;

    
    void Start()
    {
        player = GameObject.Find("Player");
        gm = player.GetComponent<GameManager>();    
    }

    void Update()
    {

    }
    private void OnGUI()
    {
        GUI.Label(new Rect(50, 30, 100, 100), "时间：" + Time.time, style);
        GUI.Label(new Rect(50, 50, 100, 100), "分数：" + gm.m_date.playerScore, style);
        GUI.Label(new Rect(50, 70, 100, 100), "血量：" + gm.m_date.playerHp, style);
        GUI.Label(new Rect(50, 90, 100, 100), "攻击力：" + gm.m_date.playerAtk, style);
    }
}
