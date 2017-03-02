using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace AppNut
{
	public partial class ListaRefeicoes : ContentPage
	{
		public List<Refeicao> refeicoes;


		public ListaRefeicoes()
		{
			refeicoes = new List<Refeicao>();
			InitializeComponent();
		}
	}
}
