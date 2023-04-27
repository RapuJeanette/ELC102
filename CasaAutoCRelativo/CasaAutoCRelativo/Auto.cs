using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace CasaAutoCRelativo
{
    internal class Auto
    {
        private float alto, largo, ancho;
        private Vector3 vector;  // posicion del objeto

        public Auto(Vector3 v, float alto, float largo, float ancho)
        {

            vector = v;
            this.largo = largo; //length
            this.alto = alto;   //height
            this.ancho = ancho; //width}
        }

        public void Dibujar()
        { 
            // LADO DERECHO PRIMERO
            GL.Begin(PrimitiveType.LineLoop);
            GL.Color4(Color.Black);
            GL.Vertex3(vector.X + alto/50, vector.Y + largo/7, vector.Z- ancho -0.1);
            GL.Vertex3(vector.X + alto/40, vector.Y + largo/8, vector.Z);
            GL.Vertex3(vector.X + alto/40, vector.Y + largo/8, vector.Z - ancho - 0.1);
            GL.Vertex3(vector.X + alto/50, vector.Y + largo/7, vector.Z - ancho - 0.1);
            GL.Vertex3(vector.X + alto / 50, vector.Y + largo / 7, vector.Z - ancho - 0.4);
            GL.Vertex3(vector.X + alto / 40, vector.Y + largo / 8, vector.Z - ancho - 0.5);
            GL.Vertex3(vector.X + alto / 40, vector.Y + largo / 8, vector.Z);
            GL.End();

            //LADO DERECHO SEGUNDO
            GL.Begin(PrimitiveType.LineLoop);
            GL.Color4(Color.Black);
            GL.Vertex3(vector.X + alto / 40, vector.Y + largo / 8, vector.Z);
            GL.Vertex3(vector.X + alto / 40, vector.Y + largo / 10, vector.Z - ancho + 0.2);
            GL.Vertex3(vector.X + alto / 40, vector.Y + largo / 10, vector.Z - ancho - 0.6);
            GL.Vertex3(vector.X + alto / 40, vector.Y + largo / 8, vector.Z- ancho - 0.5);
            GL.End();

            //SEPARACION DE PUERTAS DERECHA
            GL.Begin(PrimitiveType.LineLoop);
            GL.Color4(Color.Black);
            GL.Vertex3(vector.X + alto / 50, vector.Y + largo / 7, vector.Z - ancho - 0.25);
            GL.Vertex3(vector.X + alto / 40, vector.Y + largo / 8, vector.Z - ancho - 0.25);
            GL.Vertex3(vector.X + alto / 40, vector.Y + largo / 10, vector.Z - ancho - 0.25);
            GL.Vertex3(vector.X + alto / 40, vector.Y + largo / 12.5, vector.Z - ancho - 0.25);
            GL.End();

            //Ventana atras derecho
            GL.Begin(PrimitiveType.LineLoop);
            GL.Color4(Color.Black);
            GL.Vertex3(vector.X + alto / 50, vector.Y + largo / 7, vector.Z - ancho - 0.4);
            GL.Vertex3(vector.X + alto / 40, vector.Y + largo / 8, vector.Z - ancho - 0.4);
            GL.End();

            //PARTE ABAJO DERECHO
            GL.Begin(PrimitiveType.LineLoop);
            GL.Color4(Color.Black);
            GL.Vertex3(vector.X + alto / 40, vector.Y + largo / 10, vector.Z + ancho + 0.2);
            GL.Vertex3(vector.X + alto / 40, vector.Y + largo / 12.5, vector.Z - ancho + 0.2);
            GL.Vertex3(vector.X + alto / 40, vector.Y + largo / 12.5, vector.Z - ancho - 0.6);
            GL.Vertex3(vector.X + alto / 40, vector.Y + largo / 10, vector.Z - ancho - 0.6);
            GL.End();

            // LADO IZQUIERDO PRIMERO
            GL.Begin(PrimitiveType.LineLoop);
            GL.Color4(Color.Black);
            GL.Vertex3(vector.X, vector.Y + largo / 7, vector.Z - ancho - 0.1);
            GL.Vertex3(vector.X - alto / 200, vector.Y + largo / 8, vector.Z);
            GL.Vertex3(vector.X - alto / 200, vector.Y + largo / 8, vector.Z - ancho - 0.1);
            GL.Vertex3(vector.X, vector.Y + largo / 7, vector.Z - ancho - 0.1);
            GL.Vertex3(vector.X, vector.Y + largo / 7, vector.Z - ancho - 0.4);
            GL.Vertex3(vector.X - alto / 200, vector.Y + largo / 8, vector.Z - ancho - 0.5);
            GL.Vertex3(vector.X - alto / 200, vector.Y + largo / 8, vector.Z - ancho - 0.1);
            GL.End();

            //LADO iZQUIERDO SEGUNDO
            GL.Begin(PrimitiveType.LineLoop);
            GL.Color4(Color.Black);
            GL.Vertex3(vector.X - alto / 200, vector.Y + largo / 8, vector.Z);
            GL.Vertex3(vector.X - alto / 200, vector.Y + largo / 8, vector.Z - ancho - 0.5);
            GL.Vertex3(vector.X - alto / 200, vector.Y + largo / 10, vector.Z - ancho - 0.6);
            GL.Vertex3(vector.X - alto / 200, vector.Y + largo / 10, vector.Z - ancho + 0.2);
            GL.End();

            //SEPARACION DE PUERTAS IZQUIERDA
            GL.Begin(PrimitiveType.LineLoop);
            GL.Color4(Color.Black);
            GL.Vertex3(vector.X, vector.Y + largo / 7, vector.Z - ancho - 0.25);
            GL.Vertex3(vector.X - alto / 200, vector.Y + largo / 8, vector.Z - ancho - 0.25);
            GL.Vertex3(vector.X - alto / 200, vector.Y + largo / 10, vector.Z - ancho - 0.25);
            GL.Vertex3(vector.X - alto / 200, vector.Y + largo / 12.5, vector.Z - ancho - 0.25);
            GL.End();

            //Ventana atras IZQUIERDO
            GL.Begin(PrimitiveType.LineLoop);
            GL.Color4(Color.Black);
            GL.Vertex3(vector.X, vector.Y + largo / 7, vector.Z - ancho - 0.4);
            GL.Vertex3(vector.X - alto / 200, vector.Y + largo / 8, vector.Z - ancho - 0.4);
            GL.End();

            //PARTE ABAJO IZQUIERDO
            GL.Begin(PrimitiveType.LineLoop);
            GL.Color4(Color.Black);
            GL.Vertex3(vector.X - alto / 200, vector.Y + largo / 10, vector.Z + ancho + 0.2);
            GL.Vertex3(vector.X - alto / 200, vector.Y + largo / 12.5, vector.Z - ancho + 0.2);
            GL.Vertex3(vector.X - alto / 200, vector.Y + largo / 12.5, vector.Z - ancho - 0.6);
            GL.Vertex3(vector.X - alto / 200, vector.Y + largo / 10, vector.Z - ancho - 0.6);
            GL.End();

            //VIDRIO TRASERO
            GL.Begin(PrimitiveType.LineLoop);
            GL.Color4(Color.Black);
            GL.Vertex3(vector.X, vector.Y + largo / 7, vector.Z + ancho - 0.4);
            GL.Vertex3(vector.X + alto / 50, vector.Y + largo / 7, vector.Z - ancho - 0.4);
            GL.Vertex3(vector.X + alto / 40, vector.Y + largo / 8, vector.Z - ancho - 0.5);
            GL.Vertex3(vector.X - alto / 200, vector.Y + largo / 8, vector.Z - ancho - 0.5);
            GL.End();

            //VIDRIO TRASERO
            GL.Begin(PrimitiveType.LineLoop);
            GL.Color4(Color.Black);
            GL.Vertex3(vector.X + alto /40, vector.Y + largo / 8, vector.Z + ancho - 0.5);
            GL.Vertex3(vector.X - alto / 200, vector.Y + largo / 8, vector.Z - ancho - 0.5);
            GL.Vertex3(vector.X - alto / 200, vector.Y + largo / 10, vector.Z - ancho - 0.6);
            GL.Vertex3(vector.X + alto / 40, vector.Y + largo / 10, vector.Z - ancho - 0.6);
            GL.End();


            //LADO DE LUCES TRASERAS
            GL.Begin(PrimitiveType.LineLoop);
            GL.Color4(Color.Black);
            GL.Vertex3(vector.X + alto / 40, vector.Y + largo / 10, vector.Z + ancho - 0.6);
            GL.Vertex3(vector.X - alto / 200, vector.Y + largo / 10, vector.Z - ancho - 0.6);
            GL.Vertex3(vector.X - alto / 200, vector.Y + largo / 12.5 , vector.Z - ancho - 0.6);
            GL.Vertex3(vector.X + alto / 40, vector.Y + largo / 12.5, vector.Z - ancho - 0.6);
            GL.End();

            //PARABRISAS
            GL.Begin(PrimitiveType.LineLoop);
            GL.Color4(Color.Black);
            GL.Vertex3(vector.X, vector.Y + largo / 7, vector.Z - ancho - 0.1);
            GL.Vertex3(vector.X + alto / 50, vector.Y + largo / 7, vector.Z - ancho - 0.1);
            GL.Vertex3(vector.X + alto / 40, vector.Y + largo / 8, vector.Z);
            GL.Vertex3(vector.X - alto / 200, vector.Y + largo / 8, vector.Z);
            GL.End();

            //CAPO DEL AUTO
            GL.Begin(PrimitiveType.LineLoop);
            GL.Color4(Color.Black);
            GL.Vertex3(vector.X + alto /40, vector.Y + largo / 8, vector.Z);
            GL.Vertex3(vector.X - alto / 200, vector.Y + largo / 8, vector.Z);
            GL.Vertex3(vector.X - alto / 200, vector.Y + largo / 10, vector.Z + ancho + 0.2);
            GL.Vertex3(vector.X + alto / 40, vector.Y + largo / 10, vector.Z + ancho + 0.2);
            GL.End();

            //LADO DE LUCES DELANTERAS
            GL.Begin(PrimitiveType.LineLoop);
            GL.Color4(Color.Black);
            GL.Vertex3(vector.X - alto / 200, vector.Y + largo / 10, vector.Z + ancho + 0.2);
            GL.Vertex3(vector.X + alto / 40, vector.Y + largo / 10, vector.Z + ancho + 0.2);
            GL.Vertex3(vector.X + alto / 40, vector.Y + largo / 12.5, vector.Z + ancho + 0.2);
            GL.Vertex3(vector.X - alto / 200, vector.Y + largo / 12.5, vector.Z + ancho + 0.2);
            GL.End();


        }
    }

}
