using System; // Importa funcionalidades básicas del sistema
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Árboles_binarios
{
    // Definición de la clase Nodes, que representa un nodo de un árbol binario
    internal class Nodes
    {
        public int data; // Valor que almacena el nodo (dato entero)
        public Nodes left; // Referencia al hijo izquierdo del nodo
        public Nodes right; // Referencia al hijo derecho del nodo

        // Constructor que inicializa el nodo con un valor específico
        public Nodes(int data)
        {
            this.data = data; // Asigna el valor del nodo
            this.left = null; // Inicializa hijo izquierdo como vacío (null)
            this.right = null; // Inicializa hijo derecho como vacío (null)
        }

    }
}


