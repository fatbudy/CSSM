using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Microsoft.SqlServer.Server;
using System.IO;
using System.Collections;
using System.Text.RegularExpressions;

public partial class UserDefinedFunctions
{
    /// <summary>
    /// 获取sql语句中包含{0}这样格式的参数数量
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    [Microsoft.SqlServer.Server.SqlFunction(Name ="get_param")]
    public static int GetParam(SqlString s)     //获取sql语句中包含{0}这样格式的参数数量
    {
        // 在此处放置代码
        Regex _break_comp = new Regex(@"\{\d\}", RegexOptions.Compiled);
        return  _break_comp.Matches(s.ToString() ).Count;
        //return new SqlString("Hello");
    }
    //[SqlFunctionAttribute(Name = "getfileDetails", FillRowMethodName = "FillFileRow", TableDefinition = "FillFileRow nvarchar(255)")]
    //public static IEnumerable GetFileDetails(string directoryPath)
    //{
    //    try
    //    {
    //        DirectoryInfo di = new DirectoryInfo(directoryPath);
    //        return di.GetFiles();
    //    }
    //    catch (DirectoryNotFoundException dnf)
    //    {
    //        return new string[1] { dnf.ToString() };
    //    }

    //}
    //[SqlFunction(Name = "sp_tableFunc", TableDefinition = "letter nchar(1)", FillRowMethodName = "SampleTableFunction")]
    //public static IEnumerable SampleTableFunction(SqlString s)
    //{
    //    //...
    //    return new ArrayList(new char[3] { 'a', 'b', 'c' });
    //}
};

