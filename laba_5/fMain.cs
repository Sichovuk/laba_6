using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba_5
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();

            gvPhones.AutoGenerateColumns = false;

            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Model";
            column.Name = "Модель";
            gvPhones.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Diagonal";
            column.Name = "Діагональ";
            gvPhones.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Cores";
            column.Name = "Ядра";
            column.Width = 80;
            gvPhones.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Platform";
            column.Name = "Платформа";
            gvPhones.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "SimQuantity";
            column.Name = "Кількість сім-карт";
            column.Width = 80;
            gvPhones.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "HasAI";
            column.Name = "ШІ";
            column.Width = 60;
            gvPhones.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "HasTypeC";
            column.Name = "TypeC";
            column.Width = 60;
            gvPhones.Columns.Add(column);

            bindSrcPhones.Add(new Phone("Samsung Gal. S23", "2340x1080", 8, "Android", 2, true, true));
            bindSrcPhones.Add(new Phone("Apple iPhone 15 Pro Max", "2796x1290", 10, "iOS 17", 3, true, false));
            bindSrcPhones.Add(new Phone("Xiaomi 14 Ultra", "3200x1440", 16, "Android", 3, true, true));
            bindSrcPhones.Add(new Phone("HUAWEI P60 Pro", "2340x1080", 8, "Android", 2, false, true));
            EventArgs args = new EventArgs(); OnResize(args);
        }

        private void fMain_Load(object sender, EventArgs e)
        {
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Phone phone = new Phone();

            fPhone ft = new fPhone(phone);
            if (ft.ShowDialog() == DialogResult.OK) 
            {
                bindSrcPhones.Add(phone);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Phone phone = (Phone)bindSrcPhones.List[bindSrcPhones.Position];

            fPhone ft = new fPhone(phone);
            if (ft.ShowDialog() == DialogResult.OK) 
            {
                bindSrcPhones.List[bindSrcPhones.Position] = phone;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Видалити поточний запис?", "Видалення запису", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                bindSrcPhones.RemoveCurrent();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Очистити таблицю?\n\nВсі дані будуть втрачені", "Очищення данних", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                bindSrcPhones.Clear();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Закрити застосунок?", "Вихід з програми", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btnSaveAsText_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Текстовi файли (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.Title = "Зберегти дані у текстовому форматі";
            saveFileDialog1.InitialDirectory = Application.StartupPath;
            StreamWriter sw;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                sw = new StreamWriter(saveFileDialog1.FileName, false, Encoding.UTF8);
                try
                {
                    foreach (Phone phone in bindSrcPhones.List)
                    {
                        sw.WriteLine(phone.Model + "\t" + phone.Diagonal + "\t" +
                        phone.Cores + "\t" + phone.Platform + "\t" +
                        phone.SimQuantity + "\t" + phone.HasAI + "\t" +
                        phone.HasTypeC);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Сталась помилка: \n{0}", ex.Message,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    sw.Close();
                }
            }
        }

        private void btnSaveAsBinary_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Файли даних (*.phones)|*.phones|All files (*.*)|*.*";
            saveFileDialog1.Title = "Зберегти дані у бiнарному форматі";
            saveFileDialog1.InitialDirectory = Application.StartupPath;
            BinaryWriter bw;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                bw = new BinaryWriter(saveFileDialog1.OpenFile());
                try
                {
                    foreach (Phone phone in bindSrcPhones.List)
                    {
                        bw.Write(phone.Model);
                        bw.Write(phone.Diagonal);
                        bw.Write(phone.Cores);
                        bw.Write(phone.Platform);
                        bw.Write(phone.SimQuantity);
                        bw.Write(phone.HasAI);
                        bw.Write(phone.HasTypeC);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Сталась помилка: \n{0}", ex.Message,
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    bw.Close();
                }
            }
        }

        private void btnOpenFromText_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Текстові файли (*.txt)|*.txt|All files (*.*) | *.*";
            openFileDialog.Title = "Прочитати дані у текстовому форматі";
            openFileDialog.InitialDirectory = Application.StartupPath;
            StreamReader sr;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                bindSrcPhones.Clear(); sr = new StreamReader(openFileDialog.FileName, Encoding.UTF8);
                string s;
                try
                {
                    while ((s = sr.ReadLine()) != null)
                    {
                        string[] split = s.Split('\t');
                        Phone phone= new Phone(split[0], split[1],
                        int.Parse(split[2]), split[3], int.Parse(split[4]),
                        bool.Parse(split[5]), bool.Parse(split[6]));
                        bindSrcPhones.Add(phone);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Сталась помилка: \n{0}", ex.Message,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    sr.Close();
                }
            }
        }

        private void btnOpenFromBinary_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Файли даних (*.phones)|*.phones|All files (*.*) | *.*";
            openFileDialog.Title = "Прочитати дані у бінарному форматі";
            openFileDialog.InitialDirectory = Application.StartupPath;
            BinaryReader br;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                bindSrcPhones.Clear();
                br = new BinaryReader(openFileDialog.OpenFile());
                try
                {
                    Phone phone; while (br.BaseStream.Position < br.BaseStream.Length)
                    {
                        phone = new Phone();
                        for (int i = 0; i <= 8; i++)
                        {
                            switch (i)
                            {
                                case 0:
                                    phone.Model = br.ReadString();
                                    break;
                                case 1:
                                    phone.Diagonal = br.ReadString();
                                    break;
                                case 2:
                                    phone.Cores = br.ReadInt32();
                                    break;
                                case 3:
                                    phone.Platform = br.ReadString();
                                    break;
                                case 4:
                                    phone.SimQuantity = br.ReadInt32();
                                    break;
                                case 5:
                                    phone.HasAI = br.ReadBoolean();
                                    break;
                                case 6:
                                    phone.HasTypeC = br.ReadBoolean();
                                    break;
                            }
                        }
                        bindSrcPhones.Add(phone);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Сталась помилка: \n{0}", ex.Message,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    br.Close();
                }
            }
        }
    }
}
