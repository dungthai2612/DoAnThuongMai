<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="GioHang.aspx.cs" Inherits="DoAnThuongMai1.GioHang" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        td{
            border : 1px solid black;
        }
        tr{
            height:30px;
        }
        
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Table ID="Table1" runat="server"></asp:Table>
    <table style="width: 100%;">
        <tr>
            <td class="nen">TenSP</td>
            <td class="nen">SoLuong</td>
            <td class="nen">DonGia</td>
            <td class="nen">ThanhTien</td>
        </tr>
        <asp:Repeater ID="rptGioHang" runat ="server">
            <ItemTemplate>
                  <tr>
                   <td><%#:Eval("TenSP") %></td>
                    <td><%#:Eval("SoLuong") %></td>
                    <td><%#:string.Format("{0:#,##}",Eval("DonGia")) %> đ</td>
                    <td><%#:Eval("ThanhTien") %> đ</td>
                  </tr>
            </ItemTemplate>
        </asp:Repeater>

    <%--    <tr>
            <td>Binger bg42</td>
            <td>1</td>
            <td>15321</td>
            <td>12312344</td>
        </tr>
        <tr>
           <td>Binger bg42</td>
            <td>1</td>
            <td>15321</td>
            <td>12312344</td>
        </tr>--%>
        <tr>
            <td colspan="3">Tổng tiền : </td>
            <td><asp:Label ID ="lbThanhTien" runat="server"></asp:Label> đ</td>
        </tr>
    </table>
</asp:Content>
