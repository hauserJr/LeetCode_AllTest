using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class LeetCode_All_Question
{
    #region RunTime(142 ms) Beats 55.74% in LeetCode ,Level：Easy
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

    #region RunTime(59 ms) Beats 73.77%  in LeetCode ,Level：Easy
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

    #region RunTime(2962 ms) Beats 73.64% in LeetCode , Level：Easy
    public string BigCountries()
    {
        string SqlResult = string.Format("SELECT name,population,area FROM World WHERE population > 25000000 OR area > 3000000");     
        return SqlResult;
    }
    #endregion
}



