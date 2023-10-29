namespace Hackathon.API.Entities
{
    public class Electronics
    {
        public int IdElectronic { get; set; }
        public List<UserCredentials> Users { get; set; }
        public List<Partners> Partners { get; set; }
        public List<Categories> Categories { get; set; }
        public string Model { get; set; }
        public string Series { get; set; }
        public string EnergeticClass { get; set; }
        public string EnergyUsed { get; set; }
        public Electronics(int idElectronic, List<UserCredentials> users, List<Partners> partners, List<Categories> categories, string model, string series, string energeticClass, string energyUsed)
        {
            IdElectronic = idElectronic;
            Users = users;
            Partners = partners;
            Categories = categories;
            Model = model;
            Series = series;
            EnergeticClass = energeticClass;
            EnergyUsed = energyUsed;
        }
    }
}
