using System;

using Xamarin.Forms;

namespace AppNut
{
	public class HomeTab : TabbedPage
	{
		public HomeTab()
		{
			this.Children.Add(new AppNutPage());
			this.Children.Add(new ListaRefeicoes());
		}
	}
}

