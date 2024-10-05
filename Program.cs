using ConsoleApp1;

public class Rodate
{ 
    static void Main()
    {
        Pessoa R = new Pessoa();
        R.setNome();
        R.setIdade();
        R.setTelefone();
        R.setEndereco();
        R.setEmail();

        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("---------------Costumer Data--------------");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Nome: " + R.getNome());
        Console.WriteLine("Idade: " + R.getIdade());
        Console.WriteLine("Telefone: " + R.getTelefone());
        Console.WriteLine("Endereço: " + R.getEndereco());
        Console.WriteLine("Email: " + R.getEmail());
        Console.WriteLine("------------------------------------------");

    }

}