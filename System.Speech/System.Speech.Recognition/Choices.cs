using System.Diagnostics;
using System.Speech.Internal;
using System.Speech.Internal.GrammarBuilding;

namespace System.Speech.Recognition
{
	[DebuggerDisplay("{_oneOf.DebugSummary}")]
	public class Choices
	{
		private OneOfElement _oneOf = new OneOfElement();

		internal OneOfElement OneOf => _oneOf;

		public Choices()
		{
		}

		public Choices(params string[] phrases)
		{
			Helpers.ThrowIfNull(phrases, "phrases");
			Add(phrases);
		}

		public Choices(params GrammarBuilder[] alternateChoices)
		{
			Helpers.ThrowIfNull(alternateChoices, "alternateChoices");
			Add(alternateChoices);
		}

		public void Add(params string[] phrases)
		{
			Helpers.ThrowIfNull(phrases, "phrases");
			foreach (string text in phrases)
			{
				Helpers.ThrowIfEmptyOrNull(text, "phrase");
				_oneOf.Add(text);
			}
		}

		public void Add(params GrammarBuilder[] alternateChoices)
		{
			Helpers.ThrowIfNull(alternateChoices, "alternateChoices");
			foreach (GrammarBuilder grammarBuilder in alternateChoices)
			{
				Helpers.ThrowIfNull(grammarBuilder, "alternateChoice");
				_oneOf.Items.Add(new ItemElement(grammarBuilder));
			}
		}

		public GrammarBuilder ToGrammarBuilder()
		{
			return new GrammarBuilder(this);
		}
	}
}
