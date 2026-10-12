namespace ContactBook.Entities
{
    public class Contact
    {
        public int Id { get; set; }
        public string FullName { get; set; } =string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string? Phone { get; set; }
        public string? Note { get; set; }
        public ICollection<ContactNote> ContactNotes { get; set; } = new List<ContactNote>();
        public ICollection<ContactTag> ContactTags { get; set; } = new List<ContactTag>();



    }
}
