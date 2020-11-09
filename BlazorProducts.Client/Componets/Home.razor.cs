using System.Collections.Generic;
using Microsoft.AspNetCore.Components;

namespace BlazorProducts.Client.Componets
{
    public partial class Home
    {
        [Parameter]
        public string Title { get; set; }

        [Parameter(CaptureUnmatchedValues = true)]
        public Dictionary<string, object> AdditionalAttributes { get; set; }

        [CascadingParameter(Name = "HeadingColour")]
        public string Colour { get; set; }

        [Parameter]
        public RenderFragment VisitShopContent { get; set; }            
    }
}