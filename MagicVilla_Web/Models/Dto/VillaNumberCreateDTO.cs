using System.ComponentModel.DataAnnotations;

namespace MagicVilla_Web.Models.Dto
{
    public class VillaNumberCreateDTO
    {
        public int VillaNo { get; set; }
        [Required]
        public int VillaID { get; set; }
        public VillaDTO Villa { get; set; }
        public string SpecialDetails { get; set; }
    }
}
