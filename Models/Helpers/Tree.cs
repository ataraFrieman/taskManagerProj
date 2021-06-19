using System;


namespace MODELS.Helpers
{
    public class Tree<T> where T : IComparable
    {

        public TreeNode<T> Root { get; set; }

        public Tree(TreeNode<T> root)
        {
            this.Root = root;
        }

        public void AddTreeNode(TreeNode<T> newNode, TreeNode<T> parentNode)
        {
            parentNode.AddChild(newNode);
        }




    }
}
