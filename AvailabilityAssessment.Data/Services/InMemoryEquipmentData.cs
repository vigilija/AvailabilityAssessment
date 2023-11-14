using AvailabilityAssessment.Data.Model;

namespace AvailabilityAssessment.Data.Services
{
    public class InMemoryEquipmentData : IEquipmentData
    {
        private readonly IList<Equipment> _equipments;

        public InMemoryEquipmentData()
        {
            _equipments = new List<Equipment>()
             {
                new Equipment() { Id = 100, Name = "Speaker", Stock = 9 },
                new Equipment() { Id = 101, Name = "Bose", Stock = 11 }
             };
        }

        public IEnumerable<Equipment> GetAll()
        {
            return _equipments.OrderBy(r => r.Name);
        }
    }
}
