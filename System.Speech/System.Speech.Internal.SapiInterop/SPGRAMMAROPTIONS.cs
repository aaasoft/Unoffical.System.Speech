namespace System.Speech.Internal.SapiInterop
{
	internal enum SPGRAMMAROPTIONS
	{
		SPGO_SAPI = 1,
		SPGO_SRGS = 2,
		SPGO_UPS = 4,
		SPGO_SRGS_MSS_SCRIPT = 8,
		SPGO_FILE = 0x10,
		SPGO_HTTP = 0x20,
		SPGO_RES = 0x40,
		SPGO_OBJECT = 0x80,
		SPGO_SRGS_W3C_SCRIPT = 0x100,
		SPGO_SRGS_STG_SCRIPT = 0x200,
		SPGO_SRGS_SCRIPT = 778,
		SPGO_DEFAULT = 243,
		SPGO_ALL = 1019
	}
}
