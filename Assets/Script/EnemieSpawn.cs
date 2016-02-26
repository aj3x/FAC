﻿using UnityEngine;
using System.Collections;

public class EnemieSpawn : MonoBehaviour {
    public GameObject enemy;
    public float min_wait = 0.1f;
    public float max_wait = 2f;
    public float top_speed = 3;
    public float border = 3f;
    Rigidbody2D r_body;

	// Use this for initialization
	void Start () {
        Invoke("Spawn", max_wait);
        Invoke("increaseDif", 15f);
        r_body = GetComponent<Rigidbody2D>();
        r_body.velocity = new Vector2(top_speed, 0);
	}
	
	// Update is called once per frame
	void Update () {
	}

    void FixedUpdate() {
        if(transform.position.x < -border)
            r_body.velocity = (new Vector2(top_speed,0));
        if(transform.position.x > border) {
            r_body.velocity = (new Vector2(-top_speed, 0));
        }
    }

    void increaseDif() {
        if (min_wait == 0) {
            GameObject.Find("Enemy").SetActive(false);
        }
        min_wait -= 0.05f;
        max_wait -= 0.05f;
        Invoke("increaseDif", 2f);
    }
    void Spawn() {
        Instantiate<GameObject>(enemy).transform.position = gameObject.transform.position;
        Invoke("Spawn", Random.Range(min_wait, max_wait));
    }
}
