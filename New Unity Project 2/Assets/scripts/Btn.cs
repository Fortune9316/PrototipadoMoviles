using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Btn : MonoBehaviour {

	// Use this for initialization
	Button start;
	void Start () {
		start = GetComponent<Button> ();
		start.onClick.AddListener (() => goGame ());
	}

	void goGame(){
		SceneManager.LoadScene ("Game");
	}
		
	// Update is called once per frame
	void Update () {

	}
}
