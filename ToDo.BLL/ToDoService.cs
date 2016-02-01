
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.BLL
{
    public class ToDoService
    {
        private List<ToDoBO> _allToDos;
        private List<ToDoBO> _DoneToDOs;
        private List<ToDoBO> _UnDoneToDOs;

        public ToDoService()
        {
            this._allToDos= deSerialize();
            _UnDoneToDOs = this.fillUnDoneToDOs();
            _DoneToDOs = this.fillDoneToDOs();
        }

        public void changeStatusToDone(ToDoBO todo) {
            foreach (ToDoBO task in _allToDos) {
                if (task.ifEqual(todo)) {
                    Console.WriteLine("equal");
                    task.Olek = true;
                    serialize();
                    return;
                }
            }

        }



        public void addToDo(ToDoBO todo)
        {
            this._allToDos.Add(todo);
            serialize();
            Console.WriteLine(this._allToDos.Count+"");
        }

        private List<ToDoBO> fillDoneToDOs() {
            List<ToDoBO> doneToDOsTest= new List<ToDoBO>();
            foreach (ToDoBO todo in _allToDos) {               
                if (todo.Olek==true) {
                    doneToDOsTest.Add(todo);
                    Console.WriteLine(todo.Pealkiri);
                }
            }
            return doneToDOsTest;
        }

        private List<ToDoBO> fillUnDoneToDOs()
        {
            List<ToDoBO> unDoneToDOsTest = new List<ToDoBO>();
            foreach (ToDoBO todo in _allToDos)
            {
                if (todo.Olek == false)
                {
                    unDoneToDOsTest.Add(todo);
                    Console.WriteLine(todo.Pealkiri);
                }
            }
            return unDoneToDOsTest;
        }

        public List<ToDoBO> getDoneTasks() {
            return this._DoneToDOs;
        }
        public List<ToDoBO> getUnDoneTasks()
        {
            return this._UnDoneToDOs;
        }

        private void serialize() {
            try {
                using (Stream stream = File.Open("data.bin", FileMode.Create))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, this._allToDos);
                }
            }
            catch (IOException)
            {
            }
        }

        public List<ToDoBO> deSerialize() {
            List<ToDoBO> getToDos= new List<ToDoBO>();

            try
            {
                using (Stream stream = File.Open("data.bin", FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    var deserialized = (List<ToDoBO>)bin.Deserialize(stream);
                    getToDos = deserialized;
                }
            }
            catch (IOException)
            {
            }

            return getToDos;
        }

        public List<ToDoBO> getAllToDo()
        {
            return this._allToDos;
        }

        public void change(ToDoBO todo, string pealkiri, string kirjeldus, DateTime loodud, int prioriteet, bool olek)
        {
            todo.Pealkiri = pealkiri;
            todo.Kirjeldus = kirjeldus;
            todo.Prioriteet = (ToDoBO.priorideedid)prioriteet;
            todo.Olek = olek;
        }

        public void finnishToDO(ToDoBO todo) {
            todo.Olek = true;
        }

        public List<ToDoBO> sortByPriority()
        {
            List<ToDoBO> sortedToDoList = new List<ToDoBO>();
            foreach (ToDoBO todo in _allToDos)
            {
                if (todo.Prioriteet == ToDoBO.priorideedid.Kqrge)
                {
                    sortedToDoList.Add(todo);
                }
            }
            foreach (ToDoBO todo in this.getUnDoneTasks())
            {
                if (todo.Prioriteet == ToDoBO.priorideedid.Keskmine)
                {
                    sortedToDoList.Add(todo);
                }
            }

            foreach (ToDoBO todo in _allToDos)
            {
                if (todo.Prioriteet == ToDoBO.priorideedid.Madal)
                {
                    sortedToDoList.Add(todo);
                }
            }
            return sortedToDoList;
        }
    }
}
