using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace barApp.ViewModels
{
	class ShellViewModel
		:Conductor<object>
	{
		public void LoadMenu()
		{
			ActivateItem(new MenuTabViewModel());
		}


		public void LoadAddDrink()
		{
			ActivateItem(new AddDrinkTabViewModel());
		}
	}
}
