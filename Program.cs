using Refit;
using SysCepConsole.IRefit;

Console.WriteLine("Digite o CEP que deseja buscar:");
var cep = Console.ReadLine();

var servico = RestService.For<IRefit>("https://viacep.com.br");
var retorno = await servico.ConsultaCep(cep);

    if(retorno is null)  
    {
    Console.WriteLine("CEP não encontrado!");
    } else
    {
    Console.WriteLine($"Logradouro: {retorno.Logradouro}");
    Console.WriteLine($"Bairro: {retorno.Bairro}");
    Console.WriteLine($"Cidade: {retorno.Localidade}");
    Console.WriteLine($"Estado: {retorno.UF}");
    }



