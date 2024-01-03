using BenchmarkDotNet.Attributes;

namespace ConsoleApplication
{
    public class CollectionMethods
    {
        [Benchmark]
        /// <summary>
        /// Yanlış Kullanım
        /// </summary>
        /// <returns></returns>
        public bool HasSkodaForCount()
        {
            IEnumerable<Car> cars = new List<Car>
            {
                new Car { Name = "Octavia", Brand = "Skoda", BrandName = "Skoda", Year = 2018 },
                new Car { Name = "Passat", Brand = "Volkswagen", BrandName = "Volkswagen", Year = 2018 },
                new Car { Name = "Golf", Brand = "Volkswagen", BrandName = "Volkswagen", Year = 2018 },
                new Car { Name = "Astra", Brand = "Opel", BrandName = "Opel", Year = 2018 },
                new Car { Name = "Corsa", Brand = "Opel", BrandName = "Opel", Year = 2018 },
                new Car { Name = "Focus", Brand = "Ford", BrandName = "Ford", Year = 2018 },

            };

            return cars.Count(x => x.Brand == "Skoda") > 0;
        }

        [Benchmark(Baseline = true)]
        /// <summary>
        /// Doğru Kullanım
        /// </summary>
        /// <returns></returns>
        public bool HasSkodaForAny()
        {
            IEnumerable<Car> cars = new List<Car>
            {
                new Car { Name = "Octavia", Brand = "Skoda", BrandName = "Skoda", Year = 2018 },
                new Car { Name = "Passat", Brand = "Volkswagen", BrandName = "Volkswagen", Year = 2018 },
                new Car { Name = "Golf", Brand = "Volkswagen", BrandName = "Volkswagen", Year = 2018 },
                new Car { Name = "Astra", Brand = "Opel", BrandName = "Opel", Year = 2018 },
                new Car { Name = "Corsa", Brand = "Opel", BrandName = "Opel", Year = 2018 },
                new Car { Name = "Focus", Brand = "Ford", BrandName = "Ford", Year = 2018 },

            };

            return cars.Any(x => x.Brand == "Skoda");

        }
    }

    public class Car
    {
        public string Name { get; set; }
        public string Brand { get; set; }
        public string BrandName { get; set; }
        public int Year { get; set; }
    }
}

