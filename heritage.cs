using System;

public class Point3D
{
    public double X { get; set; }
    public double Y { get; set; }
    public double Z { get; set; }

    public Point3D(double x, double y, double z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    public override string ToString()
    {
        return $"[Point3D x : {X}, y : {Y}, z : {Z}]";
    }

    public override bool Equals(object obj)
    {
        if (obj is Point3D other)
        {
            return X == other.X && Y == other.Y && Z == other.Z;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(X, Y, Z);
    }
}

public abstract class Forme
{
    public Point3D CentreGravite { get; set; }

    protected Forme(Point3D centreGravite)
    {
        CentreGravite = centreGravite;
    }
    public void Bouger(double x, double y, double z)
    {
        CentreGravite.X += x;
        CentreGravite.Y += y;
        CentreGravite.Z += z;
    }

    public abstract double CalculerSurface();
    public abstract double CalculerVolume();

    public override string ToString()
    {
        return $"[{GetType().Name}\ncentre de gravité : {CentreGravite}]";
    }
}

public class Boule : Forme
{
    public double Rayon { get; set; }

    public Boule(Point3D centreGravite, double rayon) : base(centreGravite)
    {
        Rayon = rayon;
    }

    public override double CalculerSurface()
    {
        return 4 * Math.PI * Math.Pow(Rayon, 2);
    }

    public override double CalculerVolume()
    {
        return (4 / 3) * Math.PI * Math.Pow(Rayon, 3);
    }

    public override string ToString()
    {
        return base.ToString() + $"\nrayon : {Rayon}\n]";
    }

    public override bool Equals(object obj)
    {
        if (obj is Boule other)
        {
            return CentreGravite.Equals(other.CentreGravite) && Rayon == other.Rayon;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(CentreGravite, Rayon);
    }
}

public class Brique : Forme
{
    public double Largeur { get; set; }
    public double Longueur { get; set; }
    public double Hauteur { get; set; }

    public Brique(Point3D centreGravite, double largeur, double longueur, double hauteur) 
        : base(centreGravite)
    {
        Largeur = largeur;
        Longueur = longueur;
        Hauteur = hauteur;
    }

    public override double CalculerSurface()
    {
        return 2 * (Largeur * Longueur + Largeur * Hauteur + Longueur * Hauteur);
    }

    public override double CalculerVolume()
    {
        return Largeur * Longueur * Hauteur;
    }

    public override string ToString()
    {
        return base.ToString() + $"\nlargeur : {Largeur}\nlongueur : {Longueur}\nhauteur : {Hauteur}\n]";
    }
}

public sealed class Cube : Brique
{
    public Cube(Point3D centreGravite, double cote) 
        : base(centreGravite, cote, cote, cote)
    {
    }

    public override string ToString()
    {
        return base.ToString() + "\n(C'est un cube)";
    }
}