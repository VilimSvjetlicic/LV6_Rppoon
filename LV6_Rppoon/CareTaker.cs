using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV6_Rppoon
{
    class CareTaker
    {
        private List<Memento> lista;
        private int Counter;
        public Memento PreviousState { get; set; }

        public CareTaker() { lista = new List<Memento>(); Counter = 0; }

        public void AddState(Memento memento)
        {
            PreviousState = memento;
            lista.Add(memento);
            Counter++;
        }
        public Memento OtherStates(int x) {
            if (x < 0 || x > (lista.Count()-1))
                Console.WriteLine("Error!");
            return lista[x];
        }

    }
}
