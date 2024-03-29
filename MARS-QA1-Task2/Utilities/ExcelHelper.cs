﻿using ExcelDataReader;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA_1.Utilities
{
    public class ExcelHelper
    {
        //string filename = "ExcelData1.xlsx";


        private static readonly List<Datacollection> dataCol = new List<Datacollection>();

            public class Datacollection
            {
            
                public int rowNumber { get; set; }
                public string colName { get; set; }
                public string colValue { get; set; }
            }


            private static void ClearData()
            {
                dataCol.Clear();
            }
                   

        
            private static DataTable ExcelToDataTable (string filename, string SheetName)
            {
            

            // Open file and return as Stream
            using (var stream = File.Open(filename, FileMode.Open, FileAccess.Read))

               

            {
                Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
                var enc1252 = Encoding.GetEncoding(1252);


                //Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

                // more code here


                using (IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream))

                    
                { 
                            //excelReader.IsFirstRowAsColumnNames = true;
                            var conf = new ExcelDataSetConfiguration
                        {
                            ConfigureDataTable = _ => new ExcelDataTableConfiguration
                            {
                                UseHeaderRow = true
                            }
                        };

                        //Return as dataset
                         DataSet result = excelReader.AsDataSet(conf);

                    //Get all the tables
                    DataTableCollection table = result.Tables;

                        // store it in data table
                       DataTable resultTable = table[SheetName];

                        //excelReader.Dispose();
                        //excelReader.Close();
                        // return
                        return resultTable;
                    }
                }
            }

            public static string ReadData(int rowNumber, string columnName)
            {

            //string filepath = Directory.GetParent(@"C:\Users\Pinal\Desktop\MVPstudio Intenship\Task-2\MARS-QA1Task-2\MARS-QA1-Task2\Data\ExcelData1.xlsx").FullName
            // + Path.DirectorySeparatorChar + "Data"
            // + Path.DirectorySeparatorChar + "filename";

                try
                {
                    //Retriving Data using LINQ to reduce much of iterations

                  

                    rowNumber = rowNumber - 1;
                    string data = (from colData in dataCol
                                   where colData.colName == columnName && colData.rowNumber == rowNumber
                                   select colData.colValue).SingleOrDefault();

                    //var datas = dataCol.Where(x => x.colName == columnName && x.rowNumber == rowNumber).SingleOrDefault().colValue;


                    return data.ToString();
                }

                catch (Exception e)
                {
                    //Added by Kumar
                    Console.WriteLine("Exception occurred in ExcelLib Class ReadData Method!" + Environment.NewLine + e.Message.ToString());
                    return null;
                }
            }

            public static void PopulateInCollection(string fileName, string SheetName)

            {
                ClearData();
                DataTable table = ExcelToDataTable(fileName, SheetName);

                //Iterate through the rows and columns of the Table
                for (int row = 1; row <= table.Rows.Count; row++)
                {
                    for (int col = 0; col < table.Columns.Count; col++)
                    {
                        Datacollection dtTable = new Datacollection()
                        {
                            rowNumber = row,
                            colName = table.Columns[col].ColumnName,
                            colValue = table.Rows[row - 1][col].ToString()
                        };


                        //Add all the details for each row
                        dataCol.Add(dtTable);

                    }
                }

            }
        }




    }



