using System;
using System.Collections.Generic;
using System.Text;

namespace MODELS.Helpers
{
    public class TreeNode<T> : IComparable where T : IComparable
    {
        public TreeNode<T> ParentTreeNode { get; set; }
        public List<TreeNode<T>> ChildrenTreeNode { get; set; }
        public T Content { get; set; }
        public int Id { get; set; }

        public TreeNode(T content, int id)
        {
            this.Content = content;
            this.Id = id;
            ChildrenTreeNode = new List<TreeNode<T>>();

        }
        public void AddChild(TreeNode<T> child)
        {
            child.ParentTreeNode = this;
            ChildrenTreeNode.Add(child);
            ChildrenTreeNode.Sort();
        }

        public int CompareTo(object obj)
        {
            TreeNode<T> contentToCompare = obj as TreeNode<T>;
            if (contentToCompare == null)
                return 0;
            return this.Content.CompareTo(contentToCompare.Content);

        }
    }
}
