#pragma checksum "C:\Devs01\HRIS\HRIS.Project\HRIS.AppSrv\Training\TrainingRequest.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a872752b365c75effc1eb4c2f7e9f2ad04bc5fca"
// <auto-generated/>
#pragma warning disable 1591
namespace HRIS.AppSrv.Training
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Devs01\HRIS\HRIS.Project\HRIS.AppSrv\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Devs01\HRIS\HRIS.Project\HRIS.AppSrv\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Devs01\HRIS\HRIS.Project\HRIS.AppSrv\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Devs01\HRIS\HRIS.Project\HRIS.AppSrv\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Devs01\HRIS\HRIS.Project\HRIS.AppSrv\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Devs01\HRIS\HRIS.Project\HRIS.AppSrv\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Devs01\HRIS\HRIS.Project\HRIS.AppSrv\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Devs01\HRIS\HRIS.Project\HRIS.AppSrv\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Devs01\HRIS\HRIS.Project\HRIS.AppSrv\_Imports.razor"
using HRIS.AppSrv;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Devs01\HRIS\HRIS.Project\HRIS.AppSrv\_Imports.razor"
using HRIS.AppSrv.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Devs01\HRIS\HRIS.Project\HRIS.AppSrv\Training\TrainingRequest.razor"
using HRIS.AppSrv.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Training/TrainingRequest")]
    public partial class TrainingRequest : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Training Request</h3>\r\n\r\n\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 9 "C:\Devs01\HRIS\HRIS.Project\HRIS.AppSrv\Training\TrainingRequest.razor"
                  emp

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 9 "C:\Devs01\HRIS\HRIS.Project\HRIS.AppSrv\Training\TrainingRequest.razor"
                                        Create

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(5, "div");
                __builder2.AddAttribute(6, "class", "form-field");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "container-fluid");
                __builder2.AddAttribute(9, "style", "margin:5px;padding:0px;border:double;background-color:aliceblue");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "row");
                __builder2.AddAttribute(12, "style", "margin:0px;padding:0px;");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "col-xs-12 col-sm-8 col-md-6");
                __builder2.AddAttribute(15, "style", "width:100%;margin:0px;padding:0px");
                __builder2.OpenElement(16, "div");
                __builder2.AddAttribute(17, "class", "row");
                __builder2.AddAttribute(18, "style", "width:100%;margin:0px;padding:0px");
                __builder2.OpenElement(19, "div");
                __builder2.AddAttribute(20, "class", "col-xs-12 col-md-4");
                __builder2.AddAttribute(21, "style", "font-weight:bold");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(22);
                __builder2.AddAttribute(23, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "C:\Devs01\HRIS\HRIS.Project\HRIS.AppSrv\Training\TrainingRequest.razor"
                                                    emp.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(24, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => emp.FirstName = __value, emp.FirstName))));
                __builder2.AddAttribute(25, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => emp.FirstName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n                        ");
                __builder2.OpenElement(27, "div");
                __builder2.AddAttribute(28, "class", "col-xs-12 col-md-4");
                __builder2.AddAttribute(29, "style", "font-weight:bold");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(30);
                __builder2.AddAttribute(31, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 24 "C:\Devs01\HRIS\HRIS.Project\HRIS.AppSrv\Training\TrainingRequest.razor"
                                                    emp.PreferredName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(32, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => emp.PreferredName = __value, emp.PreferredName))));
                __builder2.AddAttribute(33, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => emp.PreferredName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\r\n                        ");
                __builder2.OpenElement(35, "div");
                __builder2.AddAttribute(36, "class", "col-xs-12 col-md-4");
                __builder2.AddAttribute(37, "style", "font-weight:bold");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(38);
                __builder2.AddAttribute(39, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 28 "C:\Devs01\HRIS\HRIS.Project\HRIS.AppSrv\Training\TrainingRequest.razor"
                                                    emp.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(40, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => emp.LastName = __value, emp.LastName))));
                __builder2.AddAttribute(41, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => emp.LastName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "C:\Devs01\HRIS\HRIS.Project\HRIS.AppSrv\Training\TrainingRequest.razor"
       

    EmployeeDTO emp = new();

    public async Task Create()
    {

    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
