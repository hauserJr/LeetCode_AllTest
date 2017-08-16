using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class LeetCode_AllTest
{
    static void Main(string[] args)
    {
        
    }

    #region RunTime Beats 55.74% in LeetCode , Level：Easy
    public static bool JudgeCircle(string moves)
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
}

