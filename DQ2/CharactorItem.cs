using System.ComponentModel;

namespace DQ2
{
	class CharactorItem : INotifyPropertyChanged
	{
		private uint mAddress;
		public event PropertyChangedEventHandler PropertyChanged;

		public CharactorItem(uint address)
		{
			mAddress = address;
		}

		public uint ID
		{
			get
			{
				return SaveData.Instance().ReadNumber(mAddress, 1);
			}
			set
			{
				SaveData.Instance().WriteNumber(mAddress, 1, value);
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ID"));
			}
		}

		public bool Equipment
		{
			get
			{
				return SaveData.Instance().ReadNumber(mAddress + 1, 1) == 1;
			}
			set
			{
				SaveData.Instance().WriteNumber(mAddress, 1, value == true ? 1U : 0);
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Equipment"));
			}
		}
	}
}
