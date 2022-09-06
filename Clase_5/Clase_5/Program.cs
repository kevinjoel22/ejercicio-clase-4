using System;
using System.Text;

namespace Clase_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estante estante = new Estante(3, 1);

            Producto p1 = new Producto("Pepsi", "PESDS97413", (float)18.5);
            Producto p2 = new Producto("Coca-Cola", "COSDS55752", (float)11.5);
            Producto p3 = new Producto("Manaos", "MASDS51292", (float)20.5);
            Producto p4 = new Producto("Crush", "CRSDS54861", (float)10.75);
        
            if(estante + p1)
            {
                Console.WriteLine("Agrego {0} {1} {2}", p1.GetMarca(), (string)p1, p1.GetPrecio());
            }
            else
            {
                Console.WriteLine("¡NO agregp {0} {1} {2}!", p1.GetMarca(),  (string)p1, p1.GetPrecio()  );
            }

            if (estante + p1)
            {
                Console.WriteLine("Agregó {0} {1} {2}", p1.GetMarca(), (string)p1, p1.GetPrecio());
            }
            else
            {
                Console.WriteLine("¡NO agregó {0} {1} {2}!", p1.GetMarca(), (string)p1, p1.GetPrecio());
            }

            if (estante + p2)
            {
                Console.WriteLine("Agregó {0} {1} {2}", p2.GetMarca(), (string)p2, p2.GetPrecio());
            }
            else
            {
                Console.WriteLine("¡NO agregó {0} {1} {2}!", p2.GetMarca(), (string)p2, p2.GetPrecio());
            }

            if (estante + p3)
            {
                Console.WriteLine("Agregó {0} {1} {2}", p3.GetMarca(), (string)p3, p3.GetPrecio());
            }
            else
            {
                Console.WriteLine("¡NO agregó {0} {1} {2}!", p3.GetMarca(), (string)p3, p3.GetPrecio());
            }

            if (estante + p4)
            {
                Console.WriteLine("Agregó {0} {1} {2}", p4.GetMarca(), (string)p4, p4.GetPrecio());
            }
            else
            {
                Console.WriteLine("¡NO agregó {0} {1} {2}!", p4.GetMarca(), (string)p4, p4.GetPrecio());
            }

            Console.WriteLine();
            Console.WriteLine("<--------------------------------------------->");
            Console.WriteLine(Estante.MostrarEstante(estante));


        }
    }
}

public class Producto
{
    private string codigoDeBarra;
    private string marca;
    private float precio;

    public string GetMarca()
    {


        return marca;
    }

    public float GetPrecio()
    {
        return precio;
    }

    public static string MostrarProducto(Producto p)
    {
        StringBuilder sb = new StringBuilder();

        sb.AppendLine($"marca:{p.marca}");
        sb.AppendLine($"codigo de barra:{p.codigoDeBarra}");
        sb.AppendLine($"precio:{p.precio}");

        return sb.ToString();
    }

    public static bool operator !=(Producto p, string marca)
    {
        return !(p.marca == marca);
    }

    public static bool operator !=(Producto p1, Producto p2)
    {
        return !(p1 == p2);
    }

    public static bool operator ==(Producto p, string marca)
    {
        if (p.marca == marca)
        {
            return true;
        }
        return false;
    }

    public static bool operator ==(Producto p1, Producto p2)
    {
        if (p1.marca == p2.marca && p1.codigoDeBarra == p2.codigoDeBarra)
        {
            return true;
        }
        return false;
    }

    public Producto(string marca, string codigo, float precio)
    {
        this.marca = marca;
        this.precio = precio;
        this.codigoDeBarra = codigo;

    }

    /*static explicit operator string(Producto p)
    {
        p.codigoDeBarra
        return
    }*/

}



public class Estante
{
    private int ubicacionEstante;
    private Producto[] productos;
    
    private Estante(int capacidad)
    {
        productos = new Producto[capacidad];
    }

    public Estante(int capacidad, int ubicacion) : this(capacidad)
    {
        this.ubicacionEstante = ubicacion;
    }

    public Producto[] GetProductos
    {
        get
        {
            return productos;
        }
    }

    public static string MostrarEstante(Estante e)
    {
        StringBuilder sb = new StringBuilder();

        foreach (Producto p in e.productos)
        {
            sb.AppendLine(Producto.MostrarProducto(p));
        }

        return sb.ToString();
    }

    public static bool operator !=(Estante e, Producto p)
    {

    }

    public static Estante operator -(Estante e, Producto p)
    {

    }

    public static bool operator +(Estante e, Producto p)
    {

    }

    public static bool operator ==(Estante e, Producto p)
    {
        if(p.GetMarca()== e.get)
    }

}
