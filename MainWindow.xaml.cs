using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using System.Windows.Threading;
using System.Diagnostics;

namespace cool
{

    public partial class MainWindow : Window
    { 
        //long? memory = 0;
       int red,grn,blu=100;
        
        DispatcherTimer dt = new DispatcherTimer();
        Stopwatch sw = new Stopwatch();

        public MainWindow()
        {
            InitializeComponent();
            dt.Tick += new EventHandler(dt_Tick);
            dt.Interval = new TimeSpan(0, 0, 0, 1, 0);//event after one sec
        }
        public void dt_Tick(object sender, EventArgs e)
        {

            TimeSpan ts = sw.Elapsed;
            
                
                

            DateTime now = DateTime.Now;
            
            string now1 = Convert.ToString(now);
            now1 = String.Format("{0:T}", now);//:{1:00}:{2:00}",

            //now.Hour, now.Minute, now.Second);
            Random h = new Random();
            GC.Collect();//garbage collecter
            int yes1 = h.Next(2, 999999999);
            if (yes1 % 2 == 0 && red >= 10)
            {
                red = red - 10;
            }
            else if (red <245 ) { red = red + 10; }


            int yes = h.Next(2, 999999999);
            if (yes % 2 == 0 && grn >= 10)
            {
                grn = grn - 10;
            }
            else if (grn < 245) { grn = grn + 10; }




            int yes2 = h.Next(2, 999999999);
            if (yes2 % 2 == 0 && blu >= 10)
            {
                blu = blu - 10;
            }
            else if (blu < 245) { blu = blu + 10; }




            grid1.Background = new SolidColorBrush(Color.FromRgb(Convert.ToByte(red), Convert.ToByte(grn), Convert.ToByte(blu)));
           

            clock.Text = Convert.ToString(now1);
            redbar.Width = red;
            grnbar.Width = grn;
            blubar.Width = blu;
            
           
        }

        

       

        private void clock_TextChanged(object sender, TextChangedEventArgs e)
        { dt.Start();

        
        GC.Collect();//garbage collecter

        }

      
            
        
     
    }
}


  


      