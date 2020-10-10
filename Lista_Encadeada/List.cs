using System;
using System.Collections.Generic;
using System.Text;

namespace Lista_Encadeada
{
    class List
    {
        private Node _inicio;

        public List()
        {
            _inicio = null;
        }

        public void InserirElemento(int elemento)
        {
            Node nova = new Node();
            nova.Elemento = elemento;
            nova.Proximo = null;

            if (_inicio == null)
            {
                _inicio = nova;
            }
            else
            {
                Node aux;
                aux = _inicio;
                while (aux.Proximo != null)
                {
                    aux = aux.Proximo;
                }
                aux.Proximo = nova;
            }
        }
        public void Listar()
        {
            if (_inicio == null)
            {
                Console.WriteLine("Lista Vazia");
            }
            else
            {
                Node aux = _inicio;
                while (aux != null)
                {
                    Console.WriteLine($"Elemento: {aux.Elemento}");
                    aux = aux.Proximo;
                }
            }
        }

        public bool VerificarCrescente()
        {
            Node aux = _inicio;
            while (aux != null)
            {
                if (aux.Proximo != null && aux.Elemento > aux.Proximo.Elemento)
                {
                    return false;
                }
                else
                {
                    aux = aux.Proximo;
                }
            }
            return true;
        }
        public bool VerificarDecrescente()
        {
            Node aux = _inicio;
            while (aux != null)
            {
                if (aux.Proximo != null && aux.Elemento < aux.Proximo.Elemento)
                {
                    return false;
                }
                else
                {
                    aux = aux.Proximo;
                }

            }
            return true;
        }
        public bool VerificarOrdenada()
        {
            if (VerificarCrescente() == false && VerificarDecrescente() == false)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
