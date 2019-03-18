using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace barApp.ViewModels
{
	class MenuTabViewModel
		:Screen
	{
		public string NameDrink1
		{
			get
			{
				return Models.BarMenu.barMenuCard.GetDrinkName(1);
            }
		}

		public string FirstIngredientDrink1
		{
			get
			{
				return Models.BarMenu.barMenuCard.GetDrinkIngredient(1,1);
			}
		}

		public string SecondIngredientDrink1
		{
			get
			{
				return Models.BarMenu.barMenuCard.GetDrinkIngredient(1, 2);
			}
		}

		public string NameDrink2
		{
			get
			{
				return Models.BarMenu.barMenuCard.GetDrinkName(2);
			}
		}

		public string FirstIngredientDrink2
		{
			get
			{
				return Models.BarMenu.barMenuCard.GetDrinkIngredient(2, 1);
			}
		}

		public string SecondIngredientDrink2
		{
			get
			{
				return Models.BarMenu.barMenuCard.GetDrinkIngredient(2, 2);
			}
		}

		public string NameDrink3
		{
			get
			{
				return Models.BarMenu.barMenuCard.GetDrinkName(3);
			}
		}

		public string FirstIngredientDrink3
		{
			get
			{
				return Models.BarMenu.barMenuCard.GetDrinkIngredient(3, 1);
			}
		}

		public string SecondIngredientDrink3
		{
			get
			{
				return Models.BarMenu.barMenuCard.GetDrinkIngredient(3, 2);
			}
		}

		public string NameDrink4
		{
			get
			{
				return Models.BarMenu.barMenuCard.GetDrinkName(4);
			}
		}

		public string FirstIngredientDrink4
		{
			get
			{
				return Models.BarMenu.barMenuCard.GetDrinkIngredient(4, 1);
			}
		}

		public string SecondIngredientDrink4
		{
			get
			{
				return Models.BarMenu.barMenuCard.GetDrinkIngredient(4, 2);
			}
		}

		public string NameDrink5
		{
			get
			{
				return Models.BarMenu.barMenuCard.GetDrinkName(5);
			}
		}

		public string FirstIngredientDrink5
		{
			get
			{
				return Models.BarMenu.barMenuCard.GetDrinkIngredient(5, 1);
			}
		}

		public string SecondIngredientDrink5
		{
			get
			{
				return Models.BarMenu.barMenuCard.GetDrinkIngredient(5, 2);
			}
		}
	}
}
