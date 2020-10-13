namespace MeuAcerto.Selecao.KataGildedRose
{
  public class Item
  {
    public string Nome { get; set; }

    public int PrazoParaVenda { get; set; }

    public int Qualidade { get; set; }

    public Item(string nome, int prazoParaVenda, int qualidade)
    {
      Nome = nome;
      PrazoParaVenda = prazoParaVenda;
      Qualidade = qualidade;
    }

    public Item CriarItem()
    {
      switch (Nome)
      {
        case "Queijo Brie Envelhecido":
          return new QueijoBrieEnvelhecido(PrazoParaVenda, Qualidade);

        case "Ingressos para o concerto do Turisas":
          return new IngressoConcertoTurisas(PrazoParaVenda, Qualidade);

        case "Dente do Tarrasque":
          return new DenteTarrasque(PrazoParaVenda, Qualidade);

        case "Bolo de Mana Conjurado":
          return new BoloManaConjurado(PrazoParaVenda, Qualidade);

        default:
          return new Item(Nome, PrazoParaVenda, Qualidade);
      }
    }

    public string ObterPropriedades() =>
      $"{Nome}, {PrazoParaVenda}, {Qualidade}";

    public virtual void AtualizaQualidadeItens()
    {

      if (Qualidade > 0)
        Qualidade = Qualidade - 1;

      PrazoParaVenda = PrazoParaVenda - 1;

      if (PrazoParaVenda < 0)
        if (Qualidade > 0)
          Qualidade = Qualidade - 1;

    }
  }
}
