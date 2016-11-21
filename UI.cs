using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UI : MonoBehaviour {

    Text Txt;
    private float Score = 0;

	// Use this for initialization
	void Start () {
        Txt = gameObject.GetComponent<Text>();
        Txt.text = "Score: " + Score;
	}
	
	// Update is called once per frame
	void Update () {
        Score += Time.deltaTime;
        Txt.text = "Score : " + Mathf.Round(Score);
    }
}
