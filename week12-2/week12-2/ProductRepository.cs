using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace week12_2
{
    public class ProductRepository
    {
        public List<Product> getProductsfromCSV(string filename)
        {
            List<Product> items = new List<Product>();
            try
            {
                using (StreamReader reader = new StreamReader(filename))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        var lineArray = line.Split(';');

                        if (lineArray.Length < 4)
                            continue;

                        var product = new Product()
                        {
                            id = Convert.ToInt32( lineArray[0]),
                            title = lineArray[1],
                            price = Convert.ToDouble(lineArray[2]),
                            catid = Convert.ToInt32(lineArray[3])
                        };
                        items.Add(product);
                    }
                }
            }
            catch (Exception)
            {

            }

            return items;
        }

        public bool saveProductstoCSV(string filename, List<Product> items)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filename))
                {
                    foreach(var item in items)
                    {
                        writer.WriteLine(string.Join(";", item.id, item.title, item.price, item.catid));
                    }
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
