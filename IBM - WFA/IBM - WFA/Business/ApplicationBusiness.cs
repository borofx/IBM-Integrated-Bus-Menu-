using IBM___WFA.Data;
using IBM___WFA.Data.Models;
using IBM___WFA.User_Controls.Schedule_Menu;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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


        //метод за извличане на всички фирми сортирани по ид
        public List<Firmi> GetAllFirmisSortedById()
        {
            using (context = new RazpisanieContext())
            {
                return context.Firmis.OrderBy(x => x.IdFirma).ToList();
            }
        }


        //методи за проверка дали фирма съществува
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

        public bool Firm_Exist(int id)
        {
            using(context= new RazpisanieContext())
            {
                bool exists = false;
                foreach(var item in context.Firmis)
                {
                    if(item.IdFirma==id)exists = true;
                }
                return exists;
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

        //метод за добавяне на разписание
        public void AddSchedule(Razpisaniq razpisanie)
        {
            using(context=new RazpisanieContext())
            {
                //проверяваме дали вече съществува такова разписание
                bool Already_Exist = false;

                foreach (var item in context.Razpisaniqs)
                {
                    if (item == razpisanie) Already_Exist = true;
                }

                if (!Already_Exist)
                {
                    context.Razpisaniqs.Add(razpisanie);
                    context.SaveChanges();
                }
            }
        }



        //методи за проверка дали разписанието вече съществува
        public bool Schedule_Exist(Razpisaniq razpisanie)
        {
            using (context = new RazpisanieContext())
            {
                bool exist = false;
                foreach (var item in context.Razpisaniqs)
                {
                    if (item == razpisanie) exist = true;
                }
                return exist;
            }

        }

        public bool Schedule_Exist(int id)
        {
            using(context= new RazpisanieContext())
            {
                bool exist = false;
                foreach(var razpisanie in context.Razpisaniqs)
                {
                    if(razpisanie.IdMarshrut==id)exist = true;
                }
                return exist;
            }
        }





        //метод за извличане на всички разписания
        public List<Razpisaniq> GetAllSchedules()
        {
            using(context= new RazpisanieContext())
            {
                return context.Razpisaniqs.ToList();
            }
        }




        //метод за изтривавне на разписание
        public void DeleteSchedule(int id)
        {
            using(context=new RazpisanieContext())
            {
                var Razpisaniq = context.Razpisaniqs.ToList();
                foreach (var razpisanie in Razpisaniq)
                {
                    if(razpisanie.IdMarshrut== id)
                        context.Razpisaniqs.Remove(razpisanie);
                        context.SaveChanges();
                }

                var RazpisaniqFirmis=context.RazpisaniqFirmis.ToList();
                foreach(var razpisaniefirma in RazpisaniqFirmis)
                {
                    if(razpisaniefirma.IdMarshrut== id)
                    {
                        context.RazpisaniqFirmis.Remove(razpisaniefirma);
                        context.SaveChanges();
                    }
                }
            }
        }



        //метод за ъпдейтване на разписание
        public void UpdateSchedule(Razpisaniq razpisanie)
        {
            using (context = new RazpisanieContext())
            {

                var item = context.Razpisaniqs.Find(razpisanie.IdMarshrut);
                if (item != null)
                {
                    context.Entry(item).CurrentValues.SetValues(razpisanie);
                    context.SaveChanges();
                }
            }
 
        }




        //метод за сортиране на разписанията по ид
        public List<Razpisaniq> SortRazpisaniqByIdMarshrut()
        {
            using (context = new RazpisanieContext())
            {
                return context.Razpisaniqs.OrderBy(x => x.IdMarshrut).ToList();
            }
        }






        //метод за сортиране на разписанията по град на заминаване
        public List<Razpisaniq> SortRazpisaniqByZaminavaOt()
        {
            using(context= new RazpisanieContext())
            {
                return context.Razpisaniqs.OrderBy(x=>x.ZaminavaOt).ToList();
            }
        }


        //метод за сортиране на разписанията по град на пристигане
        public List<Razpisaniq> SortRazpisaniqByPristigaV()
        {
            using(context=new RazpisanieContext())
            {
                return context.Razpisaniqs.OrderBy(x => x.PristigaV).ToList();
            }
        }



        //метод за сортиране на разписанията по час на заминаване
        public List<Razpisaniq> SortRazpisaniqByChasZaminavane()
        {
            using(context=new RazpisanieContext())
            {
                return context.Razpisaniqs.OrderBy(x=>x.ChasZaminavane).ToList();
            }
        }



        //метод за сортиране на разписанията по час на пристигане
        public List<Razpisaniq> SortRazpisaniqByChasPristigane()
        {
            using (context = new RazpisanieContext())
            {
                return context.Razpisaniqs.OrderBy(x => x.ChasPristigane).ToList();
            }
        }







        //---------------------------------------------------------------------------




        //методи за таблица разписания-фирми



        //метод за проверка дали разписание-фирма съществува
        public bool RazpisanieFirm_Exist(int IdMarshrut)
        {
            using (context = new RazpisanieContext())
            {
                bool exist = false;
                foreach (var item in context.RazpisaniqFirmis)
                {
                    if (item.IdMarshrut == IdMarshrut) exist = true;
                }
                return exist;
            }

        }



        //метод за добавяне на информация на разписание-фирма
        public void AddRazpisanieFirm(RazpisaniqFirmi razpisanieFirma)
        {
            using(context=new RazpisanieContext())
            {
                var Do_Exist = context.RazpisaniqFirmis.Find(razpisanieFirma.IdMarshrut);

                if(Do_Exist == null)
                {
                    context.RazpisaniqFirmis.Add(razpisanieFirma);
                    context.SaveChanges();
                }
                

            }
        }





        //метод за изтриване на информация за разписание-фирма
        public void DeleteRazpisanieFirma(int IdMarshrut)
        {
            using(context = new RazpisanieContext())
            {
                var temp = context.RazpisaniqFirmis.Find(IdMarshrut);

                if (temp != null)
                    context.RazpisaniqFirmis.Remove(temp);
                context.SaveChanges();
            }
            
        }




        //метод за обновяване на информация за разписание-фирма
        public void UpdateRazpisanieFirma(RazpisaniqFirmi razpisanieFirma)
        {
            using(context=new RazpisanieContext())
            {
                var item = context.RazpisaniqFirmis.Find(razpisanieFirma.IdMarshrut);

                if(item != null)
                {
                    context.Entry(item).CurrentValues.SetValues(razpisanieFirma);
                    context.SaveChanges();
                }
            }

                
        }




        //метод за извличане на всички записи от RazpisaniqFirmi
        public List<RazpisaniqFirmi> GetAllRazpisaniqFirmis()
        {
            using(context=new RazpisanieContext())
            {
                return context.RazpisaniqFirmis.ToList();
            }
        }






        //метод за извличане на всички записи от RazpisaniqFirmi сортирани по IdMarshrut
        public List<RazpisaniqFirmi> OrderRazpisaniqFirmiByIdMarshrut()
        {
            using (context = new RazpisanieContext())
            {
                return context.RazpisaniqFirmis.OrderBy(a=>a.IdMarshrut).ToList();
            }
        }




        //метод за извличане на всички записи от RazpisaniqFirmi сортирани по IdFirma
        public List<RazpisaniqFirmi> OrderRazpisaniqFirmiByIdFirma()
        {
            using (context = new RazpisanieContext())
            {
                return context.RazpisaniqFirmis.OrderBy(a => a.IdFirma).ToList();
            }
        }
    }
}
