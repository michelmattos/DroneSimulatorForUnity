using UnityEngine;
using System.Collections;
using Drone.Hardware;

public class MainBoard : MonoBehaviour
{
	
	public MonoBehaviour[] ThrustSignalBus;
	public MonoBehaviour[] ControlSignalBus;
	
	public void SendThrustSignal (ThrustSignal signal)
	{
		ThrustSignal result = signal;
		foreach (Drone.Hardware.Component<ThrustSignal> component in ThrustSignalBus)
		{
			result = component.ProcessSignal (result);
		}
	}
	
	public void SendControlSignal (ControlSignal signal)
	{
		ControlSignal result = signal;
		foreach (Drone.Hardware.Component<ControlSignal> component in ControlSignalBus)
		{
			result = component.ProcessSignal (result);
		}
	}
	
}

