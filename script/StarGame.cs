using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StarGame : MonoBehaviour {

    public GameObject player;
    int count;
	void Start () {
        this.GetComponent<Button>().onClick.AddListener(delegate ()
        {
            count = 1;
            Invoke("StarG", 1);
        });
    }

    void StarG()
    {
        SceneManager.LoadSceneAsync("WeekWork");
    }
    
    void Update () {
        

        if (count==1)
        {
            player.transform.Translate(new Vector3(0,0,2));
        }
	}
}
