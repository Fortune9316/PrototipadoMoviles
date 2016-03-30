using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerJump : MonoBehaviour {

    // Use this for initialization
    Rigidbody2D body;
    Button jumpButton;
    bool canJump;
    public float velocity = 10f;
	void Start () {
        canJump = false;

        body = GetComponent<Rigidbody2D>();
        jumpButton = GameObject.Find("jumpStart").GetComponent<Button>();
        jumpButton.onClick.AddListener(() => jump());
	}

    void jump()
    {
        if (canJump)
        {
            canJump = false;
            body.velocity = new Vector2(body.velocity.x, velocity);
        }
    }
	
	// Update is called once per frame
	void Update () {
	    if(Mathf.Abs(body.velocity.y) == 0)
        {
            canJump = true;
        }
	}
}
