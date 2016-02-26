using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {
    Rigidbody2D r_body;
    float move_force;
    float input_limit;
	// Use this for initialization
	void Start () {
        r_body = this.GetComponent<Rigidbody2D>();
        move_force = 10f;
        input_limit = 0.1f;
        Screen.orientation = ScreenOrientation.Portrait;
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 input = Input.acceleration.normalized;
        

        if (Mathf.Abs(Input.GetAxis("Horizontal")) < input_limit) {
            r_body.drag = 10;
        } else {
            r_body.drag = 1;
            r_body.velocity = new Vector2(Input.GetAxis("Horizontal") * 2, 0);
            //r_body.AddForce(new Vector2(Input.GetAxis("Horizontal") * move_force, 0));
        }

        if (Mathf.Abs(input.x) < input_limit) {
            r_body.drag = 10;
        } else {
            r_body.drag = 1;
            r_body.velocity = new Vector2(input.x * 2, 0);
            //r_body.AddForce(new Vector2(Input.GetAxis("Horizontal") * move_force, 0));
        }


        
    }
}
