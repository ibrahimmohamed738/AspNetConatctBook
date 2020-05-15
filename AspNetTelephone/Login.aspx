<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="AspNetTelephone.Login" %>

<!DOCTYPE html>
<html lang="en">
<head>
	<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
	<meta http-equiv="X-UA-Compatible" content="IE=edge">
	<meta name="viewport" content="width=device-width, initial-scale=1, user-scalable=no">
	<meta name="description" content="">
	<meta name="author" content="">
	<title>Login Page</title>
	<link rel="stylesheet" href="assets/styles/style.min.css">
	<link rel="stylesheet" href="assets/plugin/waves/waves.min.css">

</head>

<body>

<div id="single-wrapper">
	<form action="#" class="frm-single" name="form1" runat="server">
		<div class="inside">
			<div class="title"><strong>Telephone</strong>Directory</div>
			<div class="frm-title">Login</div>
			<div><asp:Label ID="lblErrorMessage" runat="server" Text="" ForeColor="Red" ></asp:Label></div>
			<div class="frm-input">
				<asp:TextBox ID="txtUsername" runat="server" placeholder="Username" class="frm-inp"></asp:TextBox><i class="fa fa-user frm-ico"></i></div>
			<div class="frm-input">
				<asp:TextBox ID="txtPassword" runat="server" placeholder="Password" class="frm-inp" TextMode="Password"></asp:TextBox><i class="fa fa-lock frm-ico"></i></div>
            <asp:Button ID="btnLogin" runat="server" Text="Login" class="frm-submit" OnClick="btnLogin_Click"/>
		</div>
	</form>

</div>

  <script src="assets/script/html5shiv.min.js"></script>
    <script src="assets/script/respond.min.js"></script>
	<script src="assets/scripts/jquery.min.js"></script>
	<script src="assets/scripts/modernizr.min.js"></script>
	<script src="assets/plugin/bootstrap/js/bootstrap.min.js"></script>
	<script src="assets/plugin/nprogress/nprogress.js"></script>
	<script src="assets/plugin/waves/waves.min.js"></script>
	<script src="assets/scripts/main.min.js"></script>
</body>


</html>
