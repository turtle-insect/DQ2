using System;
using System.ComponentModel;

namespace DQ2
{
	class Place : INotifyPropertyChanged
	{
		private readonly uint mAddress;
		public Place(uint address)
		{
			mAddress = address;
		}

		public String Name { get; set; }

		public bool Visite
		{
			get
			{
				return SaveData.Instance().ReadNumber(mAddress, 1) == 1;
			}

			set
			{
				SaveData.Instance().WriteNumber(mAddress, 1, value ? 1U : 0);
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Visite)));
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;
	}
}
