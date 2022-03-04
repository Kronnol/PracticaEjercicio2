using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Azure;
using EO.WebBrowser.DOM;
using ParteDos.Modelo;

namespace ParteDos.Clases
{
    public class ModeloEmpleado
    {
        PractExa1Entities db = new PractExa1Entities();

        public List<empleado> mostrar()
        {
            return db.empleadoes.ToList();
        }

        public empleado extraerAlumno(int codigo)
        {
            empleado objalumno = db.empleadoes.Single(x => x.codigo_empleado == codigo);
            return objalumno;
        }
        public void borrarAlumno(int codigo)
        {
            empleado objalumno = db.empleadoes.Single(x => x.codigo_empleado == codigo);
            db.empleadoes.Remove(objalumno);
            db.SaveChanges();
           
        }


    }
}