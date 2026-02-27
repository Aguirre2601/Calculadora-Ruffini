# 🧮 Ruffini Polynomial Solver

Una aplicación de escritorio robusta desarrollada en C# y Windows Forms diseñada para encontrar raíces reales en polinomios de hasta quinto grado. 

El sistema emplea una arquitectura multicapa para separar la lógica de validación, los cálculos algebraicos y la interfaz de usuario.

## 🚀 Características 

Resolución de Polinomios:

Calcula raíces para expresiones algebraicas de grado 1 hasta grado 5.

Algoritmos Matemáticos:Implementación del Método de Ruffini (División Sintética).

Uso del Teorema del Resto y búsqueda de divisores para el término independiente.

Resolución automática de ecuaciones de segundo grado mediante la fórmula cuadrática ($ax^2 + bx + c = 0).

Validación Inteligente: Sistema de detección de errores en tiempo real para asegurar que la sintaxis del polinomio sea correcta (evita caracteres duplicados, puntos excesivos o formatos inválidos).

Arquitectura Limpia: Separación de responsabilidades en tres capas (CapaDiseño, CapaNegocio, CapaCalculos).

## 🛠️ Detalles Técnicos

Arquitectura de Capas

El proyecto está organizado para facilitar el mantenimiento y la escalabilidad:

UI (Capa de Diseño): Gestiona la interacción con el usuario y la visualización de resultados a través de ErrorProvider.

CapaNegocio (Validación): Contiene la clase Validar que limpia y verifica la cadena de texto ingresada mediante lógica de filtrado de caracteres permitidos.

CapaCalculos (Motor Matemático): La clase CalculaRaiz se encarga de:Separar términos y extraer coeficientes por exponente.

Identificar divisores del término independiente.

Iterar mediante Ruffini hasta reducir el grado del polinomio o encontrar las raíces.

### Lógica de Validación
- El sistema no permite errores comunes de entrada, validando:

   -Caracteres permitidos: x, -, +, ^, ,, 0-9.
  
   -Prevención de operadores repetidos (ej. ++, --, ^^).
  
   -Control estricto de decimales para evitar formatos como 1.0.2.

## 💻 Instalación y Uso

Clona este repositorio.
Abre la solución (.sln) en Visual Studio.
Compila y ejecuta el proyecto TP_2_POO.
Ingresa un polinomio en el cuadro de texto (ejemplo: 1x^2-5x+6) y presiona Agregar.

## 🧪 Ejemplo de Cálculo

Para un polinomio de segundo grado: $$f(x) = x^2 - 5x + 6$$ 

El sistema identificará los coeficientes, aplicará la resolución cuadrática y devolverá:
Raíz 1: 3
Raíz 2: 2

## 🛠 Tecnologías Utilizadas

Lenguaje: C# (.NET Framework)

Interfaz: Windows Forms

IDE: Visual Studio
