using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogarithmicAxisCustomization_MAUI_CartesianChart
{
	public class ViewModel
	{
		public List<Model> Data { get; set; }

		public ViewModel()
		{
			Data = new List<Model>()
			{
				new Model(){Year= "1995", Profit = 80},
				new Model(){Year= "1996", Profit = 200},
				new Model(){Year= "1997", Profit = 400},
				new Model(){Year= "1998", Profit = 600},
				new Model(){Year= "1999", Profit = 700},
				new Model(){Year= "2000", Profit = 1400},
				new Model(){Year= "2001", Profit = 2000},
				new Model(){Year= "2002", Profit = 4000},
				new Model(){Year= "2003", Profit = 6000},
				new Model(){Year= "2004", Profit = 8000},
				new Model(){Year= "2005", Profit = 11000},
			};

		}
	}
}
