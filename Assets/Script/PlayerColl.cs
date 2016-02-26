using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerColl : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D coll) {
        print("Y");
        coll.CompareTag("Enemy");
        //SceneManager.LoadScene(0);
    }
}
