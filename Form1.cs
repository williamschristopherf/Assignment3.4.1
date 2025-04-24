using System.ComponentModel;

namespace Assignment3._4._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            BindingList<Coffee> coffees = new BindingList<Coffee>();

            coffees.Add(new Coffee() { BevName = "Folgers", CRoast = Coffee.Roast.medium, IsDecaf = true, Price = 6.00, SizeOz = 12 });
            coffees.Add(new Coffee() { BevName = "Black Rifle", CRoast = Coffee.Roast.dark, IsDecaf= false, Price = 7.00, SizeOz = 12 });   
            DataS
        }
    }
}
