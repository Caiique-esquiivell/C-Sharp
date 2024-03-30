namespace pi
{
    public static class Calculadora
    {
        public static double PI = 3.14;
         public static double Circunferencia(double R)
            {
                return 2.0 * PI * R;
            }

            public static double Volume(double R)
            {
                return 4.0 / 3.0 * PI * Math.Pow(R, 3.0);
            }
    }
}