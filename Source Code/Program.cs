namespace SeliseDevTest
{
    public class TreeNode
    {
        public int key;
        public TreeNode left, right;

        public TreeNode(int key)
        {
            this.key = key;
            left = right = null;
        }
    }

    public class BinaryTree
    {
        public TreeNode root;

        public List<int> GetRightmostNodes(TreeNode root)
        {

            List<int> result = new List<int>();
            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);

            if(root == null)
                return result;
            int counter = 0;

            while (q.Count != 0)
            {
                int n = q.Count;
                for(int i=0; i<n; i++)
                {
                    TreeNode temp = q.Peek();
                    q.Dequeue();
                    if (i == 0 && n==1 && counter == 0)
                    {
                        counter = 1;
                        Console.Write(temp.key + " ");
                        result.Add(temp.key);
                    }
                    if (temp.left != null)
                        q.Enqueue(temp.left);


                    if (temp.right != null)
                    {
                        q.Enqueue(temp.right);
                        Console.Write(temp.right.key + " ");
                        result.Add(temp.right.key);
                    }
                }
            }

            return result;

        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            
            BinaryTree tree = new BinaryTree();

            //1
            //tree.root = new TreeNode(1);
            //tree.root.left = new TreeNode(2);
            //tree.root.right = new TreeNode(3);
            //tree.root.left.left = new TreeNode(4);
            //tree.root.right.left = new TreeNode(5);
            //tree.root.right.right = new TreeNode(6);
            //tree.root.right.left.right = new TreeNode(7);

            //2
            //tree.root = new TreeNode(1);

            //3
            tree.root = new TreeNode(1);
            tree.root.right = new TreeNode(2);
            tree.root.right.right = new TreeNode(3);
            tree.root.right.right.right = new TreeNode(4);

            //4 
            //tree.root = null;

            //5
            //tree.root = new TreeNode(1);
            //tree.root.left = new TreeNode(2);
            //tree.root.left.left = new TreeNode(3);
            //tree.root.left.left.left = new TreeNode(4);

            //6
            //tree.root = new TreeNode(1);
            //tree.root.left = new TreeNode(2);
            //tree.root.left.left = new TreeNode(4);
            //tree.root.left.right = new TreeNode(5);
            //tree.root.right = new TreeNode(3);
            //tree.root.right.right = new TreeNode(7);

            //7
            //tree.root = new TreeNode(1);
            //tree.root.left = new TreeNode(2);
            //tree.root.left.right = new TreeNode(4);
            //tree.root.right = new TreeNode(3);


            var result = tree.GetRightmostNodes(tree.root);

            int[] res = result.ToArray();
            
        }
    }
}