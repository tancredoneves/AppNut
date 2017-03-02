using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace AppNut
{
	public partial class AppNutPage : ContentPage
	{
		public List<Refeicao> refeicoes;

		public AppNutPage()
		{
			refeicoes = new List<Refeicao>();
			InitializeComponent();
		}

		public void AtulalizarContador(object sender, EventArgs e) 
		{
			double valor = stpCalorias.Value;
			lblCalorias.Text = valor.ToString();
		}

		public void SalvaRefeicao(object sender, EventArgs e)
		{
			string descricao = entDescricao.Text;
			double valor = stpCalorias.Value;
			string tituloCaixa = "Salva Refeicao";
			string msg = "ref" + descricao + " de " + valor;
			string txtbotao = "ok";
			Clear();

			Refeicao refeicao = new Refeicao(descricao, valor);
			refeicoes.Add(refeicao);
			DisplayAlert(tituloCaixa, msg, txtbotao);
		}

		public void Clear() 
		{
			entDescricao.Text = "";
			stpCalorias.Value = 10;
		}

		public void MostraLista(object sender, EventArgs e) 
		{
			ListaRefeicoes tela = new ListaRefeicoes();
			Navigation.PushAsync(tela);
		}

	}
}
