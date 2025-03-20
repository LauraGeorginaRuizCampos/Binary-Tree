📚 Binary Tree Implementation in C#
Descripción General

Este proyecto implementa un Árbol Binario de Búsqueda (Binary Search Tree) utilizando el lenguaje C#. El árbol permite almacenar datos enteros y proporciona operaciones fundamentales como inserción, búsqueda y recorridos.
🔍 Detalle de la Implementación
1. Clase Node (archivo: Nodes.cs)

La clase Node define la estructura básica de un nodo del árbol:

    int Data: Guarda el valor entero del nodo.
    Node Left y Node Right: Referencias a los nodos hijo izquierdo y derecho.
    Constructor:
        Recibe un valor int.
        Inicializa el valor y asigna null a los hijos.

📌 Importancia: Permite modelar la estructura jerárquica del árbol.
2. Clase Operations (archivo: Operations.cs)

Contiene los métodos esenciales para operar sobre el árbol:
➤ Método: Insertar Nodo (Insert)

    Entrada: Nodo raíz y valor a insertar.
    Proceso:
        Si la raíz es null, crea un nuevo nodo.
        Si el valor es menor, inserta en el subárbol izquierdo.
        Si es mayor, inserta en el subárbol derecho.
    Técnica: Usa recursión para navegar hasta la posición correcta.

➤ Métodos de Recorrido:

    Preorden (Preorder):
        Procesa el nodo actual.
        Recorre hijo izquierdo.
        Recorre hijo derecho.

    Inorden (Inorder):
        Hijo izquierdo.
        Nodo actual.
        Hijo derecho.
        📌 Útil para mostrar los datos ordenados.

    Postorden (Postorder):
        Hijo izquierdo.
        Hijo derecho.
        Nodo actual.

➤ Método: Buscar Nodo (Search)

    Entrada: Nodo raíz y valor buscado.
    Proceso:
        Compara el valor buscado con el nodo actual.
        Si coincide, retorna el nodo.
        Si es menor, busca en la izquierda.
        Si es mayor, busca en la derecha.
        Retorna null si no encuentra el valor.

3. Clase Principal: Program (archivo: Program.cs)

Se encarga de probar la implementación:

    Inicializa un árbol vacío (root = null).
    Inserta manualmente los valores: 50, 30, 70, 20, 40, 60, 80.
    Muestra en consola los tres tipos de recorridos.
    Realiza la búsqueda de un valor específico (ej. 40) e imprime el resultado.

🧪 Resultados Obtenidos

Al ejecutar el programa:

    Inserción exitosa: Los valores se organizan respetando las reglas del árbol binario de búsqueda.
    Recorridos correctos:
        Preorden: 50 30 20 40 70 60 80
        Inorden: 20 30 40 50 60 70 80
        Postorden: 20 40 30 60 80 70 50
    Búsqueda funcional: Encuentra correctamente valores existentes e informa si no están presentes.
