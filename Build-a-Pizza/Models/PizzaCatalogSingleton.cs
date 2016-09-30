using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Build_a_Pizza.ViewModels;

namespace Build_a_Pizza.Models
{
   public class PizzaCatalogSingleton
    {
        private static PizzaCatalogSingleton _instance;
        public static PizzaCatalogSingleton Instance
        {
            get
            {
                if (_instance == null)
               _instance =  new PizzaCatalogSingleton();
                return _instance;
                
            }
        }

        #region All collections
        public ObservableCollection<PizzaModel> PizzaList { get; set; }
        public ObservableCollection<Veggies> VeggiesList { get; set; }
        public ObservableCollection<Crust> CrustsList { get; set; }
        public ObservableCollection<Sauce> SaucesList { get; set; }
        public ObservableCollection<Meat> MeatsList { get; set; }
        public ObservableCollection<Cheese> CheesesList { get; set; }

        #endregion

        #region Methods

        public void AddPizza(PizzaModel newPizza)
        {
            PizzaList.Add(newPizza);
        }

        public void DeletePizza()
        {
            if (MainPageViewModel.SelectedPizza > -1)
            {
                PizzaList.RemoveAt(MainPageViewModel.SelectedPizza);
            }
        }

        #endregion


    }
}
