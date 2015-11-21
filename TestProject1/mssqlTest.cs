using MSSQL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Text;

namespace TestProject1
{
    
    
    ///// <summary>
    /////这是 mssqlTest 的测试类，旨在
    /////包含所有 mssqlTest 单元测试
    /////</summary>
    //[TestClass()]
    //public class mssqlTest
    //{


    //    private TestContext testContextInstance;

    //    /// <summary>
    //    ///获取或设置测试上下文，上下文提供
    //    ///有关当前测试运行及其功能的信息。
    //    ///</summary>
    //    public TestContext TestContext
    //    {
    //        get
    //        {
    //            return testContextInstance;
    //        }
    //        set
    //        {
    //            testContextInstance = value;
    //        }
    //    }

    //    #region 附加测试特性
    //    // 
    //    //编写测试时，还可使用以下特性:
    //    //
    //    //使用 ClassInitialize 在运行类中的第一个测试前先运行代码
    //    //[ClassInitialize()]
    //    //public static void MyClassInitialize(TestContext testContext)
    //    //{
    //    //}
    //    //
    //    //使用 ClassCleanup 在运行完类中的所有测试后再运行代码
    //    //[ClassCleanup()]
    //    //public static void MyClassCleanup()
    //    //{
    //    //}
    //    //
    //    //使用 TestInitialize 在运行每个测试前先运行代码
    //    //[TestInitialize()]
    //    //public void MyTestInitialize()
    //    //{
    //    //}
    //    //
    //    //使用 TestCleanup 在运行完每个测试后运行代码
    //    //[TestCleanup()]
    //    //public void MyTestCleanup()
    //    //{
    //    //}
    //    //
    //    #endregion


    //    /// <summary>
    //    ///Save 的测试
    //    ///</summary>
    //    [TestMethod()]
    //    public void SaveTest()
    //    {
    //        mssql target = new mssql(); // TODO: 初始化为适当的值
    //        target.ServerName = "localhost";
    //        target.User = "sa";
    //        target.Password = "1@123.com";
    //        target.DatabaseName = "Carsupplies";
    //        target.LinkOledb = false;
    //        Stream s = null; // TODO: 初始化为适当的值
    //        bool expected = true; // TODO: 初始化为适当的值
    //        bool actual;
    //        using (BinaryWriter bw = new BinaryWriter(new FileStream(@"d:\dbsetting.db", FileMode.Create, FileAccess.Write)))
    //        {
    //            byte[] value = Encoding.UTF8.GetBytes(target.AssemblyName);
    //            bw.Write(value.Length);
    //            bw.Write(value);
    //            using (MemoryStream ms = new MemoryStream())
    //            {
    //                actual = target.Save(ms);
    //                value = ms.ToArray();
    //            }

    //            bw.Write(value.Length);
    //            bw.Write(value);
    //        }
    //        Assert.AreEqual(expected, actual);
    //        //Assert.Inconclusive("验证此测试方法的正确性。");
    //    }

    //    /// <summary>
    //    ///Load 的测试
    //    ///</summary>
    //    [TestMethod()]
    //    public void LoadTest()
    //    {
    //        mssql target = new mssql(); // TODO: 初始化为适当的值
    //        Stream s = null; // TODO: 初始化为适当的值
    //        int len = 0; // TODO: 初始化为适当的值
    //        bool expected = true; // TODO: 初始化为适当的值
    //        bool actual;
    //        string an = string.Empty;
    //        using (BinaryReader br =new BinaryReader ( new FileStream(@"d:\dbsetting.db", FileMode.Open, FileAccess.Read)))
    //        {
    //            len = br.ReadInt32();
    //            an = Encoding.UTF8.GetString(br.ReadBytes(len));
    //            len = br.ReadInt32();
    //            actual = target.Load(br.BaseStream , len);
    //        }

    //        Assert.AreEqual(expected, actual);  //读取验证

    //        actual = target.AssemblyName.Equals(an);
    //        Assert.AreEqual(expected, actual);//实例明验证

    //        actual = target.Checked();//Checked 的测试
    //        Assert.AreEqual(expected, actual);
    //        //Assert.Inconclusive("验证此测试方法的正确性。");
    //    }

    //}
}
