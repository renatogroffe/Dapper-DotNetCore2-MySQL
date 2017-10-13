using Dapper.Contrib.Extensions;

namespace APIEstados
{
    [Table("Estados")]
    public class Estado
    {
        [ExplicitKey]
        public string SiglaEstado { get; set; }
        public string NomeEstado { get; set; }
        public string NomeCapital { get; set; }
    }
}