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

namespace pr_9
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Subscriber subscriber1;
        Subscriber subscriber2;
        Subscriber subscriber3;
        Subscriber subscriber4;
        Subscriber subscriber5;
        Subscriber subscriber6;
        Subscriber subscriber7;

        Subscriber[] subscribers;

        public MainWindow()
        {
            InitializeComponent();

            subscriber1 = new Subscriber("Филиппов М. А.", "+7(3565)446-75-37", "ул. Будапештсткая");
            subscriber2 = new Subscriber("Карасев Е. М.", "+530(481)346-73-94", "ул. Космонавтов");
            subscriber3 = new Subscriber("Коршунов И. Д.", "+908(1880)403-16-81", "ул. Домодедовская");
            subscriber4 = new Subscriber("Колесова Е. Я.", "+7(6377)194-63-84", "ул. Сталина");
            subscriber5 = new Subscriber("Иванов Ф. Г.", "+6(620)456-12-14", "ул. Ленина");
            subscriber6 = new Subscriber("Федорова Д. Д.", "+8(48)875-00-07", "ул. Гагарина");
            subscriber7 = new Subscriber("Гусева А. А.", "+37(77)524-48-27", "ул. Гоголя");

            listBox.Items.Add($"{subscriber1.Name} | {subscriber1.PhoneNumber} | {subscriber1.Address}");
            listBox.Items.Add($"{subscriber2.Name} | {subscriber2.PhoneNumber} | {subscriber2.Address}");
            listBox.Items.Add($"{subscriber3.Name} | {subscriber3.PhoneNumber} | {subscriber3.Address}");
            listBox.Items.Add($"{subscriber4.Name} | {subscriber4.PhoneNumber} | {subscriber4.Address}");
            listBox.Items.Add($"{subscriber5.Name} | {subscriber5.PhoneNumber} | {subscriber5.Address}");
            listBox.Items.Add($"{subscriber6.Name} | {subscriber6.PhoneNumber} | {subscriber6.Address}");
            listBox.Items.Add($"{subscriber7.Name} | {subscriber7.PhoneNumber} | {subscriber7.Address}");
        }

        struct Subscriber
        {
            public string Name { get; set; }
            public string PhoneNumber { get; set; }
            public string Address { get; set; }

            public Subscriber(string name, string phoneNumber, string address)
            {
                Name = name;
                PhoneNumber = phoneNumber;
                Address = address;
            }
        }

        private void find_Click(object sender, RoutedEventArgs e)
        {
            subscribers = new[] { subscriber1, subscriber2, subscriber3,subscriber4,subscriber5,subscriber6,subscriber7 };
            string findItem = inputAddress.Text;
            for (int i = 0; i < subscribers.Length; i++)
            {
                if (subscribers[i].Address.Contains(findItem))
                    MessageBox.Show($"{subscribers[i].Name} | {subscribers[i].PhoneNumber} | {subscribers[i].Address}");
            }
        }

        private void about_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Практическая работа №9\n" +
                "Даанов Шахмар  ИСП-34\n" +
                "Заполнить таблицу со списком телефонных абонентов на 7 человек с полями: ФИО, номер телефона, адрес. " +
                "Вывести результат на экран. Вывести список абонентов живущих на заданной улице.", "О программе", MessageBoxButton.OK);
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
