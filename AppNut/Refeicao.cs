using System;
namespace AppNut
{
	public class Refeicao
	{
		double valor;

		public string Descricao { get; set;}
		public double Calorias { get; set; }



		public Refeicao(string descricao, double calorias)
		{
			this.Descricao = descricao;
			this.Calorias = calorias;
		}
	}
}
