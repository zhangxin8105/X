﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using NewLife;
    
    #line 1 "..\..\Views\CubeHome\Index.cshtml"
    using NewLife.Common;
    
    #line default
    #line hidden
    using NewLife.Cube;
    using NewLife.Reflection;
    using NewLife.Web;
    using XCode;
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/CubeHome/Index.cshtml")]
    public partial class _Views_CubeHome_Index_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_CubeHome_Index_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\CubeHome\Index.cshtml"
  
    Layout = null;
    var page = HttpRuntime.AppDomainAppVirtualPath;
    page = page.EnsureEnd("/") + "Admin";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n<head>\r\n    <meta");

WriteLiteral(" name=\"viewport\"");

WriteLiteral(" content=\"width=device-width\"");

WriteLiteral(" />\r\n    <title>");

            
            #line 13 "..\..\Views\CubeHome\Index.cshtml"
      Write(SysConfig.Current.DisplayName);

            
            #line default
            #line hidden
WriteLiteral("</title>\r\n    <meta");

WriteLiteral(" http-equiv=\"refresh\"");

WriteAttribute("content", Tuple.Create(" content=\"", 324), Tuple.Create("\"", 345)
, Tuple.Create(Tuple.Create("", 334), Tuple.Create("0;url=", 334), true)
            
            #line 14 "..\..\Views\CubeHome\Index.cshtml"
, Tuple.Create(Tuple.Create("", 340), Tuple.Create<System.Object, System.Int32>(page
            
            #line default
            #line hidden
, 340), false)
);

WriteLiteral(">\r\n</head>\r\n<body>\r\n    <div>\r\n        <h1>");

            
            #line 18 "..\..\Views\CubeHome\Index.cshtml"
       Write(SysConfig.Current.DisplayName);

            
            #line default
            #line hidden
WriteLiteral("</h1>\r\n        <h3>正在启动系统……</h3>\r\n");

WriteLiteral("        ");

            
            #line 20 "..\..\Views\CubeHome\Index.cshtml"
   Write(SysConfig.Current.Company);

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n</body>\r\n</html>");

        }
    }
}
#pragma warning restore 1591
