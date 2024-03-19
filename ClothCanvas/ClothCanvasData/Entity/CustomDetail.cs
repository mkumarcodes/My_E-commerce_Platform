namespace ClothCanvas.Entity;

public class CustomDetail
{
    public int CustomDetailId { get; set; }
    public int ProductId { get; set; }
    public string Customizations { get; set; }
    public DateTime CreatedAt { get; set; }
    
    public Product Product { get; set; }
    
    
}