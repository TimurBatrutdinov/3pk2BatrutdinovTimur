using PZ_3;

BynaryTree tree = new BynaryTree(6);
Console.Write("Братец, в среднем так: ");
BynaryTree.AverageArif(tree.Root);
Console.WriteLine("Ну больше 0, да: " + BynaryTree.CountPlus(tree.Root));
Console.WriteLine("Ну меньше 0, да: " + BynaryTree.CountMinus(tree.Root));

Console.Write("Какое число хочешь найти, Брат?: ");
int sverka = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Столько раз твой варик был, Ахперс: " + BynaryTree.Countsverka(tree.Root, sverka));