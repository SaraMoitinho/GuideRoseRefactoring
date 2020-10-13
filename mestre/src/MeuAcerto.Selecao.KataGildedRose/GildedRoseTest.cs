using ApprovalTests.Combinations;
using ApprovalTests.Reporters;
using System;
using System.Collections.Generic;
using Xunit;

namespace MeuAcerto.Selecao.KataGildedRose
{
  [UseReporter(typeof(DiffReporter))]
  public class GildedRoseTest
  {
    [Fact]
    public void DadoQueAtualizaQualidade()
    {
     
      CombinationApprovals.VerifyAllCombinations(AtualizarQualidade,
        new String[] {"foo", "Queijo Brie Envelhecido", "Ingressos para o concerto do Turisas", "Dente do Tarrasque", "Bolo de Mana Conjurado" },
        new int[] {-1, 0, 2, 6, 11},
        new int[] {0, 1, 49, 50});
    }

    private static string AtualizarQualidade(string nomeItem, int valorVenda, int valorQualidade)
    {
      List<Item> itens = new List<Item>
        {

        new Item(nomeItem,valorVenda, valorQualidade).CriarItem()
      };

      GildedRose app = new GildedRose(itens);
      app.AtualizarQualidade();
      return app.Itens[0].ObterPropriedades();
    }
  }
}
