using UnityEngine;
using System.Collections;

public class BgLooper : MonoBehaviour {

    // Use this for initialization

    Material mat;
    public float speed;
    Vector2 offset;
	void Start () {
        speed = 1f;
        mat = GetComponent<Renderer>().material;
        offset = mat.GetTextureOffset("_MainTex");
        if (gameObject.name == "Ground")
        {
            speed -= speed/2;
        }

    }
	
	// Update is called once per frame
	void Update () {
        offset.x += speed * Time.deltaTime;
        mat.SetTextureOffset("_MainTex", offset);
	}
}
