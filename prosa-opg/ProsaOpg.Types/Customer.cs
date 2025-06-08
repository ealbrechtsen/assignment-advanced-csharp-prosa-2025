﻿namespace ProsaOpg.Types;

public class Customer
{
    public int Id { get; set; }
    public string? Name { get; set; } = string.Empty;
    public int Age { get; set; }
    public string? Country { get; set; } = string.Empty;
    public double Revenue { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.Now;
    public bool IsActive { get; set; }
    public List<string>? Tags { get; set; } = new();

    public override string ToString()
    {
        return $"Customer: {Id} {Name} {Age} {Country} {Revenue} {CreatedDate} {IsActive} {string.Join(", ", Tags ?? new List<string>())}";
    }
}
