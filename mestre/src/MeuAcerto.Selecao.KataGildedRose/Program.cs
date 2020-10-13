using System;
using System.Collections.Generic;

namespace MeuAcerto.Selecao.KataGildedRose
{
  class Program
  {
    public static void Main(string[] args)
    {
      Item[] itens = new Item[] {
        new Item ("Corselete +5 DEX", 10, 20),
        new Item ("Queijo Brie Envelhecido", 2, 0),
        new Item ("Elixir do Mangusto", 5, 7),
        new Item ("Dente do Tarrasque", 0, 80),
        new Item ("Dente do Tarrasque", -1, 80),
        new Item ("Ingressos para o concerto do Turisas", 15, 20),
        new Item ( "Ingressos para o concerto do Turisas", 10, 49),
        new Item ( "Ingressos para o concerto do Turisas", 5,  49),
			  new Item ("Bolo de Mana Conjurado", 3, 6) 
      };

      var app = new GildedRose(itens);


      for (var i = 0; i < 31; i++)
      {
        Console.WriteLine("-------- dia " + i + " --------");
        Console.WriteLine("Nome, PrazoParaVenda, Qualidade");
        for (var j = 0; j < itens.Length; j++)
        {
          Console.WriteLine(itens[j].Nome + ", " + itens[j].PrazoParaVenda + ", " + itens[j].Qualidade);
        }
        Console.WriteLine("");
        app.AtualizarQualidade();
      }
    }

  }
}
