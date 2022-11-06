// See https://aka.ms/new-console-template for more information
using ConsoleAppBinaryTreeLCA;

public class Program
{
    public static void Main(String[] args)
    {
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
        //Console.Write(JsonConvert.SerializeObject(bTree, Formatting.Indented));
        LowestCommonAncestor(bTree, 83, 87); //85
    }

    private static void LowestCommonAncestor(Node node, int NodeLeft, int NodeRight){
        if (node.Id != NodeLeft)
        {
            Console.WriteLine($"This node: {node.Id}");
            if (node.Child1 is not null)
            {
                Console.WriteLine($"Child1: {node.Child1.Id}");
                LowestCommonAncestor(node.Child1, NodeLeft, NodeRight);
            }

            if (node.Child2 is not null)
            {
                Console.WriteLine($"Child2: {node.Child2.Id}");
                LowestCommonAncestor(node.Child2, NodeLeft, NodeRight);
            }
        }
    }
}


