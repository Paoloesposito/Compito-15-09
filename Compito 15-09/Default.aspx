<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Compito_15_09.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<h2>Benvenuto nel  e-commerce Di Paolino</h2>
     <asp:Button ID="Button2" runat="server" Text="Vai al carrello" OnClick="btnGoToCart_Click" CssClass="btn btn-primary" />
     <asp:Label ID="lblProductCount" runat="server" CssClass="badge badge-pill badge-info"></asp:Label>
     <div class="row">

        <asp:Repeater ID="ProductRepeater" runat="server">
            <ItemTemplate>
                <div class="col-lg2- col-md-2 col-sm-6 mb-4">
                    <div class="card">
                        <img class="card-img-top" src='<%# Eval("ImageUrl") %>' alt='<%# Eval("Name") %>' />
                        <div class="card-body">
                            <h5 class="card-title"><%# Eval("Name") %></h5>
                            <p class="card-text"><%# Eval("Description") %></p>
                            <p class="card-text"><strong>Prezzo: </strong><%# Eval("Price", "{0:C}") %></p>
                            <asp:Button runat="server" ID="AddToCartButton" Text="Aggiungi al carrello" OnClick="AddToCartButton_Click" CommandArgument='<%# Eval("Id") %>' />
                        </div>
                    </div>
                  
                </div>
            </ItemTemplate>
        </asp:Repeater>
           
</asp:Content>
