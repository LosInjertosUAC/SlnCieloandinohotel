<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Reserva.aspx.cs" Inherits="ClienteCSharp.Reserva" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Cielo Andino - Reservas</h1>
    <br/>
    <p>&nbsp;<asp:Label ID="Label1" runat="server" Text="Codigo Reserva:"></asp:Label>
        <asp:TextBox runat="Server" ID="txtCodreserva"/>
        <asp:Label ID="Label2" runat="server" Text="Codigo Cliente:"></asp:Label>
        <asp:TextBox ID="txtCodcliente" runat="server"></asp:TextBox>
        <asp:Label ID="Label3" runat="server" Text="Fecha Inicio:"></asp:Label>
        <asp:TextBox ID="txtInicio" runat="server"></asp:TextBox>
        <asp:Label ID="Label6" runat="server" Text="Fecha Fin:"></asp:Label>
        <asp:TextBox ID="txtFinal" runat="server"></asp:TextBox>
        <asp:Label ID="Label4" runat="server" Text="Numero de Personas"></asp:Label>
        <asp:TextBox ID="txtNropersonas" runat="server"></asp:TextBox>
        <asp:Label ID="Label5" runat="server" Text="Observaciones:"></asp:Label>
        <asp:TextBox ID="txtObserbaciones" runat="server"></asp:TextBox>
        <asp:Button ID="btnAgregar" runat="server" OnClick="btnAgregar_Click" Text="AGREGAR" />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="ELIMINAR" />
        </p>
    <p>
        <asp:Gridview runat="server" ID="gvReserva">
            </asp:Gridview>
        </p>
</asp:Content>
