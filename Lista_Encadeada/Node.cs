using System;
using System.Collections.Generic;
using System.Text;

namespace Lista_Encadeada
{
    class Node
    {
        private int _elemento;
        private Node _proximo;

        public int Elemento
        {
            get { return _elemento; }
            set { _elemento = value; }
        }

        public Node Proximo
        {
            get { return _proximo; }
            set { _proximo = value; }
        }

    }
}
