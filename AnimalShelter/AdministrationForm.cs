using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AnimalShelter
{
    public partial class AdministrationForm : Form
    {
        /// <summary>
        /// The (only) animal in this administration (for now....)
        /// </summary>
        public Animal animal;
        private int RegNummer = 0;
        public Administration Administration;

        /// <summary>
        /// Creates the form for doing adminstrative tasks
        /// </summary>
        public AdministrationForm()
        {
            Administration = new Administration();
            animal = new Cat(RegNummer++, new SimpleDate(1, 04, 2018), "Klaartje","");
            Administration.Add(animal);
            animal = new Cat(RegNummer++, new SimpleDate(12, 8, 2014), "Puck", "");
            Administration.Add(animal);
            animal = new Cat(RegNummer++, new SimpleDate(21, 11, 2016), "Bor", "");
            Administration.Add(animal);
            animal = new Dog(RegNummer++, new SimpleDate(6, 5, 2013), "Kinga", new SimpleDate(1,1,1980));
            Administration.Add(animal);
            animal = new Dog(RegNummer++, new SimpleDate(17, 12, 2016), "Bijke", new SimpleDate(1, 1, 1980));
            Administration.Add(animal);
            InitializeComponent();
            animalTypeComboBox.SelectedIndex = 0;
            textBoxBadHabits.Visible = true;
            LabelHabits.Visible = true;
            labelWalked.Visible = false;
            numericUpDownLastDayWalked.Visible = false;
            numericUpDownLastWallkedYear.Visible = false;
            numericUpDownLastMonthWalkedMonth.Visible = false;
            animal = null;
            UpdateListbox();

        }

        /// <summary>
        /// Create an Animal object and store it in the administration.
        /// If "Dog" is selected in the animalTypeCombobox then a Dog object should be created.
        /// If "Cat" is selected in the animalTypeCombobox then a Cat object should be created.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createAnimalButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text) || string.IsNullOrEmpty(textBoxName.Text))
            {
                MessageBox.Show("Geef dit arme beestje een naam!");
            }
            else
            {
                if (animalTypeComboBox.SelectedIndex == 0)
                {
                    animal = new Cat(RegNummer++, new SimpleDate(Convert.ToInt32(numericUpDownDy.Value), Convert.ToInt32(numericUpDownMonth.Value), Convert.ToInt32(numericUpDown3.Value)), textBoxName.Text, textBoxBadHabits.Text);
                    if (Administration.Add(animal) == false)
                    {
                        MessageBox.Show("Er is iets fout gegaan");
                    }
                }

                if (animalTypeComboBox.SelectedIndex == 1)
                {
                    animal = new Dog(RegNummer++, new SimpleDate(Convert.ToInt32(numericUpDownDy.Value), Convert.ToInt32(numericUpDownMonth.Value), Convert.ToInt32(numericUpDown3.Value)), textBoxName.Text, new SimpleDate(Convert.ToInt32(numericUpDownLastDayWalked.Value), Convert.ToInt32(numericUpDownLastMonthWalkedMonth.Value), Convert.ToInt32(numericUpDownLastWallkedYear.Value)));
                    if (Administration.Add(animal) == false)
                    {
                        MessageBox.Show("Er is iets fout gegaan");
                    }
                }
                UpdateListbox();
            }
        }

        private void UpdateListbox()
        {
            listBoxAnimalsNotReserved.Items.Clear();
            listBoxAnimalsReserved.Items.Clear();
            comboBoxFindAnimal.Items.Clear();
            foreach (Animal a in Administration.GetReservedAnimals())
            {
                listBoxAnimalsReserved.Items.Add(a);
                comboBoxFindAnimal.Items.Add(a.ChipRegistrationNumber);
            }
            foreach (Animal a in Administration.GetUnReservedAnimals())
            {
                listBoxAnimalsNotReserved.Items.Add(a);
                comboBoxFindAnimal.Items.Add(a.ChipRegistrationNumber);
            }

        }

        /// <summary>
        /// Show the info of the animal referenced by the 'animal' field. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void showInfoButton_Click(object sender, EventArgs e)
        {
            Animal currentAnimal = listBoxAnimalsNotReserved.SelectedItem as Animal;
            MessageBox.Show(currentAnimal.ToString());
        }

        private void animalTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (animalTypeComboBox.Text == "Cat")
            {
                textBoxBadHabits.Visible = true;
                LabelHabits.Visible = true;
                labelWalked.Visible = false;
                numericUpDownLastDayWalked.Visible = false;
                numericUpDownLastWallkedYear.Visible = false;
                numericUpDownLastMonthWalkedMonth.Visible = false;
            }
            if (animalTypeComboBox.Text == "Dog")
            {
                textBoxBadHabits.Visible = false;
                LabelHabits.Visible = false;
                labelWalked.Visible = true;
                numericUpDownLastDayWalked.Visible = true;
                numericUpDownLastWallkedYear.Visible = true;
                numericUpDownLastMonthWalkedMonth.Visible = true;
            }
        }

        private void ButtonReserve_Click(object sender, EventArgs e)
        {
            //Vraag: mag je voor het reserveren in de class van Administration een extra methode aanmaken?

            try
            {
                Animal currentAnimal = listBoxAnimalsNotReserved.SelectedItem as Animal;
                Administration.RemoveAnimal(currentAnimal.ChipRegistrationNumber);
                currentAnimal.IsReserved = true;
                if (Administration.Add(currentAnimal) == true)
                {
                    MessageBox.Show("Reserved!");
                }
                UpdateListbox();
            }
            catch { }       
            
        }

        private void buttonUnReserve_Click(object sender, EventArgs e)
        {
            try
            {
                Animal currentAnimal = listBoxAnimalsReserved.SelectedItem as Animal;
                Administration.RemoveAnimal(currentAnimal.ChipRegistrationNumber);
                currentAnimal.IsReserved = false;
                if(Administration.Add(currentAnimal)== true)
                {
                    MessageBox.Show("Unreserved!");
                }
                UpdateListbox();
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Animal currentanimal = Administration.FindAnimal(Convert.ToInt32(comboBoxFindAnimal.Text));
                if ( currentanimal != null)
                {
                    MessageBox.Show(currentanimal.ToString());
                }
                
            }
            catch { }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (Administration.RemoveAnimal(Convert.ToInt16(comboBoxFindAnimal.Text)) == true)
                {
                    MessageBox.Show("Deleted!");
                }
                UpdateListbox();
            }
            catch { }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            animal = new Dog(RegNummer++, new SimpleDate(17, 12, 2016), "Bijke", new SimpleDate(1, 1, 1980));
            MessageBox.Show(animal.ToString());
        }
    }
}
