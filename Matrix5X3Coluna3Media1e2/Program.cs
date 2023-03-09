double[,] table = new double [5,3];

Popular();
Imprimir();

void Popular()
{
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine("Digite os valores para a posição separados por espaço:");
        string[] entradas = Console.ReadLine().Split(' ');

        table[i, 0] = double.Parse(entradas[0]);
        table[i, 1] = double.Parse(entradas[1]);
        table[i, 2] = (table[i, 0] + table[i, 1]) / 2.0;
    }
}
void Imprimir()
{
    for (int linha = 0; linha < 5; linha++)
    {
        for (int coluna = 0; coluna < 3; coluna++)
        {
            Console.Write("|    {0}     | ", table[linha, coluna].ToString("F1"));
        }
        Console.WriteLine();
    }
}