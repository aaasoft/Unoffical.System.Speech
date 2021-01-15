using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Speech.Internal;
using System.Speech.Internal.SrgsParser;
using System.Text;
using System.Xml;

namespace System.Speech.Recognition.SrgsGrammar
{
	[Serializable]
	[DebuggerDisplay("{DebuggerDisplayString ()}")]
	[DebuggerTypeProxy(typeof(OneOfDebugDisplay))]
	public class SrgsOneOf : SrgsElement, IOneOf, IElement
	{
		internal class OneOfDebugDisplay
		{
			private Collection<SrgsItem> _items;

			[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
			public SrgsItem[] AKeys
			{
				get
				{
					SrgsItem[] array = new SrgsItem[_items.Count];
					for (int i = 0; i < _items.Count; i++)
					{
						array[i] = _items[i];
					}
					return array;
				}
			}

			public OneOfDebugDisplay(SrgsOneOf oneOf)
			{
				_items = oneOf._items;
			}
		}

		private SrgsItemList _items = new SrgsItemList();

		public Collection<SrgsItem> Items => _items;

		internal override SrgsElement[] Children
		{
			get
			{
				SrgsElement[] array = new SrgsElement[_items.Count];
				int num = 0;
				foreach (SrgsItem item in _items)
				{
					array[num++] = item;
				}
				return array;
			}
		}

		public SrgsOneOf()
		{
		}

		public SrgsOneOf(params string[] items)
			: this()
		{
			Helpers.ThrowIfNull(items, "items");
			for (int i = 0; i < items.Length; i++)
			{
				if (items[i] == null)
				{
					throw new ArgumentNullException("items", SR.Get(SRID.ParamsEntryNullIllegal));
				}
				_items.Add(new SrgsItem(items[i]));
			}
		}

		public SrgsOneOf(params SrgsItem[] items)
			: this()
		{
			Helpers.ThrowIfNull(items, "items");
			foreach (SrgsItem srgsItem in items)
			{
				if (srgsItem == null)
				{
					throw new ArgumentNullException("items", SR.Get(SRID.ParamsEntryNullIllegal));
				}
				_items.Add(srgsItem);
			}
		}

		public void Add(SrgsItem item)
		{
			Helpers.ThrowIfNull(item, "item");
			Items.Add(item);
		}

		internal override void WriteSrgs(XmlWriter writer)
		{
			writer.WriteStartElement("one-of");
			foreach (SrgsItem item in _items)
			{
				item.WriteSrgs(writer);
			}
			writer.WriteEndElement();
		}

		internal override string DebuggerDisplayString()
		{
			StringBuilder stringBuilder = new StringBuilder("SrgsOneOf Count = ");
			stringBuilder.Append(_items.Count);
			return stringBuilder.ToString();
		}
	}
}
