<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Add.aspx.cs" Inherits="AddPet" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="Server">

    <div class="container">
     
        <h2>Agregar Smartphone</h2>
        <asp:Label ID="lbName" runat="server" Text="Marca"></asp:Label>
        <asp:TextBox class="form-control" ID="txb_marca" runat="server"></asp:TextBox>
        <asp:Label ID="lbTipo" runat="server" Text="Sistema"></asp:Label>
        <asp:DropDownList class="form-control" ID="ddl_sistema" runat="server">
            <asp:ListItem>Android</asp:ListItem>
            <asp:ListItem>iOS</asp:ListItem>
            <asp:ListItem>Windows phones :(</asp:ListItem>
        </asp:DropDownList>
        <asp:Label ID="Label1" runat="server" Text="Tamaño"></asp:Label>
        <asp:TextBox class="form-control" ID="txb_tamanio" runat="server"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" Text="Liberado"></asp:Label>
        <asp:CheckBox ID="cbx_liberado" runat="server" Text=" " />
        <br/>
        <asp:Button ID="btnAgregar" type="button" runat="server" OnClick="btnAgregarClick" Text="Agregar" />
        <asp:Button ID="btn_cancelar" runat="server" Text="Cancelar" OnClick="btn_cancelar_Click" />
    </div>

    <div class="alert alert-primary" id="divAlert" runat="server" role="alert">        
    </div>
</asp:Content>

