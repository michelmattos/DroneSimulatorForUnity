using UnityEngine;
using System.Collections;

public class CommandControl : Drone.Hardware.Component<object>
{
	
	#region implemented abstract members of Component
	public override object SendSignal (object signal)
	{
		throw new System.NotImplementedException ();
	}
	#endregion
	
}

