using System.Data;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ExcelDataReader;


namespace easyChart
{
    public class LoadData
    {
        public string filePath { get; set; }
        public int dateCol { get; set; }
        public int wellCol { get; set; }

        public DataTable wellDate { get; set; }

        public LoadData(string file_path)
        {
            filePath = file_path;
            dateCol = 1;
            wellCol = 0;
        }

        public void read_excel()
        {
            using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
            {
                // Auto-detect format, supports:
                //  - Binary Excel files (2.0-2003 format; *.xls)
                //  - OpenXml Excel files (2007 format; *.xlsx)
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    var temp = reader.AsDataSet(new ExcelDataSetConfiguration()
                        {
                            // Gets or sets a value indicating whether to set the DataColumn.DataType 
                            // property in a second pass.
                            UseColumnDataType = true,

                            // Gets or sets a callback to obtain configuration options for a DataTable. 
                            ConfigureDataTable = (tableReader) => new ExcelDataTableConfiguration()
                            {
                                // Gets or sets a value indicating whether to use a row from the 
                                // data as column names.
                                UseHeaderRow = true,

                                // Gets or sets a callback to determine which row is the header row. 
                                // Only called when UseHeaderRow = true.
//                                ReadHeaderRow = (rowReader) =>
//                                {
//                                    // F.ex skip the first row and use the 2nd row as column headers:
//                                    rowReader.Read();
//                                }
                            }
                        }
                    );

                    wellDate = temp.Tables[0];
                    // The result of each spreadsheet is in result.Tables
                }
            }
        }

        public List<string> get_lines()
        {
            List<string> reList = new List<string>();
            foreach (DataColumn col in wellDate.Columns)
            {
                int colNum = wellDate.Columns.IndexOf(col);
                if (colNum != dateCol && colNum != wellCol)
                {
                    reList.Add(col.ColumnName);
                }
            }
            return reList;
        }

        public List<string> get_wells()
        {
            List<string> reList = new List<string>();
            for (int i = 0; i < wellDate.Rows.Count; i++)
            {
                reList.Add(wellDate.Rows[i][wellCol].ToString());
            }

            return reList.Distinct().ToList();
        }


    }
}