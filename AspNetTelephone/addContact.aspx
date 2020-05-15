<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="addContact.aspx.cs" Inherits="AspNetTelephone.addContact" %>
<asp:Content ID="Content1" ContentPlaceHolderID="C1" runat="server">
    <div class="row small-spacing">
            <div class="col-lg-12 col-xs-12">
                <div class="box-content card white">
                    <h4 class="box-title">Add New Contact</h4>

                    <div class="card-content">
                            <div>
                                <asp:Label ID="lblErrorMessage" runat="server" Text="" ForeColor="Red" ></asp:Label>
				                <asp:Label ID="lblSuccessMessage" runat="server" Text="" ForeColor="Green"></asp:Label>
                            </div>
                            <div class="form-group">
                                <label for="txtfirstname">First Name:</label>
                                <asp:TextBox ID="txtfirstname" runat="server" class="form-control" ></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label for="txtLastname">Last Name:</label>
                                <asp:TextBox ID="txtLastname" runat="server" class="form-control" ></asp:TextBox>
                            </div>
                             <div class="form-group">
                                <label for="txtContactno">Contact No:</label>
                                 <asp:TextBox ID="txtContactno" runat="server" class="form-control" ></asp:TextBox>
                            </div>
                             <div class="form-group">
                                <label for="txtemail">Email:</label>
                                <asp:TextBox ID="txtemail" runat="server" class="form-control" ></asp:TextBox>
                            </div>
                             <div class="form-group">
                                <label for="txtAddress">Address:</label>
                                 <asp:TextBox ID="txtAddress" runat="server" class="form-control" ></asp:TextBox>
                            </div>
                             <div class="form-group">
                                <label for="txtCity">City:</label>
                                 <asp:TextBox ID="txtCity" runat="server" class="form-control" ></asp:TextBox>
                            </div>


                            <asp:Button ID="btnAddContact" runat="server" Text="Add Contact" class="btn btn-primary btn-sm waves-effect waves-light" OnClick="btnAddContact_Click"/>
                          
                      
                    </div>

                </div>
                </div>
        </div>
</asp:Content>
