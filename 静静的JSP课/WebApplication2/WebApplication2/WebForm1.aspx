<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication2.WebForm1" %>
<form runat="server">

<asp:XmlDataSource ID="CategoryList" runat="server" DataFile="Content/ChildCategory.xml"
        XPath="Main/Category"></asp:XmlDataSource>
    <asp:XmlDataSource ID="ChildCategoryList" runat="server" DataFile="Content/ChildCategory.xml"
        XPath="/Main/Category/ChildCategory"></asp:XmlDataSource>
    
    <table border="1" cellpadding="1" cellspacing="1">
        <tr>

            <td style="width: 125px">
                <asp:Label ID="LabelCategory" runat="server" Text="请选择主分类："></asp:Label></td>
            <td style="width: 100px">

                <asp:DropDownList ID="DdlCategory" runat="server" DataSourceID="CategoryList" DataTextField="ChsName"
                    DataValueField="ID" OnSelectedIndexChanged="CategorySelectedIndexChanged" AutoPostBack="True" Width="100px">
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td style="width: 125px">
                <asp:Label ID="LabelChildCategory" runat="server" Text="请选择子分类："></asp:Label></td>
            <td style="width: 100px">
                <asp:DropDownList ID="DdlChildCategory" runat="server" DataSourceID="ChildCategoryList"
                    DataTextField="ChsName" DataValueField="ID" AutoPostBack="True" Width="100px">
                </asp:DropDownList></td>
        </tr>
    </table>

<!--https://www.cnblogs.com/AntiGameZ/archive/2007/03/21/607512.html-->
</form>

