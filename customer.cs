class Customer
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public DateTime DateJoined { get; set; }
    public bool IsPremiumMember { get; set; }

    // Parameterless constructor
    public Customer() { }

    // Constructor with parameters
    public Customer(int id, string name, string email, string phoneNumber, string address, DateTime dateJoined, bool isPremiumMember)
    {
        Id = id;
        Name = name;
        Email = email;
        PhoneNumber = phoneNumber;
        Address = address;
        DateJoined = dateJoined;
        IsPremiumMember = isPremiumMember;
    }

    public override string ToString()
    {
        return $"ID: {Id}, Name: {Name}, Email: {Email}, Phone: {PhoneNumber}, Address: {Address}, Date Joined: {DateJoined.ToShortDateString()}, Premium Member: {IsPremiumMember}";
    }
}
