using Pronia.Models.Base;

namespace Pronia.Models
{
    public class Product : BaseEntity
    {
        public int CategoryId { get; set;  }    
        public Category Category { get; set;  } 
        public string Name { get; set;  }   
        public double Price { get; set;  }  
        public string Description { get; set;  }
        public string SKU { get; set;  }
        public string ImageUrl { get; set;  }   
        public bool PrimaryPic { get; set;  }       
    }
}
