using System;
using FreshMvvm;
using System.Collections.Generic;
using ProductosCharla.Models;
namespace ProductosCharla.PageModels
{
    public class ListaProductosPageModel:FreshBasePageModel
    {

        public List<Producto> Productos{get;set;}

		public override void Init(object initData)
		{
            base.Init(initData);

            Productos = new List<Producto>(){
                new Producto(){Nombre="Gafas de sol",Precio=30,Descripcion="Para que no me moleste el sol"},
                new Producto(){Nombre="Sudadera",Precio=25,Descripcion="..."},
                new Producto(){Nombre="Camiseta",Precio=15,Descripcion="..."},
                new Producto(){Nombre="Vaqueros",Precio=60,Descripcion="..."},
                new Producto(){Nombre="Zapatillas",Precio=70,Descripcion="..."},
                new Producto(){Nombre="Bañador",Precio=30,Descripcion="Para bañarme"},
                new Producto(){Nombre="Portatil",Precio=2000,Descripcion="Para programar entre baño y baño"},
                new Producto(){Nombre="Movil",Precio=800,Descripcion="Para hacer fotos y subirlas"},
             };
		}


	}
}
