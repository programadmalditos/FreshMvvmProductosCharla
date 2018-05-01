using System;
using PropertyChanged;

namespace ProductosCharla.Models
{

    [AddINotifyPropertyChangedInterface]
    public class Producto
    {
      
        public string Nombre
        {
            get;
            set;
        }
        public Double Precio
        {
            get;
            set;
        }
        public string Descripcion
        {
            get;
            set;
        }

    }
}
