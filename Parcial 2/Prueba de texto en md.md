# Estructuras de Datos

Las **estructuras de datos** son una forma particular de organizar la información en una computadora para que pueda ser utilizada de manera eficiente. Las más comunes y fundamentales son:

- **Lineales:**
    - Arreglo (Array)
    - Pila (Stack)
    - Cola (Queue)
    - Lista Enlazada
        - Simple
        - Doble
        - Circular
- **No Lineales:**
    - Árbol (Tree)
        - Árbol Binario (Binary Tree)
        - Árbol Binario de Búsqueda (BST)
    - Grafo (Graph)
    - Tabla Hash (Hash Table)

---

## Estructuras Lineales

### Arreglos (Arrays)

Un **arreglo** o **vector** es una estructura de datos que almacena una colección de elementos del **mismo tipo**, organizados de forma **contigua en memoria** y accesibles mediante un **índice numérico**. Su principal ventaja es el acceso rápido a cualquier elemento (tiempo $O(1)$).

| Operación | Complejidad Promedio | Descripción |
| :---: | :---: | :--- |
| Acceder | $O(1)$ | Rápido por índice. |
| Insertar/Eliminar | $O(n)$ | Puede requerir desplazar muchos elementos. |

### Pilas (Stacks)

Una **pila** es una estructura de datos lineal que sigue el principio **LIFO** (por sus siglas en inglés, "**L**ast **I**n, **F**irst **O**ut" o "**último en entrar, primero en salir**"), donde el último elemento que se añade es el primero en ser eliminado. Es un Tipo de Dato Abstracto (TDA) con dos operaciones básicas:

- **Apilar** (*push*): Para añadir un elemento en la parte superior.
- **Desapilar** (*pop*): Para retirar el elemento de la cima.

Se pueden implementar mediante arreglos o listas enlazadas.

### Colas (Queues)

Una **cola** es una estructura de datos lineal que opera bajo el principio **FIFO** (por sus siglas en inglés, "**F**irst **I**n, **F**irst **O**ut" o "**primero en entrar, primero en salir**"). Esto imita el comportamiento de una fila de personas.

Sus operaciones principales son:

- **Encolar** (*Enqueue*): Añade un elemento al **final** de la cola.
- **Desencolar** (*Dequeue*): Retira el elemento del **frente** de la cola.

> El principio FIFO es fundamental en sistemas operativos para la gestión de procesos o en redes para la gestión de paquetes.
> El tiempo es un factor importante.

### Listas Enlazadas (Linked Lists)

Una **lista enlazada** es una colección lineal de elementos de datos, llamados **nodos**, donde cada nodo apunta al siguiente elemento en la secuencia. A diferencia de los arreglos, los nodos **no** están necesariamente contiguos en memoria.

- **Simple:** Cada nodo tiene un enlace al *siguiente* nodo.
- **Doble:** Cada nodo tiene un enlace al *siguiente* y al *anterior*.
- **Circular:** El último nodo apunta de vuelta al *primer* nodo.

---
## Estructuras No Lineales

### Árboles (Trees)

Un **árbol** es una estructura de datos jerárquica que consta de **nodos** (valores) y **aristas** (conexiones), sin ciclos. Tienen un nodo especial llamado **raíz**. 

#### Árbol Binario (Binary Tree)

Un **árbol binario** es un tipo de árbol donde cada nodo tiene **como máximo dos hijos** (un hijo izquierdo y un hijo derecho).

#### Árbol Binario de Búsqueda (Binary Search Tree - BST)

Un **BST** es un tipo especial de árbol binario que mantiene las siguientes propiedades para facilitar la búsqueda, inserción y eliminación:

1. El valor de todos los nodos en el subárbol izquierdo de un nodo *n* es **menor** que el valor de *n*.
2. El valor de todos los nodos en el subárbol derecho de un nodo *n* es **mayor** que el valor de *n*.

Las búsquedas en un BST balanceado tienen una complejidad de tiempo $O(\log n)$.

### Grafos (Graphs)

Un **grafo** es una estructura de datos que representa un conjunto de **objetos** (llamados **vértices** o **nodos**) donde algunos pares de los objetos están conectados por **enlaces** (llamados **aristas** o **lados**).

Los grafos pueden ser:

- **Dirigidos:** Las aristas tienen una dirección (un sentido de flujo).
- **No Dirigidos:** Las aristas no tienen dirección.
- **Ponderados:** Las aristas tienen un valor o "peso" asociado.

Los grafos se usan para modelar redes sociales, mapas de carreteras, y mucho más.

### Tablas Hash (Hash Tables)

Una **tabla hash** (o mapa) es una estructura de datos que implementa un **arreglo asociativo**. Utiliza una **función hash** para calcular un índice (o *hash*) en un arreglo de ranuras o *buckets*, a partir de una **clave** para acceder a su **valor**.

Su principal característica es que la inserción, eliminación y búsqueda pueden ser muy rápidas (en promedio $O(1)$), siempre y cuando la función hash distribuya bien las claves.

---
```javascript
console.log("Las estructuras de datos son la columna vertebral de la programación eficiente.");
