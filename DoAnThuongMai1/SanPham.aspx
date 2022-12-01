<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="SanPham.aspx.cs" Inherits="DoAnThuongMai1.SanPham" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .main-san-pham{
           display:flex;
           flex-wrap: wrap;

        }
        
        .san-pham{
             width:33%;
             border: 1px solid black;
             color:black;
             text-decoration:none;

        }
        .san-pham-tieu-de{
            text-align:center;
        }
        .hinh{
            width:100%;
        }
        .gia{
            text-align:center;
            font-size:20px;
        }
        
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="main-san-pham">
        <asp:Repeater ID="rptSanPham" runat="server">
            <ItemTemplate>
                <a class="san-pham" href="SanPhamChiTiet.aspx?MASP=<%#:Eval("MaSP") %>"> 
                <h2 class="san-pham-tieu-de"><%#:Eval("TenSP") %></h2>
                <img class="hinh" src="<%#:Eval("Hinh") %>" />
                <p class="gia"><%#:Eval("DonGia") %>đ</p>
                </a>
            </ItemTemplate>
        </asp:Repeater>
     <%--   <div class="san-pham">
            <h2 class="san-pham-tieu-de">TênSanPham</h2>
            <img class="hinh" src="dongho.jpg" />
            <p class="gia"> giá</p>
        </div>
         <div class="san-pham">
            <h2 class="san-pham-tieu-de">TênSanPham</h2>
            <img class="hinh" src="dongho.jpg" />
            <p class="gia"> giá</p>
        </div>
         <div class="san-pham">
            <h2 class="san-pham-tieu-de">TênSanPham</h2>
            <img class="hinh" src="dongho.jpg" />
            <p class="gia"> giá</p>
        </div>' <div class="san-pham">
            <h2 class="san-pham-tieu-de">TênSanPham</h2>
            <img class="hinh" src="dongho.jpg" />
            <p class="gia"> giá</p>
        </div>--%>
    </div>
</asp:Content>
