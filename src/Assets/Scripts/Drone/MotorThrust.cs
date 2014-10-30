using UnityEngine;
using System.Collections;

public class MotorThrust : MonoBehaviour {
	
	public float MaxThrust = .5f;
	public float Thrust = 0f;

	private Rigidbody rigid;

	// Use this for initialization
	void Start () {
		rigid = GetComponent<Rigidbody>();
	}
	
	public void ApplyTorque(float percent) {
		Thrust = Mathf.Clamp01(percent) * MaxThrust;
		rigid.AddForce(transform.up * (Thrust * Physics.gravity.magnitude));
		rigid.AddForce(-transform.forward * (Thrust * Physics.gravity.magnitude));
	}
	
//	void OnDrawGizmos() {
//		Gizmos.color = Color.yellow;
//		Gizmos.DrawRay(transform.position, transform.forward);
//	}
	
}