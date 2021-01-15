using System.Runtime.InteropServices;
using System.Speech.Internal;

namespace System.Speech.Synthesis.TtsEngine
{
	[StructLayout(LayoutKind.Sequential)]
	public class Prosody
	{
		internal ProsodyNumber _pitch;

		internal ProsodyNumber _range;

		internal ProsodyNumber _rate;

		internal int _duration;

		internal ProsodyNumber _volume;

		internal ContourPoint[] _contourPoints;

		public ProsodyNumber Pitch
		{
			get
			{
				return _pitch;
			}
			set
			{
				_pitch = value;
			}
		}

		public ProsodyNumber Range
		{
			get
			{
				return _range;
			}
			set
			{
				_range = value;
			}
		}

		public ProsodyNumber Rate
		{
			get
			{
				return _rate;
			}
			set
			{
				_rate = value;
			}
		}

		public int Duration
		{
			get
			{
				return _duration;
			}
			set
			{
				_duration = value;
			}
		}

		public ProsodyNumber Volume
		{
			get
			{
				return _volume;
			}
			set
			{
				_volume = value;
			}
		}

		public ContourPoint[] GetContourPoints()
		{
			return _contourPoints;
		}

		public void SetContourPoints(ContourPoint[] points)
		{
			Helpers.ThrowIfNull(points, "points");
			_contourPoints = (ContourPoint[])points.Clone();
		}

		public Prosody()
		{
			Pitch = new ProsodyNumber(0);
			Range = new ProsodyNumber(0);
			Rate = new ProsodyNumber(0);
			Volume = new ProsodyNumber(-1);
		}

		internal Prosody Clone()
		{
			Prosody prosody = new Prosody();
			prosody._pitch = _pitch;
			prosody._range = _range;
			prosody._rate = _rate;
			prosody._duration = _duration;
			prosody._volume = _volume;
			return prosody;
		}
	}
}
