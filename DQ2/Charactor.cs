using System;
using System.Collections.ObjectModel;

namespace DQ2
{
	class Charactor
	{
		public ObservableCollection<CharactorItem> Items { get; set; } = new ObservableCollection<CharactorItem>();

		private readonly uint mAddress;

		public Charactor(uint address)
		{
			mAddress = address;

			for (uint i = 0; i < Util.ItemCount; i++)
			{
				Items.Add(new CharactorItem(mAddress + 0x28 + i * 2));
			}
		}

		public uint Lv
		{
			get
			{
				return SaveData.Instance().ReadNumber(mAddress + 0x14, 1);
			}

			set
			{
				Util.WriteNumber(mAddress + 0x14, 1, value, 1, 99);
			}
		}

		public String Name
		{
			get
			{
				return SaveData.Instance().ReadText(mAddress + 0x02, 4);
			}

			set
			{
				SaveData.Instance().WriteText(mAddress + 0x02, 4, value);
			}
		}

		public uint Power
		{
			get
			{
				return SaveData.Instance().ReadNumber(mAddress + 0x1D, 2);
			}

			set
			{
				Util.WriteNumber(mAddress + 0x1D, 2, value, 0, 999);
			}
		}

		public uint Speed
		{
			get
			{
				return SaveData.Instance().ReadNumber(mAddress + 0x1F, 2);
			}

			set
			{
				Util.WriteNumber(mAddress + 0x1F, 2, value, 0, 999);
			}
		}

		public uint Protect
		{
			get
			{
				return SaveData.Instance().ReadNumber(mAddress + 0x21, 2);
			}

			set
			{
				Util.WriteNumber(mAddress + 0x21, 2, value, 0, 999);
			}
		}

		public uint HP
		{
			get
			{
				return SaveData.Instance().ReadNumber(mAddress + 0x15, 2);
			}

			set
			{
				Util.WriteNumber(mAddress + 0x15, 2, value, 0, 999);
			}
		}

		public uint MaxHP
		{
			get
			{
				return SaveData.Instance().ReadNumber(mAddress + 0x23, 2);
			}

			set
			{
				Util.WriteNumber(mAddress + 0x23, 2, value, 0, 999);
			}
		}

		public uint MP
		{
			get
			{
				return SaveData.Instance().ReadNumber(mAddress + 0x17, 2);
			}

			set
			{
				Util.WriteNumber(mAddress + 0x17, 2, value, 0, 999);
			}
		}

		public uint MaxMP
		{
			get
			{
				return SaveData.Instance().ReadNumber(mAddress + 0x25, 2);
			}

			set
			{
				Util.WriteNumber(mAddress + 0x25, 2, value, 0, 999);
			}
		}

		public uint Exp
		{
			get
			{
				return SaveData.Instance().ReadNumber(mAddress + 0x19, 4);
			}

			set
			{
				Util.WriteNumber(mAddress + 0x19, 4, value, 0, 99999999);
			}
		}

		public bool Exist
		{
			get
			{
				return SaveData.Instance().ReadNumber(mAddress + 0x27, 1) == 1;
			}

			set
			{
				SaveData.Instance().WriteNumber(mAddress + 0x27, 1, value ? 1U : 0);
			}
		}
	}
}
