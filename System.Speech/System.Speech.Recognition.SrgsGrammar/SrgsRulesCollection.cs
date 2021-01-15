using System.Collections.ObjectModel;
using System.Speech.Internal;

namespace System.Speech.Recognition.SrgsGrammar
{
	[Serializable]
	public sealed class SrgsRulesCollection : KeyedCollection<string, SrgsRule>
	{
		public void Add(params SrgsRule[] rules)
		{
			Helpers.ThrowIfNull(rules, "rules");
			for (int i = 0; i < rules.Length; i++)
			{
				if (rules[i] == null)
				{
					throw new ArgumentNullException("rules", SR.Get(SRID.ParamsEntryNullIllegal));
				}
				base.Add(rules[i]);
			}
		}

		protected override string GetKeyForItem(SrgsRule rule)
		{
			if (rule == null)
			{
				throw new ArgumentNullException("rule");
			}
			return rule.Id;
		}
	}
}
