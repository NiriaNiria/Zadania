using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        private List<TaskItem> tasks = new List<TaskItem>();
        private string filePath = "tasks.txt";
        public Form1()
        {
            InitializeComponent();
            cmbPriority.Items.Add("Ważne");
            cmbPriority.Items.Add("Standard");
            cmbPriority.Items.Add("Niezbyt wazne");
            cmbPriority.SelectedIndex = 0;
            LoadTasks();
        }

       

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Wpisz nazwe zadania");
                return;
            }
            string name = txtName.Text;
            string priority = cmbPriority.SelectedItem.ToString();
            TaskItem task = new TaskItem(name, priority);
            tasks.Add(task);
            ZADANIA.Items.Add(task);
            txtName.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if(ZADANIA.SelectedItem != null)
            {
                ZADANIA.Items.Remove(ZADANIA.SelectedItem);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> lines = new List<string>();
            foreach(TaskItem t in tasks)
            {
                lines.Add(t.Name + ";" + t.Priority);
               
            }
            File.WriteAllLines(filePath, lines);
            MessageBox.Show("Zapisano do pliku!");
        }
        private void LoadTasks()
        {
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach(string line in lines){
                    string[] parts = line.Split(';');
                    if (parts.Length == 2)
                    {
                        TaskItem task = new TaskItem(parts[0], parts[1]);
                        tasks.Add(task);
                        ZADANIA.Items.Add(task);
                    }
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBoxTasks_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
