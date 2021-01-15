namespace System.Speech.Synthesis
{
	public class BookmarkReachedEventArgs : PromptEventArgs
	{
		private string _bookmark;

		private TimeSpan _audioPosition;

		public string Bookmark => _bookmark;

		public TimeSpan AudioPosition => _audioPosition;

		internal BookmarkReachedEventArgs(Prompt prompt, string bookmark, TimeSpan audioPosition)
			: base(prompt)
		{
			_bookmark = bookmark;
			_audioPosition = audioPosition;
		}
	}
}
