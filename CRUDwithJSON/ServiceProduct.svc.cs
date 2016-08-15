using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CRUDwithJSON
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServiceProduct" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServiceProduct.svc o ServiceProduct.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServiceProduct : IServiceProduct
    {

        public List<Productos> findAll()
        {
            
            using (mydemoEntities mde = new mydemoEntities()) {
                
                return mde.Products.Select(pe => new Productos{
                    id = pe.id,
                    name = pe.name,
                    price = pe.price,
                    quantity = pe.quantity.Value
                
                }).ToList();
            };
        }

        public Productos find(string id)
        {
            using (mydemoEntities mde = new mydemoEntities())
            {

                int nid = Convert.ToInt32(id);
                return mde.Products.Where(pe => pe.id == nid).Select(pe => new Productos
                {
                    id = pe.id,
                    name = pe.name,
                    price = pe.price,
                    quantity = pe.quantity.Value

                }).First();
            };
        }

        public bool create(Productos product)
        {
            using (mydemoEntities mde = new mydemoEntities())
            {
                try {

                    Product pe = new Product();
                    pe.name = product.name;
                    pe.price = product.price;
                    pe.quantity = product.quantity;
                    mde.Products.Add(pe);
                    mde.SaveChanges();

                    return true;
                }
                catch {

                    return false;
                
                }
               
                
            };
            
        }

        public bool edit(Productos product)
        {
            using (mydemoEntities mde = new mydemoEntities())
            {
                try
                {

                    int id = Convert.ToInt32(product.id);
                    Product pe = mde.Products.Single(p => p.id == product.id);
                    pe.name = product.name;
                    pe.price = product.price;
                    pe.quantity = product.quantity;
                    mde.SaveChanges();

                    return true;
                }
                catch
                {

                    return false;

                }


            };
        }

        public bool delete(Productos product)
        {
            using (mydemoEntities mde = new mydemoEntities())
            {
                try
                {

                    int id = Convert.ToInt32(product.id);
                    Product pe = mde.Products.Single(p => p.id == product.id);
                    mde.Products.Remove(pe);
                    mde.SaveChanges();

                    return true;
                }
                catch
                {

                    return false;

                }


            };
        }
    }
}
