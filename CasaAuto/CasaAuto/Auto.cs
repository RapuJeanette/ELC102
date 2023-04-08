using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaAuto
{
    class Auto
    {
        private ParteAuto parteauto;
        private Llantas llantas;
        private BordeAuto bordeauto;
        private ParteAtrasAuto parteAtrasAuto;
        private AutoLadoIzquierdo autoLadoIzquierdo;
        private AutoLadoDerecho autoLadoDerecho;

        public Auto()
        {
            parteauto = new ParteAuto();
            llantas = new Llantas();
            bordeauto = new BordeAuto();
            parteAtrasAuto = new ParteAtrasAuto();
            autoLadoIzquierdo=new AutoLadoIzquierdo();
            autoLadoDerecho = new AutoLadoDerecho();
        }

        public void dibujar()
        {
            parteauto.dibujar();
            llantas.dibujar();
            bordeauto.dibujar();
            parteAtrasAuto.dibujar();
            autoLadoIzquierdo.dibujar();
            autoLadoDerecho.dibujar();
        }
    }
}
