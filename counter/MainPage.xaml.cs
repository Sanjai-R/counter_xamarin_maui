using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace counter
{
    public partial class MainPage : ContentPage
    {
        public int count = 0;

        public string text = "count";

        public int Count
        {
            get { return count; }
            set
            {
                if (count != value)
                {
                    count = value;
                    OnPropertyChanged(nameof(Count));
                }
            }
        }

        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
        }
        
         public void increase(System.Object sender , EventArgs e)
        {
            Console.WriteLine("increased");
            Count += 1;
        }

         public void decrease(System.Object sender, EventArgs e)
        {
            Count -= 1;
        }

      
    }
}

