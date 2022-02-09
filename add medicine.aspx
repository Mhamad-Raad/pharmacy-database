<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="add medicine.aspx.cs" Inherits="SDA.add_medicine" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
       <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
<head runat="server">
    <title></title>
    <style type="text/css">

        .auto-style3 {
            width: 96%;
        }
        .auto-style1 {
            width: 216px;
        }
        .auto-style2 {
            width: 169px;
        }
        .auto-style4 {
            width: 185px;
        }
        .auto-style5 {
            width: 433px;
        }
    </style>
</head>
<body>
    

<nav class="navbar navbar-expand-lg navbar-light  nav" style="background-color: #008B8B;">
 

    <div class="collapse navbar-collapse" id="navbarScroll">
      <ul class="navbar-nav me-auto my-2 my-lg-0 navbar-nav-scroll" style="--bs-scroll-height: 100px;">
       
         
          <li class="nav-item1">
          <a class="nav-link active" aria-current="page" href="homepage.aspx">Home</a>
        </li>
        <li class="nav-item1">
          <a class="nav-link active" aria-current="page" href="add medicine.aspx">Add Medicine</a>
        </li>
         
           <li class="nav-item1">
          <a class="nav-link active" aria-current="page" href="Login.aspx">Log Out</a>
        </li>
        
      </ul>
        
        
  </div>
</nav>









    <form id="form1" runat="server">
        <div>
        <table class="auto-style3">
            <tr>
                <td class="auto-style1">Name</td>
                <td class="auto-style2">price</td>
                <td class="auto-style4">Quantity</td>
                <td class="auto-style5">Description</td>
                <td>Id</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:TextBox ID="name" runat="server" class="pass"></asp:TextBox>
                </td>
                <td id="price0">
                    <asp:TextBox ID="price" runat="server" class="pass" TextMode="Number"></asp:TextBox>
                </td>
                <td class="auto-style4">
                    <asp:TextBox ID="quantity" runat="server" class="pass" TextMode="Number"></asp:TextBox>
                </td>
                <td class="auto-style5">
                    <asp:TextBox ID="description" runat="server" class="pass" Width="422px"></asp:TextBox>
                </td>
                <td>
                    <asp:TextBox ID="lol" runat="server" class="pass" TextMode="Number"></asp:TextBox>
                </td>
                
               
            </tr>
           
        </table>
            <br />
            <asp:Label ID="Label2" runat="server" Font-Bold="true"></asp:Label>
            <br />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add" class="search mid btn btn-successs btn-sm"
            style="width:100px; background-color:#008B8B; color:white;"/>
            <br />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
