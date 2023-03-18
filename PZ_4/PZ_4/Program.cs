using System;
// Узел дерева
public class NOD                                 
{
    public int value;
    public NOD left;
    public NOD right;

    public NOD(int val)
    {
        value = val;
        left = null;
        right = null;
    }
}
// Дерево поиска
public class BinaryTree       
{
    public NOD root;

    public BinaryTree()
    {
        root = null;
    }

    public void Insert(int val)
    // Заполнение дерева 
    {
        NOD newNode = new NOD(val);

        if (root == null)                       
        {
            root = newNode;
            return;
        }

        NOD current = root;

        while (true)
        {
            if (val < current.value)                
            {
                if (current.left == null)            
                {
                    current.left = newNode;
                    break;
                }
                else                               
                {
                    current = current.left;
                }
            }
            else                                    
            {
                if (current.right == null)        
                {
                    current.right = newNode;
                    break;
                }
                else                           
                {
                    current = current.right;
                }
            }
        }
    }
    // Массив отрицательных значений 
    public int[] array = new int[1000];
    int index = 0;

    public int[] array2 = new int[1000];
    int index2 = 0;
    // Складывание полей дерева
    public int Sum(NOD node)
    {
        if (node == null)
        {
            return 0;
        }
        if (node.value < 0)
        {
            array[index] = node.value;
            index++;
        }
        array2[index2] = node.value;
        index2++;
        return node.value + Sum(node.left) + Sum(node.right);
    }
    // Подсчёт узлов
    public int CountInternalNodes(NOD node)
    {
        if (node == null || (node.left == null && node.right == null))
        {
            return 0;
        }

        return 1 + CountInternalNodes(node.left) + CountInternalNodes(node.right);
    }
}

public class Program
{
    public static void Main()
    {
        Random rnd = new Random();
        BinaryTree tree = new BinaryTree();

        for (int i = 10; i <= 100; i++)
        {
            tree.Insert(rnd.Next(-100, 100));
        }
        int sum = tree.Sum(tree.root);
        Console.Write("EX ONE: ");
        Console.WriteLine("Всего: " + sum);
        Console.WriteLine(" ");


        int internalNodesCount = tree.CountInternalNodes(tree.root);
        Console.Write("EX TWO: ");
        Console.WriteLine("Количество узлов: " + internalNodesCount);
        Console.WriteLine(" ");

 
        int minusValue = 0;
        Console.Write("EX FREE: ");
        Console.WriteLine("Отрицательные: ");
        for (int i = 0; i <= tree.array.Length; i++)
        {
            if (tree.array[i] == 0) break;
            minusValue++;
            Console.Write(tree.array[i] + " ");
        }
        Console.WriteLine(" ");
        Console.WriteLine("Отрицательные: " + minusValue);
        Console.WriteLine(" ");


        Console.WriteLine("EX FOUR: ");
        BinaryTree tree1 = new BinaryTree();
        BinaryTree tree2 = new BinaryTree();
        int[] arrayValueRavny = new int[1000];
        int indexArrayValueRavny = 0;
        int index = 0;

        int countValue = 0;
        for (int i = 0; i <= 30; i++)
        {
            tree1.Insert(rnd.Next(-20, 20));
        }
        for (int i = 0; i <= 30; i++)
        {
            tree2.Insert(rnd.Next(-20, 20));
        }
        int sum1 = tree1.Sum(tree1.root);
        int sum2 = tree2.Sum(tree2.root);
        for (int i = 0; i <= 30; i++)
        {
            index++;
            Console.WriteLine(tree1.array2[index]);
            Console.WriteLine(tree2.array2[index]);
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("ARMENIA-ARMENIA-ARMENIA-ARMENIA-ARMENIA-ARMENIA-ARMENIA-ARMENIA-ARMENIA-ARMENIA-ARMENIA-ARMENIA-ARMENIA-ARMENIA-ARMENIA-");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
            if (tree1.array2[index] == tree2.array2[index])
            {
                arrayValueRavny[indexArrayValueRavny] = tree1.array2[index];
                indexArrayValueRavny++;
            }
        }
        Console.WriteLine("Вот узлы");
        indexArrayValueRavny = 0;
        for (int i = 0; i <= 30; i++)
        {
            if (arrayValueRavny[indexArrayValueRavny] != 0)
            {
                countValue++;
                Console.WriteLine(arrayValueRavny[indexArrayValueRavny]);
            }
            indexArrayValueRavny++;
        }
        Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine("ARMENIA-ARMENIA-ARMENIA-ARMENIA-ARMENIA-ARMENIA-ARMENIA-ARMENIA-ARMENIA-ARMENIA-ARMENIA-ARMENIA-ARMENIA-ARMENIA-ARMENIA-");
        Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine("Нужные узлвы в 1 и 2: " + countValue);
    }
}