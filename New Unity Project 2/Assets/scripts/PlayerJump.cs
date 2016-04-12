using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class PlayerJump : MonoBehaviour {

	// Use this for initialization
	Rigidbody2D body;
	bool canJump;
	Button jumpButton;
    Animator anim;
    const string RUN = "Run";
    const string JUMP = "Jump";
    const string IDLE = "Idle";

	float jumpPower = 10f;
	void Start () {
		body = GetComponent<Rigidbody2D> ();
		jumpButton = GameObject.Find ("btnTouch").GetComponent<Button> ();
        anim = GetComponent<Animator>();
        anim.Play(RUN);
		jumpButton.onClick.AddListener(() => jump());
		canJump = false;
	}

	void jump(){
		if (canJump) {
			canJump = false;
            anim.Play(JUMP);
			body.velocity = new Vector2 (body.velocity.x, jumpPower);
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (Mathf.Abs (body.velocity.y) == 0) {
			canJump = true;
            anim.Play(RUN);
		}
	}
}
