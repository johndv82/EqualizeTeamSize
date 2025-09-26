# EqualizeTeamSize Project

Este proyecto resuelve el problema de igualar el tamaño de equipos a partir de un arreglo inicial permitiendo reducir como máximo k equipos.

### 📝 Descripción de la solución

Solo se reduce el tamaño de algunos equipos.

Se pueden reducir como máximo k equipos.

El algoritmo elige un target de acuerdo al array ingresado y reduce los equipos más grandes hasta que se alcance el límite k.

Finalmente devuelve el arreglo resultante de equipos.

Ejemplo:
Entrada → [2, 5, 3, 3, 6, 7, 8], k = 2
Salida → [2, 5, 3, 3, 6, 3, 3]
(Aquí se redujeron los equipos de tamaño 8 y 7 al valor 3).


### 🚨 Manejo de errores

El sistema valida los siguientes casos:

k < 0 → lanza error: "Número máximo de equipos no puede ser negativo".

Algún equipo con tamaño negativo → lanza error: "El tamaño de un equipo no puede ser negativo".


### ✅ Tests incluidos

El proyecto usa XUnit para las pruebas unitarias.