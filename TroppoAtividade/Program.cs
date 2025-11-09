using TroppoAtividade.Entities;

double valorPago;
string varNome;
string varEndereco;
string tipoPessoa;

Console.Write("Informe o Nome: ");
varNome = Console.ReadLine();

Console.Write("Informe o Endereço: ");
varEndereco = Console.ReadLine();

Console.WriteLine("Para Pessoa Física, digite (F)");
Console.WriteLine("Para Pessoa Jurídica, digite (J)\n");
tipoPessoa = Console.ReadLine();

if ((tipoPessoa == "F") || (tipoPessoa == "f"))
{
    // PESSOA FÍSICA
    Console.WriteLine("\n******* PESSOA FÍSICA *******\n");
    PessoaFisica pessoaFisica = new PessoaFisica();
    pessoaFisica.Nome = varNome;
    pessoaFisica.Endereco = varEndereco;

    Console.Write("Informe o CPF: ");
    pessoaFisica.Cpf = Console.ReadLine();

    Console.Write("Informe o RG: ");
    pessoaFisica.Rg = Console.ReadLine();

    Console.Write("Informe o VALOR da COMPRA: ");
    valorPago = Convert.ToDouble(Console.ReadLine());

    pessoaFisica.PagarImposto(valorPago);

    Console.WriteLine($"\nNome ...........: {pessoaFisica.Nome}");
    Console.WriteLine($"Endereço .........: {pessoaFisica.Endereco}");
    Console.WriteLine($"CPF ..............: {pessoaFisica.Cpf}");
    Console.WriteLine($"RG ...............: {pessoaFisica.Rg}");
    Console.WriteLine($"Valor da Compra ..: {pessoaFisica.Valor.ToString("C")}");
    Console.WriteLine($"Imposto ..........: {pessoaFisica.ValorImposto.ToString("C")}");
    Console.WriteLine($"Total a Pagar ....: {pessoaFisica.Total.ToString("C")}");
}

else if ((tipoPessoa == "J") || (tipoPessoa == "j"))
{
    // PESSOA JURÍDICA
    Console.WriteLine("\n******* PESSOA JURÍDICA *******\n");
    PessoaJuridica pessoaJuridica = new PessoaJuridica();
    pessoaJuridica.Nome = varNome;
    pessoaJuridica.Endereco = varEndereco;

    Console.Write("Informe o CNPJ: ");
    pessoaJuridica.Cnpj = Console.ReadLine();

    Console.Write("Informe o IE: ");
    pessoaJuridica.Ie = Console.ReadLine();

    Console.Write("Informe o VALOR da COMPRA: ");
    valorPago = Convert.ToDouble(Console.ReadLine());

    pessoaJuridica.PagarImposto(valorPago);

    Console.WriteLine($"\nNome ...........: {pessoaJuridica.Nome}");
    Console.WriteLine($"Endereço .........: {pessoaJuridica.Endereco}");
    Console.WriteLine($"CPF ..............: {pessoaJuridica.Cnpj}");
    Console.WriteLine($"RG ...............: {pessoaJuridica.Ie}");
    Console.WriteLine($"Valor da Compra ..: {pessoaJuridica.Valor.ToString("C")}");
    Console.WriteLine($"Imposto ..........: {pessoaJuridica.ValorImposto.ToString("C")}");
    Console.WriteLine($"Total a Pagar ....: {pessoaJuridica.Total.ToString("C")}");
}

else
{
    Console.WriteLine("\nPor favor, insira o tipo de Pessoa corretamente!");
}
