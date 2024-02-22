namespace KodlamaIOGün2Ödev3.DAL.Abstract
{
    public interface IBaseDal<T> where T : class
    {
        void Add(T entity);
        void Update(T entity);
        T Delete(T entity);
        List<T> GetAll();
    }
}
