
namespace ConsoleApp1
{ //ENCAPSULAMENTO
     public class Pessoa
    {
        private string nome;
        private int idade;
        private string telefone;
        private string endereco;
        private string email;

        public void setNome()
        {
            Console.Clear();
            Console.WriteLine("Escreva seu Nome");
            string addnome = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(addnome))
            {
                this.nome = addnome;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Nome Cadastrado com sucesso!");
                Console.ReadLine();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Nome Invalido, Tente Novamente!!!");
                Console.WriteLine("Tecle ENTER PARA TENTAR NOVAMENTE!!!");
                Console.ReadLine();
                setNome();
            }
            
        }
        public string getNome()
        {
            return this.nome;
        }
        public void setIdade()
        {
            Console.Clear();
            Console.WriteLine("Adicone uma Idade: ");
            string addIdade = Console.ReadLine();
            if (int.TryParse(addIdade,out int idade) && idade >= 17)
            {
                this.idade = idade;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Idade cadastrada com sucesso!!!");
                Console.ReadLine();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Idade Invalida, Tente Novamente");
                Console.WriteLine("Tecle ENTER PARA TENTAR NOVAMENTE!!!");
                Console.ReadLine();
                setIdade();
            }
        }
        public int getIdade()
        {
            return this.idade;
        }
        public void setTelefone()
        {
            Console.Clear();
            Console.WriteLine("Adicone seu Numero de Telefone: ");
            string addTelefone = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace (addTelefone))
            {
                this.telefone = addTelefone;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Seu telefone foi cadastrado com Sucesso!");
                Console.ReadLine();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Telefone invalido, tente Novamente!!!");
                Console.WriteLine("Tecle ENTER PARA TENTAR NOVAMENTE!!!");
                Console.ReadLine();
                setTelefone();
            }
        }
        public string getTelefone()
        {
            return this.telefone;
        }

        public void setEndereco()
        {
            Console.Clear();
            Console.WriteLine("Cadastre seu Endereço: ");
            string  addEndereco = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(addEndereco))
            {
                this.endereco = addEndereco;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Endereço cadastrado com sucesso!!!");
                Console.ReadLine();
                setEndereco();

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Endereço Invalido, Tente Novamente!!!");
                Console.WriteLine("Tecle ENTER PARA TENTAR NOVAMENTE!!!");
                Console.ReadLine();
                setEndereco();
            }
        }
        public string getEndereco()
        {           
            return this.endereco;
        }

        public void setEmail()
        {
            Console.Clear();
            Console.WriteLine("Cadastre seu Email: ");
            string addEmail = Console.ReadLine();
            if (! string.IsNullOrWhiteSpace(addEmail))
            {
                this.email = addEmail;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Email cadastrado com sucesso!!!");
                Console.ReadLine();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Email Invalido, Tente Novamente!!!");
                Console.WriteLine("Tecle ENTER PARA TENTAR NOVAMENTE!!!");
                Console.ReadLine();
                setEmail();
            }
        }
        public string getEmail()
        {
            return this.email;
        }


















     
        









    }  
    

          
}
