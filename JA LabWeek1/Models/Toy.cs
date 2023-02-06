public class Toy
{
    public string brand { get; set; }
    public int idNumber { get; set; }
    public double heightCM { get; set; }

    public Toy(string brand, int idNumber, double heightCM) {
            
        this.brand = brand;
        this.idNumber = idNumber;
        this.heightCM = heightCM;

    
    }
  
}