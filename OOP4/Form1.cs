using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP4
{
    public partial class Form1 : Form
    {
        private Explorer temp = new Explorer();
        string path;
        public Form1()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            
            InitializeComponent();
            this.BackColor = Color.Transparent;
        }
           
        private void comboBoxListOfDrives_SelectedIndexChanged(object sender, EventArgs e)
        {
            listDriveFiles.Items.Clear();
            listDriveDirectories.Items.Clear();
            labelCurrentDriveClick_Click(sender, e);
            labelDriveCapacityClick_Click(sender, e);
            labelFreeSpaceClick_Click(sender, e);
            labelDriveTypeClick_Click(sender, e);
            string[] directorieslist = temp.GetDirectoriesList(comboBoxListOfDrives.Text);
            for(int i = 0; i < directorieslist.Length; i++)
            {
                listDriveDirectories.Items.Add(directorieslist[i]);
            }
            string[] fileslist = temp.GetFilesList(comboBoxListOfDrives.Text);
            for (int i = 0; i < fileslist.Length; i++)
            {
                listDriveFiles.Items.Add(fileslist[i]);
            }
            path = comboBoxListOfDrives.Text;
            path = path.Remove(path.Length - 1, 1);

        }

        private void buttonRefreshDrives_Click(object sender, EventArgs e)
        {
            comboBoxListOfDrives.Items.Clear();
            string[] DriveList = temp.GetDrivesList();
            for(int i = 0; i < DriveList.Length; i++)
            {
                comboBoxListOfDrives.Items.Add(DriveList[i]);
            }
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buttonRefreshDrives_Click(sender, e);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelCurrentDriveClick_Click(object sender, EventArgs e)
        {
            string temp = comboBoxListOfDrives.Text;
            if (temp.Length > 0)
            temp = temp.Remove(temp.Length-2,2);
            labelCurrentDriveClick.Text = temp;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void labelDriveCapacityClick_Click(object sender, EventArgs e)
        {
            labelDriveCapacityClick.Text = temp.GetDriveCapacity(comboBoxListOfDrives.Text);
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void labelFreeSpaceClick_Click(object sender, EventArgs e)
        {
            labelFreeSpaceClick.Text = temp.GetFreeDriveCapacity(comboBoxListOfDrives.Text);
        }

        private void labelDriveTypeClick_Click(object sender, EventArgs e)
        {
            labelDriveTypeClick.Text = temp.GetDriveType(comboBoxListOfDrives.Text);
        }

        private void DriveDirectoriesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelSelectedObjectClick.Text = listDriveDirectories.SelectedItem.ToString();
            path += @"\" + listDriveDirectories.SelectedItem.ToString();
            listDriveFiles.Items.Clear();
            listDriveDirectories.Items.Clear();

            string[] directorieslist = temp.GetDirectoriesList(path);
            for (int i = 0; i < directorieslist.Length; i++)
            {
                listDriveDirectories.Items.Add(directorieslist[i]);
            }
            string[] fileslist = temp.GetFilesList(path);
            for (int i = 0; i < fileslist.Length; i++)
            {
                listDriveFiles.Items.Add(fileslist[i]);
            }
            labelSizeClick.Text = temp.GetDirectorySize(path);
            labelDateOfCreationClick.Text = temp.GetDirectoryDateOfCreation(path);
            labelLastAccessDateClick.Text = temp.GetDirectoryLastAccessDate(path);
            labelLastWriteDateClick.Text = temp.GetDirectoryLastWriteDate(path);
        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void listDriveFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelSelectedObjectClick.Text = listDriveFiles.SelectedItem.ToString();
            labelSizeClick.Text = temp.GetFileSize(path + @"\" + listDriveFiles.SelectedItem);
            labelDateOfCreationClick.Text = temp.GetFileDateOfCreation(path + @"\" + listDriveFiles.SelectedItem);
            labelLastAccessDateClick.Text = temp.GetFileLastAccessDate(path + @"\" + listDriveFiles.SelectedItem);
            labelLastWriteDateClick.Text = temp.GetFileLastWriteDate(path + @"\" + listDriveFiles.SelectedItem);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_4(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
