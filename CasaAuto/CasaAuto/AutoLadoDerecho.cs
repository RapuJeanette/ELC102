using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK.Graphics.OpenGL;

namespace CasaAuto
{
    internal class AutoLadoDerecho
    {
        public AutoLadoDerecho() { }

        public void dibujar()
        {
            //LADO DERECHO ARRIBA
            GL.Begin(PrimitiveType.Polygon);
            GL.Color4(Color.DarkViolet);
            GL.Vertex3(0.2, 0.7, -0.1);
            GL.Vertex3(0.25, 0.6, 0);
            GL.Vertex3(0.25, 0.6, -0.1);
            GL.Vertex3(0.2, 0.7, -0.1);
            GL.Vertex3(0.2, 0.7, -0.4);
            GL.Vertex3(0.25, 0.6, -0.5);
            GL.Vertex3(0.25, 0.6, 0);
            GL.End();

            //PARTE DERECHA ABAJO
            GL.Begin(PrimitiveType.Quads);
            GL.Color4(Color.LightSlateGray);
            GL.Vertex3(0.25, 0.6, 0);
            GL.Vertex3(0.25, 0.5, 0.2);
            GL.Vertex3(0.25, 0.5, -0.6);
            GL.Vertex3(0.25, 0.6, -0.5);
            GL.End();

            //SEPARANCION DE PUERTAS DERECHA
            GL.Begin(PrimitiveType.LineLoop);
            GL.Color4(Color.Black);
            GL.Vertex3(0.2, 0.7, -0.25);
            GL.Vertex3(0.25, 0.6, -0.25);
            GL.Vertex3(0.25, 0.5, -0.25);
            GL.Vertex3(0.25, 0.4, -0.25); ;
            GL.End();

            //VENTANA ATRAS DERECHO
            GL.Begin(PrimitiveType.LineLoop);
            GL.Color4(Color.Black);
            GL.Vertex3(0.2, 0.7, -0.4);
            GL.Vertex3(0.25, 0.6, -0.4);
            GL.End();

            //PARTE ABAJO DERECHO
            GL.Begin(PrimitiveType.Quads);
            GL.Color4(Color.DarkSeaGreen);
            GL.Vertex3(0.25, 0.5, 0.2);
            GL.Vertex3(0.25, 0.4, 0.2);
            GL.Vertex3(0.25, 0.4, -0.6);
            GL.Vertex3(0.25, 0.5, -0.6); ;
            GL.End();
        }
    }
}
