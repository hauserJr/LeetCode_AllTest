using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class LeetCode_All_Solution
{
    #region 1.RunTime(142 ms) Beats 55.74% in LeetCode ,Level：Easy
    public bool JudgeCircle(string moves)
    {
        int[] Ordinate = new int[] { 0, 0 };
        foreach (var item in moves)
        {
            if (item.Equals('U'))
            {
                Ordinate[1] = Ordinate[1] + 1;
            }
            else if (item.Equals('D'))
            {
                Ordinate[1] = Ordinate[1] - 1;
            }
            else if (item.Equals('L'))
            {
                Ordinate[0] = Ordinate[0] - 1;
            }
            else
            {
                Ordinate[0] = Ordinate[0] + 1;
            }
        }
        bool OriPath = Ordinate[0] + Ordinate[1] == 0 ? true : false;
        return OriPath;
    }
    #endregion

    #region 2.RunTime(59 ms) Beats 73.77%  in LeetCode ,Level：Easy
    public int HammingDistance(int x, int y)
    {
        int XOR_Value = x ^ y;
        int AND_Value = 1;
        int result = 0;
        while (XOR_Value != 0)
        {
            if ((AND_Value & XOR_Value) == 1)
            {
                result++;
            }
            XOR_Value = XOR_Value >> 1;
        }
        return result;
    }
    #endregion

    #region 3.RunTime(2962 ms) Beats 73.64% in LeetCode , Level：Easy
    public string BigCountries()
    {
        string SqlResult = string.Format("SELECT name,population,area FROM World WHERE population > 25000000 OR area > 3000000");     
        return SqlResult;
    }
    #endregion

    #region 4.RunTime(202 ms) Beats 69.78%  in LeetCode ,Level：Easy
    public static TreeNode MergeTrees(TreeNode t1, TreeNode t2)
    {
        if (t1 == null)
        {
            return t2;
        }
        if (t2 == null)
        {
            return t1;
        }
        t1.val += t2.val;
        t1.left = MergeTrees(t1.left, t2.left);
        t1.right = MergeTrees(t1.right, t2.right);
        return t1;
    }
    #endregion


}

//####各題所需參數集區####//
#region For 第四題MergeTrees
public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int x) { val = x; }

    public TreeNode SampleValue_t1()
    {
        TreeNode t1 = new TreeNode(1);
        t1.left = new TreeNode(3);
        t1.right = new TreeNode(2);
        t1.left.left = new TreeNode(5);
        return t1;
    }
    public TreeNode SampleValue_t2()
    {
        TreeNode t2 = new TreeNode(2);
        t2.left = new TreeNode(1);
        t2.right = new TreeNode(3);
        t2.left.right = new TreeNode(4);
        t2.right.right = new TreeNode(7);
        return t2;
    }
}
#endregion
//####各題所需參數集區####//



