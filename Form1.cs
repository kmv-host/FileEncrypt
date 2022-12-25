using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;               // Добавляем для работы программы

namespace FileEncrypt
{
    public partial class Form1 : Form
    {
        byte[] abc;             // Обьявляем глобальные переменные ?
        byte[,] table;          // Обьявляем глобальные переменные ? 
        public Form1()
        {
            InitializeComponent();
        }

        private void btBrowse_Click(object sender, EventArgs e) // обработчик кнопки " Browse"
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Multiselect= false;
            if(od.ShowDialog() == DialogResult.OK) 
            {
            tbPath.Text = od.FileName;
            }
        }

        private void rbEncrypt_CheckedChanged(object sender, EventArgs e) // Обработчик радиобаттон rbEncrypt
        {
            if(rbEncrypt.Checked) 
            {
            rbDecrypt.Checked = false;
            } 
        }

        private void rbDecrypt_CheckedChanged(object sender, EventArgs e) // Обработчик Радиобаттон rbDecrypt
        {
            if(rbDecrypt.Checked)
                rbEncrypt.Checked = false;
        }

        private void Form1_Load(object sender, EventArgs e)  // Обработчик загрузки формы 
        {
            rbEncrypt.Checked = true;
            // init abc and table
            abc = new byte[256];
            for(int i = 0; i < 256; i++)
                abc[i] = Convert.ToByte(i);
            
            table = new byte[256, 256];
            for(int i = 0; i < 256; i++)
                for(int j = 0; j < 256; j++)
                
                {
                    table[i, j] = abc[(i + j % 256)];   //  Вот здесь останов программы и косяк что ли!!!!
                }
        }

        private void btStart_Click(object sender, EventArgs e)  // Обработчик кнопки " Start"
        {
            // Check input values
            if (!File.Exists(tbPath.Text)) 
            
            {
                MessageBox.Show("File does not exist.");
                return;
            }
            if(String.IsNullOrEmpty(tbPassword.Text)) 
            {
                MessageBox.Show("Password empty. Please enter your password");
                return;
            }

            // Get file content and key for encrypt/Decrypt
            try 
            {
                byte[] fileContent = File.ReadAllBytes(tbPath.Text);
                byte[] passwordTmp = Encoding.ASCII.GetBytes(tbPassword.Text);
                byte[] keys = new byte[fileContent.Length];
                for (int i = 0; i < fileContent.Length; i++)
                    keys[i] = passwordTmp[i % passwordTmp.Length];

                // Encrypt
                byte[] result = new byte[fileContent.Length];
                if (rbEncrypt.Checked) 
                {
                    

                for(int i = 0; i < fileContent.Length; i++) 
                    {
                    byte value = fileContent[i];
                    byte key = keys[i];
                    int valueIndex = -1, keyIndex = -1;
                    for (int j = 0; j < 256; j++)
                            if (abc[j] == value) 
                            {
                                valueIndex = j;
                                break;
                            }
                    for(int j = 0; j < 256; j++)
                            if (abc[j] == key)
                            {
                                keyIndex= j;
                                break;                         // Я здесь закончил писать код время на видео 17:49
                            }
                        result[i] = table[keyIndex, valueIndex];
                    }
                }
                // Decrypt
                else 
                
                {
                for(int i = 0; i < fileContent.Length; i++) 
                    {
                    byte value = fileContent[i];
                    byte key = keys[i];
                    int valueIndex = -1, keyIndex = -1;
                    for(int j = 0; j < 256; j++)
                            if (abc[j] == key)
                            {
                                keyIndex= j;
                                break;                        
                            }
                        for (int j = 0; j < 256; j++)
                            if (table[keyIndex, j] == value)
                            {
                                valueIndex = j;
                                break;
                            }
                        result[i] = abc[valueIndex];
                    }
                }
                // Save resule to new file with the same extention
                String fileExt = Path.GetExtension(tbPath.Text);
                SaveFileDialog sd = new SaveFileDialog();
                sd.Filter = "Files (*" + fileExt + ") | *" + fileExt;
                if(sd.ShowDialog() == DialogResult.OK) 
                {
                File.WriteAllBytes(sd.FileName, result);      // Я здесь закончил писать код время на видео 22:05
                }
            }
            catch 
            {
                MessageBox.Show("File is in use.Close other program is using this file and try again.");
                return;
            }
            
        }
    }
}
