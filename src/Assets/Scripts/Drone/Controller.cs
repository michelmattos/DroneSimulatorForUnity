using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour {
	
	public Rigidbody Frame;
	public MotorThrust MotorFR;
	public MotorThrust MotorFL;
	public MotorThrust MotorRR;
	public MotorThrust MotorRL;
	
	public float MaxRoll = .01f;
	public float MaxPitch = .01f;
	public float MaxYaw = .01f;
	

	// Use this for initialization
	void Start () {
	
	}
	
	void FixedUpdate () {
		float powerFR = Input.GetAxis("Vertical");
		float powerFL = Input.GetAxis("Vertical");
		float powerRR = Input.GetAxis("Vertical");
		float powerRL = Input.GetAxis("Vertical");
		
		// Pitch
//		if (Input.GetAxis("RightY") < 0f) {
//			float halfPitch = MaxPitch;
//			powerFR -= halfPitch;
//			powerFL -= halfPitch;
//			powerRR += halfPitch;
//			powerRL += halfPitch;
//		}
//		else if (Input.GetAxis("RightY") > 0f) {
//			float halfPitch = MaxPitch;
//			powerFR += halfPitch;
//			powerFL += halfPitch;
//			powerRR -= halfPitch;
//			powerRL -= halfPitch;
//		}
//		else {
//			
//		}
		
		// Roll
		if (Input.GetAxis("RightX") > 0f) {
			float halfRoll = MaxRoll;
			powerFR -= halfRoll;
			powerFL += halfRoll;
			powerRR -= halfRoll;
			powerRL += halfRoll;
		}
		else if (Input.GetAxis("RightX") < 0f) {
			float halfRoll = MaxRoll;
			powerFR += halfRoll;
			powerFL -= halfRoll;
			powerRR += halfRoll;
			powerRL -= halfRoll;
		}
		else {
			if (Frame.rotation.eulerAngles.z >= 180f && Frame.rotation.eulerAngles.z <= 359f) {
				float halfRoll = MaxRoll;
				powerFR += halfRoll;
				powerFL -= halfRoll;
				powerRR += halfRoll;
				powerRL -= halfRoll;
			}
			else if (Frame.rotation.eulerAngles.z < 180f && Frame.rotation.eulerAngles.z >= 1f) {
				float halfRoll = MaxRoll;
				powerFR -= halfRoll;
				powerFL += halfRoll;
				powerRR -= halfRoll;
				powerRL += halfRoll;
			}
		}
		
		MotorFR.ApplyTorque(powerFR);
		MotorFL.ApplyTorque(powerFL);
		MotorRR.ApplyTorque(powerRR);
		MotorRL.ApplyTorque(powerRL);
	}
}
