global using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    public class Usings
    {
        [Test]
        [TestCase(1,2,3)]
        public void V3Creation(float x, float y , float z)
        {
            Vector3 v = new Vector3(x, y, z);

            float a = 0.1f;
            float b = 0.2f;
            float c = 0.3f;

            Assert.That(v.GetX, Is.EqualTo(x).Within(0.0001f));
        }
    }
}
