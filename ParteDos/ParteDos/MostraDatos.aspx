<%@ Page Title="" Language="C#" EnableEventValidation="false" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MostraDatos.aspx.cs" Inherits="ParteDos.MostraDatos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <link rel="stylesheet" type="text/css" href="css/bootstrap.css" />
    
<script src="//ajax.googleapis.com/ajax/libs/jquery/1.11.0/jquery.min.js"></script>
   
    <asp:HiddenField runat="server" ID="hf_control" />

    <div class="container">

        <div class="Jumbotron">
            <h3>Mostrar datos del Empleado</h3>

            <asp:GridView DataKeyNames="codigo_empleado" ID="GridView1" runat="server" CssClass="table" OnRowDataBound="GridView1_RowDataBound" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" AllowSorting="True" PageSize="5">
            </asp:GridView>
        </div>
        <asp:Panel ID="Panel1" runat="server" Visible="false">

            Codigo<asp:TextBox ID="txtCodigo" runat="server"></asp:TextBox><br />
            Nombre<asp:TextBox ID="txtNombre" runat="server"></asp:TextBox><br />
            <asp:Button ID="btnCerrar" runat="server" Text="Cerrar" OnClick="btnCerrar_Click" />
            <asp:Button ID="btnBorrar"  runat="server" Text="Borrar" OnClick="btnBorrar_Click" />
             
        </asp:Panel>
    </div>

</asp:Content>
