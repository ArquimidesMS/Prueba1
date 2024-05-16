using System;

namespace OperacionMatematica
{
    // Clase abstracta para operaciones matemáticas
    public abstract class Operacion
    {
        public abstract decimal Calcular(decimal num1, decimal num2);
    }

    // Clase concreta que representa la operación de multiplicación
    public class Multiplicacion : Operacion
    {
        public override decimal Calcular(decimal num1, decimal num2)
        {
            return num1 * num2;
        }
    }
}