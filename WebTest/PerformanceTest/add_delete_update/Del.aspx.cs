﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SyntacticSugar;
using SqlSugar;
using Dapper;

namespace WebTest.Select
{
    public partial class Del : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            PerformanceTest pt = new PerformanceTest();
            pt.SetCount(1);//设置循环次数
            using (SqlSugarClient db = new SqlSugarClient(System.Configuration.ConfigurationManager.ConnectionStrings["sqlConn"].ToString()))
            {
                //sqlSugar
                pt.Execute(i =>
                {
                    db.Delete<Models.InsertTest>(1000);

                }, m => { }, "sqlSugar");
            }


        }
    }
}