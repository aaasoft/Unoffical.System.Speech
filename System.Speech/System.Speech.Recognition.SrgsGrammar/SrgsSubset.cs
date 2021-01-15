using System.Diagnostics;
using System.Speech.Internal;
using System.Speech.Internal.SrgsParser;
using System.Xml;

namespace System.Speech.Recognition.SrgsGrammar
{
	[Serializable]
	[DebuggerDisplay("{DebuggerDisplayString ()}")]
	public class SrgsSubset : SrgsElement, ISubset, IElement
	{
		private SubsetMatchingMode _matchMode;

		private string _text;

		public SubsetMatchingMode MatchingMode
		{
			get
			{
				return _matchMode;
			}
			set
			{
				if (value != SubsetMatchingMode.OrderedSubset && value != 0 && value != SubsetMatchingMode.OrderedSubsetContentRequired && value != SubsetMatchingMode.SubsequenceContentRequired)
				{
					throw new ArgumentException(SR.Get(SRID.InvalidSubsetAttribute), "value");
				}
				_matchMode = value;
			}
		}

		public string Text
		{
			get
			{
				return _text;
			}
			set
			{
				Helpers.ThrowIfEmptyOrNull(value, "value");
				value = value.Trim(Helpers._achTrimChars);
				Helpers.ThrowIfEmptyOrNull(value, "value");
				_text = value;
			}
		}

		public SrgsSubset(string text)
			: this(text, SubsetMatchingMode.Subsequence)
		{
		}

		public SrgsSubset(string text, SubsetMatchingMode matchingMode)
		{
			Helpers.ThrowIfEmptyOrNull(text, "text");
			if (matchingMode != SubsetMatchingMode.OrderedSubset && matchingMode != 0 && matchingMode != SubsetMatchingMode.OrderedSubsetContentRequired && matchingMode != SubsetMatchingMode.SubsequenceContentRequired)
			{
				throw new ArgumentException(SR.Get(SRID.InvalidSubsetAttribute), "matchingMode");
			}
			_matchMode = matchingMode;
			_text = text.Trim(Helpers._achTrimChars);
			Helpers.ThrowIfEmptyOrNull(_text, "text");
		}

		internal override void WriteSrgs(XmlWriter writer)
		{
			writer.WriteStartElement("sapi", "subset", "http://schemas.microsoft.com/Speech/2002/06/SRGSExtensions");
			if (_matchMode != 0)
			{
				string value = null;
				switch (_matchMode)
				{
				case SubsetMatchingMode.Subsequence:
					value = "subsequence";
					break;
				case SubsetMatchingMode.OrderedSubset:
					value = "ordered-subset";
					break;
				case SubsetMatchingMode.SubsequenceContentRequired:
					value = "subsequence-content-required";
					break;
				case SubsetMatchingMode.OrderedSubsetContentRequired:
					value = "ordered-subset-content-required";
					break;
				}
				writer.WriteAttributeString("sapi", "match", "http://schemas.microsoft.com/Speech/2002/06/SRGSExtensions", value);
			}
			if (_text != null && _text.Length > 0)
			{
				writer.WriteString(_text);
			}
			writer.WriteEndElement();
		}

		internal override void Validate(SrgsGrammar grammar)
		{
			grammar.HasSapiExtension = true;
			base.Validate(grammar);
		}

		internal override string DebuggerDisplayString()
		{
			return _text + " [" + _matchMode.ToString() + "]";
		}
	}
}
