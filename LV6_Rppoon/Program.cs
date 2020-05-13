using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV6_Rppoon
{
    class Program
    {
        static void Main(string[] args)
        {
            ////1. zadatak

            //Notebook notebook = new Notebook();
            //notebook.AddNote(new Note("Title1", "text1"));
            //notebook.AddNote(new Note("Title2", "text2"));
            //notebook.AddNote(new Note("Title3", "text3"));
            //notebook.AddNote(new Note("Title4", "text4"));
            //IAbstractIterator iterator = notebook.GetIterator();
            //notebook.GetIterator();
            //for (Note note = iterator.First(); iterator.IsDone == false; note = iterator.Next()) { note.Show(); }

            ////2. zadatak

            //Box box = new Box();
            //box.AddProduct(new Product("Bomboni", 5.99));
            //box.AddProduct(new Product("Kolači", 6.99));
            //box.AddProduct(new Product("Lego kocke", 45.99));
            //box.AddProduct(new Product("Tehnička olovka", 12.99));
            //BoxIterator iterator = box.GetIterator();
            //box.GetIterator();
            //for (Product product = iterator.First(); iterator.IsDone == false; product = iterator.Next())
            //{ Console.WriteLine(product.ToString()); }

            ////3. zadatak

            //CareTaker careTaker = new CareTaker();
            //ToDoItem item = new ToDoItem("Title1", "text1", DateTime.Now);
            //careTaker.AddState(item.StoreState());
            //for (int i = 0; i < 10; i++)
            //{
            //    item.Rename("Title" + i.ToString());
            //    item.ChangeTask("text" + i.ToString());
            //    item.ChangeTimeDue(DateTime.Now);
            //    careTaker.AddState(item.StoreState());
            //}
            ////ispis svih stanja u listi
            //for (int i = 9; i >= 0; i--)
            //{
            //    Console.WriteLine(item.ToString() + "\n");
            //    item.RestoreState(careTaker.OtherStates(i));
            //}
            ////ispis zadnjeg elementa u listi
            //item.RestoreState(careTaker.PreviousState);
            //Console.WriteLine(item.ToString() + "\n");

            ////4. zadatak

            //BankAccount bankAccount = new BankAccount("Vilim Svjetličić","Ulica Ivana Gundulića 88",1200);
            //BankAccountMemento memento = new BankAccountMemento(bankAccount);
            //bankAccount.ChangeOwnerAddress("Vukovarska ulica 34");
            //bankAccount.UpdateBalance(-2000);
            //Console.WriteLine(bankAccount.ToString());
            //bankAccount.RestoreState(memento);
            //Console.WriteLine("\n"+bankAccount.ToString());

            ////5. zadatak

            //AbstractLogger logger = new ConsoleLogger(MessageType.ALL);
            //FileLogger fileLogger = new FileLogger(MessageType.ERROR | MessageType.WARNING, @"D:\\Users\\Korisnik\\Downloads\\LV6_Rppoon\\LV6_Rppoon\\logFile.txt");
            //ConsoleLogger consoleLogger= new ConsoleLogger(MessageType.INFO);
            //FileLogger fileLogger1= new FileLogger(MessageType.INFO, @"D:\\Users\\Korisnik\\Downloads\\LV6_Rppoon\\LV6_Rppoon\\logFile.txt");
            //logger.SetNextLogger(fileLogger);
            //fileLogger.SetNextLogger(consoleLogger);
            //consoleLogger.SetNextLogger(fileLogger1);
            //logger.Log("Ovo je ERROR poruka.", MessageType.ERROR);
            //logger.Log("Ovo je INFO poruka.", MessageType.INFO);
            //logger.Log("Ovo je WARNING poruka.", MessageType.WARNING);


            //6. zadatak


            //StringUpperCaseChecker upperCaseChecker = new StringUpperCaseChecker();
            //StringLowerCaseChecker lowerCaseChecker = new StringLowerCaseChecker();
            //StringDigitChecker digitChecker = new StringDigitChecker();
            //StringLengthChecker stringLength = new StringLengthChecker();

            //upperCaseChecker.SetNext(lowerCaseChecker);
            //lowerCaseChecker.SetNext(digitChecker);
            //digitChecker.SetNext(stringLength);

            //Console.WriteLine("String 'Svj56': "+upperCaseChecker.Check("Svj56"));
            //Console.WriteLine("String 'vid': " + upperCaseChecker.Check("vid"));

            ////7. zadatak

            //StringUpperCaseChecker upperCaseChecker = new StringUpperCaseChecker();
            //StringLowerCaseChecker lowerCaseChecker = new StringLowerCaseChecker();
            //StringDigitChecker digitChecker = new StringDigitChecker();
            //StringLengthChecker stringLength = new StringLengthChecker();
            //PasswordValidator validator = new PasswordValidator(upperCaseChecker);
            //validator.AddChecker(lowerCaseChecker);
            //validator.AddChecker(digitChecker);
            //validator.AddChecker(stringLength);
            //Console.WriteLine(validator.checkValidation("Svj56"));
            //Console.WriteLine(validator.checkValidation("vksa"));


        }
    }
}
