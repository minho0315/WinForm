using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleWindow
{
    
    class MainApp : Form
    {
        static void Main(string[] args)
        {
            MainApp form = new MainApp();
            form.Click += new EventHandler(
                (sender, eventArgs) =>
                {
                    Console.WriteLine("Closing Window...");
                    Application.Exit();
                });
            Console.WriteLine("Starting Window Application...");
            Application.Run(form);
            Console.WriteLine("Exiting Window Application...");
            Console.ReadLine();
        }
    }
}

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace SimpleWindow
//{
//    class MyForm : Form
//    {

//    }
//    class MainApp 
//    {
//        static void Main(string[] args)
//        {
//            MyForm form = new MyForm();
//            form.Click += new EventHandler(
//                (sender, eventArgs) =>
//                {
//                    Application.Exit();
//                });
//            Application.Run(form);
//        }
//    }
//}

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace SimpleWindow
//{
//    class MainApp : Form
//    {
//        static void Main(string[] args)
//        {
//            Application.Run(new MainApp());
//        }
//    }
//}
