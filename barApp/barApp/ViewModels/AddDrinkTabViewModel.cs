using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace barApp.ViewModels
{
	public class AddDrinkTabViewModel : PropertyChangedBase
	{
		private string _name = "";
		private string _ingredient1 = "";
		private string _ingredient2 = "";

		public string Name
		{
			get
			{
				return _name;
			}
			set
			{
				_name = value;
				NotifyOfPropertyChange(() => Name);
			}
		}

		public string FirstIngredient
		{
			get
			{
				return _ingredient1;
			}
			set
			{
				_ingredient1 = value;
				NotifyOfPropertyChange(() => FirstIngredient);
			}
		}

		public string SecondIngredient
		{
			get
			{
				return _ingredient2;
			}
			set
			{
				_ingredient2 = value;
				NotifyOfPropertyChange(() => SecondIngredient);
			}
		}


		public void AddDrink()
		{
			Models.BarMenu.barMenuCard.AddDrink(_name, _ingredient1, _ingredient2);
		}
	}
}