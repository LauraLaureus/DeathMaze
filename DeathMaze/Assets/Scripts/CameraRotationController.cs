using UnityEngine;
using System.Collections;

public class CameraRotationController : MonoBehaviour {

	public float step = 1.0f;

	public float speed = 1.0f;
	private Rigidbody rb;

	void Start(){
		rb = GetComponent<Rigidbody> ();
	}


	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.Rotate(Time.deltaTime,-step,0);
		}

		if(Input.GetKey(KeyCode.RightArrow)){
			transform.Rotate(Time.deltaTime,step,0);
		}
			
	}

	void FixedUpdate(){
		if (Input.GetKey (KeyCode.UpArrow))
			rb.velocity += transform.forward * speed;

		if (Input.GetKey (KeyCode.DownArrow))
			rb.velocity -= transform.forward * speed;
	}


}
