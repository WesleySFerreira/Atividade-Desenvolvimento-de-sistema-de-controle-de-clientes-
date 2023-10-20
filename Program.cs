using System;
namespace Atividade
{
    class Program 
    {
        static void Main(string[] args)
        {
            float val_pag;
            Console.WriteLine("Informe o nome:");
            string var_nome = Console.ReadLine();
            Console.WriteLine("Informe endereço:");
            string var_endereco = Console.ReadLine();
            Console.WriteLine("Pessoa Física (f) ou Pessoa Jurídica (j) ?");
            string var_tipo = Console.ReadLine();

            if(var_tipo == "f")
            {
                // --- Pessoa Física ---
                Pessoa_Fisica pf = new Pessoa_Fisica();
                pf.Nome = var_nome;
                pf.Endereco = var_endereco;
                Console.WriteLine("Informe CPF:");
                pf.Cpf = Console.ReadLine();
                Console.WriteLine("Informe RG:");
                pf.Rg = Console.ReadLine();
                Console.WriteLine("Informe valor de compra:");
                val_pag = float.Parse(Console.ReadLine());
                pf.Pagar_Imposto(val_pag);
                Console.WriteLine("-------- Pessoa Física --------");
                Console.WriteLine("Nome ............: " + pf.Nome);
                Console.WriteLine("Endereço ........: " + pf.Endereco);
                Console.WriteLine("CPF .............: " + pf.Cpf);
                Console.WriteLine("RG ..............: " + pf.Rg);
                Console.WriteLine("Valor da compra .: " + pf.Valor.ToString("C"));
                Console.WriteLine("Imposto .........: " + pf.Valor_imposto.ToString("C"));
                Console.WriteLine("Total a pagar ...: " + pf.Total.ToString("C"));                
            }
            if(var_tipo == "j")
            {
                // Pessoa Jurídica
                Pessoa_Juridica pj = new Pessoa_Juridica();
                pj.Nome = var_nome;
                pj.Endereco = var_endereco;
                Console.WriteLine("Informe CNPJ:");
                pj.Cnpj = Console.ReadLine();
                Console.WriteLine("Informe IE:");
                pj.Ie = Console.ReadLine();
                Console.WriteLine("Informe valor de compra:");
                val_pag = float.Parse(Console.ReadLine());
                pj.Pagar_Imposto(val_pag);
                Console.WriteLine("-------- Pessoa Jurídica --------");
                Console.WriteLine("Nome ............: " + pj.Nome);
                Console.WriteLine("Endereço ........: " + pj.Endereco);
                Console.WriteLine("CNPJ.............: " + pj.Cnpj);
                Console.WriteLine("IE ..............: " + pj.Ie);
                Console.WriteLine("Valor da compra .: " + pj.Valor.ToString("C"));
                Console.WriteLine("Imposto .........: " + pj.Valor_imposto.ToString("C"));
                Console.WriteLine("Total a pagar ...: " + pj.Total.ToString("C"));

            }
        }
    }
}