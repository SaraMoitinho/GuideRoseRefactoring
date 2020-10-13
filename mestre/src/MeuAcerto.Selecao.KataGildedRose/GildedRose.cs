using System.Collections.Generic;

namespace MeuAcerto.Selecao.KataGildedRose
{
  class GildedRose
  {
    public IList<Item> Itens;
    public GildedRose(IList<Item> Itens)
    {
      this.Itens = Itens;
    }

    public void AtualizarQualidade()
    {
      for (var i = 0; i < Itens.Count; i++)
        Itens[i].AtualizaQualidadeItens();
    }
  }
}
