using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class end : MonoBehaviour {

    GameObject date;
    Score s;
    float score;
     public  GUIStyle style;
	void Start () {
        this.GetComponent<Button>().onClick.AddListener(delegate ()
        {
            SceneManager.LoadScene("test");
        });

        date = GameObject.FindWithTag("date");
        s = date.GetComponent<Score>();
        score = s.score;
    }
	
	
	void Update () {
        if (date!=null)
        {
            Debug.Log("1");
        }
        if (s != null)
        {
            Debug.Log("2");
        }
    }
    private void OnGUI()
    {
        GUI.Label(new Rect(900, 300, 100, 100), "分数：" + score, style);
    }
}
