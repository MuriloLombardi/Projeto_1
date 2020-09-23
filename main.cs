using System;

class MainClass {
  public static void Main (string[] args) {
    
    string cliente;
    Hamburguer lanche = new Hamburguer(); 
    int aux = 0;

    Console.WriteLine("Digite seu nome: ");
    cliente = Console.ReadLine();
    


    Console.WriteLine ("Digite o codigo do pão desejado: \n| 1-Tradicional          | 2-Frances | 3-Australiano |\n------------------------------------------------------\n| 4-Tradicional+Gergelim | 5-Tapioca |");
    aux = Convert.ToInt32(Console.ReadLine());
    lanche.escolhePao(aux);
    Console.WriteLine ("Digite o codigo da carne desejada: \n| 1-Tradicional 150g | 2-Picanha 150g | 3-Frango 150g |4-Tradicional Smash 100g |");                                                aux = Convert.ToInt32(Console.ReadLine());
    lanche.escolheCarne(aux);
    



  }
}