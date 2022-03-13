using CsvHelper;
using CsvHelper.Configuration;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace NDDD.Domain
{
    public static class CsvParser
    {
        public static List<T> Read<T>(string filepath)
        {
            using (var reader = new StreamReader(filepath))
            using (var csv = new CsvReader(reader, CultureInfo.CurrentCulture))
            {
                return csv.GetRecords<T>().ToList();
            }
        }
        public static void Write<T>(IEnumerable<T> obj, string filepath)
        {
            using (var reader = new StreamWriter(filepath))
            using (var csv = new CsvWriter(reader, CultureInfo.CurrentCulture))
            {
                csv.WriteRecords<T>(obj);

            }
        }
        public static List<T> Read<T>(string filepath, Encoding encoding, string delimiter)
        {
            var config = new CsvConfiguration(CultureInfo.CurrentCulture)
            {
                Delimiter = delimiter,
            };
            using (var reader = new StreamReader(filepath, encoding))
            using (var csv = new CsvReader(reader, config))
            {
                return csv.GetRecords<T>().ToList();
            }

        }
        public static void Write<T>(IEnumerable<T> obj, string filepath, Encoding encoding, string delimiter)
        {
            var config = new CsvConfiguration(CultureInfo.CurrentCulture)
            {
                Delimiter = delimiter,
            };
            using (var reader = new StreamWriter(filepath, false, encoding))
            using (var csv = new CsvWriter(reader, config))
            {
                csv.WriteRecords<T>(obj);
            }
        }
    }
}
