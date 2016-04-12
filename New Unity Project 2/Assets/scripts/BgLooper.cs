using UnityEngine;
using System.Collections;

public class BgLooper : MonoBehaviour {

	// Use this for initialization
	Material mat;
	public float Speed;
	Vector2 offset;

	void Start () {
		mat = GetComponent<Renderer> ().material;
		offset = mat.GetTextureOffset ("_MainTex");
	}
	
	// Update is called once per frame
	void Update () {
		offset.x += Speed * Time.deltaTime;
		mat.SetTextureOffset ("_MainTex", offset);
	}
}
