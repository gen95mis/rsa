using System;
using System.Windows;

namespace RSA
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void btn_process_Click(object sender, RoutedEventArgs e)
        {
            int xmax = Convert.ToInt32(tb_xmax.Text);
            int xmin = Convert.ToInt32(tb_xmin.Text);
            long np = Convert.ToInt64(tb_np.Text);
            long nq = Convert.ToInt64(tb_nq.Text);
            long pow = Convert.ToInt64(tb_pow.Text);


            Random random = new Random();
            long num = random.Next(xmin, xmax);
            long mod = np * nq;

             Сipher.RSA rsa = new Сipher.RSA(num, pow, mod);

            MessageBox.Show(rsa.DeltaX + " - " + rsa.DeltaY);
            rsa.DeltaX = 32;
            MessageBox.Show(rsa.DeltaX + " - " + rsa.DeltaY);
        }
    }
}
