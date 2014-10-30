using UnityEngine;
using System.Collections;
using Drone.Hardware;

public class MotorsController : Drone.Hardware.Component <ThrustSignal>
{
	
	public MotorThrust MotorFR;
	public MotorThrust MotorFL;
	public MotorThrust MotorRR;
	public MotorThrust MotorRL;
	
	#region implemented abstract members of Component
	public override ThrustSignal ProcessSignal (ThrustSignal signal)
	{
		MotorFR.ApplyTorque (signal.FRThrust);
		MotorFL.ApplyTorque (signal.FLThrust);
		MotorRR.ApplyTorque (signal.RRThrust);
		MotorRL.ApplyTorque (signal.RLThrust);
		
		return signal;
	}
	#endregion
	
}

