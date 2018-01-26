<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="sample.aspx.cs" Inherits="GoogleYouTubeApi.sample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            YouTube data API<br />
            <br />
            Enter a Video ID:<asp:TextBox ID="aTextId" runat="server" style="margin-left: 12px" Width="346px"></asp:TextBox>
            <asp:Button ID="aButtonGetData" runat="server" OnClick="Button1_Click" Text="Get Youtube Video Data" Width="169px" />
            <br />
            <br />
            <asp:Panel ID="aPanelVideoInfo" runat="server" Height="104px" Width="1017px">
                Video Title:<asp:Label ID="aLabelTitle" runat="server"></asp:Label>
                <br />
                Video Published On:<asp:Label ID="aLabelPublishedDate" runat="server"></asp:Label>
                <br />
                <br />
                <br />
                Enter Playlist ID:
                <asp:TextBox ID="aTextPlaylistId" runat="server" Width="296px"></asp:TextBox>
                <asp:Button ID="aButtonGetPlaylistId" runat="server" OnClick="aButtonGetPlaylistId_Click" Text="Get Playlist Data" Width="172px" />
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
