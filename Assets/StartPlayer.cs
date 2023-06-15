using UnityEngine;

public class StartPlayer : MonoBehaviour {

	public Rigidbody rb ;



	// Use this for initialization


	// Update is called once per frame
	void FixedUpdate () {

		if (Input.GetKey ("space")) {
			rb.AddForce (0, 0, 200);
		}

	}
}