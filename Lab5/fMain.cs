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
using ClassLib;
using Lab5;

namespace Lab5
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            gvBicycles.AutoGenerateColumns = false;

            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Model";
            column.Name = "Модель";
            gvBicycles.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Frame";
            column.Name = "Рама";
            gvBicycles.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Broadcast";
            column.Name = "Передачі";
            gvBicycles.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Fork";
            column.Name = "Вилка";
            gvBicycles.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Handlebars";
            column.Name = "Руль";
            gvBicycles.Columns.Add(column);

            column = new DataGridViewCheckBoxColumn();
            column.DataPropertyName = "Ring";
            column.Name = "Дзвінок";
            gvBicycles.Columns.Add(column);

            column = new DataGridViewCheckBoxColumn();
            column.DataPropertyName = "Has3Wheels";
            column.Name = "Має 3 колеса";
            gvBicycles.Columns.Add(column);

            bindSrcBicycles.Add(new Bicycle("Sport", "f12f", 124, "Fasflk", "asfqf", true, true));
            EventArgs eventArgs = new EventArgs(); OnResize(eventArgs);
        }

        private void fMain_Resize(object sender, EventArgs e)
        {
            int buttonsSize = 9 * btnAdd.Width + 3 * toolStripSeparator1.Width + 30;
            btnExit.Margin = new Padding(Width - buttonsSize, 0, 0, 0); 
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Bicycle bicycle = new Bicycle();

            fBicycle fbc = new fBicycle(bicycle);
            if(fbc.ShowDialog() == DialogResult.OK)
            {
                bindSrcBicycles.Add(bicycle);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Bicycle bicycle = (Bicycle)bindSrcBicycles.List[bindSrcBicycles.Position];

            fBicycle fbc = new fBicycle(bicycle);
            if (fbc.ShowDialog() == DialogResult.OK)
            {
                bindSrcBicycles.List[bindSrcBicycles.Position] = bicycle;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Видалити поточний запис?", "Видалення запису", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            { bindSrcBicycles.RemoveCurrent(); }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Очистити таблицю?\n\nВсі дані будуть втрачені", "Очищення даних", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)== DialogResult.OK)
                bindSrcBicycles.List.Clear();
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
            saveFileDialog.Filter = "Текстові файли (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.Title = "Зберегти дані у текстовому форматі";
            saveFileDialog.InitialDirectory = Application.StartupPath;
            StreamWriter sw;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                sw = new StreamWriter(saveFileDialog.FileName, false, Encoding.UTF8);
                try
                {
                    foreach (Bicycle bc in bindSrcBicycles.List)
                    {
                        sw.Write(bc.Model + "\t" + bc.Frame + "\t" +
                                 bc.Broadcast + "\t" + bc.Fork + "\t" + bc.Handlebars + "\t" +
                                 bc.Ring + "\t" + bc.Has3Wheels + "\t\n");
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
            saveFileDialog.Filter = "Файли даних (*.bicycles)|*.bicycles|All files (*.*)|*.*";
            saveFileDialog.Title = "Зберегти дані у бінарному форматі";
            saveFileDialog.InitialDirectory = Application.StartupPath;
            BinaryWriter bw;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                bw = new BinaryWriter(saveFileDialog.OpenFile());
                try 
                {    
                    foreach (Bicycle bc in bindSrcBicycles.List)
                    {
                        bw.Write(bc.Model);
                        bw.Write(bc.Frame);
                        bw.Write(bc.Broadcast);
                        bw.Write(bc.Fork);
                        bw.Write(bc.Handlebars);
                        bw.Write(bc.Ring);
                        bw.Write(bc.Has3Wheels);
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
            openFileDialog.Filter = "Текстові файли (*.txt)| *.txt|All files (*.*) | *.* ";
            openFileDialog.Title = "Прочитати дані у текстовому форматі";
            openFileDialog.InitialDirectory = Application.StartupPath;
            StreamReader sr;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                bindSrcBicycles.Clear(); sr = new StreamReader(openFileDialog.FileName, Encoding.UTF8);
                string s;
                try
                {
                    while ((s = sr.ReadLine()) != null)
                    {
                        string[] split = s.Split('\t');
                        Bicycle bc = new Bicycle(split[0], split[1], int.Parse(split[2]), split[3], split[4]
                            , bool.Parse(split[5]), bool.Parse(split[6]));
                        bindSrcBicycles.Add(bc);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Сталась помилка: \n{0}", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                openFileDialog.Filter = "Текстові файли (*.bicycles)| *.bicycles|All files (*.*) | *.* ";
                openFileDialog.Title = "Прочитати дані у текстовому форматі";
                openFileDialog.InitialDirectory = Application.StartupPath;
                BinaryReader br;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    bindSrcBicycles.Clear();
                    br = new BinaryReader(openFileDialog.OpenFile());
                    try
                    {
                        Bicycle bicycle;
                        while(br.BaseStream.Position < br.BaseStream.Length)
                        {
                            bicycle = new Bicycle();
                            for (int i = 0; i < 8; i++)
                            {
                                switch (i)
                                {
                                    case 1:
                                        bicycle.Model = br.ReadString();
                                        break;
                                    case 2:
                                        bicycle.Frame = br.ReadString();
                                        break;
                                    case 3:
                                        bicycle.Broadcast = br.ReadInt32();
                                        break;
                                    case 4:
                                        bicycle.Fork = br.ReadString();
                                        break;
                                    case 5:
                                        bicycle.Handlebars = br.ReadString();
                                        break;
                                    case 6:
                                        bicycle.Ring = br.ReadBoolean();
                                        break;
                                    case 7:
                                        bicycle.Has3Wheels = br.ReadBoolean();
                                        break;
                                }
                            }
                            bindSrcBicycles.Add(bicycle);
                        }
                    }    
                    catch (Exception ex)
                    {
                        MessageBox.Show("Сталась помилка: \n{0}", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        br.Close();
                    }
                }
            }
    }
}
