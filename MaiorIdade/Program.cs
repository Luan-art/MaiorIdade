// See https://aka.ms/new-console-template for more information
int idade;

Console.WriteLine("Digita sua idade");

idade = int.Parse(Console.ReadLine());

if(idade < 0)
{

    Console.WriteLine("Invalido");

} else if (idade >= 18)
{
    Console.WriteLine("Maior de idade");

}
else
{
    Console.WriteLine("Menor de idade");
    Console.WriteLine();
}