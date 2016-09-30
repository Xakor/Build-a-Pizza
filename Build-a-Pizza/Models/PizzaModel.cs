using System.Reflection;

namespace Build_a_Pizza.Models
{
    public class PizzaModel
    {
        public float SubTotalPrice;
        public Sauce Sauce;
        public Crust Crust;
        public Meat Meat;
        public Veggies Veggies;
        public Cheese Cheese;


        public PizzaModel()
        {
        }

        public PizzaModel( float subtotal, Sauce sauce, Crust crust, Meat meat, Veggies veggies, Cheese cheese)
        {
            subtotal = Sauce.Price + Crust.Price + Veggies.Price + Cheese.Price + Meat.Price;
            SubTotalPrice = subtotal;
            Sauce = sauce;
            Crust = crust;
            Meat = meat;
            Veggies = veggies;
            Cheese = cheese;
        }
    }
}