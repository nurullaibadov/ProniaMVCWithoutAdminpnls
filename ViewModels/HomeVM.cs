using Pronia.Models;

namespace Pronia.ViewModels
{
    public class HomeVM
    { 
        public List<Category> Categories { get; set; } = new List<Category>();        
        public List<Slider> Sliders { get; set; } = new List<Slider>();       
    }
}
