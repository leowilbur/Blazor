// <auto-generated/>
#pragma warning disable 1591
namespace Test
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public class TestComponent : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.OpenComponent<Test.MyComponent>(0);
            builder.AddAttribute(1, "Value", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetValue(ParentValue));
            builder.AddAttribute(2, "OnChanged", Microsoft.AspNetCore.Blazor.Components.BindMethods.SetValueHandler(__value => ParentValue = __value, ParentValue));
            builder.CloseComponent();
        }
        #pragma warning restore 1998
#line 3 "x:\dir\subdir\Test\TestComponent.cshtml"
            
    public int ParentValue { get; set; } = 42;

#line default
#line hidden
    }
}
#pragma warning restore 1591