using CargoStorage.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoStorage.Services
{
    public class CargoService: ICargoService
    {
        private static int cargo_id = 0;

        private String[] names = new String[]
        {
            "Масло растительное",
            "Порошок чистящий",
            "Песок керамзитный",
            "Песок золотоносный",
            "Кислота уксусная",
            "Порошок зубной",
            "Порошок стиральный",
            "Кофе",
            "чай",
            "чайник",
            "пылесос",
            "микроволновка",
            "табурет"
        };


        private String[] units = new string[]
        {
            "тонна",
            "килограмм",
            "литр",
            "метр куб.",
            "метр пог.",
            "метр кв.",
            "штуки",
            "коробки",
            "упаковки",
            "тубы"
        };

        public Cargo GenerateCargo()
        {
            Random random = new Random();

            Cargo cargo = new Cargo(
                ++cargo_id, 
                names[random.Next(names.Length)],
                DateTime.Now.AddDays(-random.Next(30)),
                random.NextDouble()*2000,
                random.NextDouble()*1000,
                units[random.Next(units.Length)]
            );

            return cargo;
        }
    }
}
