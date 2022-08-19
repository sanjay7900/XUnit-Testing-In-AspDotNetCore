namespace XUnitTesting_Implement.Services
{
    public interface IDataServices<TypeEntity>
    {
        List<TypeEntity> GetAll();
        TypeEntity GetById(int id);
        bool AddEntity(TypeEntity data);
        bool UpdateEntity(TypeEntity data,int id);
        bool DeleteEntity(int id);

        
    }
}
