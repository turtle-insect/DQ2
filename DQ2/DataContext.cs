using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace DQ2
{
	class DataContext
	{
		public ObservableCollection<Charactor> Party { get; set; } = new ObservableCollection<Charactor>();
		public ObservableCollection<Place> Places { get; set; } = new ObservableCollection<Place>();

		public DataContext()
		{
			SaveData saveData = SaveData.Instance();
			uint address = 0x0010;
			for (uint i = 0; i < Util.MaxParty; i++)
			{
				if (saveData.ReadNumber(address, 2) == 0) break;
				Party.Add(new Charactor(address));
				address += 0x3C;
			}

			foreach (var place in Info.Instance().Places)
			{
				Places.Add(new Place(place.Value) { Name = place.Name });
			}
		}

		public uint Gold
		{
			get
			{
				return SaveData.Instance().ReadNumber(0xC4, 4);
			}

			set
			{
				Util.WriteNumber(0xC4, 4, value, 0, 99999999);
			}
		}

		public bool Ship
		{
			get
			{
				return SaveData.Instance().ReadNumber(0x11F, 1) == 1;
			}

			set
			{
				SaveData.Instance().WriteNumber(0x11F, 1, value ? 1U : 0);
			}
		}
	}
}
