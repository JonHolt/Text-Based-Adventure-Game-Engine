using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedEngine
{
    static class GameManager
    {
        static Form1 window;

        public static void Start(Form1 _window)
        {
            window = _window;
            //Call opening scene method here
            ExampleStart(new object(), new EventArgs());
        }

        public static void ExampleStart(object s, EventArgs e)
        {
            window.SetPrompt("Welcome to the text based adventure game engine! Simply add methods in the Game Manager File to get started. All methods will use the following two methods to interface with this window:\r\n\r\n\nwindow.SetPrompt(string):\r\n\tThis method sets the promt the user will see in this textbox.\r\n\r\nwindow.AddChoice(string, EventHandler):\r\n\tThis method will add a button to the window giving the user another choice to click. Simply give it a string (something to say), and the name of the method it should call when clicked. All methods that will be called when clicked must accept an object and an EventArgs in the same way ExampleStart does.");
            window.AddChoice("I understand", Understood);
            window.AddChoice("Wait... what?", Confused);
            window.AddChoice("This\r\nis\r\na\r\nbig\r\nbutton\r\test",null);
            window.AddChoice("This\r\nis\r\na\r\nbig\r\nbutton\r\test", null);
        }

        public static void Understood(object s, EventArgs e)
        {
            window.SetPrompt("Great! Have fun programming your game, and let me know if you have any questions or run into any problems by emailing me at jholt@alpinedistrict.org\r\n\r\nPlanned Features:\r\n1.Saving and Loading\r\n2.Player Statistics\r\n3.Inventory System\r\n4.Miscellaneous Data Storage");
            window.AddChoice("Close", Done);
        }

        public static void Confused(object s, EventArgs e)
        {
            window.SetPrompt("I'm sorry to hear you're having trouble. Email me your questions at jholt@alpinedistrict.org");
            window.AddChoice("Close", Done);
        }

        public static void Done(object s, EventArgs e)
        {
            window.Close();
        }
    }
}
