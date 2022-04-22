namespace TodoApi.Models
{
    public class TodoItem
    {
        public long Id { get; set; } // Id funciona como a chave primaria em um banco de dados relacional.
        public string? Name { get; set; }
        public bool IsComplete { get; set; }
        public string? Secret { get; set; }
    }
}
