using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PortalController : MonoBehaviour {

	void OnCollisionEnter(Collision other){
		SceneManager.LoadScene ("Main");
	}
}
