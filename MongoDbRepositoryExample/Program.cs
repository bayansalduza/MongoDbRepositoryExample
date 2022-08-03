using MongoRepository;
using MongoRepository.Models;
using System;

namespace MongoDbRepositoryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            using (MongoRepository<Model> repository = new MongoRepository<Model>())
            {
                Model model = new Model()
                {
                    Ad = "ExampleName",
                    Soyad = "ExampleLastName"
                };

                //repository.Add(model);                                            //Add to database
                //var data = repository.Get(x => x.Soyad == "Günay");               //It retrieves data according to the given condition.
                //var datas = repository.GetAll();                                  //It pulls all the data. -> Returns in foreach.
                //var datas = repository.GetAll(x => x.Soyad == "ExampleLastName"); //Retrieves all data matching the given condition.
                //repository.Update(x => x.Soyad == "ExampleLastName", model);      //Updates the incoming data according to the condition.
                //repository.Delete(x => x.Ad == "ExampleName");                    //It deletes the data according to the condition.

            }
        }
    }
}
