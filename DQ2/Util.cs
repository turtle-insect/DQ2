namespace DQ2
{
	class Util
	{
		public const uint BlockSize = 0x400;
		public const uint ItemCount = 10;
		public const uint MaxParty = 3;

		public static void WriteNumber(uint address, uint size, uint value, uint min, uint max)
		{
			if (value < min) value = min;
			if (value > max) value = max;
			SaveData.Instance().WriteNumber(address, size, value);
		}
	}
}
