// (c) @sjuvvalapalem -- Funny but no Copyright.. Do anything you want no responsibility from my side for any thing...
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;

namespace JSONtoCSharp
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TextArea1.InnerText = @"";
            //simple JSON string
            string jsonString = "[  {\"id\":\"01\", \"language\": \"Java\", \"edition\": \"third\",  \"author\": \"Herbert Schildt\" }, { \"id\":\"07\",\"language\": \"C++\",\"edition\": \"second\", \"author\": \"E.Balagurusamy\"      }   ]";
            // as you can see above we have two books .. :)

            //here is the code to convert the json string to a C# object.. as we have two books in the JSON we are going to store it as a object array ..
            List<myBookClass> myBookClassObjectArray = (List<myBookClass>)JsonConvert.DeserializeObject(jsonString, typeof(List<myBookClass>));
            Console.WriteLine("Count of Objects in the Array = " + myBookClassObjectArray.Count);
            TextArea1.InnerText = String.Format("Count of Objects in the Array ={0} \n " , myBookClassObjectArray.Count);

            //As you can see below the coun of Objects = 2

            //lets try to print the objects..
            for (int i = 0; i < myBookClassObjectArray.Count; i++)
            {
               
                //create the object from the object Array...
                myBookClass objBook = myBookClassObjectArray[i];
                TextArea1.InnerText += String.Format("Printing Object {0} of {1} \n", i + 1, myBookClassObjectArray.Count);
                TextArea1.InnerText += String.Format("   id = " + objBook.id +"\n");
                TextArea1.InnerText += String.Format("   language = " + objBook.language + "\n");
                TextArea1.InnerText += String.Format("   edition = " + objBook.edition + "\n"); ;
                TextArea1.InnerText += String.Format("   author = " + objBook.author + "\n");

            }

            //Here is some more  interesting code.. lets try to find a book object from the bookobjectArray by the value of a field..
            // i.e get the object by the id .. id = 01 which should return us one object.. this is extremely useful when you have a big array i.e say 500 objects and you are trying to find one then we can one object..
            //Note: remember as always if the id doesnt exist then it will throw a error....
            myBookClass objBook1 = myBookClassObjectArray.Find(item => item.id.Equals("01", StringComparison.InvariantCultureIgnoreCase));

            //lets print this object...
            TextArea1.InnerText += ("\n");
            TextArea1.InnerText += ("Printing the object found by the ID \n");
            TextArea1.InnerText += ("   id = " + objBook1.id + "\n");
            TextArea1.InnerText += ("   language = " + objBook1.language + "\n");
            TextArea1.InnerText += ("   edition = " + objBook1.edition + "\n");
            TextArea1.InnerText += ("   author = " + objBook1.author + "\n");
        }
    }

    public class myBookClass
    {
        public string id { get; set; } // suman this is a nifty way of writing getter and setter in C# 3.0 -- Bob
        public string language { get; set; }
        public string edition { get; set; }
        public string author { get; set; }
    }
}