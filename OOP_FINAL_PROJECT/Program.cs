using System;
using System.Collections;
using System.Collections.Generic;
using static System.Formats.Asn1.AsnWriter;
using System.IO;


namespace OOP_FINAL_PROJECT
{
    public class Program
    {
        static void Main(string[] args)
        {

            // Зчитуємо дані з файлу
            var manyStores = new List<JewelryShop>();
            using (var reader = new StreamReader(@"D:\\OOP\\Labs\\OOP_FINAL_PROJECT\\OOP_FINAL_PROJECT\\jShInformation.txt"))
            {
                while (!reader.EndOfStream) // перевіряє, чи читач ще не досягнув 
                                            // кінця потоку, і якщо це так,
                                            // то виконується тіло циклу,
                                            // яке зазвичай містить один або
                                            // кілька рядків коду.
                                            // Після виконання тіла циклу
                                            // виконання повертається до початку циклу,
                                            // і перевіряється умова знову.
                                            // Цей процес повторюється, доки умова reader.
                                            // EndOfStream не стане true.
                {
                   
                    var shop = new JewelryShop(); //  !!!!!!!!!! створює новий об'єкт класу !!!!!!!!!!!! JewerlyShop і присвоює його посилання змінній store
                    shop.Address = reader.ReadLine(); // Доступаємось до поля з адресою за допомогою властивостей,
                                                       // cтворених раніше в JewelryShop,
                                                       // зчитуємоз файлу адресу за допомогою readline
                    shop.Amount = Int32.Parse(reader.ReadLine()); // зчитує наступний рядок з потоку reader,
                                                               // перетворює його на ціле число
                                                               // і присвоює його полю amount
                    shop.Jewelries = new List<Jewelry>(); // доступаємось до поля Jewelries об'єкту shop,
                                                          // який ми створили вище,
                                                          // присвоюємо цьому об'єкту ліст типу Jewelry,
                                                          // бо цей ліст буде містити характеристики прикраси
                    for (int i = 0; i < shop.Amount; i++)
                    {
                        var line = reader.ReadLine().Split('*'); // створюємо масив з рядків,
                                                                 // в який будемо звчитувати елементи.
                                                                 // Кожен новий елемент - частинка файлу розділена комою
                        var oneJewelry = new Jewelry(); // для кожної прикраси на проміжку вище
                                                        // ми створюємо об'єкт типу Jewelry,
                                                        // який містить поля з характеристиками прикраси
                        oneJewelry.Name = line[0]; // вказуємо, що першим елементом масиву в нас буде ім'я прикраси
                        oneJewelry.Metal = line[1]; // вказуємо, що другим елементом масиву в нас буде метал, з якого зроблена прикраса
                        oneJewelry.Weight = double.Parse(line[2]); // вказуємо, що третім елементом масиву в нас буде вага прикраси.
                                                                   // Приводимо її до типу дабл,
                                                                   // оскільки записуємо вагу через кому,
                                                                   // а не через цілі значення
                        oneJewelry.Price = Int32.Parse(line[3]); // вказуємо, що четвертим елементом масиву в нас буде ціна прикраси.

                        shop.Jewelries.Add(oneJewelry);
                   
                    }
    

                    for (int i = 0; i<shop.Amount; i++)
                    {
                        manyStores.Add(shop);
                    }
                    Console.WriteLine(manyStores);

                    /*          Console.Write(shop);*/
/*
                    foreach (var jewelryShop11 in manyStores)
                    {
                        Console.WriteLine("-------------------------");
                        Console.WriteLine("Shop Address: " + jewelryShop11.Address);
                        Console.WriteLine("Number of Jewelries: " + jewelryShop11.Amount);
                        Console.WriteLine("Jewelries:");

                        foreach (var jewelryItem in shop.Jewelries)
                        {
                            Console.WriteLine("Name: " + jewelryItem.Name);
                            Console.WriteLine("Metal: " + jewelryItem.Metal);
                            Console.WriteLine("Weight: " + jewelryItem.Weight);
                            Console.WriteLine("Price: " + jewelryItem.Price);
                            Console.WriteLine();
                        }

                        Console.WriteLine("-------------------------");
                    }*/

                    foreach (var obj in manyStores)
                    {
                        obj.PrintShopInfo();
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
            }

        }
    }
}
