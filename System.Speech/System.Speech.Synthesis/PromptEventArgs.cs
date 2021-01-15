using System.ComponentModel;

namespace System.Speech.Synthesis
{
	public abstract class PromptEventArgs : AsyncCompletedEventArgs
	{
		private Prompt _prompt;

		public Prompt Prompt => _prompt;

		internal PromptEventArgs(Prompt prompt)
			: base(prompt._exception, prompt._exception != null, prompt)
		{
			_prompt = prompt;
		}
	}
}
