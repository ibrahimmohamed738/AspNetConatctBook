<%@ Page Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true"  CodeBehind="ContactReport.aspx.cs" Inherits="AspNetTelephone.ContactReport" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<asp:Content ID="Content1" ContentPlaceHolderID="C1" runat="server">

        <div class="row small-spacing">
            <div class="col-lg-12 col-xs-12">
                <div class="box-content card white">
                    <h4 class="box-title">Edit Contact</h4>

                    <div class="card-content">


                        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                        <asp:Button ID="btnShowReport" runat="server" Text="Show Report" OnClick="btnShowReport_Click" />
                        <rsweb:ReportViewer ID="ReportViewer1" runat="server" Width="80%"></rsweb:ReportViewer>
                        </div>
                    </div>
                </div>
            </div>
</asp:Content>
