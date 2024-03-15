using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comp282_Coursework2
{
    
    public partial class Form1 : Form
    {
        List<Country> countries = new List<Country>();
        bool sortNameAsc = false;
        bool sortPopAsc = false;

        private void RedrawCountryList()
        {
            
            bool chooseIdx = false;
            int idx = -1;
            if (countryListView.SelectedIndices.Count > 0)
            {
                chooseIdx = true;
                idx = countryListView.SelectedIndices[0];
                if (idx >= countries.Count)
                {
                    idx--;
                }

            }
            countryListView.Items.Clear();
            foreach (Country countr in countries)
            {
                string countrName = countr.Name;
                string countrPop = countr.Population.ToString();

                ListViewItem item = new ListViewItem(countrName);
                item.SubItems.Add(countrPop);
                countryListView.Items.Add(item);
            }
            if(chooseIdx == true) { 
                if (countries.Count > 0)
                {
                    countryListView.Items[idx].Selected = true;
                }
            }
        }
        public Form1()
        {
            InitializeComponent();
            AcceptButton = addButton;
            RedrawCountryList();
        }


        private void addButton_Click(object sender, EventArgs e)
        {
            AcceptButton = addButton;
            if (string.IsNullOrEmpty(nameTxtBox.Text) || string.IsNullOrEmpty(popTxtBox.Text))
            {
                MessageBox.Show("Error: Please the country's name and population.");
                return;
            }
            else
            {
                if (countryListView.SelectedIndices.Count > 0)
                {
                    int idx = countryListView.SelectedIndices[0];
                    countries.Insert(idx, new Country(nameTxtBox.Text, long.Parse(popTxtBox.Text)));
                }
                else
                {
                    countries.Add(new Country(nameTxtBox.Text, long.Parse(popTxtBox.Text)));  
                }
                RedrawCountryList();
            }
            nameTxtBox.Clear();
            popTxtBox.Clear();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            AcceptButton = removeButton;
            if (countryListView.SelectedIndices.Count > 0)
            {
                int idx = countryListView.SelectedIndices[0];
                countries.RemoveAt(idx);
                RedrawCountryList();
            }
            else
            {
                MessageBox.Show("Error: Please select a country already in the list.");
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            AcceptButton = updateButton;
            if (countryListView.SelectedIndices.Count > 0)
            {
                int idx = countryListView.SelectedIndices[0];
                Country selectedCountry = countries.ElementAt(idx);

                if (!string.IsNullOrEmpty(nameTxtBox.Text))
                {
                    selectedCountry.Name = nameTxtBox.Text;
                }
                if (!string.IsNullOrEmpty(popTxtBox.Text))
                {
                    selectedCountry.Population = long.Parse(popTxtBox.Text);
                }

                countries[idx] = selectedCountry;
                RedrawCountryList();
            }
            else
            {
                MessageBox.Show("Error: Please select a country already in the list.");
            }
            nameTxtBox.Clear();
            popTxtBox.Clear();
        }


        private void countryListView_ColumnClick_1(object sender, ColumnClickEventArgs e)
        {
            if (e.Column.ToString() == "0")
            {
                if (sortNameAsc == true)
                {
                    var sortedList = from country in countries
                                     orderby country.Name ascending
                                     select country;
                    List<Country> temp = new List<Country>();
                    foreach (Country countr in sortedList)
                    {
                        temp.Add(countr);
                    }
                    countries = temp;

                    nameColHeader.Text = "Name↓";
                    sortNameAsc = false;
                }
                else
                {
                    var sortedList = from country in countries
                                     orderby country.Name descending
                                     select country;
                    List<Country> temp = new List<Country>();
                    foreach (Country countr in sortedList)
                    {
                        temp.Add(countr);
                    }
                    countries = temp;

                    nameColHeader.Text = "Name↑";
                    sortNameAsc = true;
                }
                RedrawCountryList();
                
            }
            if (e.Column.ToString() == "1")
            {
                if (sortPopAsc == true)
                {
                    var sortedList = from country in countries
                                     orderby country.Population ascending
                                     select country;
                    List<Country> temp = new List<Country>();
                    foreach (Country countr in sortedList)
                    {
                        temp.Add(countr);
                    }
                    countries = temp;

                    popColHeader.Text = "Population↓";
                    sortPopAsc = false;
                }
                else
                {
                    var sortedList = from country in countries
                                     orderby country.Population descending
                                     select country;
                    List<Country> temp = new List<Country>();
                    foreach (Country countr in sortedList)
                    {
                        temp.Add(countr);
                    }
                    countries = temp;

                    popColHeader.Text = "Population↑";
                    sortPopAsc = true;
                }
                RedrawCountryList();
            }
        }
    }
}
