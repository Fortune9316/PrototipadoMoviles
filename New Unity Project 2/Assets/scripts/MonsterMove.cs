using UnityEngine;
using System.Collections;

public class MonsterMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(isActiveAndEnabled)
        {
            transform.position -= new Vector3(5f * Time.deltaTime, transform.position.y, transform.position.z);
        }
	}
}
