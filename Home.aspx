<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            margin-left: 122px;
        }
        .auto-style2 {
            margin-left: 16px;
            margin-right: 0px;
            margin-top: 48px;
        }
        .auto-style3 {
            margin-right: 0px;
        }
        .auto-style4 {
            margin-top: 0px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
    <br />
</p>
<p>
    <asp:Image ID="Image1" runat="server" CssClass="auto-style1" Height="450px" ImageUrl="~/Welcome.jpg" Width="1040px" />
    </p>
    <p>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Image ID="Image2" runat="server" Height="297px" ImageUrl="~/Salman.jpg" Width="486px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Image ID="Image3" runat="server" CssClass="auto-style2" Height="300px" ImageUrl="~/Dangal.jpg" Width="580px" />
    </p>
    <p>
        &nbsp;</p>
    <p>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Image ID="Image4" runat="server" CssClass="auto-style3" ImageUrl="~/Varun.jpg" Width="485px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Image ID="Image5" runat="server" CssClass="auto-style4" Height="326px" ImageUrl="~/parineet.jpg" Width="574px" />
    </p>
    <p>
        &nbsp;</p>
</asp:Content>

