using System; // Importa funcionalidades básicas del sistema
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Árboles_binarios
{
    internal class BinaryTree
    {
        public Nodes root = null; // Define el nodo raíz del árbol, inicia en null
        public string Data = " "; // Variable para almacenar datos ingresados por el usuario como string

        // Método para insertar un nodo en el árbol
        public void Insert(int data)
        {
            // Si el árbol está vacío, crea el nodo raíz
            if (root == null)
            {
                root = new Nodes(data);
            }

            Nodes actual = root; // Nodo actual para recorrer el árbol
            Nodes father = null; // Nodo padre para saber dónde insertar el nuevo nodo

            // Recorre el árbol hasta encontrar una posición libre
            while (actual != null)
            {
                father = actual;
                if (data < actual.data) // Si el dato es menor, ve al hijo izquierdo
                {
                    actual = actual.left;
                }
                else // Si es mayor o igual, va al hijo derecho
                {
                    actual = actual.right;
                }
            }

            // Inserta el nuevo nodo en la posición encontrada
            if (data < father.data)
            {
                father.left = new Nodes(data);
            }
            else
            {
                father.right = new Nodes(data);
            }

        }

        // Método para buscar un valor en el árbol
        public bool Find(int data)
        {
            Nodes actual = root; // Comienza desde la raíz

            // Recorre el árbol buscando el valor
            while (actual != null)
            {
                if (data == actual.data) // Si encuentra el valor, retorna true
                {
                    return true;
                }

                if (data < actual.data) // Si es menor, ve al hijo izquierdo
                {
                    actual = actual.left;
                }
                else // Si es mayor, va al hijo derecho
                {
                    actual = actual.right;
                }
            }

            return false; // Si no encuentra el valor, retorna false
        }

        // Recorrido PreOrder: raíz, izquierda, derecha
        public void PreOrder(Nodes root)
        {
            if (root == null)
            {
                return;
            }
            else
            {
                Console.WriteLine(root.data); // Visita la raíz
                PreOrder(root.left); // Visita el subárbol izquierdo
                PreOrder(root.right); // Visita el subárbol derecho
            }
        }



        // Recorrido InOrder: izquierda, raíz, derecha
        public void InOrder(Nodes root)
        {
            if (root != null)
            {
                InOrder(root.left); // Visita el subárbol izquierdo
                //InOrder(nodes.right);
                Console.WriteLine(root.data + " "); // Visita la raíz
                InOrder(root.right); // Visita el subárbol derecho
            }
        }


        // Recorrido PostOrder: derecha, izquierda, raíz
        public void PostOrder(Nodes nodes)
        {
            if (nodes == null)
            {
                return;
            }
            else
            {
                PostOrder(nodes.right); // Visita subárbol derecho
                PostOrder(nodes.left); // Visita subárbol izquierdo
                Console.WriteLine(nodes.data); // Visita la raíz
            }
        }

        // Método para eliminar un nodo
        public void Delete(int data)
        {
            root = DeleteNodes(root, data); // Llama a la función recursiva
        }

        // Función recursiva para eliminar nodos
        private Nodes DeleteNodes(Nodes nodes, int data)
        {
            if (root == null) // Si el árbol está vacío
            {
                return null;
            }

            // Recorre el árbol buscando el nodo a eliminar
            if (data < nodes.data)
            {
                nodes.left = DeleteNodes(nodes.left, data);
            }
            else if (data > nodes.data)
            {
                nodes.right = DeleteNodes(nodes.right, data);
            }
            else
            {
                // Caso nodo hoja
                if (nodes.left == null && nodes.right == null)
                {
                    return null;
                }

                // Caso solo tiene hijo derecho
                if (nodes.left == null)
                {
                    return nodes.right;
                }
                // Caso solo tiene hijo izquierdo
                if (nodes.right == null)
                {
                    return nodes.left;
                }

                // Caso tiene dos hijos, busca el sucesor (el menor del subárbol derecho)
                Nodes succesor = Minn(nodes.right);
                nodes.data = succesor.data;
                nodes.right = DeleteNodes(nodes.right, succesor.data);
            }

            return nodes; // Retorna el nodo actualizado
        }

        // Encuentra el nodo con el valor mínimo (más a la izquierda)
        public Nodes Minn(Nodes Nodes)
        {
            while (Nodes.left != null)
            {
                Nodes = Nodes.left;
            }

            return Nodes;
        }

        // Guarda el dato en la variable Data (sobrescribe cada vez)
        public void SaveData(int data)
        {
            Data += data + " "; // Guarda el valor como string (OJO: sobrescribe el anterior)
        }

        // Muestra los datos ingresados por el usuario
        public void ShowData()
        {
            Console.WriteLine("Datos ingresados por el usuario:");

            if (Data == " ") // Si no hay datos
            {
                Console.WriteLine("No hay datos para mostrar :(");

            }
            else
            {
                Console.WriteLine(Data); // Muestra los datos almacenados
            }
        }
    }

}
