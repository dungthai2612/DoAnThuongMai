<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="SanPhamChiTiet.aspx.cs" Inherits="DoAnThuongMai1.SanPhamChiTiet" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .san-pham-chi-tiet{
            display:flex;
            padding: 10px;
            width: 90%;
        }
        .hinhsp{
            flex:1;
            width:300px;
            height:300px;
        }
        .noi-dung-sp{
            flex:3;
            padding:20px 10px;
        }
        .noi-dung-ct{
            padding:25px 0;
            font-size:20px;
        }
        .them-btn{
            font-size:20px;
            padding:5px 10px;
            cursor:pointer;
        }
        .noi-dung-chi-tiet-btn{
            font-size :20px;
            padding:5px 10px;
            cursor:pointer;
            border: 1px solid black;
            color:black;
            text-decoration:none;
        }
        .noi-dung-chi-tiet-btn:hover{
            background-color:#808080;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Repeater ID="rptSanPhamChiTiet" runat ="server">
      <ItemTemplate>
            <div class ="san-pham-chi-tiet">
        <img class="hinhsp" src ="<%#:Eval("Hinh") %>" />
        <div class="noi-dung-sp">
            <p class ="noi-dung-ct"><%#:Eval("TenSP") %></p>
            <p class ="noi-dung-ct">Giá : <%#:Eval("DonGia") %> đ</p>
            <p class ="noi-dung-ct"><%#:Eval("MoTa") %></p>
            <a class="noi-dung-chi-tiet-btn" href="XuLyGioHang.aspx?MaSP=<%#:Eval("MaSP") %>">Thêm vào giỏ hàng</a>
        </div> 
    </div>
      </ItemTemplate>
    </asp:Repeater>
    <%--<div class ="san-pham-chi-tiet">
        <img class="hinhsp" src ="dongho.jpg" />
        <div class="noi-dung-sp">
            <p class ="noi-dung-ct">Tenaa</p>
            <p class ="noi-dung-ct">Gia</p>
            <p class ="noi-dung-ct">mota</p>
            <input class="them-btn" type="button" value="Thêm vào giỏ hàng" />
        </div> 
    </div>--%>
</asp:Content>
