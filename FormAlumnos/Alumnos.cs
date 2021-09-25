using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormAlumnos
{
    class Alumnos
    {
        private String nombre;
        private String apellido;
        private int DNI;
        private int legajo;
        private String carrera;
        private int añoDeInscripcion;


        public Alumnos(String pNombre, String pApellido, int pDNI, int pLegajo, String pCarrera, int pAñoDeInscripcion) {

            this.nombre = pNombre;
            this.apellido = pApellido;
            this.DNI = pDNI;
            this.legajo = pLegajo;
            this.carrera = pCarrera;
            this.añoDeInscripcion = pAñoDeInscripcion;
        }

    
    }
}
