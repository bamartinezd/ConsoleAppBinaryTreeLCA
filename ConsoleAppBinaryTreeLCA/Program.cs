// See https://aka.ms/new-console-template for more information
using ConsoleAppBinaryTreeLCA;
using Newtonsoft.Json;

public class Program
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Hello, World!");

        var bTree = new Node
        {
            Id = 67,
            Child1 = new Node
            {
                Id = 39,
                Child1 = new Node
                {
                    Id = 28,
                    Child1 = new Node
                    {
                        Id = 29
                    }
                },
                Child2 = new Node
                {
                    Id = 44
                }
            },
            Child2 = new Node
            {
                Id = 76,
                Child1 = new Node
                {
                    Id = 74
                },
                Child2 = new Node
                {
                    Id = 85,
                    Child1 = new Node
                    {
                        Id = 83
                    },
                    Child2 = new Node
                    {
                        Id = 87
                    }
                }
            }
        };

        Console.WriteLine(JsonConvert.SerializeObject(bTree, Formatting.Indented));
    }

    private Node LowestCommonAncestor(Node tree, int NodeLeft, int NodeRight){
        //LowestCommonAncestor(tree, 83, 87) = 85

        
        return new Node();
    }
}


