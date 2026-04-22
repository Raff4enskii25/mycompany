namespace MyCompany.Models
{
    //Класс DTO предназначен для передачи на клиент
    //и скрывает за собой ахритектуру реальной доменной модели Service
    public record ServiceDTO
    {
        public int Id { get; set; }
        public string? CategoryName { get; set; }
        public string? Title { get; set; }
        public string? DescriptionShort { get; set; }
        public string? Description { get; set; }
        public string? PhotoFileName { get; set; }
        public string? Type { get; set; }
    }
}
