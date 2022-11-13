using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Observable
{
    public partial class Form1 : Form
    {
        BindingList<Person> people = new BindingList<Person>();

        private void Form1_Load(object sender, EventArgs e)
        {
            Sample.AddPeople(people);
            listBox1.DataSource = people;
        }


        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            string firstName = Interaction.InputBox("Gib deinen Vornamen ein");
            string lastName = Interaction.InputBox("Gib deinen Nachnamen ein");
            int age = Convert.ToInt32(Interaction.InputBox("Gib dein Alter ein"));

            people.Add(new Person() { FirstName = firstName, LastName = lastName, Age = age });
        }

    }
}
