using System.ComponentModel.DataAnnotations.Schema;

namespace apitest.Data
{
    public class Hotel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public double Reting { get; set; }
        [ForeignKey(nameof(CoutryId))]
        public int CoutryId { get; set; }
        public Country Country { get; set; }
    }
}
