// See https://aka.ms/new-console-template for more information
using ConsoleAppBinaryTreeLCA;

Console.WriteLine("Hello, World!");

var bTree = new Node {
    Id = 67,
    Child1 = new Node {
        Id=39,
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
    Child2 = new Node {
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


