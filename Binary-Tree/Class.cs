using System; // Importa funcionalidades básicas del sistema
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Árboles_binarios
{
    // Definición de la clase Class (parece ser un nodo, pero el nombre no es descriptivo)
    internal class Class
    {
        public int data; // Almacena el valor del nodo
        public Nodes left; // Referencia al hijo izquierdo del nodo
        public Nodes right; // Referencia al hijo derecho del nodo


        // Constructor que inicializa solo el valor y deja hijos en null
        public Class(int data)
        {
            this.data = data; // Asigna el valor del nodo
            this.left = null; // Hijo izquierdo vacío
            this.right = null; // Hijo derecho vacío
        }

        // Constructor que inicializa el valor y el hijo izquierdo, hijo derecho queda null
        public Class(int data, Nodes left)
        {
            this.data = data; // Valor del nodo
            this.left = left; // Asigna el hijo izquierdo
            this.right = null; // Hijo derecho vacío
        }

        // Constructor que inicializa valor, hijo izquierdo y derecho
        public Class(int data, Nodes left, Nodes right)
        {
            this.data = data; // Valor del nodo
            this.left = left; // Hijo izquierdo
            this.right = right; // Hijo derecho
        }

    }
}

