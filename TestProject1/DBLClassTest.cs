using dbl;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data;

namespace TestProject1
{


    /// <summary>
    ///这是 DBLClassTest 的测试类，旨在
    ///包含所有 DBLClassTest 单元测试
    ///</summary>
    [TestClass()]
    public class DBLClassTest
    {
        private TestContext testContextInstance;

        /// <summary>
        ///获取或设置测试上下文，上下文提供
        ///有关当前测试运行及其功能的信息。
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region 附加测试特性
        // 
        //编写测试时，还可使用以下特性:
        //
        //使用 ClassInitialize 在运行类中的第一个测试前先运行代码
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //使用 ClassCleanup 在运行完类中的所有测试后再运行代码
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //使用 TestInitialize 在运行每个测试前先运行代码
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //使用 TestCleanup 在运行完每个测试后运行代码
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion

        /// <summary>
        ///ReadData 的测试
        ///</summary>
        [TestMethod()]
        public void ReadDataTest()
        {
            DBLClass target = new DBLClass(); // TODO: 初始化为适当的值
            string key = string.Empty; // TODO: 初始化为适当的值
            SqlCmd sqlc = null; // TODO: 初始化为适当的值

            List<object[]> param = null; // TODO: 初始化为适当的值
            int id = 0; // TODO: 初始化为适当的值
            int expected = 0; // TODO: 初始化为适当的值
            int actual;
            bool check, ischecked = true;

            target.InitSetting();   //加载数据库连接配置
            check = target.CheckDBLinkState();
            Assert.AreEqual(ischecked, check);  //验证连接配置信息有效性

            actual = target.LoadKey();
            Assert.AreEqual(expected, actual);  //验证载入操作数据字典

            key = "mabc";
            actual = target.ReadData(key, ref sqlc, param, id);

            //Assert.AreEqual(sqlcExpected, sqlc);
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("验证此测试方法的正确性。");
        }

        ///// <summary>
        /////Update 的测试
        /////</summary>
        //[TestMethod()]
        //public void UpdateTest()
        //{
        //    DBLClass target = new DBLClass(); // TODO: 初始化为适当的值
        //    SqlCmd sqlc = null; // TODO: 初始化为适当的值
        //    int expected = 0; // TODO: 初始化为适当的值
        //    int actual;
        //    bool check, ischecked = true;

        //    target.InitSetting();   //加载数据库连接配置
        //    check = target.CheckDBLinkState();
        //    Assert.AreEqual(ischecked, check);  //验证连接配置信息有效性

        //    actual = target.LoadKey();
        //    Assert.AreEqual(expected, actual);  //验证载入操作数据字典

        //    actual = target.ReadData("mabc", ref sqlc, new List<object[]>() { new object[] { }, new object[] { 9998 },new object[]{1} });
        //    sqlc.SQLList[0].OnUpdated = true;
        //    sqlc.SQLDataSet.Tables[0].Rows[0][6] = 25;      //修改数据 

        //    sqlc.SQLList[1].OnUpdated = true;
        //    sqlc.SQLDataSet.Tables[1].Rows[0][6] = 65;
        //    DataRow dr = sqlc.SQLDataSet.Tables[1].NewRow();    //添加一行新数据
        //    dr["id"] = 9996;
        //    dr["name"] = "贴膜";
        //    dr["category"] = 0;
        //    dr["groupid"] = 0;
        //    dr["unit"] = "米";
        //    dr["price"] = 20.0;
        //    sqlc.SQLDataSet.Tables[1].Rows.Add(dr);
        //    actual = target.Update(sqlc);
        //    Assert.AreEqual(expected, actual);
        //    //Assert.Inconclusive("验证此测试方法的正确性。");
        //}


            ///// <summary>
            /////InitSetting 的测试
            /////</summary>
            //[TestMethod()]
            //public void InitSettingTest()
            //{
            //    DBLClass target = new DBLClass(); // TODO: 初始化为适当的值
            //    int expected = 0; // TODO: 初始化为适当的值
            //    int actual;
            //    actual = target.InitSetting();
            //    Assert.AreEqual(expected, actual);
            //    //Assert.Inconclusive("验证此测试方法的正确性。");
            //}

            ///// <summary>
            /////InitSetting 的测试
            /////</summary>
            //[TestMethod()]
            //public void InitSettingTest1()
            //{
            //    DBLClass target = new DBLClass(); // TODO: 初始化为适当的值
            //    string filename = @"D:\Projects\C#\汽车用品管理系统\TestProject1\bin\Debug\databasesetting.db"; // TODO: 初始化为适当的值
            //    int expected = 0; // TODO: 初始化为适当的值
            //    int actual;
            //    actual = target.InitSetting(filename);
            //    Assert.AreEqual(expected, actual);
            //    //Assert.Inconclusive("验证此测试方法的正确性。");
            //}

        /// <summary>
        ///CompParamCount 的测试
        ///</summary>
        [TestMethod()]
        [DeploymentItem("dbl.dll")]
        public void CompParamCountTest()
        {
            DBLClass_Accessor target = new DBLClass_Accessor(); // TODO: 初始化为适当的值
            string val = string.Empty; // TODO: 初始化为适当的值
            int num = 2; // TODO: 初始化为适当的值
            bool expected = true; // TODO: 初始化为适当的值
            bool actual;
            val = @"select id,pid,unit,number from prosubunits where pid='{0}' and id='{1}‘";
            actual = target.CompParamCount(val, num);
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("验证此测试方法的正确性。");
        }
    }
}
