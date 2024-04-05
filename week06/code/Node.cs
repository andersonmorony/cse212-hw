public class Node {
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data) {
        this.Data = data;
    }

    public void Insert(int value) {
        var isDuplicate = Contains(value);

        if (!isDuplicate)
        {
            if (value < Data) {
                // Insert to the left
                if (Left is null)
                    Left = new Node(value);
                else
                    Left.Insert(value);
                }
            else {
                // Insert to the right
                if (Right is null)
                    Right = new Node(value);
                else
                    Right.Insert(value);
            }
        }
    }

    public bool Contains(int value) {
        // TODO Start Problem 2
        if(value == Data)
        {
            return true;
        }
        else if (value < Data)
        {
            if (Left is null)
                return false;
            else if(value == Left.Data)
                return true;
            else
                return Left.Contains(value);
        }
        else if(value > Data)
        {
            if (Right is null)
                return false;
            else if (value == Right.Data)
                return true;
            else
                return Right.Contains(value);
        }

        return false;
    }

    public int GetHeight(Node? node) {
        // TODO Start Problem 4
        if(node is not null)
            return 1 + GetHeight(node.Right); // Replace this line with the correct return statement(s)
        return 0;
    }
}