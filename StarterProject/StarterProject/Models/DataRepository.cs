
namespace StarterProject.Models
{
    public class DataRepository : IDataRepository
    {
        private readonly List<DataModel> _dataRepository = new();

        private int _nextId = 1;
        public void AddData(DataModel dataModel)
        {
            dataModel.UserId = _nextId++;
            _dataRepository.Add(dataModel);
        }

        public IEnumerable<DataModel> GetAllData()
        {
            return _dataRepository;
        }

        public DataModel GetById(int id)
        {
            return _dataRepository.FirstOrDefault(d => d.UserId == id);
        }
    }
}
