using System;

public class Node
{
    public int Value { get; set; }

    public Node Left { get; set; }

    public Node Right { get; set; }

    public Node(int value, Node left, Node right)
    {
        Value = value;
        Left = left;
        Right = right;
    }
}

public class BinarySearchTree
{
    public static bool Contains(Node root, int value)
    {
        /*if (root == null)
        {
            //root = new Node();
            root.Value = value;
        }
        else if (value < root.Value)
        {
            root.Left = Contains(root.Left, value);
        }
        else
        {
            root.Right = Contains(root.Right, value);
        }

        return root;*/

        //if (root.Left == null && root.Right == null)
        // return true;

        if (root.Left == null)
        {
            // Checking root.Right.Value
            if (root.Value <= root.Right.Value)
                return true;

            else
                return false;
        }
        else if (root.Right == null)
        {
            // Checking root.Left.Value
            if (root.Value > root.Left.Value)
                return true;
            else
                return false;
        }
        else
        {
            // Checking both Values
            if (root.Value > root.Left.Value && root.Value <= root.Right.Value)
                return true;
            else
                return false;

            throw new NotImplementedException("Waiting to be implemented.");
        }
    }

    public static void Main(string[] args)
    {
        Node n1 = new Node(1, null, null);
        Node n3 = new Node(3, null, null);
        Node n2 = new Node(2, n1, n3);

        Console.WriteLine(Contains(n2, 3));
    }
}
