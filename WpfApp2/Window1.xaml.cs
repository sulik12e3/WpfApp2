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
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
          ///  cmbgenre.ItemsSource = Connectdb.db.Genre.Select(itemG => itemG.Name).ToList();

        }
   
        private void save_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Videotapes vs = new Videotapes();
                vs.NameTapes = txbNameT.Text;
                vs.Quantity = Convert.ToInt32(Txbquantity);
                vs.QuantityAviable = Convert.ToInt32(TXBAVIABLE);
                vs.Genre.Name = txbgenre.Text;
                
                Connectdb.db.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Добавление прошло успешно", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
