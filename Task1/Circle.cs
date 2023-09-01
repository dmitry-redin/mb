using System;
using System;
using System.Numerics;

namespace mb {

public class Circle : Figure {
    private Vector2 center_ = new();
    private float radius_ = 1f;
    public Circle(Vector2 center, float radius)
    {
        center_ = center;
        radius_ = radius;
        // todo - проверить радиус на неположительное значение->выкинуть исключение
    }

    public float Square()
    {
        return ((float)Math.PI)*radius_*radius_;
    }
}

}// namespace