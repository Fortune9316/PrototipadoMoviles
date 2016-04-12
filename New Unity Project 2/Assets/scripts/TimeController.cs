using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimeController : MonoBehaviour {

    public Text text;
    int score;
    float elapsed;
	// Use this for initialization
	void Start () {
        score = 0;
        elapsed = 0;
        text.text = score.ToString();
	}

    // Update is called once per frame
    void Update() {
        elapsed += Time.deltaTime; 
        if(elapsed >= 1f)
        {
            elapsed = 0;
            score++;
            text.text = score.ToString();
        }
	}
}
