using IBM___WFA.Data;
using IBM___WFA.Data.Models;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBM___WFA.Business
{
    public class ApplicationBusiness
    {
        private RazpisanieContext context;

        //методи за таблица фирми



        //метод за добавяне на фирма
        public void AddFirm(Firmi firm)
        {
            using(context=new RazpisanieContext())
            {
                //проверяваме дали вече съществува такава фирма
                bool Already_Exist = false;

                foreach(var firma in context.Firmis)
                {
                    if(firma==firm)Already_Exist = true;
                }

                if (!Already_Exist)
                {
                    context.Firmis.Add(firm);
                    context.SaveChanges();
                }
            }
        }

        //метод за премахване на фирма
        public void RemoveFirm(string Name_Of_Firm)
        {
            int Id_Of_Firm_If_Exist = -1;
            bool Is_Exist = false;

            using (var context = new RazpisanieContext())
            {
                var firmis = context.Firmis.ToList();

                foreach (var firma in firmis)
                {
                    if (firma.Ime == Name_Of_Firm)
                    {
                        Is_Exist = true;
                        Id_Of_Firm_If_Exist = firma.IdFirma;
                        context.Firmis.Remove(firma);
                        context.SaveChanges();
                    }
                }

                if (Is_Exist)
                {
                    var razpisaniqFirmis = context.RazpisaniqFirmis.ToList();

                    foreach (var item in razpisaniqFirmis)
                    {
                        if (item.IdFirma == Id_Of_Firm_If_Exist)
                        {
                            context.RazpisaniqFirmis.Remove(item);
                            context.SaveChanges();
                        }
                    }
                }
            }
        }



        //метод за извличане на всички фирми
        public List<Firmi> GetAllFirmis()
        {
            using(context=new RazpisanieContext())
            {
                return context.Firmis.ToList();
            }
        }


        //метод за извличане на всички фирми сортирани по име
        public List<Firmi> GetAllFirmisSortedByName()
        {
            using (context = new RazpisanieContext())
            {
                return context.Firmis.OrderBy(x =>x.Ime).ToList();
            }
        }


        //метод за проверка дали фирма съществува
        public bool Firm_Exist(string name)
        {
            using(context = new RazpisanieContext())
            {
                bool exist = false;
                foreach (var firma in context.Firmis)
                {
                    if(firma.Ime==name)exist = true;
                }
                return exist;
            }
            
        }



        //метод за ъпдейтване на фирма
        public void UpdateFirm(Firmi Firm)
        {
            using (context = new RazpisanieContext())
            {

                var item = context.Firmis.Find(Firm.IdFirma);
                if (item != null)
                {
                    context.Entry(item).CurrentValues.SetValues(Firm);
                    context.SaveChanges();
                }

            }
        }




        //---------------------------------------------------------------------------




        //методи за таблица разписания




    }
}
