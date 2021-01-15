namespace System.Speech.Synthesis
{
	public class VoiceChangeEventArgs : PromptEventArgs
	{
		private VoiceInfo _voice;

		public VoiceInfo Voice => _voice;

		internal VoiceChangeEventArgs(Prompt prompt, VoiceInfo voice)
			: base(prompt)
		{
			_voice = voice;
		}
	}
}
