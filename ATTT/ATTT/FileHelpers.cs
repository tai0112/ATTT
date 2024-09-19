using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATTT
{
    public class FileHelpers
    {
        /// <summary>
        /// Đọc dữ liệu từ file
        /// </summary>
        /// <param name="duongDan"></param>
        /// <returns></returns>
        public static string DocNoiDungFile(string duongDan)
        {
            StringBuilder builder = new StringBuilder("");

            FileStream fileStream = new FileStream(duongDan, FileMode.Open, FileAccess.Read);

            //Khai báo 1 luồng để đọc dữ liệu
            StreamReader streamReader = new StreamReader(fileStream);

            //Đọc từng dòng đến khi nào còn dữ liệu
            string dong = "";
            while (streamReader.Peek() >= 0)
            {
                dong = streamReader.ReadLine();

                builder.Append(dong + "\r\n");
            }

            //Giải phóng bộ đệm
            streamReader.Close();
            fileStream.Close();

            return builder.ToString();
        }

        /// <summary>
        /// Ghi nội dung ra file
        /// </summary>
        /// <param name="noiDung"></param>
        /// <param name="duongDan"></param>
        public static void GhiNoiDungRaFile(string noiDung, string duongDan)
        {
            //Ghi dữ liệu ra file
            try
            {
                FileStream fileStream = null;

                FileInfo fi = new FileInfo(duongDan);

                if (fi.Exists)
                {
                    fileStream = new FileStream(fi.FullName, FileMode.Truncate);
                }
                else
                {
                    fileStream = new FileStream(fi.FullName, FileMode.OpenOrCreate);
                }

                //Khai báo 1 luồng ghi
                StreamWriter writer = new StreamWriter(fileStream);

                writer.WriteLine(noiDung);

                //Đẩy dữ liệu ra file
                writer.Flush();

                //Đóng luồng
                writer.Close();
                fileStream.Close();

                Debug.WriteLine("Ghi dữ liệu ra file thành công");
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Có lỗi xảy ra. Chi tiết: " + ex.Message);
            }
        }
    }
}
