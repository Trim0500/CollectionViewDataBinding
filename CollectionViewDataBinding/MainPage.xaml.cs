using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CollectionViewDataBinding
{
    public partial class MainPage : ContentPage
    {
        //In order for the collection view to be populated, we need a field to store the new changes that are generated at run time
        public IList<Fruit> Fruits { get; set; } //Create a new IList of type Fruit to create a list to populate the collection view list
        public IList<FederalParties> Parties { get; set; }

        //In the main page method (which remember functions as the main method) we will instantiate the list variable to a new List, then call a method to programatically create new instances of the Fruit class to use
        public MainPage()
        {
            InitializeComponent();
            //Fruits = new List<Fruit>(); //Create a new List of type Fruit and assign it to the Fruits field of the same type
            Parties = new List<FederalParties>();
            //AddFruits(); //Method to use to instantiate the list with Fruit Objects
            AddParties();
            BindingContext = this; //Have the program assign the binding context to this code behind on compilation
        }

        //This method will act as the method that will change and add new objects to the list
        public void AddFruits()
        {
            Fruits.Add(new Fruit //Call the Add method (remember we're using a list) to make a new object of type Fruit
            {
                Name = "Apple", //Change the name
                Color = "Red", //Change the Color

                ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSCIkLAMb88i1JvgocoeC8um_Zk6n7-i5YzyRZ41NcBlc7rd3YWGCNbykFmoLMIYZnIa4k&usqp=CAU" //Add an image
            });

            Fruits.Add(new Fruit
            {
                Name = "Oranges",
                Color = "Orange",
                ImageUrl = "https://cdn.britannica.com/w:400,h:300,c:crop/24/174524-050-A851D3F2/Oranges.jpg"

            });

            Fruits.Add(new Fruit
            {
                Name = "Banana",
                Color = "Yellow",
                ImageUrl = "https://images.everydayhealth.com/images/diet-nutrition/all-about-bananas-nutrition-facts-health-benefits-recipes-and-more-rm-722x406.jpg?w=1110"
            });

        }

        public void AddParties()
        {
            Parties.Add(new FederalParties //Call the Add method (remember we're using a list) to make a new object of type Fruit
            {
                name = "Liberals", //Change the name
                leader = "Justin Trudeau", //Change the Color

                imageURL = "https://www.cjnews.com/wp-content/uploads/2016/01/libs.jpg" //Add an image
            });

            Parties.Add(new FederalParties //Call the Add method (remember we're using a list) to make a new object of type Fruit
            {
                name = "Conservatives", //Change the name
                leader = "Erin O'Toole", //Change the Color

                imageURL = "https://www.vmcdn.ca/f/files/glaciermedia/import/mb/1576178-web-pc-logo-icon-blue.jpg;w=960" //Add an image
            });

            Parties.Add(new FederalParties //Call the Add method (remember we're using a list) to make a new object of type Fruit
            {
                name = "Bloc Quebecois", //Change the name
                leader = "Yves-François, Blanchet", //Change the Color

                imageURL = "https://media.socastsrm.com/wordpress/wp-content/blogs.dir/1920/files/2019/11/Bloc-Quebecois-logo-Twitter.jpg" //Add an image
            });

            Parties.Add(new FederalParties //Call the Add method (remember we're using a list) to make a new object of type Fruit
            {
                name = "NDP", //Change the name
                leader = "Jagmeet, Singh", //Change the Color

                imageURL = "https://pbs.twimg.com/profile_images/1196465881087455232/hFKPjmeb_400x400.png" //Add an image
            });
        }

        private void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e) //sender is the collectionview and e is the actual item
        {
            FederalParties itemSelected = (FederalParties)e.CurrentSelection[0];
        }
    }
}
