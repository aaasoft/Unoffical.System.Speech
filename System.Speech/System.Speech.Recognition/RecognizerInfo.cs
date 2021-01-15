using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Speech.AudioFormat;
using System.Speech.Internal;
using System.Speech.Internal.ObjectTokens;

namespace System.Speech.Recognition
{
	public class RecognizerInfo : IDisposable
	{
		private ReadOnlyDictionary<string, string> _attributes;

		private string _id;

		private string _name;

		private string _description;

		private string _sapiObjectTokenId;

		private CultureInfo _culture;

		private ReadOnlyCollection<SpeechAudioFormatInfo> _supportedAudioFormats;

		private ObjectToken _objectToken;

		public string Id => _id;

		public string Name => _name;

		public string Description => _description;

		public CultureInfo Culture => _culture;

		public ReadOnlyCollection<SpeechAudioFormatInfo> SupportedAudioFormats => _supportedAudioFormats;

		public IDictionary<string, string> AdditionalInfo => _attributes;

		private RecognizerInfo(ObjectToken token, CultureInfo culture)
		{
			_id = token.Name;
			_description = token.Description;
			_sapiObjectTokenId = token.Id;
			_name = token.TokenName();
			_culture = culture;
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			string[] valueNames = token.Attributes.GetValueNames();
			foreach (string text in valueNames)
			{
				if (token.Attributes.TryGetString(text, out var value))
				{
					dictionary[text] = value;
				}
			}
			_attributes = new ReadOnlyDictionary<string, string>(dictionary);
			if (token.Attributes.TryGetString("AudioFormats", out var value2))
			{
				_supportedAudioFormats = new ReadOnlyCollection<SpeechAudioFormatInfo>(SapiAttributeParser.GetAudioFormatsFromString(value2));
			}
			else
			{
				_supportedAudioFormats = new ReadOnlyCollection<SpeechAudioFormatInfo>(new List<SpeechAudioFormatInfo>());
			}
			_objectToken = token;
		}

		internal static RecognizerInfo Create(ObjectToken token)
		{
			if (token.Attributes == null)
			{
				return null;
			}
			if (!token.Attributes.TryGetString("Language", out var value))
			{
				return null;
			}
			CultureInfo cultureInfoFromLanguageString = SapiAttributeParser.GetCultureInfoFromLanguageString(value);
			if (cultureInfoFromLanguageString != null)
			{
				return new RecognizerInfo(token, cultureInfoFromLanguageString);
			}
			return null;
		}

		internal ObjectToken GetObjectToken()
		{
			return _objectToken;
		}

		public void Dispose()
		{
			_objectToken.Dispose();
			GC.SuppressFinalize(this);
		}
	}
}
