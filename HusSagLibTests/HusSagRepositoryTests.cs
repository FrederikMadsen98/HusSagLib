using Microsoft.VisualStudio.TestTools.UnitTesting;
using HusSagLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HusSagLib.Tests
{
    [TestClass()]
    public class HusSagRepositoryTests
    {
        [TestMethod()]
        public void GetAllTest()
        {
            HusSagRepository husSagRepository = new HusSagRepository(); //Laver en instans af HusSagRepository
            List<HusSag> husSager = husSagRepository.GetAll(); //Kalder metoden GetAll på instansen af HusSagRepository
            Assert.AreEqual(5, husSager.Count); //Tester om der er 5 elementer i listen
        }

        [TestMethod()]
        public void GetByIdTest()
        {
            HusSagRepository husSagRepository = new HusSagRepository();
            HusSag husSag = husSagRepository.GetById(3); //Kalder metoden GetById på instansen af HusSagRepository
            Assert.AreEqual(3, husSag.Id); 
            Assert.AreEqual("Vej3", husSag.Vej); 
            Assert.AreEqual(3, husSag.HusNr); 
            Assert.AreEqual("By3", husSag.By); 
            Assert.AreEqual(3000000, husSag.Pris); 
        }

        [TestMethod()]
        public void AddTest()
        {
            HusSagRepository husSagRepository = new HusSagRepository();
            HusSag husSag = new HusSag { Vej = "Vej6", HusNr = 6, By = "By6", Pris = 6000000 }; //Laver en ny instans af HusSag
            husSagRepository.Add(husSag); //Kalder metoden Add på instansen af HusSagRepository
            Assert.AreEqual(6, husSag.Id); //Tester om Id'et er 6
            Assert.AreEqual(6, husSagRepository.GetAll().Count); //Tester om der er 6 elementer i listen
        }
    }
}