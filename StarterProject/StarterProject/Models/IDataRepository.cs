namespace StarterProject.Models
{
    public interface IDataRepository
    {
        IEnumerable<DataModel> GetAllData();
        DataModel GetById(int id);
        void AddData(DataModel dataModel);
    }
}
