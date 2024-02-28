namespace ATV2_CJ3021963
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float salario;

           //leitura salario
           Console.WriteLine("Digite seu salário");
            salario = float.Parse(Console.ReadLine());

            salario = salario + (25.0f / 100.0f) * salario;

            Console.WriteLine("O novo salário será de R$ {0}", salario);




        }
    }
}
