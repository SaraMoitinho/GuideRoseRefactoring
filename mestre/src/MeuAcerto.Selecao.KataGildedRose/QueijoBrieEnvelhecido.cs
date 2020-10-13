
namespace MeuAcerto.Selecao.KataGildedRose
{
  public class QueijoBrieEnvelhecido : Item
  {
    public QueijoBrieEnvelhecido(int prazoParaVenda, int qualidade)
      : base("Queijo Brie Envelhecido", prazoParaVenda, qualidade)
    {
    }
    public override void AtualizaQualidadeItens()
    {
      if (Qualidade < 50)
        Qualidade = Qualidade + 1;

      PrazoParaVenda = PrazoParaVenda - 1;

      if (PrazoParaVenda < 0)
      {
        if (Qualidade < 50)
          Qualidade = Qualidade + 1;
      }
    }
  }
}

