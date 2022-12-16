using System;

namespace corto2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            double descuento = 0;

            Empleado empleado1 = new Empleado(nombreE: "Eduardo", salarioE: 200, modalidad: 0, generoE: false, anioNac: 2001, iss: 0.03, afp: 0.07, renta: 0.10);
            Console.WriteLine(empleado1.ToString());
            Console.WriteLine(empleado1.calculoRetiro(empleado1.anioNac));
            descuento = empleado1.calculardesC();
            Console.WriteLine("EL descuento es de: " + descuento);
            Console.WriteLine("El nuevo salario es de: "+empleado1.nuevapaga(descuento));

            Empleado empleado2 = new Empleado(nombreE: "Eduardo", salarioE: 300, modalidad: 1, generoE: false, anioNAc: 1957, iss: 0.03, afp: 0.07, renta: 0.10);
            Console.WriteLine(empleado2.ToString());
            Console.WriteLine(empleado2.calculoRetiro(empleado1.anioNac));
            descuento = empleado2.calculardesC();
            Console.WriteLine("EL descuento es de: " + descuento);
            Console.WriteLine("El nuevo salario es de: "+empleado1.nuevapaga(descuento));
            
        }
        
    }
}
{
    get => renta;
    set => renta = value;
}

public string calculoRetiro(int anioNac)
{
    string mensaje = "";

    if (generoE)
    {
        if (2022 - anioNac >= 55)
        {
            mensaje = "Se puede retirar";
        }else if (2022 - anioNac < 55)
        {
            mensaje = "Aun no se puede retirar";
        }
    }else if (generoE == false)
    {
        if (2022 - anioNac >= 60)
        {
            mensaje = "Se puede retirar";
        }else if (2022 - anioNac < 60)
        {
            mensaje = "Aun no se puede retirar";
        }
    }

    return mensaje;
}

public double CaculardesC()
{
    double totaldesc = 0;

    if (modalidad == 0)
    {
        totaldesc = salarioE * renta;
    }else if (modalidad == 1)
    {
        totaldesc = (salarioE * renta) + (salarioE * iss) + (salarioE * afp);
    }

    return totaldesc;
}