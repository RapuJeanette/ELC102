using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK.Graphics.OpenGL;

namespace CasaAuto
{
    internal class AutoLadoIzquierdo
    {
        public AutoLadoIzquierdo() { }

        public void dibujar()
        {
            //LADO PUERTAS IZQUIERDAS 
            GL.Begin(PrimitiveType.Polygon);
            GL.Color4(Color.DarkOliveGreen);
            GL.Vertex3(0, 0.7, -0.1);
            GL.Vertex3(-0.05, 0.6, 0);
            GL.Vertex3(-0.05, 0.6, -0.1);
            GL.Vertex3(0, 0.7, -0.1);
            GL.Vertex3(0, 0.7, -0.4);
            GL.Vertex3(-0.05, 0.6, -0.5);
            GL.Vertex3(-0.05, 0.6, -0.1);
            GL.End();

            //PARTE IZQUIERDO ABAJO
            GL.Begin(PrimitiveType.Quads);
            GL.Color4(Color.Gray);
            GL.Vertex3(-0.05, 0.6, 0);
            GL.Vertex3(-0.05, 0.6, -0.5);
            GL.Vertex3(-0.05, 0.5, -0.6);
            GL.Vertex3(-0.05, 0.5, 0.2);
            GL.End();

            //SEPARANCION DE PUERTAS IZQUIERDA
            GL.Begin(PrimitiveType.LineLoop);
            GL.Color4(Color.Black);
            GL.Vertex3(0, 0.7, -0.25);
            GL.Vertex3(-0.05, 0.6, -0.25);
            GL.Vertex3(-0.05, 0.5, -0.25);
            GL.Vertex3(-0.05, 0.4, -0.25); ;
            GL.End();

            //VENTANA ATRAS IZQUIERDO
            GL.Begin(PrimitiveType.LineLoop);
            GL.Color4(Color.Black);
            GL.Vertex3(0, 0.7, -0.4);
            GL.Vertex3(-0.05, 0.6, -0.4);
            GL.End();

            //PARTE ABAJO IZQUIERDO
            GL.Begin(PrimitiveType.Quads);
            GL.Color4(Color.DarkSeaGreen);
            GL.Vertex3(-0.05, 0.5, 0.2);
            GL.Vertex3(-0.05, 0.4, 0.2);
            GL.Vertex3(-0.05, 0.4, -0.6);
            GL.Vertex3(-0.05, 0.5, -0.6); ;
            GL.End();
        }
    }
}
