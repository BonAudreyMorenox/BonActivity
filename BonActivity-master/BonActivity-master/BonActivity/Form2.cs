﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BonActivity
{
    public partial class Form2 : Form
    {
        List<string> groceryList = new List<string>();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string item = itemTxt.Text.Trim();
            if (string.IsNullOrEmpty(item))
            {
                MessageBox.Show("Please enter a grocery item.");
                return;
            }
            if (groceryList.Count >= 5)
            {
                MessageBox.Show("Maximum of 5 items only.");
                return;
            }
            groceryList.Add(item);
            items2.Items.Add(item);
            itemTxt.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (groceryList.Count == 0)
            {
                MessageBox.Show("No items to save.");
                return;
            }

            string json = JsonConvert.SerializeObject(groceryList, Formatting.Indented);
            File.WriteAllText("shoppinglist.json", json);
            MessageBox.Show("Grocery list saved successfully!");
            this.Close();
        }
    }
}

