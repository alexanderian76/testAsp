using System.ComponentModel.DataAnnotations.Schema;

namespace TestAsp.Models
{
    public class Phone
    {
        public int Id { get; set; }
        [Column("Code")]
        public int Code { get; set; }
        [Column("Value")]
        public string? Value { get; set; }
    }
}