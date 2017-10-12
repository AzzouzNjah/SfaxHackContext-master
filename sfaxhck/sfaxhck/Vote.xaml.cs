using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sfaxhck.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace sfaxhck
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Vote : ContentPage
    {
        List<Voting> persons ;
        public Vote()
        {   
            InitializeComponent();
           persons = new List<Voting>();
            persons.Add(new Voting() { Name = "azzouz", Img = "One.png", Details = "MSP TUNISIA",Etat = false});
            persons.Add(new Voting() { Name = "azzouz", Img = "One.png", Details = "MSP TUNISIA",Etat = false});
            persons.Add(new Voting() { Name = "azzouz", Img = "One.png", Details = "MSP TUNISIA",Etat = false});
            persons.Add(new Voting() { Name = "azzouz", Img = "One.png", Details = "MSP TUNISIA",Etat = false});
            persons.Add(new Voting() { Name = "Achraf", Img = "Two.png", Details = "MSP TUNISIA", Etat = false });
            persons.Add(new Voting() { Name = "Achraf", Img = "Two.png", Details = "MSP TUNISIA", Etat = false });
            persons.Add(new Voting() { Name = "Achraf", Img = "Two.png", Details = "MSP TUNISIA", Etat = false });
            persons.Add(new Voting() { Name = "Dali", Img = "Three.png", Details = "MSP TUNISIA", Etat = false });
            persons.Add(new Voting() { Name = "Dali", Img = "Three.png", Details = "MSP TUNISIA", Etat = false });
            persons.Add(new Voting() { Name = "Dali", Img = "Three.png", Details = "MSP TUNISIA", Etat = false });
            persons.Add(new Voting() { Name = "Dali", Img = "Three.png", Details = "MSP TUNISIA", Etat = false });
            //persons.Add(new Person(){Name = "azzouz",Img = "One.png" ,Details = "MSP TUNISIA"});
            //persons.Add(new Person(){Name = "azzouz",Img = "One.png" ,Details = "MSP TUNISIA"});
            //deligators.ItemsSource = persons;
            deligators.ItemsSource = persons;

        }

        private void Deligators_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {           //tofix
            ListView L = sender as ListView;
            Voting v = L.SelectedItem as Voting;

            foreach (Voting item in persons)
            {
                if (item.Name.Equals(v.Name))
                {
                    item.Etat = true;
                }
                else
                {
                    item.Etat = false;
                }

            }
            deligators.ItemsSource = null;
            deligators.ItemsSource = persons;
        }

        private void CustomRadioButton_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {

        }
    }
}