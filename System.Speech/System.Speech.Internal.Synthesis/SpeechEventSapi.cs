namespace System.Speech.Internal.Synthesis
{
	internal struct SpeechEventSapi
	{
		public short EventId;

		public short ParameterType;

		public int StreamNumber;

		public long AudioStreamOffset;

		public IntPtr Param1;

		public IntPtr Param2;

		public static bool operator ==(SpeechEventSapi event1, SpeechEventSapi event2)
		{
			if (event1.EventId == event2.EventId && event1.ParameterType == event2.ParameterType && event1.StreamNumber == event2.StreamNumber && event1.AudioStreamOffset == event2.AudioStreamOffset && event1.Param1 == event2.Param1)
			{
				return event1.Param2 == event2.Param2;
			}
			return false;
		}

		public static bool operator !=(SpeechEventSapi event1, SpeechEventSapi event2)
		{
			return !(event1 == event2);
		}

		public override bool Equals(object obj)
		{
			if (!(obj is SpeechEventSapi))
			{
				return false;
			}
			return this == (SpeechEventSapi)obj;
		}

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}
	}
}
