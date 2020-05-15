<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="MyContact.aspx.cs" Inherits="AspNetTelephone.MyContact" %>
<asp:Content ID="Content1" ContentPlaceHolderID="C1" runat="server">

    <div class="row small-spacing">
            <div class="col-lg-12 col-xs-12">
                <div class="box-content card white">
                    <h4 class="box-title">My Contact</h4>
                   <table class="table">
                       <tr>
                           <td><label for="txtfirstname" style="margin-top:10px">First Name:</label></td>
                           <td><asp:TextBox ID="txtfirstname" runat="server" class="form-control" ></asp:TextBox></td>
                           <td><asp:Button ID="btnSearch" runat="server" Text="Search" class="btn btn-primary btn-sm waves-effect waves-light" style="margin-top:10px" OnClick="btnSearch_Click"/></td>
                       </tr>
                       
                   </table>
                    <asp:Repeater ID="RepContact" runat="server">
                        <HeaderTemplate>
                            <table class="table table-bordered">
                        <tr>
                            <th>FirstName</th>
                            <th>LastName</th>
                            <th>Contact No</th>
                            <th>Email</th>
                            <th>Address</th>
                            <th>City</th>
                            <th colspan="2">Actions</th>
                        </tr>
                        </HeaderTemplate>
                        <ItemTemplate>
                             <tr>
                            <td><%#Eval("firstname") %></td>
                            <td><%#Eval("lastname") %></td>
                            <td><%#Eval("contactno") %></td>
                            <td><%#Eval("email") %></td>
                            <td><%#Eval("address") %></td>
                            <td><%#Eval("city") %></td>
                            <td><a href="edit.aspx?id=<%#Eval("id") %>""><img src="assets/images/edit.png" height="20" width="20"/></a></td>
                            <td><a href="delete.aspx?id=<%#Eval("id") %>"><img src="assets/images/delete.png" height="20" width="20"/></a></td>
                        </tr>
                        </ItemTemplate>
                        <FooterTemplate>
                             </table>
                        </FooterTemplate>
                    </asp:Repeater>
                    
                  
                </div>

            </div>

    </div>
</asp:Content>
