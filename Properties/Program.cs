


Customer customer = new Customer();

customer.id = new Guid();
customer.name = "Test";

Console.WriteLine(customer.id);


class Customer
{
    public Guid id { get; set; }

    public string name {

        get { return name }

        set { if (name == null)  throw new Exception("error")  this.name = name  }
    
    }

   
}