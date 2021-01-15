using System.Runtime.InteropServices;
using System.Speech.Internal;

namespace System.Speech.Synthesis.TtsEngine
{
	[StructLayout(LayoutKind.Sequential)]
	public class TextFragment
	{
		private FragmentState _state;

		[MarshalAs(UnmanagedType.LPWStr)]
		private string _textToSpeak = string.Empty;

		private int _textOffset;

		private int _textLength;

		public FragmentState State
		{
			get
			{
				return _state;
			}
			set
			{
				_state = value;
			}
		}

		public string TextToSpeak
		{
			get
			{
				return _textToSpeak;
			}
			set
			{
				Helpers.ThrowIfEmptyOrNull(value, "value");
				_textToSpeak = value;
			}
		}

		public int TextOffset
		{
			get
			{
				return _textOffset;
			}
			set
			{
				_textOffset = value;
			}
		}

		public int TextLength
		{
			get
			{
				return _textLength;
			}
			set
			{
				_textLength = value;
			}
		}

		public TextFragment()
		{
		}

		internal TextFragment(FragmentState fragState)
			: this(fragState, null, null, 0, 0)
		{
		}

		internal TextFragment(FragmentState fragState, string textToSpeak)
			: this(fragState, textToSpeak, textToSpeak, 0, textToSpeak.Length)
		{
		}

		internal TextFragment(FragmentState fragState, string textToSpeak, string textFrag, int offset, int length)
		{
			if (fragState.Action == TtsEngineAction.Speak || fragState.Action == TtsEngineAction.Pronounce)
			{
				textFrag = textToSpeak;
			}
			if (!string.IsNullOrEmpty(textFrag))
			{
				TextToSpeak = textFrag;
			}
			State = fragState;
			TextOffset = offset;
			TextLength = length;
		}
	}
}
