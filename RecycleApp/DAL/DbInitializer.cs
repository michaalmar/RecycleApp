//using RecycleApp.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;

//namespace RecycleApp.DAL
//{
//    public class DbInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<DataContex>

//    {
//        protected override void Seed(DataContex context)
//        {
//            var categories = new List<Category>
//            {
//                new Category{CategoryID=1, Name="Papier" },
//                new Category{CategoryID=2, Name="Metale i tworzywa sztuczne"},
//                new Category{CategoryID=3, Name="Szkło"},
//                new Category{CategoryID=4, Name="Odpady zielone"},
//                new Category{CategoryID=5, Name="BIO"},
//                new Category{CategoryID=6, Name="Zmieszane odpady komunalne"},

//            };
//            categories.ForEach(c => context.Categories.Add(c));
//            context.SaveChanges();

//            var trashes = new List<Trash>
//            {
//                new Trash{TrashID=1,Name="słoik", CategoryID=3 },
//                new Trash{TrashID=2, Name="Puszka",CategoryID=2},
//            };
//            trashes.ForEach(t => context.Trashes.Add(t));
//            context.SaveChanges();

                
//        }


//    }
//}