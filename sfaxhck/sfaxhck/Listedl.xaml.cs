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
    public partial class Listedl : ContentPage
    {
        public Listedl()
        {
            InitializeComponent();
            List<Person> persons = new List<Person>();
            persons.Add(new Person(){Name = "azzouz",Img = "One.png" ,Details = "MSP TUNISIA"});
            persons.Add(new Person(){Name = "Achraf",Img = "Two.png", Details = "MSP TUNISIA"});
            persons.Add(new Person(){Name = "Dali",Img = "Three.png", Details = "MSP TUNISIA"});
            persons.Add(new Person(){Name = "Dali",Img = "Three.png", Details = "MSP TUNISIA"});
            persons.Add(new Person(){Name = "Dali",Img = "Three.png", Details = "MSP TUNISIA"});
            persons.Add(new Person(){Name = "Dali",Img = "Three.png", Details = "MSP TUNISIA"});
            persons.Add(new Person(){Name = "Dali",Img = "Three.png", Details = "MSP TUNISIA"});
            persons.Add(new Person(){Name = "Dali",Img = "Three.png", Details = "MSP TUNISIA"});
            persons.Add(new Person(){Name = "Dali",Img = "Three.png", Details = "MSP TUNISIA"});
            persons.Add(new Person(){Name = "Dali",Img = "Three.png", Details = "MSP TUNISIA"});
            persons.Add(new Person(){Name = "Dali",Img = "Three.png", Details = "MSP TUNISIA"});
            persons.Add(new Person(){Name = "Dali",Img = "Three.png", Details = "MSP TUNISIA"});
            persons.Add(new Person(){Name = "Dali",Img = "Three.png", Details = "MSP TUNISIA"});
            persons.Add(new Person(){Name = "Dali",Img = "Three.png", Details = "MSP TUNISIA"});
            persons.Add(new Person(){Name = "Dali",Img = "Three.png", Details = "MSP TUNISIA"});
            persons.Add(new Person(){Name = "Dali",Img = "Three.png", Details = "MSP TUNISIA"});
            persons.Add(new Person(){Name = "Dali",Img = "Three.png", Details = "MSP TUNISIA"});


            //persons.Add(new Person(){Name = "azzouz",Img = "One.png" ,Details = "MSP TUNISIA"});
            //persons.Add(new Person(){Name = "azzouz",Img = "One.png" ,Details = "MSP TUNISIA"});
            deligators.ItemsSource = persons;

        }

        //private void deta(object sender, SelectedItemChangedEventArgs e)
        //{
        //    Person p = sender as Person;
        //   //await Navigation.PushAsync(new Detailsperson(p));
           
        //}
    }
}