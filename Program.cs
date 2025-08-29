// Ejemplo clase


Producto p = new Producto();

p.id = 1;
p.nombre = "arroz";
p.precio = 1600;
p.cantidad = 4;

Console.WriteLine($"El producto {p.nombre} cuesta {p.precio}");

Corredor juan = Corredor.Main();

Alumno.MejorPromedio();

Empleado[] empleados = [Empleado.CargarEmpleado("jose", 100, "barrendero"),
 Empleado.CargarEmpleado("jaime", 500,  "kinesiologo"), Empleado.CargarEmpleado("jacinto", 800, "cardiólogo")];
mayorSueldo(empleados);
menorSueldo(empleados);

void mayorSueldo(Empleado[] empleados)
{
    int[] sueldos = [empleados.Length];
    for (int i = 0; i < empleados.Length; i++)
    {
        sueldos[i] = empleados[i].salario;
    }
    for (int i = 0; i < empleados.Length; i++)
    {
        if (sueldos[i] == sueldos.Max())
        {
            Empleado.MostrarEmpleado(empleados[i]);
        }
    }
}

void menorSueldo(Empleado[] empleados)
{
    int[] sueldos = [empleados.Length];
    for (int i = 0; i < empleados.Length; i++)
    {
        sueldos[i] = empleados[i].salario;
    }

    for (int i = 0; i < empleados.Length; i++)
    {
        if (sueldos[i] == sueldos.Min())
        {
            Empleado.MostrarEmpleado(empleados[i]);
        }
    }
}

public struct Producto
{
    public int id;
    public string nombre;
    public float precio;
    public int cantidad;
}

// Estructura 1






public struct Corredor
{
    public string nombre;
    public int edad;
    public string sexo;
    public string club;
    public string categoria;
    public static Corredor Main()
    {
        Console.WriteLine("Ingrese a continuación los datos de su corredor");
        Corredor c = new Corredor();
        Console.WriteLine("Nombre: ");
        c.nombre = Console.ReadLine();
        Console.WriteLine("Edad: ");
        c.edad = int.Parse(Console.ReadLine());
        Console.WriteLine("Sexo: ");
        c.sexo = Console.ReadLine();
        Console.WriteLine("Club: ");
        c.club = Console.ReadLine();

        if (c.edad <= 18)
        {
            c.categoria = "Juvenil";
        }
        else if (c.edad <= 40)
        {
            c.categoria = "Señor";
        }
        else
        {
            c.categoria = "Veterano";
        }
        Console.WriteLine($"Nombre: {c.nombre} \t Edad: {c.edad} \t Sexo: {c.edad} \t Club: {c.club} \t Categoria: {c.categoria}");
        return c;
    }
}

// Ejercicio 2

public struct Alumno
{
    public string nombre;
    public int edad;
    public int promedio;
    public static Alumno PedirDatos()
    {
        Console.WriteLine("Ingrese a continuacion los datos de su alumno: ");
        Alumno a = new Alumno();
        Console.WriteLine("Nombre: ");
        a.nombre = Console.ReadLine();
        Console.WriteLine("Edad: ");
        a.edad = int.Parse(Console.ReadLine());
        Console.WriteLine("Promedio: ");
        a.promedio = int.Parse(Console.ReadLine());
        return a;
    }
    public void MostrarAlumno()
    {
        Console.WriteLine($"Nombre: {nombre}");
        Console.WriteLine($"Edad: {edad}");
        Console.WriteLine($"Promedio: {promedio}");

    }
    public static void MejorPromedio()
    {
        Alumno a = PedirDatos();
        Alumno b = PedirDatos();
        Alumno c = PedirDatos();
        int[] promedios = [a.promedio, b.promedio, c.promedio];
        Alumno[] alumnos = [a, b, c];
        for (int i = 0; i < 3; i++)
        {
            if (promedios.Max() == promedios[i])
            {
                Console.WriteLine("El alumno con mejor promedio es: ");
                alumnos[i].MostrarAlumno();
            }
        }

    }
}

// Ejercicio 3

public struct Empleado
{
    public string nombre;
    public int salario;
    public string puesto;

    public static Empleado CargarEmpleado(string n, int s, string p)
    {
        Empleado empleado = new Empleado();
        empleado.nombre = n;
        empleado.salario = s;
        empleado.puesto = p;
        return empleado;
    }

    public static void MostrarEmpleado(Empleado empleado)
    {
        Console.WriteLine("Descargando los datos del empleado...");
        Console.WriteLine($"Nombre: {empleado.nombre}");
        Console.WriteLine($"Salario: {empleado.salario}");
        Console.WriteLine($"Puesto: {empleado.puesto}");
    }
}
