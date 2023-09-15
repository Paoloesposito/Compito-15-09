<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="Compito_15_09.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridViewCart" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
    <Columns>
        <asp:BoundField DataField="Id" HeaderText="ID" />
        <asp:BoundField DataField="Name" HeaderText="Nome" />
        <asp:BoundField DataField="Description" HeaderText="Descrizione" />
        <asp:BoundField DataField="Price" HeaderText="Prezzo" />
        <asp:TemplateField HeaderText="Azione">
            <ItemTemplate>
                <asp:Button ID="btnRemoveFromCart" runat="server" Text="Rimuovi dal carrello" OnClick="btnRemoveFromCart_Click" CssClass="btn btn-danger" CommandArgument='<%# Eval("Id") %>' />
            </ItemTemplate>
        </asp:TemplateField>
    </Columns>
</asp:GridView>
    <asp:Button ID="btnBackToProducts" runat="server" Text="Torna ai prodotti" OnClick="btnBackToProducts_Click" CssClass="btn btn-primary" />
    <asp:Label ID="lblProductCount" runat="server" CssClass="badge badge-pill badge-info"></asp:Label>
</asp:Content>
