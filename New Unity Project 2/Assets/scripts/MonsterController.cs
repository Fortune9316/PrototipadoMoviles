using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MonsterController : MonoBehaviour {

    // Use this for initialization
    public GameObject[] elements;
    List<GameObject> monsters;
    float elapsed;
	void Start () {
        monsters = new List<GameObject>();
        InitMonsters();
        elapsed = 0;
	}

    void InitMonsters()
    {
        int total = elements.Length * 5;
        for (int i =0; i < total;i++)
        {
            int index = Random.Range(0, elements.Length);
            GameObject go = Instantiate(elements[index], transform.position, Quaternion.identity) as GameObject;
            monsters.Add(go);
            go.SetActive(false);
        }
    }
	
	// Update is called once per frame
	void Update () {
        elapsed += Time.deltaTime;
        if(elapsed >= 1.5f)
        {
            CallMonster();
            elapsed = 0;
        }
	}
    void CallMonster()
    {
        int index = Random.Range(0, monsters.Count);
        if(!monsters [index].activeInHierarchy)
        {
            monsters[index].SetActive(true);
            monsters[index].transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        }
    }
}
