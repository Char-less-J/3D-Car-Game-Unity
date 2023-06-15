using UnityEngine;

public class PlayerBehaviourScript : MonoBehaviour {

	public Rigidbody rb ;



	// Use this for initialization

	
	// Update is called once per frame
	void FixedUpdate () {
		
		if (Input.GetKey ("w")) {
			rb.AddForce (2000 * Time.deltaTime, 0, 0);
		}
		if (Input.GetKey ("s")) {
			rb.AddForce (-2000 * Time.deltaTime, 0, 0);
		}
		if (Input.GetKey ("a")) {
			rb.AddForce (0 , 0, 2000 * Time.deltaTime);
		}
		if (Input.GetKey ("d")) {
			rb.AddForce (0 , 0, -2000 * Time.deltaTime);
		}

	}
}