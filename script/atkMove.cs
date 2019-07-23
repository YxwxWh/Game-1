using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class atkMove : MonoBehaviour {

    private GameObject player;
    GameManager gm;

    void Start()
    {
        player = GameObject.Find("Player");
        gm = player.GetComponent<GameManager>();
    }


    void Update()
    {
        transform.Translate(-Vector3.forward * 0.5f, Space.World);
        transform.Rotate(new Vector3(0, 1, 0), Space.Self);
        Destroy(this.gameObject, 10);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("player"))
        {
            gm.m_date.playerAtk++;
            Destroy(this.gameObject);
        }
    }
}
