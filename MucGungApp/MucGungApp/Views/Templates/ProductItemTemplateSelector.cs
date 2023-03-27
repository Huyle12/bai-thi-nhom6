using MucGungApp.Models;

namespace MucGungApp.Views.Templates
{
    public class ProductItemTemplateSelector : DataTemplateSelector
    {
        public DataTemplate ProductItemTemplate { get; set; }
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var product = (Product)item;

    

            return ProductItemTemplate;
        }
    }
}
