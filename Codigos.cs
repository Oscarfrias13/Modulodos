using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulodos
{
    public class Codigos
    {
        public void Repeticionfor()
        {
            int cantidad;
            int valores;
            int numerosmayoresamill = 0;
            try
            {
                Console.WriteLine("Digite la cantidad de numeros que desea ingresar:");
                cantidad = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < cantidad; i++)
                {
                    Console.Write($"Ingrese el numero {i + 1}: ");
                    valores = int.Parse(Console.ReadLine());

                    if (valores >= 1000)
                    {
                        numerosmayoresamill++;

                    }


                }
                Console.WriteLine($"La cantidad de numero mayores o igual a mil son: {numerosmayoresamill}");
            }


            catch (Exception ex)
            {
                Console.WriteLine($"Se ha producido el siguiente error: {ex.Message}");
            }

        }

        public void Triangulo()
        {
            int cantidaddedatos;
            double valores;
            double superficie;
            double altura;
            int superficesmayores = 0;
            try {
                Console.WriteLine("Digite la cantidad de triangulos que desea calcular:");
                cantidaddedatos = Convert.ToInt32(Console.ReadLine());
             
               
                    for (int i = 0; i < cantidaddedatos; i++)
                    {
                        Console.WriteLine($"Ingrese la base {i + 1}");
                        valores = double.Parse(Console.ReadLine());
                        Console.WriteLine($"Ingrese la altura {i + 1}");
                        altura = double.Parse(Console.ReadLine());

                        superficie = (valores * altura) / 2;
                        Console.WriteLine($"Triangulo{i}");
                        Console.WriteLine($"la base es: {valores}");
                        Console.WriteLine($"La altura es: {altura}");
                        Console.WriteLine($"La superficie es: {superficie}");
                        if (superficie>12)
                        {
                            superficesmayores++;
                        }
                    }
                    Console.WriteLine($"La cantidad de superfices mayor a 12 son: {superficesmayores}");

            
            }
            catch (Exception ex)
            {
                Console.WriteLine($"El Siguiente error ha occurido: {ex.Message}");
            }
        }
        public void tablademultiplicar()
        {
            int tabla = 5;
            int multiplicar; 
            for (int i = 1; i <= 10; i++)
            {
                multiplicar = i * tabla;
                Console.WriteLine($"{i} x {tabla} = {multiplicar}");
            }
        }
        public void sumapromedio()
        {
            int cantidad;
            int datos;
            int conteo = 0;
            int suma =0;
            int promedio =0 ;
            try
            {
                Console.WriteLine("Cuantos valores desea ingresar?");
                cantidad = int.Parse(Console.ReadLine());

                while (conteo <= cantidad)
                {
                    Console.WriteLine($"Digite su valor {conteo}");
                    datos = int.Parse(Console.ReadLine());
                    suma = suma + datos;
                    promedio = suma / cantidad;
                    conteo++;
                }

                Console.WriteLine($"La suma de los valores ingresado es: {suma} y el promedio es {promedio}");
            } 
            catch (Exception ex)
            {
                Console.WriteLine($"El siguiente error se ha dectetado: {ex.Message}");
            }
        }
        public void programadefabrica()
        {
            int cantidad;
            int conteo=1;
            double longitud;
            int piezas=0;
            try
            {
                Console.WriteLine("Cuantas piezas ingresara?");
                cantidad = int.Parse(Console.ReadLine());
                while (conteo <= cantidad)
                {
                    Console.WriteLine($"Digite la longitud de la pieza numero {conteo}");
                    longitud = double.Parse(Console.ReadLine());
                    if ( longitud >= 1.20 && longitud <= 1.30)
                    {
                        piezas++;
                    }
                    conteo++;

                }
                Console.WriteLine($"Tiene una cantidad de {piezas} aptas.");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"El siguiente error ha ocurrido: {ex.Message}");
            }

        }
        public void notas()
        {   

            int cantidad = 0;
            int conteo=1;
            int mayores = 0;
            int menores = 0;
            int valor = 0;

            try
            {
                Console.WriteLine("Cuantas notas ingresaras?");
                cantidad=int.Parse(Console.ReadLine());
                while (conteo <= cantidad)
                {
                    Console.WriteLine($"Digite la nota numero {conteo}");
                    valor=int.Parse(Console.ReadLine());
                     if ( valor >= 7)
                    {
                        mayores++;
                    }
                     else
                    {
                        menores++;
                    }
                    conteo++;
                }
                Console.WriteLine($"Las notas mayores a 7 son: {mayores} y menores a 7 son: {menores}");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Se ha producido el siguiente error: {ex.Message}");
            }
        }
        public void sueldo()
        {
            int sueldo = 0;
            int conteo=1;
            int empleado = 0;
            int valoresdesueldo = 0;
            int empleadomas = 0;
            int gastos = 0;

            try
            {
                Console.WriteLine("Cuantos sueldos ingresar?");
                sueldo=int.Parse(Console.ReadLine());

                while (conteo <= sueldo)
                {
                    Console.WriteLine($"Digue el sueldo numero {conteo}: ");
                    valoresdesueldo=int.Parse(Console.ReadLine());
                    if (valoresdesueldo >= 100 && valoresdesueldo <= 300)
                    {
                        empleado++;
                    }
                    if (valoresdesueldo > 300)
                    {
                        empleadomas++;
                    }
                    gastos = gastos +valoresdesueldo;

                    conteo++;
                }
                Console.WriteLine($"Los empleados que cobran en el rango de 100 a 300 son: {empleado} y mayor a 300 son: {empleadomas}");
                Console.WriteLine($"La empresa gasta {gastos} en emplados");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"El siguiente error ha ocurrido:{ex.Message}");
            }
        }

    }
}
