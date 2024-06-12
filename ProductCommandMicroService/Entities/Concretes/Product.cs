using ProductCommandMicroService.Entities.Abstracts;

namespace ProductCommandMicroService.Entities.Concretes;

public class Product : BaseEntity {  

    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
}
