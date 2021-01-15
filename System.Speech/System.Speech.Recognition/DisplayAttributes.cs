namespace System.Speech.Recognition
{
	[Flags]
	public enum DisplayAttributes
	{
		None = 0x0,
		ZeroTrailingSpaces = 0x2,
		OneTrailingSpace = 0x4,
		TwoTrailingSpaces = 0x8,
		ConsumeLeadingSpaces = 0x10
	}
}
