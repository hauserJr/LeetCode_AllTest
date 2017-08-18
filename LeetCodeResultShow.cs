using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class LeetCodeResultShow
{
    static System.Diagnostics.Stopwatch RunTime = new System.Diagnostics.Stopwatch();
    static string RunTime_ms = string.Empty;
    static void Main(string[] args)
    {
        //Question Area , 題目集中區
        LeetCode_All_Solution _CallResult = new LeetCode_All_Solution();

        #region 取得程式執行時間,非LeetCode上RunTime
        RunTimeSetUp();
        #endregion

        #region 程式呼叫區,Method Call
        
        #endregion

        #region 停止計算程式執行時間
        RunTime.Stop();
        RunTime_ms = string.Format(@"{0}ms",RunTime.Elapsed.TotalMilliseconds.ToString());
        #endregion

        //結果顯示
        Console.Write("RunTime(Method/ms): " + RunTime_ms);
        Console.Read();

    }

    #region Run Time Process
    private static void RunTimeSetUp()
    {
        RunTime.Reset();//碼表歸零
        RunTime.Start();//碼表開始計時
    }
    #endregion
}