using System.Numerics;
using System;

namespace mb {

public class Triangle : Figure
{
    private Vector2 A_ = new();
    private Vector2 B_ = new();
    private Vector2 C_ = new();

    public Triangle(Vector2 A, Vector2 B, Vector2 C)
    {
        A_ = A;
        B_ = B;
        C_ = C;
        // todo - проверить, что точки не лежат на одной кривой - выкинуть исключение
    }

    public float Square()
    {
        return 0.5f*Math.Abs((B_.X - A_.X)*(C_.Y - A_.Y) - (C_.X - A_.X)*(B_.Y - A_.Y));
    }

    public bool IsRight()
    {
        float eps = 1e-3f;

        var sides = new List<float>();

        sides.Add(Vector2.Distance(A_, B_));
        sides.Add(Vector2.Distance(A_, C_));
        sides.Add(Vector2.Distance(B_, C_));

        sides.Sort();

        return sides[2]*sides[2] - sides[1]*sides[1] - sides[0]*sides[0] < eps;
    }
}

}// namespace