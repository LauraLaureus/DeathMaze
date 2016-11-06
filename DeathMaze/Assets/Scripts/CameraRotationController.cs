using UnityEngine;
using System.Collections;

public class CameraRotationController : MonoBehaviour {

	public float step = 1.0f;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.Rotate(Time.deltaTime,-step,0);
		}

		if(Input.GetKey(KeyCode.RightArrow)){
			transform.Rotate(Time.deltaTime,step,0);
		}
			
	}
}
