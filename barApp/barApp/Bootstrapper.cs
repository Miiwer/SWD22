using barApp.ViewModels;
using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace barApp
{
	public class Bootstrapper
		:BootstrapperBase		//arver fra bootstrapper frameworket
	{
		public Bootstrapper()
		{
			Initialize();
		}

		// overwriter startup-funktionen vi lige fjernede i App.xaml
		protected override void OnStartup(object sender, StartupEventArgs e)
		{
			DisplayRootViewFor<ShellViewModel>();   // linker startup vindue til et objekt (shellViewModel) vi selv definere
		}
	}
}
