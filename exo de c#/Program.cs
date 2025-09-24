using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TU_Challenge
{
    public struct Vector3
    {
        public float x, y, z;

        public Vector3(float _X, float _Y, float _Z)
        {
            x = _X;
            y = _Y;
            z = _Z;
        }

        public float GetX() { return x; }
        public float GetY() { return y; }
        public float GetZ() { return z; }


        public float Magnitude(Vector3 vecteur)
        {

            float magnitude;

            magnitude = (vecteur.x * x + vecteur.y * y + vecteur.z * z);

            return magnitude;
        }

        public float SqrtMagnitude(Vector3 vecteur)
        {

            float Sqrtmagnitude = (float)Math.Sqrt(Magnitude(vecteur));

            return Sqrtmagnitude;
        }

        public Vector3 Normalize(Vector3 vecteur)
        {

            vecteur = new Vector3(GetX() / SqrtMagnitude(vecteur), GetY() / SqrtMagnitude(vecteur), GetZ() / SqrtMagnitude(vecteur));

            return vecteur;
        }

    }
}
    