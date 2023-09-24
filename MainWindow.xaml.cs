using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
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

namespace _24._09._2023_Введение_в_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string[] mas_answer;

        public MainWindow() {
            InitializeComponent();

            answer.IsEnabled = false;

            mas_answer = new string[] { "Бесспорно", "Предрешено", "Никаких сомнений","Определённо да",
            "Можешь быть уверен в этом", "Мне кажется — «да»","Вероятнее всего","Хорошие перспективы","Знаки говорят — «да»","Да",
            "Пока не ясно, попробуй снова","Спроси позже", "Лучше не рассказывать", "Сейчас нельзя предсказать","Сконцентрируйся и спроси опять",
            "Даже не думай","Мой ответ — «нет»","По моим данным — «нет»","Перспективы не очень хорошие","Весьма сомнительно" };            
        }

        private void answer_Click(object sender, RoutedEventArgs e) {
            textBox.Clear();
            answer.IsEnabled = false;
            Random random = new Random();
            textBlock.Text = mas_answer[random.Next(0, mas_answer.Length)];
        }

        private void textBox_KeyUp(object sender, KeyEventArgs e) {
            answer.IsEnabled = true;
        }
    }
}
