using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_2_DiagramEditor
{
    public partial class Form1 : Form
    {
        Data d = new Data();
        TempData td = new TempData();
        public Form1()
        {
            InitializeComponent();
            textBox_Population.Select();   
        } // Конструктор формы

        private void Form1_Load(object sender, EventArgs e) // Загрузка формы
        {
            this.Width = 312;
            d.CloneBackgroundImage = pictureBox_Diagramm.BackgroundImage.Clone();
        }

        private void button_Add_Click(object sender, EventArgs e) // Добавление кандидата
        {
            long itemp = Convert.ToInt64(textBox_HowMany.Text);
            char[] temp = textBox_HowMany.Text.ToCharArray(); //
            string stemp = textBox_HowMany.Text;  

            if (temp[0].ToString() == "0")                     
                stemp = textBox_HowMany.Text.Substring(1);    // Удаление 0 если есть спереди 
            if (++d.tempCountCandidates > d.CountCandidates)
            {
                MessageBox.Show("No more candidates");
                button_Add.Enabled = false;
                return;
            }
            if (textBox_ForWhom.Text != "" && stemp != "")              // Условие заполнения полей
            {
                d.PercentCandidate = (Convert.ToDouble(stemp) * 100.0) / d.CountPopulation; // Процент голосов кандидата
                d.tempCountPopulation -= Convert.ToInt64(stemp);                          // Остаток изберателей
                d.EditPoulation.Add(stemp); // Добавляем голоса за кандидата

                listBox_List.Items.Add(textBox_ForWhom.Text + ":" + d.PercentCandidate.ToString("0.00") + "% "); // Запись в ListBox
                textBox_ForWhom.Text = ""; // Обнуление полей
                textBox_HowMany.Text = "0";//
                listBox_List.Select(); // Нужно для включения кнопки Reset
            }
            else
                MessageBox.Show("Некоторые поля пустые заполните пожалуйста все поля"); // При не за полненых полях
            textBox_ForWhom.Select();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e) // Проверка на символы и Проверка на Enter
        {
            if (Char.IsDigit(e.KeyChar)) 
                return;
            else
                e.Handled = true;
            if (e.KeyChar == (char)Keys.Enter)
                textBox_HowManyCandidates.Select();
            if (e.KeyChar == (char)Keys.Back && textBox_Population.Text.Length > 0)
            {
                textBox_Population.Text = textBox_Population.Text.Substring(0, textBox_Population.Text.Length - 1);
                textBox_Population.SelectionStart = textBox_Population.Text.Length;
            }
        }

        private void textBox_HowMany_KeyPress(object sender, KeyPressEventArgs e) // Проверка на символы и Проверка на Enter
        {
            if (Char.IsDigit(e.KeyChar))
                return;
            else
                e.Handled = true;
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (button_Add.Visible == true)
                    button_Add.PerformClick();
                else
                    button_Edit.PerformClick();
            } 
            if (e.KeyChar == (char)Keys.Back && textBox_HowMany.Text.Length > 1)
            {
                textBox_HowMany.Text = textBox_HowMany.Text.Substring(0, textBox_HowMany.Text.Length - 1);
                textBox_HowMany.SelectionStart = textBox_HowMany.Text.Length;
            }
            if (e.KeyChar == (char)Keys.Back && textBox_HowMany.Text.Length == 1)
            {
                textBox_HowMany.Text = "0";
                textBox_HowMany.SelectionStart = textBox_HowMany.Text.Length;
            }
        }

        private void textBox_HowManyCandidates_KeyPress(object sender, KeyPressEventArgs e) // Проверка на символы и Проверка на Enter
        {
            if (Char.IsDigit(e.KeyChar))
                return;
            else
                e.Handled = true;
            if (e.KeyChar == (char)Keys.Enter)
                button_SavePopulation.PerformClick();
            if (e.KeyChar == (char)Keys.Back && textBox_HowManyCandidates.Text.Length > 0)
            {
                textBox_HowManyCandidates.Text = textBox_HowManyCandidates.Text.Substring(0, textBox_HowManyCandidates.Text.Length - 1);
                textBox_HowManyCandidates.SelectionStart = textBox_HowManyCandidates.Text.Length;
            }
        }

        private void textBox_ForWhom_KeyPress(object sender, KeyPressEventArgs e) // Проверка на Enter
        {
            if (e.KeyChar == (char)Keys.Enter)
                textBox_HowMany.Select();
            if (e.KeyChar == (char)Keys.Back && textBox_ForWhom.Text.Length > 0)
            {
                textBox_ForWhom.Text = textBox_ForWhom.Text.Substring(0, textBox_ForWhom.Text.Length - 1);
                textBox_ForWhom.SelectionStart = textBox_ForWhom.Text.Length;
            }
        }

        private void button_SavePopulation_Click(object sender, EventArgs e) // Сохранение населения, кандидатов и активацыя полей
        {
            if (textBox_Population.Text != "" && textBox_HowManyCandidates.Text != "")
            {
                char[] tempPopulation = textBox_Population.Text.ToCharArray();   // Для проверки на первый 0
                char[] tempCandidates = textBox_HowManyCandidates.Text.ToCharArray();//
                if (textBox_Population.Text == "0" || textBox_HowManyCandidates.Text == "0") // Проверка полей на 0
                {
                    MessageBox.Show(@"Golf Electorates empty Please enter data OR(AND)       
                Golf Candidates empty Please enter data");
                    return;
                }
                else if (tempPopulation[0] != '0') // Сохранение если нету первого 0 для изберателей
                {
                    d.tempCountPopulation = d.CountPopulation = Convert.ToInt64(textBox_Population.Text);
                    label_Eopulation.Visible = false;
                    textBox_Population.Visible = false;
                    button_SavePopulation.Visible = false;
                    label_HowManyCandidates.Visible = false;
                    textBox_HowManyCandidates.Visible = false;
                    labelForWhom.Visible = true;
                    textBox_ForWhom.Visible = true;
                    labelHowMany.Visible = true;
                    textBox_HowMany.Visible = true;
                    button_Add.Visible = true;
                    listBox_List.Visible = true;
                }
                else // Сохранение если есть спереди ноль для изберателей
                {
                    string stemp = textBox_Population.Text.Substring(1); // Удаление ноля
                    d.tempCountPopulation = d.CountPopulation = Convert.ToInt32(stemp);
                    label_Eopulation.Visible = false;
                    textBox_Population.Visible = false;
                    button_SavePopulation.Visible = false;
                    label_HowManyCandidates.Visible = false;
                    textBox_HowManyCandidates.Visible = false;
                    labelForWhom.Visible = true;
                    textBox_ForWhom.Visible = true;
                    labelHowMany.Visible = true;
                    textBox_HowMany.Visible = true;
                }
                if (tempCandidates[0] != '0') // Сохранение если нету спереди ноля для кандидатов
                    d.CountCandidates = Convert.ToInt32(textBox_HowManyCandidates.Text.ToString());
                else // Сохранение если есть спереди ноль для кандидатов
                {
                    string stemp = textBox_HowManyCandidates.Text.Substring(1); // Удаление ноля
                    d.CountCandidates = Convert.ToInt32(stemp);
                }

                textBox_ForWhom.Select(); // Активация поля ФИО кандидата
                this.Width = 786;
            }
            else
                MessageBox.Show("Некоторые поля пустые заполните пожалуйста все поля"); // При не за полненых полях
        }

        private void textBox_Population_TextChanged(object sender, EventArgs e) // Активация поля кандидатов 
        {
            textBox_HowManyCandidates.Enabled = true;
        }

        private void textBox_HowManyCandidates_TextChanged(object sender, EventArgs e) // Активация кнопки Save
        {
            button_SavePopulation.Enabled = true;
        }  

        private void textBox_HowMany_TextChanged(object sender, EventArgs e) // Проверка на количество изберателей
        {
            long temp = Convert.ToInt64(textBox_HowMany.Text);
            if (temp > d.tempCountPopulation)
            {
                MessageBox.Show("Not enough population in the country remains = " + d.tempCountPopulation + " people");
                button_Add.Enabled = false;
                textBox_HowMany.Text = "0";
                textBox_HowMany.SelectionStart = textBox_HowMany.Text.Length;
            }
            else
                button_Add.Enabled = true;
        }

        private void textBox_ForWhom_TextChanged(object sender, EventArgs e) // Проверка на количество кандидатов
        {
            if (d.tempCountCandidates >= d.CountCandidates)
            {
                button_Add.Enabled = false;
                textBox_HowMany.Enabled = false;
                textBox_ForWhom.Enabled = false;
                MessageBox.Show("No more candidates");
            }
            else
                textBox_HowMany.Enabled = true;
        }

        private void button_FullReset_Click(object sender, EventArgs e) // Сброс программы до самого начала
        {
            d.flag = 0;
            d.ClearData();
            td.ClearData();
            textBox_Population.Text = "";
            listBox_List.Items.Clear();
            textBox_ForWhom.Clear();
            textBox_HowMany.Text = "0";
            d.tempCountCandidates = 0;
            textBox_HowManyCandidates.Clear();

            d.tempCountPopulation = d.CountPopulation = 0;
            label_Eopulation.Visible = true;
            textBox_Population.Visible = true;
            button_SavePopulation.Visible = true;
            label_HowManyCandidates.Visible = true;
            textBox_HowManyCandidates.Visible = true;
            labelForWhom.Visible = false;
            textBox_ForWhom.Visible = false;
            labelHowMany.Visible = false;
            textBox_HowMany.Visible = false;
            button_Add.Enabled = false;
            button_Add.Visible = false;
            listBox_List.Visible = false;
            button_SavePopulation.Enabled = false;
            textBox_HowManyCandidates.Enabled = false;
            textBox_ForWhom.Enabled = true; // Активация поля ФИО
            button_Edit.Visible = false; // Деактивация кнопки Edit
            
            textBox_Population.Select(); // Ставим курсор на поле количество изберателей
            this.Width = 312;            // Уменьшение формы
            button_Reset.Visible = false; // Деактивация кнопки Reset
            button_Draw.Visible = false;  // Деактивация кнопки Draw
            pictureBox_Diagramm.BackgroundImage = d.CloneBackgroundImage as Image; // Стирание диаграмм
            button_FullReset.Location = new Point(12, 407); // Задание координаты отсчета
            button_FullReset.Width = 254; // Изменение размеров 
            button_FullReset.Height = 47; //                    кнопки FullReset
            d.EditPoulation.Clear(); // Очищаем временное хранилище голосов за кандидатов
        }

        private void listBox_List_Enter(object sender, EventArgs e) // Активация кнопки Reset и Draw
        {
            button_Reset.Visible = true;
            button_Draw.Visible = true;
            button_FullReset.Location = new Point(137, 431); // Задание координаты отсчета
            //button_FullReset.Location = new System.Drawing.Point(X, Y); // На всякий случай
            button_FullReset.Width = 128; // Изменение размеров 
            button_FullReset.Height = 23; //                    кнопки FullReset
        }

        private void button_Reset_Click(object sender, EventArgs e) // Очистка списка
        {
            d.flag = 0;
            d.ClearData();
            td.ClearData();
            listBox_List.Items.Clear();   // Очистка ListBox
            button_Reset.Visible = false; // Деактивация кнопки Reset
            button_Edit.Visible = false; // Деактивация кнопки Edit
            button_Draw.Visible = false;  // Деактивация кнопки Draw
            textBox_ForWhom.Enabled = true; // Активация поля ФИО
            textBox_ForWhom.Select(); // Ставим курсор на ФИО
            d.tempCountPopulation = d.CountPopulation; // Возвращение tempCountPopulation к первоначальному значению
            d.tempCountCandidates = 0;      // Обнуление подсчитаных кандидатов
            button_FullReset.Location = new Point(12, 407); // Задание координаты отсчета
            button_FullReset.Width = 254; // Изменение размеров 
            button_FullReset.Height = 47; //                    кнопки FullReset
            pictureBox_Diagramm.BackgroundImage = d.CloneBackgroundImage as Image; // Стирание диаграмм
            textBox_ForWhom.Clear();    // Обнуление полей
            textBox_HowMany.Text = "0"; //
            d.EditPoulation.Clear(); // Очищаем временное хранилище голосов за кандидатов
        }

        private void button_Draw_Click(object sender, EventArgs e) // Построить диаграмму кнопка Draw
        {
            int n = listBox_List.Items.Count; // Количество подсчитаных кандидатов
            string[] tempPerc = new string[2]; // Временно для процента
            d.names = new string[n]; // Фио
            d.Percents = new double[n]; // Процент
            for (int i = 0; i < n; i++)
            {
                d.temp = listBox_List.Items[i].ToString().Split(':'); //
                d.names[i] = d.temp[0];                               // Присвоение данных
                tempPerc = d.temp[1].Split('%');                      //
                d.Percents[i] = Convert.ToDouble(tempPerc[0]);        //
            }
            d.flag = 1; // Флаг для срабатывания отрисовки
            d.ClearData();
            td.ClearData();
            pictureBox_Diagramm.Invalidate(); // Перерисовка
            d.YRecDiagram = pictureBox_Diagramm.Size.Height / 2;
            timer1.Start();
        }

        private void pictureBox_Diagramm_Paint(object sender, PaintEventArgs e) // Событие рисования
        {
            switch (d.flag)
            {
                case 1:
                    DrowDiafram(e.Graphics);
                    break;
                default:
                    break;
            }
            
        }

        public void DrowDiafram(Graphics g) // Метод который будет рисовать диаграммы
        {
            d.n = listBox_List.Items.Count; // Количество подсчитаных кандидатов
            g.Clear(this.BackColor); // Если нужно убрать задний фон на диаграмме
            d.p = new Pen(Color.Black, 3);
            g.DrawLine(d.p, 0, pictureBox_Diagramm.Size.Height / 2, pictureBox_Diagramm.Size.Width, pictureBox_Diagramm.Size.Height / 2); // Рисуем линию
            g.DrawLine(d.p, pictureBox_Diagramm.Size.Width / 2, pictureBox_Diagramm.Size.Height / 2, pictureBox_Diagramm.Size.Width / 2, pictureBox_Diagramm.Size.Height); // Рисуем линию

            d.OnePercentCircle = d.OnePercentRectangle = 0;
            foreach (var Percent in d.Percents) // Сумируем все проценты 
                d.OnePercentCircle = d.OnePercentRectangle += (float)Percent;
            if (d.OnePercentCircle == 0)
                d.OnePercentCircle = d.OnePercentRectangle = 0.01f;
            else
            {
                d.OnePercentRectangle = (float)200 / d.OnePercentRectangle;
                d.OnePercentCircle = (float)360 / d.OnePercentCircle; // Получаем сколько градусов занимает один процент
            }
            d.Width = ((pictureBox_Diagramm.Size.Width - (15 * (d.n - 1)) - 20) / d.n); // Ширина колонки

            d.Y = pictureBox_Diagramm.Size.Height / 2 + 10;
            for (int i = 0; i < d.n; i++) // Вывод на экран ФИО и цвет
            {
                g.DrawString(d.names[i] + " : " + d.Percents[i].ToString() + "%", new Font("Arial", 12), new SolidBrush(Color.FromName(d.Colors[i])), (pictureBox_Diagramm.Size.Width / 2) + 10, d.Y); // ФИО
                d.r = new Rectangle(pictureBox_Diagramm.Size.Width - 20, d.Y, 10, 10); // Выбираем прямоугольник
                d.b1 = new SolidBrush(Color.FromName(d.Colors[i]));
                g.FillRectangle(d.b1, d.r); // Рисуем поле 
                d.Y += 15; // Переходим на новую строку
            }

            for (int i = 0; i < d.i; i++) // Цикл для перерисовки уже отрисованых графиков
            {
                g.DrawString(d.Percents[i].ToString("0.00") + "%", new Font("Arial", 11), new SolidBrush(Color.FromName(d.Colors[i])), td.arrtd[i].X + d.Width / 3, 6); // Ставим над колонкой процент

                if (td.arrtd[i].Height == 0) // Если 0%
                {
                    d.p = new Pen(Color.FromName(d.Colors[i]), 4);
                    g.DrawLine(d.p, td.arrtd[i].X, td.arrtd[i].YRecDiagram, td.arrtd[i].X + d.Width, td.arrtd[i].YRecDiagram);
                }
                else
                {
                    d.r = new Rectangle(td.arrtd[i].X, td.arrtd[i].YRecDiagram, d.Width, pictureBox_Diagramm.Height / 2 - td.arrtd[i].YRecDiagram + 1); // Выбираем прямоугольник
                    d.b1 = new LinearGradientBrush(d.r, Color.White, Color.FromName(d.Colors[i]), 270); // Цветовой градиент
                    g.FillRectangle(d.b1, d.r); // Рисуем поле
                }

                d.r = new Rectangle(0, pictureBox_Diagramm.Size.Height / 2, pictureBox_Diagramm.Size.Width / 2, pictureBox_Diagramm.Size.Height / 2); // Выбираем прямоугольник для круга
                d.b1 = new SolidBrush(Color.FromName(d.Colors[i])); // Присвоение своего цвета
                g.FillPie(d.b1, d.r, td.arrtd[i].firstAngle, td.arrtd[i].fullAngle); // Отрисовываем
            }
            if (d.i < d.n)
            {
                if (d.YRecDiagram >= (pictureBox_Diagramm.Size.Height / 2 - d.Height))
                {
                    d.Height = Convert.ToInt32(d.Percents[d.i] * d.OnePercentRectangle); // Высота колонки
                    d.ScorePercent += (float)d.Percents[d.i] * d.OnePercentRectangle / d.Height / 2;
                    g.DrawString(d.ScorePercent.ToString("0.00") + "%", new Font("Arial", 11), new SolidBrush(Color.FromName(d.Colors[d.i])), d.X + d.Width / 3, 6); // Ставим над колонкой процент
                    if (d.Height == 0) // Если 0%
                    {
                        d.p = new Pen(Color.FromName(d.Colors[d.i]), 4);
                        g.DrawLine(d.p, d.X, d.YRecDiagram, d.X + d.Width, d.YRecDiagram);
                    }
                    else
                    {
                        d.r = new Rectangle(d.X, d.YRecDiagram, d.Width, pictureBox_Diagramm.Height / 2 - d.YRecDiagram + 1); // Выбираем прямоугольник
                        d.b1 = new LinearGradientBrush(d.r, Color.White, Color.FromName(d.Colors[d.i]), 270); // Цветовой градиент
                        g.FillRectangle(d.b1, d.r); // Рисуем поле
                    }
                    d.YRecDiagram--;

                    d.fullAngle = (float)d.Percents[d.i] * d.OnePercentCircle; //Какой угол для конкретного кандидата
                    if (d.Height == 0)
                        d.lastAngle = d.fullAngle;
                    if (d.lastAngle == 0 && d.Height > 0)
                        d.lastAngle = d.fullAngle / d.Height;

                    d.r = new Rectangle(0, pictureBox_Diagramm.Size.Height / 2, pictureBox_Diagramm.Size.Width / 2, pictureBox_Diagramm.Size.Height / 2); // Выбираем прямоугольник для круга
                    d.b1 = new SolidBrush(Color.FromName(d.Colors[d.i])); // Присвоение своего цвета
                    g.FillPie(d.b1, d.r, d.firstAngle, d.lastAngle); // Отрисовываем
                    d.lastAngle += d.fullAngle / d.Height; // Переставляем первую точку на следующую позицию

                }
                else
                {
                    td.arrtd.Add(new TempData { YRecDiagram = d.YRecDiagram, X = d.X, Height = d.Height, firstAngle = d.firstAngle,
                                                fullAngle = d.fullAngle , ScorePercent = d.ScorePercent});
                    d.i++;
                    d.YRecDiagram = pictureBox_Diagramm.Size.Height / 2;
                    d.X += d.Width + d.WidthwidthTheGap; // Следующая колонка
                    d.firstAngle += d.fullAngle;
                    d.lastAngle = 0;
                    d.ScorePercent = 0;
                }
            }
            else
            {
                td.arrtd.Add(new TempData { YRecDiagram = d.YRecDiagram, X = d.X, Height = d.Height, firstAngle = d.firstAngle, fullAngle = d.fullAngle });
                timer1.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox_Diagramm.Invalidate(); // Перерисовка
        }

        private void listBox_List_DoubleClick(object sender, EventArgs e)
        {
            textBox_ForWhom.Enabled = true; // Демлаем поле ввода ФИО активны
            d.tempCountCandidates--; // Временно уменшаем количество подсчитаных кандидатов
            d.tempCountPopulation += Convert.ToInt64(d.EditPoulation[listBox_List.SelectedIndex]);// Временно уменшаем количество подсчитаных голосов
            string[] tempPerc = new string[2]; // Временно для процента
            d.temp = listBox_List.SelectedItem.ToString().Split(':');    //
            textBox_ForWhom.Text = d.temp[0];
            textBox_HowMany.Text = d.EditPoulation[listBox_List.SelectedIndex];// Присвоение данных
            textBox_ForWhom.Select(); // Ставим курсор на поле ФИО
            textBox_ForWhom.SelectionStart = textBox_ForWhom.Text.Length; // Передвигаем курсор в конец строки
            button_Edit.Visible = true;
            button_Add.Visible = false;
        }

        private void button_Edit_Click(object sender, EventArgs e)
        {
            long itemp = Convert.ToInt64(textBox_HowMany.Text);
            char[] temp = textBox_HowMany.Text.ToCharArray(); //
            string stemp = textBox_HowMany.Text;

            if (temp[0].ToString() == "0")
                stemp = textBox_HowMany.Text.Substring(1);    // Удаление 0 если есть спереди 
            if (++d.tempCountCandidates > d.CountCandidates)
            {
                MessageBox.Show("No more candidates");
                button_Add.Enabled = false;
                return;
            }
            if (textBox_ForWhom.Text != "" && stemp != "")              // Условие заполнения полей
            {
                d.PercentCandidate = (Convert.ToDouble(stemp) * 100.0) / d.CountPopulation; // Процент голосов кандидата
                d.tempCountPopulation -= Convert.ToInt64(stemp);                          // Остаток изберателей
                d.EditPoulation[listBox_List.SelectedIndex] = stemp; // Добавляем голоса за кандидата

                int i = listBox_List.SelectedIndex;
                listBox_List.Items.RemoveAt(listBox_List.SelectedIndex);
                listBox_List.Items.Insert(i, textBox_ForWhom.Text + ":" + d.PercentCandidate.ToString("0.00") + "%"); // Запись в ListBox

                textBox_ForWhom.Text = ""; // Обнуление полей
                textBox_HowMany.Text = "0";//
                listBox_List.Select(); // Нужно для включения кнопки Reset
            }
            else
                MessageBox.Show("Некоторые поля пустые заполните пожалуйста все поля"); // При не за полненых полях
            textBox_ForWhom.Select();
            button_Edit.Visible = false;
            button_Add.Visible = true;
        }

    }
    class Data
    {
        public int CountCandidates = 0; // Количество кандидатов
        public int tempCountCandidates = 0; // Подсчитаные кандидаты
        public string[] names; // ФИО кандидата
        public double[] Percents; // Проценты
        public string[] temp = new string[2]; // Временная переменная для хранения записи голосования
        public long CountPopulation = 0; // Количесто изберателей
        public long tempCountPopulation = 0; // Остаток изберателей
        public List<string> EditPoulation = new List<string>(); // Будит хранить количество людей за конкретного кандидата
        public double PercentCandidate = 0; // Процент за кандидата
        public int flag = 0; // Флаг
        public object CloneBackgroundImage;
        public string[] Colors = { @"Blue", "Gold", "Green", "SaddleBrown", "IndianRed", "DarkGreen", "Red", "Magenta",
                                "Purple", "Orang", "SpringGreen", "GreenYellow", "Cyane", "LightCoral"};
        public int Height = 0, Width = 0, Y = 0, YRecDiagram = 0, WidthwidthTheGap = 15, X = 10; // Нужны для определения координат прямоугольников
        public float OnePercentRectangle = 0;
        public float ScorePercent = 0; // Временный процент для роста диаграмы 

        public float fullAngle = 0, firstAngle = 0, lastAngle = 0, OnePercentCircle = 0; // Углы для круглой диаграммы
        public int n = 0; // Количество подсчитаных кандидатов
        public int i = 0; // Для таймера 
        public Rectangle r; // Прямоугольник
        public Brush b1; // Заливка
        public Pen p; // Каранлдаш
        public void ClearData()
        {
            Height = Width = Y = 0;
            WidthwidthTheGap = 15;
            X = 10;
            OnePercentRectangle = 0;
            firstAngle = lastAngle = OnePercentCircle = 0;
            n = i = 0;
        }
    }
    class TempData
    {
        public int Height = 0, YRecDiagram = 0, X = 0;
        public float firstAngle = 0, fullAngle = 0, ScorePercent = 0;
        public List <TempData> arrtd = new List<TempData>();
        public void ClearData()
        {
            Height = YRecDiagram = X = 0;
            firstAngle = fullAngle = ScorePercent = 0;
            arrtd.Clear();
        }
    }
}