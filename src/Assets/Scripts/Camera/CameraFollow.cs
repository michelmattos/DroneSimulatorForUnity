using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public Transform Target;
	
	// Update is called once per frame
	void Update () {
		transform.LookAt(Target);
	}
}
