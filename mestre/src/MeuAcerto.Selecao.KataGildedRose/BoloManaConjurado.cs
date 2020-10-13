using System;
using System.Collections.Generic;
using System.Text;

namespace MeuAcerto.Selecao.KataGildedRose
{
  public class BoloManaConjurado : Item
  {
    public BoloManaConjurado(int prazoParaVenda, int qualidade)
      : base("Bolo de Mana Conjurado", prazoParaVenda, qualidade)
    {
    }
    public override void AtualizaQualidadeItens()
    {
      if (Qualidade > 2)
        Qualidade = Qualidade - 2;
      else Qualidade = 0;

      PrazoParaVenda = PrazoParaVenda - 1;

      if (PrazoParaVenda < 1)
        Qualidade = 0;

    }
  }
}
