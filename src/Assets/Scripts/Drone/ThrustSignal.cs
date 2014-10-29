using System;

namespace Drone.Hardware
{
	public class ThrustSignal
	{
		
		public float FRThrust { get; set; }
		public float FLThrust { get; set; }
		public float RRThrust { get; set; }
		public float RLThrust { get; set; }
		
		public ThrustSignal ()
		{
			FRThrust = 0f;
			FLThrust = 0f;
			RRThrust = 0f;
			RLThrust = 0f;
		}
		
	}
}