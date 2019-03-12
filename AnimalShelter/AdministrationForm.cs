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
        private List<Animal> Animals;

        /// <summary>
        /// Creates the form for doing adminstrative tasks
        /// </summary>
        public AdministrationForm()
        {
            Animals = new List<Animal>();
            InitializeComponent();
            animalTypeComboBox.SelectedIndex = 0;
            textBoxBadHabits.Visible = true;
            LabelHabits.Visible = true;
            labelWalked.Visible = false;
            numericUpDownLastDayWalked.Visible = false;
            numericUpDownLastWallkedYear.Visible = false;
            numericUpDownLastMonthWalkedMonth.Visible = false;
            animal = null;
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
                    Animals.Add(animal);
                }

                if (animalTypeComboBox.SelectedIndex == 1)
                {
                    animal = new Dog(RegNummer++, new SimpleDate(Convert.ToInt32(numericUpDownDy.Value), Convert.ToInt32(numericUpDownMonth.Value), Convert.ToInt32(numericUpDown3.Value)), textBoxName.Text, new SimpleDate(Convert.ToInt32(numericUpDownLastDayWalked.Value), Convert.ToInt32(numericUpDownLastMonthWalkedMonth.Value), Convert.ToInt32(numericUpDownLastWallkedYear.Value)));
                    Animals.Add(animal);
                }
                UpdateListbox();
            }
        }

        private void UpdateListbox()
        {
            listBoxAnimals.Items.Clear();
            foreach(Animal a in Animals)
            {
                listBoxAnimals.Items.Insert(a.ChipRegistrationNumber, a.ToString());
            }
        }

        /// <summary>
        /// Show the info of the animal referenced by the 'animal' field. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void showInfoButton_Click(object sender, EventArgs e)
        {
            foreach(Animal a in Animals)
            {
                if(a.ChipRegistrationNumber == listBoxAnimals.SelectedIndex)
                {
                    MessageBox.Show(a.ToString());
                }
            }
        }

        private void animalTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(animalTypeComboBox.Text == "Cat")
            {
                textBoxBadHabits.Visible = true;
                LabelHabits.Visible = true;
                labelWalked.Visible = false;
                numericUpDownLastDayWalked.Visible = false;
                numericUpDownLastWallkedYear.Visible = false;
                numericUpDownLastMonthWalkedMonth.Visible = false;
            }
            if(animalTypeComboBox.Text == "Dog")
            {
                textBoxBadHabits.Visible = false;
                LabelHabits.Visible = false;
                labelWalked.Visible = true;
                numericUpDownLastDayWalked.Visible = true;
                numericUpDownLastWallkedYear.Visible = true;
                numericUpDownLastMonthWalkedMonth.Visible = true;
            }
        }
    }
}
