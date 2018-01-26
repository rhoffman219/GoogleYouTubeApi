<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="sample.aspx.cs" Inherits="GoogleYouTubeApi.sample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous">
</head>
<body>
    <form id="form1" runat="server">
        <div class="form-group">
            <h1>YouTube data API</h1><br />
            <br />
            Enter a Video ID:<asp:TextBox placeholder="Enter Valid Video ID" ID="aTextId" runat="server" style="margin-left: 12px" Width="355px"></asp:TextBox>
            <br />
            <asp:Button class="btn btn-primary" ID="aButtonGetData" runat="server" OnClick="Button1_Click" Text="Get Youtube Video" Width="169px" />
            <br />
            <asp:Panel ID="aPanelVideoInfo" runat="server" Height="104px" Width="1017px">
                Video Title:<asp:Label ID="aLabelTitle" runat="server"></asp:Label>
                <br />
                Video Published On:<asp:Label ID="aLabelPublishedDate" runat="server"></asp:Label>
                <br />
                <br />
                <br />
                Enter Playlist ID:
                <asp:TextBox placeholder="Enter Valid Playlist ID" ID="aTextPlaylistId" runat="server" Width="296px"></asp:TextBox>
                <asp:Button class="btn btn-primary" ID="aButtonGetPlaylistId" runat="server" OnClick="aButtonGetPlaylistId_Click" Text="Get Playlist Data" Width="172px" />
            </asp:Panel>
            <br />
            Videos in Playlist:<br />
            <asp:ListBox ID="aListVideos" runat="server" Height="176px" Width="585px"></asp:ListBox>
            <br /> 
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
