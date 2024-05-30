using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HusSagLib
{
    public class HusSagRepository
    {
        private int _nextId = 1;
        private List<HusSag> husSager = new List<HusSag>();

        public HusSagRepository() 
        {
            husSager.Add(new HusSag { Id = _nextId++, Vej = "Vej1", HusNr = 1, By = "By1", Pris = 1000000 });
            husSager.Add(new HusSag { Id = _nextId++, Vej = "Vej2", HusNr = 2, By = "By2", Pris = 2000000 });
            husSager.Add(new HusSag { Id = _nextId++, Vej = "Vej3", HusNr = 3, By = "By3", Pris = 3000000 });
            husSager.Add(new HusSag { Id = _nextId++, Vej = "Vej4", HusNr = 4, By = "By4", Pris = 4000000 });
            husSager.Add(new HusSag { Id = _nextId++, Vej = "Vej5", HusNr = 5, By = "By5", Pris = 5000000 });
        }
        public List<HusSag> GetAll()
        {
            return husSager;
        }

        public HusSag? GetById(int id) //Hvis der ikke findes en husSag med det givne id, returneres null
        {
            return husSager.FirstOrDefault(h => h.Id == id); //Returnerer den første husSag i listen, hvor id'et er lig med det givne id
        }

        public void Add(HusSag husSag)
        {
            husSag.Id = _nextId++;
            husSager.Add(husSag);
        }
    }
}
