using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Árboles_binarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree(); // Crea una instancia del árbol binario para operar (insertar, buscar, eliminar, recorrer)
            int op; // Variable para guardar la opción seleccionada por el usuario
            BinaryTree BinaryTree = new BinaryTree(); // Otra instancia para almacenar los datos insertados (esto puede causar duplicidad innecesaria, pero así lo dejaremos)
            string continuee = "s"; // Variable para controlar si el usuario desea continuar ('s' para sí)

            // Ciclo que mantiene el menú activo mientras el usuario desee continuar
            while (continuee.ToLower() == "s")
            {
                // Menú de opciones
                Console.WriteLine("Bienvenido a un árbol binario, porfa escoge una opción:");
                Console.WriteLine("1. Insertar un nodo");
                Console.WriteLine("2. Buscar un valor");
                Console.WriteLine("3. Recorrer Preorden");
                Console.WriteLine("4. Recorrer Inorden");
                Console.WriteLine("5. Recorrer Postorden");
                Console.WriteLine("6. Eliminar un nodo");
                Console.WriteLine("7. Mostrar los datos ingresados");
                Console.WriteLine("8. Salir");
                op = int.Parse(Console.ReadLine()); // Lee la opción elegida

                // Dependiendo de la opción seleccionada, ejecuta la acción correspondiente
                switch (op)
                {
                    case 1: // Insertar un nodo
                        Console.WriteLine("Ingresa el valor a insertar: ");
                        int dataInsert = int.Parse(Console.ReadLine()); // Captura el valor
                        tree.Insert(dataInsert); // Inserta en el árbol
                        BinaryTree.SaveData(dataInsert); // Guarda el dato para mostrar después
                        Console.WriteLine($"Nodo {dataInsert} insertado");
                        break;

                    case 2: // Buscar un valor
                        Console.WriteLine("Ingrese el valor a buscar: ");
                        int dataFind = int.Parse(Console.ReadLine());
                        if (tree.Find(dataFind)) // Busca el valor
                        {
                            Console.WriteLine($"El nodo {dataFind} ha sido encontrado");
                        }
                        else
                        {
                            Console.WriteLine($"El nodo {dataFind} no ha sido encontrado");
                        }
                        break;

                    case 3: // Recorrido Preorden
                        Console.WriteLine("Recorrido PreOrden");
                        tree.PreOrder(tree.root);
                        break;

                    case 4: // Recorrido Inorden
                        Console.WriteLine("Recorrido InOrden");
                        tree.InOrder(tree.root);
                        break;

                    case 5: // Recorrido Postorden
                        Console.WriteLine("Recorrido PostOrden");
                        tree.PostOrder(tree.root);
                        break;

                    case 6: // Eliminar un nodo
                        Console.WriteLine("Ingrese el valor a eliminar: ");
                        int dataDelete = int.Parse(Console.ReadLine());
                        tree.Delete(dataDelete); // Elimina el nodo
                        Console.WriteLine($"Nodo {dataDelete} eliminado");
                        break;

                    case 7: // Mostrar los datos ingresados
                        BinaryTree.ShowData();
                        break;

                    case 8: // Salir
                        Console.WriteLine("Gracias por usar el programa :)");
                        break;

                    default: // Opción no válida
                        Console.WriteLine("Opción no válida");
                        break;
                }

                // Preguntar al usuario si quiere continuar
                Console.WriteLine("¿Desea continuar el programa? (s/n)");
                continuee = Console.ReadLine(); // Actualiza la variable, si pone 'n' saldrá del ciclo
            }
        }
    }
}
