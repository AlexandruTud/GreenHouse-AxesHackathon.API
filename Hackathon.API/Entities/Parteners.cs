namespace Hackathon.API.Entities
{
    public class Partners
    {
        public int IdPartner { get; set; }
        public string namePartner { get; set; }
        public Partners(int IdPartener, string namePartener) {
            this.IdPartner = IdPartener;
            this.namePartner = namePartener;
        }  

    }
}