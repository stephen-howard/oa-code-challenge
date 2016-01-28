using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerDomainModel;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq.Expressions;

namespace CustomerDAL
{
    public class GenericDataRepository<T> : IGenericDataRepository<T> where T : class
    {
        public IList<CRUDErrors> Errors = new List<CRUDErrors>();

        public virtual IList<CRUDErrors> GetCRUDErrors()  // Model Errors 
        {
            return Errors;
        }

        public virtual IList<T> GetAll(params Expression<Func<T, object>>[] navigationProperties)
        {
            List<T> list;
            using (var context = new CustomerEntities())
            {
                IQueryable<T> dbQuery = context.Set<T>();

                //Apply eager loading
                foreach (Expression<Func<T, object>> navigationProperty in navigationProperties)
                    dbQuery = dbQuery.Include<T, object>(navigationProperty);

                list = dbQuery
                    .AsNoTracking()
                    .ToList<T>();
            }
            return list;
        }

        public virtual IList<T> GetAllPaged(int pageNumber, int recordCount, Expression<Func<T, string>> orderBy, params Expression<Func<T, object>>[] navigationProperties)
        {
            List<T> list;
            using (var context = new CustomerEntities())
            {
                IQueryable<T> dbQuery = context.Set<T>();

                //Apply eager loading
                foreach (Expression<Func<T, object>> navigationProperty in navigationProperties)
                    dbQuery = dbQuery.Include<T, object>(navigationProperty);

                list = dbQuery
                    .AsNoTracking()
                    .OrderByDescending(orderBy)
                    .Skip(pageNumber * recordCount)
                    .Take(recordCount)
                    .ToList<T>();
            }
            return list;
        }

        public int GetTotalRecordCount()
        {
            int count;
            using (var context = new CustomerEntities())
            {
                // var objectContext = context.ToObjectContext();
                IQueryable<T> dbQuery = context.Set<T>();
                count = dbQuery.Count();
            }
            return count;
        }

        public virtual IList<T> GetList(Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties)
        {
            List<T> list;
            using (var context = new CustomerEntities())
            {
                IQueryable<T> dbQuery = context.Set<T>();

                //Apply eager loading
                foreach (Expression<Func<T, object>> navigationProperty in navigationProperties)
                    dbQuery = dbQuery.Include<T, object>(navigationProperty);

                list = dbQuery
                    .AsNoTracking()
                    .Where(where)
                    .ToList<T>();
            }
            return list;
        }

        public virtual T GetSingle(Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties)
        {
            T item = null;
            using (var context = new CustomerEntities())
            {
                IQueryable<T> dbQuery = context.Set<T>();

                //Apply eager loading
                foreach (Expression<Func<T, object>> navigationProperty in navigationProperties)
                    dbQuery = dbQuery.Include<T, object>(navigationProperty);

                item = dbQuery
                    .AsNoTracking() //Don't track any changes for the selected item
                    .FirstOrDefault(where); //Apply where clause
            }
            return item;
        }

        public virtual void Add(params T[] items)
        {
            using (var context = new CustomerEntities())
            {
                foreach (T item in items)
                {  //context.Entry(item).State = System.Data.EntityState.Added; //EF 5
                    context.Entry(item).State = System.Data.Entity.EntityState.Added; //EF 6
                }
                try
                {
                    context.SaveChanges();
                }
                catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
                {
                    DBValidationErros(dbEx);
                }
                catch (System.Data.Entity.Infrastructure.DbUpdateException dbEx)
                {
                    DBUpdateExceptionErrors(dbEx);
                }
            }
        }

        public virtual void Update(params T[] items)
        {
            using (var context = new CustomerEntities())
            {
                foreach (T item in items)
                {// context.Entry(item).State = System.Data.EntityState.Modified; //EF 5
                    context.Entry(item).State = System.Data.Entity.EntityState.Modified; //EF 6
                }
                try
                {
                    context.SaveChanges();
                }
                catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
                {
                    DBValidationErros(dbEx);
                }
                catch (System.Data.Entity.Infrastructure.DbUpdateException dbEx)
                {
                    DBUpdateExceptionErrors(dbEx);
                }
            }
        }

        // entity validation errors (Uses Data Annotations defined in the class to validate)
        private void DBValidationErros(System.Data.Entity.Validation.DbEntityValidationException dbEx)
        {
            foreach (var validationErrors in dbEx.EntityValidationErrors)
            {
                foreach (var validationError in validationErrors.ValidationErrors)
                {
                    CRUDErrors c = new CRUDErrors();
                    c.PropertyName = validationError.PropertyName;
                    c.ErrorMessage = validationError.ErrorMessage;
                    Errors.Add(c);
                }
            }
        }

        private void DBUpdateExceptionErrors(System.Data.Entity.Infrastructure.DbUpdateException dbEx)
        {
            CRUDErrors c = new CRUDErrors();
            c.PropertyName = string.Empty;
            c.ErrorMessage = dbEx.InnerException.InnerException.Message;
            Errors.Add(c);
        }

        public virtual void Remove(params T[] items)
        {
            using (var context = new CustomerEntities())
            {
                foreach (T item in items)
                {
                    //context.Entry(item).State = System.Data.EntityState.Deleted; //EF 5
                    context.Entry(item).State = System.Data.Entity.EntityState.Deleted; //EF 6
                }
                try
                {
                    //throw new System.InvalidOperationException("Error occured with delete.....");
                    context.SaveChanges();
                }
                catch (InvalidOperationException e)
                {
                    CRUDErrors c = new CRUDErrors();
                    c.PropertyName = "Test";
                    c.ErrorMessage = e.Message.ToString();
                    Errors.Add(c);
                }
            }
        }
    }

}