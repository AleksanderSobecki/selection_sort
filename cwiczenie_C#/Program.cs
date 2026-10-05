using cwiczenie_C_;

sort_wybor sortowanie = new sort_wybor();

Console.Write("Ile liczb wprowadzisz: ");
var ileLiczb = int.Parse(Console.ReadLine());
sortowanie.Numbers = new int[ileLiczb];

for  (int i = 0; i < ileLiczb; i++)
{
    Console.Write($"Wprowadź liczbę {i + 1}: ");
    sortowanie.Numbers[i] = int.Parse(Console.ReadLine());
}
Console.Clear();
Console.WriteLine("Tablica przed sortowaniem: ");
sortowanie.WypiszTablice();
Console.WriteLine("\nTablica po posortowaniu: ");
sortowanie.SortujMalejaco();
sortowanie.WypiszTablice();

//Console.WriteLine($"Pozycja max: {sortowanie.ZnajdzMax()}");