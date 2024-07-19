using System.ComponentModel.DataAnnotations;
using DBtechcareer.Data;

namespace DBtechcareer.Models{
    public class BootcampViewModel{
        [Key]

        public int BootcampId{get;set;}
        public string? Baslik{get;set;}
        public int? EgitmenId {get;set;}
        public ICollection<BootcampKayit> KursKayit {get;set;} = new List<BootcampKayit>();
    }
}