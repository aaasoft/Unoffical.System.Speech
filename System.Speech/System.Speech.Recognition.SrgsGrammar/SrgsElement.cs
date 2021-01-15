using System.Diagnostics;
using System.Speech.Internal.SrgsParser;
using System.Xml;

namespace System.Speech.Recognition.SrgsGrammar
{
	[Serializable]
	[DebuggerDisplay("SrgsElement Children:[{_items.Count}]")]
	[DebuggerTypeProxy(typeof(SrgsElementDebugDisplay))]
	public abstract class SrgsElement : MarshalByRefObject, IElement
	{
		internal class SrgsElementDebugDisplay
		{
			private SrgsElement[] _elements;

			[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
			public SrgsElement[] AKeys => _elements;

			public SrgsElementDebugDisplay(SrgsElement element)
			{
				_elements = element.Children;
			}
		}

		internal virtual SrgsElement[] Children => new SrgsElement[0];

		internal abstract void WriteSrgs(XmlWriter writer);

		internal abstract string DebuggerDisplayString();

		internal virtual void Validate(SrgsGrammar grammar)
		{
			SrgsElement[] children = Children;
			foreach (SrgsElement srgsElement in children)
			{
				srgsElement.Validate(grammar);
			}
		}

		void IElement.PostParse(IElement parent)
		{
		}
	}
}
