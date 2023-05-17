using System;
using System.Collections;
using System.Collections.Generic;


namespace OOP_FINAL_PROJECT
{
    public class Program
    {
        static void Main(string[] args)
        {
            string information = @"D:\OOP\Labs\OOP_FINAL_PROJECT\OOP_FINAL_PROJECT\jShInformation.txt";
            Console.WriteLine("\n ------  Reading from file: ------ \n");

            ArrayList shopInformation1 = new ArrayList();
            ArrayList shopInformation2 = new ArrayList();
            ArrayList shopInformation3 = new ArrayList();
            ArrayList shopInformation4 = new ArrayList();

            string line;
            string currentBlock = string.Empty;

            using (StreamReader sr = new StreamReader(information))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.StartsWith("*"))
                    {
                        currentBlock = "*";
                    }
                    else if (line.StartsWith("**"))
                    {
                        currentBlock = "**";
                    }
                    else if (line.StartsWith("***"))
                    {
                        currentBlock = "***";
                    }
                    else if (line.StartsWith("****"))
                    {
                        currentBlock = "****";
                    }


                    switch (currentBlock)
                    {
                        case "*":
                            shopInformation1.Add(line);
                            break;
                        case "**":
                            shopInformation2.Add(line);
                            break;
                        case "***":
                            shopInformation3.Add(line);
                            break;
                        case "****":
                            shopInformation4.Add(line);
                            break;
                    }

                }
            }

            Console.WriteLine("------  Shop Information 1: ------");
            foreach (var item in shopInformation1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("------  Shop Information 2: ------");
            foreach (var item in shopInformation2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("------  Shop Information 3: ------");
            foreach (var item in shopInformation3)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("------  Shop Information 4: ------");
            foreach (var item in shopInformation4)
            {
                Console.WriteLine(item);
            }
        }
    }
}

            /*   var stores = new List<JewerlyShop>();
               using (var reader = new StreamReader("data.txt"))
               {
                   while (!reader.EndOfStream)
                   {
                       var shop = new JewerlyShop();
                       shop.adress = reader.ReadLine();
                       shop.Items = new List<JewerlyItem>();

                       var count = int.Parse(reader.ReadLine());
                       for (int i = 0; i < count; i++)
                       {
                           var line = reader.ReadLine().Split(',');
                           var item = new JewelryItem();
                           item.Name = line[0];
                           item.Metal = line[1];
                           item.Weight = int.Parse(line[2]);
                           if (int.TryParse(line[2], out int weight))
                           {
                               item.Weight = weight;
                           }
                           else
                           {
                           }
                       }
                   }
               }*/
        