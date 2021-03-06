﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Com.Com
{
    /// <summary>
    /// 工具类
    /// </summary>
    public class Utils
    {

        #region ListNode
        /// <summary>
        /// 创建链表
        /// </summary>
        /// <param name="numberlist"></param>
        /// <returns></returns>
        public static ListNode CreateListNode(List<int> numberlist)
        {
            ListNode node = null;
            node = CreateListNode(node, numberlist, 0);
            return node;
        }

        private static ListNode CreateListNode(ListNode node, List<int> numberlist, int index)
        {
            if (index >= numberlist.Count)
            {
                return null;
            }

            node = new ListNode(numberlist[index]);
            node.next = CreateListNode(node.next, numberlist, index + 1);

            return node;
        }

        /// <summary>
        /// 获取链表指定位置节点
        /// </summary>
        /// <param name="node"></param>
        /// <param name="pos"></param>
        /// <returns></returns>
        public static ListNode GetNode(ListNode head, int pos)
        {
            ListNode node = head;

            int i = 0;
            while (i < pos)
            {
                if (node == null || node.next == null)
                {
                    break;
                }
                node = node.next;
                i++;
            }
            if (i != pos)
            {
                return null;
            }

            return node;
        }
        #endregion

        #region TreeNode
        /// <summary>
        /// 根据前序遍历数组创建二叉树
        /// [1,2,2,3,4,4,3]
        /// [1,2,2,null,3,null,3]
        /// </summary>
        /// <param name="numberlist"></param>
        /// <returns></returns>
        public static TreeNode CreateTreeNode(List<string> numberlist)
        {
            TreeNode root = null;
            root = CreateTreeNode(root, numberlist, 0);
            return root;
        }

        private static TreeNode CreateTreeNode(TreeNode node, List<string> numberlist, int index)
        {
            if (index >= numberlist.Count)
            {
                return null;
            }

            if (numberlist[index].Equals("null", StringComparison.InvariantCultureIgnoreCase))
            {
                node = null;
                return null;
            }

            node = new TreeNode(int.Parse(numberlist[index]));
            node.left = CreateTreeNode(node.left, numberlist, 2 * index + 1);
            node.right = CreateTreeNode(node.right, numberlist, 2 * index + 2);

            return node;
        }

        public static TreeNode CreateTreeNode(List<int> numberlist)
        {
            TreeNode root = null;
            root = CreateTreeNode(root, numberlist, 0);
            return root;
        }

        private static TreeNode CreateTreeNode(TreeNode node, List<int> numberlist, int index)
        {
            if (index >= numberlist.Count)
            {
                return null;
            }

            node = new TreeNode(numberlist[index]);
            node.left = CreateTreeNode(node.left, numberlist, 2 * index + 1);
            node.right = CreateTreeNode(node.right, numberlist, 2 * index + 2);

            return node;
        }
        #endregion

        /// <summary>
        /// 控制台打印IList<IList<T>>类型
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        public static void ConsoleWriteLine<T>(IList<IList<T>> list)
        {
            if (list == null)
            {
                Console.WriteLine("");
                return;
            }

            foreach (var sublist in list)
            {
                Console.WriteLine(string.Join<T>(",", sublist));
            }
        }
    }
}
