Investigar datatypes en c#
reference vs value types

-----
Los tipos de datos se clasifican en dos categorias, tipo de valor y tipo de referencia

Tipos de Valor

Los tipos de valor contienen directamente sus datos. Estos tipos se almacenan en la pila, lo que significa que si asignas una variable de un tipo de valor a otra, cada variable trabaja con su propia copia independiente de los datos. Cambiar uno no afecta al otro. 
Los tipos de valor incluyen:
Tipos simples: int, double, bool, char, etc.



Tipos de Referencia
Los tipos de referencia almacenan una referencia a sus datos, no los datos en sí. Estos tipos se almacenan en el montón, y dos variables pueden referenciar al mismo objeto, quiere decir que los cambios en uno pueden afectar al otro. Los tipos de referencia incluyen:

Clases: Incluyen tipos definidos por el usuario (como clases, interfaces).


Diferencias Clave
Almacenamiento: Los tipos de valor se almacenan en la pila, y los tipos de referencia se almacenan en el montón.
Copia: Al copiar una variable de tipo de valor, se crea una copia independiente de los datos. Con los tipos de referencia, copiar una variable simplemente copia la referencia, no el objeto en sí.
Nullabilidad: Los tipos de valor no pueden ser null por defecto (a menos que se utilicen tipos de valor anulables, introducidos con ?). Los tipos de referencia pueden ser null.

int a = 10; // Tipo de valor
int b = a; // Copia de a
b = 20; // Cambiar b no afecta a a

object obj1 = new object(); // Tipo de referencia
object obj2 = obj1; // obj2 referencia al mismo objeto que obj1

En este ejemplo, cambiar b no afecta a a porque son tipos de valor independientes. Sin embargo, obj1 y obj2 son tipos de referencia que apuntan al mismo objeto, por lo que cambiar uno afectaría al otro si modificáramos el objeto a través de una de las variables.


Principio KISS (Keep It Simple, Stupid)
El principio KISS es una filosofía de diseño que enfatiza la simplicidad y evitar la complejidad innecesaria.


El principio YAGNI (You Aren't Gonna Need It) es una filosofía en el desarrollo de software que enfatiza la importancia de no implementar funcionalidades adicionales hasta que realmente se necesiten.