﻿namespace ClothCanvas.Entity;

public class Address
{
    public int AddressId { get; set; }
    public int UserId { get; set; }
    public string AddressLine1 { get; set; }
    public string AddressLine2 { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string PostalCode { get; set; }
    public string Country { get; set; }
    public bool IsPrimary { get; set; }
    public DateTime CreatedAt { get; set; }
    
    public User User { get; set; }
}