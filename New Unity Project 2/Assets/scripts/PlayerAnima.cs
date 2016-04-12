using UnityEngine;
using System.Collections;

public class PlayerAnima : MonoBehaviour {

    // Use this for initialization
    Animator animator;

	void Start () {
        animator = GetComponent<Animator>();
        animator.Play("Run");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void PlayAnimation(string state)
    {
        animator.Play(state);
    }
}
