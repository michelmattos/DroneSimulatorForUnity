using System;
using UnityEngine;

namespace Drone.Hardware
{
	public abstract class Component<S> : MonoBehaviour
	{
		
		public abstract S ProcessSignal (S signal); 
		
	}
}