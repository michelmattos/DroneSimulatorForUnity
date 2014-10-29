using UnityEngine;
using System.Collections;
using Drone.Hardware;

public class InputControl : MonoBehaviour
{
	
	public MainBoard MainBoard;
	
	void FixedUpdate ()
	{
		ControlSignal signal = new ControlSignal ();
		
		signal.Throttle = Input.GetAxis ("LeftY");
		signal.Rudder = Input.GetAxis ("LeftX");
		signal.Elevator = Input.GetAxis ("RightY");
		signal.Aileron = Input.GetAxis ("RightX");
		
		MainBoard.SendControlSignal (signal);
	}
	
}