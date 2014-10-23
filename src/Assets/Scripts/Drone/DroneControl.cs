using UnityEngine;
using System.Collections;

public class DroneControl : MonoBehaviour {

	public Transform RotorFR;
	public Transform RotorFL;
	public Transform RotorRR;
	public Transform RotorRL;
	public float Force;
	public float Torque;

	private Rigidbody rigid;
	private Vector3 forceFR;
	private Vector3 forceFL;
	private Vector3 forceRR;
	private Vector3 forceRL;

	private Vector3 startPos;
	private Quaternion startRotation;

	public Vector3 Euler;

	// Use this for initialization
	void Start () {
		rigid = GetComponent<Rigidbody>();
		startPos = transform.position;
		startRotation = transform.rotation;
	}

	void Update() {
		if (Input.GetButtonDown("Fire1")) {
			rigid.position = startPos;
			rigid.rotation = startRotation;
			rigid.velocity = Vector3.zero;
			rigid.angularVelocity = Vector3.zero;
		}
		Euler = rigid.rotation.eulerAngles;
	}

	void FixedUpdate () {
		forceFR = Vector3.zero;
		forceFL = Vector3.zero;
		forceRR = Vector3.zero;
		forceRL = Vector3.zero;

		if (Input.GetAxis("Vertical") > 0f && rigid.velocity.y < 2f) {
			forceFR += (Force * Input.GetAxis("Vertical")) * transform.up;
			forceFL += (Force * Input.GetAxis("Vertical")) * transform.up;
			forceRR += (Force * Input.GetAxis("Vertical")) * transform.up;
			forceRL += (Force * Input.GetAxis("Vertical")) * transform.up;
		}

		if (Input.GetAxis("RightY") > 0f) {
			forceRR += (Force * -Input.GetAxis("RightY")) * transform.up * .05f;
			forceRL += (Force * -Input.GetAxis("RightY")) * transform.up * .05f;
		}
		if (Input.GetAxis("RightY") < 0f) {
			forceFR += (Force * Input.GetAxis("RightY")) * transform.up * .05f;
			forceFL += (Force * Input.GetAxis("RightY")) * transform.up * .05f;
		}
		if (Input.GetAxis("RightX") > 0f) {
			forceFL += (Force * Input.GetAxis("RightX")) * transform.up * .05f;
			forceRL += (Force * Input.GetAxis("RightX")) * transform.up * .05f;
		}
		if (Input.GetAxis("RightX") < 0f) {
			forceFR += (Force * -Input.GetAxis("RightX")) * transform.up * .05f;
			forceRR += (Force * -Input.GetAxis("RightX")) * transform.up * .05f;
		}

		rigid.AddForceAtPosition(forceFR, RotorFR.position);
		rigid.AddForceAtPosition(forceFL, RotorFL.position);
		rigid.AddForceAtPosition(forceRR, RotorRR.position);
		rigid.AddForceAtPosition(forceRL, RotorRL.position);

		rigid.AddRelativeTorque(Vector3.up * Torque * Input.GetAxis("Horizontal"));
	}

	/*void OnDrawGizmosSelected() {
        Gizmos.color = Color.yellow;
        Gizmos.DrawSphere(RotorFR.position, 1);
    }*/
}
