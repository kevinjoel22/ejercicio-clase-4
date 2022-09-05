using System;
using System.Text;
namespace Clase_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Producto producto1 = new Producto(1, "alfajor", 150, 100);
            Producto producto2 = new Producto(221, " chupetin", 50, 12);


            int total = producto1 + producto2;

            Console.WriteLine("stock total ${0}", total);

            int stock = producto1 + 10;

            if(producto1 == 1)
            {
                Console.WriteLine("son iguales");
            }
            else
            {
                Console.WriteLine("mal ahi compa, tas re equivocado");
            }

            int id = (int) producto1;
            Console.WriteLine("Explicito {0}",id);

            string nombre = producto1;
            Console.WriteLine("nombre {0}",nombre);


        }
    }

    //propiedad
   /* public int MyProperty 
    {
        
        set
        {
            //asignar valor
            this.Puertas = value;
        }
        get
        {
            //retornar
            return this.puertas;
        }

    }*/
    


}

public class Personas
{
    private int dni;
    private string nombre;
    private string legajo;

    public Personas()
    {
        dni = 0;
        nombre = "";
    }

    public Personas(string nombre)
    {
        this.nombre = nombre;   
    }

    public Personas(string nombre, int dni): this(nombre)
    {
        dni = dni;
    }

    public Personas(string nombre, string legajo, int dni): this(nombre, dni)
    {
        this.legajo = legajo;
    }

}

/*
 * clase producto
 * nombre (string) 
 * precio (int)
 * stock (int)
 * --------------
 * Procuto (string)
 * producto (string, int)
 * producto (string, int, int)
 *
 */

public class Producto
{
    private string nombre;
    private int precio;
    private int stock;
    private int id;

    #region CONSTRUCTORES

    public Producto(int id)
    {
        this.id = id;
        this.nombre="";
        this.precio = 0;
        this.stock = 0;
    }

    public Producto(int id, string nombre) : this(id)
    {
        nombre = nombre;
        precio = 0;
        stock = 0;
    }

    public Producto(int id, string nombre, int precio) : this(id, nombre)
    {
        precio = precio;
        stock = 0;
    }

    public Producto(int id, string nombre, int precio, int stock) : this(id, nombre, precio)
    {
        stock=stock;
    }

    public int Precio
    {
        get
        {
            return this.Precio;
        }
        set
        {
            precio=value;
        }
    }
    public string Nombre
    {
        get
        {
            return this.nombre;
        }
        set
        {
            nombre=value;
        }
    }
    public int Stock
    {
        get
        {
            return this.stock;
        }
        set
        {
            stock=value;
        }
    }
    public int Id
    {
        get
        {
            return this.id;
        }
    }
    #endregion


    #region METODOS

    public void Mostrar()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("Producto");
        sb.AppendLine("ID");
        sb.AppendLine("PRECIO");
        sb.AppendLine("STOCK");
        sb.AppendLine("");

        Console.WriteLine(sb.ToString());
    }

    public void Mostrar(ConsoleColor backColor)
    {
        Console.BackgroundColor = backColor;
        Mostrar();
    }




    #endregion



    #region OPERADORES

    public static int operator +(Producto p1, Producto p2)
    {
        return (p1.Stock * p1.precio) + (p2.Stock * p2.precio);
    }

    public static int operator +(Producto p1 , int n1)
    {
        return p1.Stock + n1;
    }

    public static bool operator ==(Producto p1, int id)
    {
        return p1.id == id;
    }

    public static bool operator !=(Producto p1, int id)
    {
        return !(p1.id == id);
    }

    public static int operator -(Producto p1, int n1)
    {
        return p1.Stock - n1;
    }

    public static explicit operator int(Producto p1)
    {
        return p1.id;
    }



    public static implicit operator string(Producto p1)
    {
        return p1.nombre;
    }
    #endregion
}









