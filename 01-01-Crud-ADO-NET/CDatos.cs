using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_01_Crud_ADO_NET
{
    class CDatos
    {
        crudbasicEntities db;

        public void Create(persona opPersona)
        {
            try
            {
                using(db=new crudbasicEntities())
                {
                    db.persona.Add(opPersona);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public List<persona> Read()
        {
            try
            {
                using(db=new crudbasicEntities())
                {
                    return db.persona.ToList();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
        public void update(persona opPersona)
        {
            try
            {
                using(db=new crudbasicEntities())
                {
                    db.Entry(opPersona).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void Delete(int opId)
        {
            try
            {
                using(db=new crudbasicEntities())
                {
                    db.persona.Remove(db.persona.Single
                        (p => p.id == opId));
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public List<persona> buscarId(int opId)
        {
            try
            {
                using(db = new crudbasicEntities())
                {
                    return db.persona.Where(p => p.id == opId).ToList();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
        public List<persona> buscarNombre(string opNombre)
        {
            try
            {
                using(db = new crudbasicEntities())
                {
                    return db.persona.Where(p =>
                    p.nombre.Contains(opNombre)).ToList();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

    }
}
