
namespace MeuAcerto.Selecao.KataGildedRose
{
  public class IngressoConcertoTurisas : Item
  {
    public IngressoConcertoTurisas(int prazoParaVenda, int qualidade)
      : base("Ingressos para o concerto do Turisas", prazoParaVenda, qualidade)
    {
    }

    public override void AtualizaQualidadeItens()
    {
      if (Qualidade < 50)
      {
        Qualidade = Qualidade + 1;

        if (PrazoParaVenda < 11)
        {
          if (Qualidade < 50)
          {
            Qualidade = Qualidade + 1;
          }
        }

        if (PrazoParaVenda < 6)
        {
          if (Qualidade < 50)
          {
            Qualidade = Qualidade + 1;
          }
        }
      }

      PrazoParaVenda = PrazoParaVenda - 1;

      if (PrazoParaVenda < 0)
        Qualidade = 0;
    }
  }
}
