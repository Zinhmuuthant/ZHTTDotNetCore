﻿using System.Data;
using System.Data.SqlClient;
using System.Net.Http.Headers;
using ZHTTDotNetCore.ConsoleApp.EFCoreExamples;

Console.WriteLine("Hello World");


//SqlConnectionStringBuilder stringBuilder = new SqlConnectionStringBuilder();
//stringBuilder.DataSource = ".";
//stringBuilder.InitialCatalog = "ZHTTDotNetCore";
//stringBuilder.UserID = "sa";
//stringBuilder.Password = "sa@123";

//SqlConnection connection = new SqlConnection(stringBuilder.ConnectionString);

//connection.Open();
//Console.WriteLine("Connection open.");


//string query = "select * from Tbl_Blog";
//SqlCommand cmd = new SqlCommand(query, connection);
//SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
//DataTable dt = new DataTable();
//sqlDataAdapter.Fill(dt);



//connection.Close();
//Console.WriteLine("Connection close.");

//foreach (DataRow dr in dt.Rows)
//{
//    Console.WriteLine(dr["BlogId"]);
//    Console.WriteLine(dr["BlogTitle"]);
//    Console.WriteLine(dr["BlogAuthor"]);
//    Console.WriteLine(dr["BlogContent"]);
//    Console.WriteLine("--------------------------");



//}

//AdoDotNetExample adoDotNetExample = new AdoDotNetExample();
//adoDotNetExample.Read();
//adoDotNetExample.Create("title", "author", "content");
//adoDotNetExample.Update(11, "test title", "test author", "test content");
//adoDotNetExample.Delete(11);
//adoDotNetExample.Edit(11);
//adoDotNetExample.Edit(1);
//DapperExample dapperExample = new DapperExample();
//dapperExample.Run();
EFCoreExample eFCoreExample = new EFCoreExample();
eFCoreExample.Run();


Console.ReadKey();
