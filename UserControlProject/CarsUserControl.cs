using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControlProject
{
    public partial class CarsUserControl : UserControl
    {
        public CarsUserControl()
        {
            InitializeComponent();
        }
       
        public string MyProperty
        {
            get { return CarLabel.Text; }
            set { CarLabel.Text = value; }
        }
        
        public event EventHandler AddClick;
        public event EventHandler RemoveClick;
        public event EventHandler EditClick;

        protected virtual void OnAddClick()
        {
            AddClick?.Invoke(this, EventArgs.Empty);
        }
        protected virtual void OnRemoveClick()
        {
            RemoveClick?.Invoke(this, EventArgs.Empty);
        }
        protected virtual void OnEditClick()
        {
            EditClick?.Invoke(this, EventArgs.Empty);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AddData(textBoxAdd.Text);
            OnAddClick();
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
            OnRemoveClick();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
            AddData(textBoxEdit.Text);
            OnEditClick();
        }
        public void AddData(String Data)
        {
            listBox1.Items.Add(Data);
        }
        public List<String> GetData()
        {
            return listBox1.Items.OfType<String>().ToList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
