using System.ComponentModel.DataAnnotations;

namespace DBtechcareer.Data{
    public class Bootcamp{
        [Key]

        public int BootcampId{get;set;}
        public string? Baslik{get;set;}
        public int? EgitmenId {get;set;}
        public Egitmen Egitmen {get;set;} = null!;
        public ICollection<BootcampKayit> KursKayit {get;set;} = new List<BootcampKayit>();
    }
}