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
