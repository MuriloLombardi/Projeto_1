using System;

class Hamburguer
{
  private string pao;
  private string carne;
  private int quantCarne;
  private string queijo;
  private string acompanhamentos;
  private string adicionais;

  public void escolhePao (int codPao) {
    switch (codPao){
      case 1: pao = "Tradicional";
      break;
      case 2: pao = "Frances";
      break;
      case 3: pao = "Australiano";
      break;
      case 4: pao = "Tradicional + Gergelim";
      break;
      case 5: pao = "Tapioca";
      break;
      default: Console.WriteLine("Opção invalida, tente novamente!");
      break;
    }
    

  }


}