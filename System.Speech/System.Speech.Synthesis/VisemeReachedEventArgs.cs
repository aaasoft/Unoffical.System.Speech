namespace System.Speech.Synthesis
{
	public class VisemeReachedEventArgs : PromptEventArgs
	{
		private int _currentViseme;

		private TimeSpan _audioPosition;

		private TimeSpan _duration;

		private SynthesizerEmphasis _emphasis;

		private int _nextViseme;

		public int Viseme => _currentViseme;

		public TimeSpan AudioPosition => _audioPosition;

		public TimeSpan Duration => _duration;

		public SynthesizerEmphasis Emphasis => _emphasis;

		public int NextViseme => _nextViseme;

		internal VisemeReachedEventArgs(Prompt speakPrompt, int currentViseme, TimeSpan audioPosition, TimeSpan duration, SynthesizerEmphasis emphasis, int nextViseme)
			: base(speakPrompt)
		{
			_currentViseme = currentViseme;
			_audioPosition = audioPosition;
			_duration = duration;
			_emphasis = emphasis;
			_nextViseme = nextViseme;
		}
	}
}
