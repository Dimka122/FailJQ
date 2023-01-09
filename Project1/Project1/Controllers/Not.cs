namespace Notes.Controllers
{
    internal class Not
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Token_id { get; set; }
        public List<Not> Nots { get; set; }
}
}