using System;

namespace Drone.Hardware
{
	public class ControlSignal
	{
		
		public float Throttle { get; set; }
		public float Rudder { get; set; }
		public float Elevator { get; set; }
		public float Aileron { get; set; }
		
		public ControlSignal ()
		{
			Throttle = 0f;
			Rudder = 0f;
			Elevator = 0f;
			Aileron = 0f;
		}
		
	}
}