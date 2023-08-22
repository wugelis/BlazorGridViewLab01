using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.AspNetCore.Components.Web;

namespace BlazorGridViewLab1.Client.Components
{
    public class MyButton3Class : ComponentBase
    {
        [Parameter] public string ButtonText { get; set; } = default!;

        [Parameter] public EventCallback<MouseEventArgs> OnClickCallback { get; set; }

        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.OpenElement(5, "button");
            builder.AddAttribute(6, "class", "btn btn-primary");
            builder.AddAttribute(7, "onclick", OnClickCallback);
            builder.AddContent(8, ButtonText);
            builder.CloseElement();

            //builder.AddMarkupContent(0, $"<button class=\"btn btn-primary\">{ButtonText}</button>");
        }
    }
}
