using System;
using CsvHelper;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStateCensusAnaylzer
{
    public class StateCensusAnalyser
    {
        public static int ReadstateCensusData(string filepath)
        {
            using (var reader = new StreamReader(filepath))
            {
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    var records = csv.GetRecords<StateCensusData>().ToList();
                    Console.WriteLine("Read data from CSV");
                    foreach (var data in records)
                    {
                        Console.WriteLine(data.State + "___" + data.Population + "___" + data.AreaInSqKm + "___" + data.DensityPerSqKm);
                    }
                    return records.Count() - 1;
                }
            }
        }
    }
}
