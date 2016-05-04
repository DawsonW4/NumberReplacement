<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TestFrontEnd._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Number Printer!
        </h1>
        <p class="lead">Add some numbers to do a divisible check and replace that number with.</p>
        <p class="lead">
            <asp:Label ID="statusLabel" runat="server"></asp:Label></p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Adding Replacements</h2>
            <p>
                <label>Divisible Number</label><asp:TextBox ID="text_divisibleBy" runat="server" />
            </p>
            <p>
                <label>Replacement String</label><asp:TextBox ID="text_replacementString" runat="server" />
            </p>
            <p>
                <asp:Button ID="btn_AddDivisible" Text="Submit" runat="server" />
            </p>
        </div>
        <div class="col-md-4">
            <h2>Current Replacements</h2>
            <div>
                <asp:ListView ID="divisibleListView" runat="server">
                    <LayoutTemplate>
                        <table style="width: 100%; text-align: left;">
                            <tr>
                                <td style="width: 20%; text-align: center;">Divisible Number</td>
                                <td style="width: 20%; text-align: center;">String Replacement</td>
                            </tr>
                            <tr runat="server" id="itemPlaceHolder"></tr>
                            <asp:PlaceHolder runat="server" ID="groupPlaceHolder1"></asp:PlaceHolder>
                            <tr>
                                <td colspan="3">
                                    <asp:DataPager ID="divisibleListViewPager" runat="server" PagedControlID="divisibleListView" PageSize="10">
                                        <Fields>
                                            <asp:NextPreviousPagerField ButtonType="Link" ShowFirstPageButton="false" ShowPreviousPageButton="true" ShowNextPageButton="false" />
                                            <asp:NumericPagerField ButtonType="Link" />
                                            <asp:NextPreviousPagerField ButtonType="Link" ShowNextPageButton="true" ShowLastPageButton="false" ShowPreviousPageButton="false" />
                                        </Fields>
                                    </asp:DataPager>
                                </td>
                            </tr>
                        </table>
                    </LayoutTemplate>
                    <ItemTemplate>
                        <tr id="itemPlaceHolder">
                            <td style="width: 20%; text-align: center;"><%#Eval("Key") %></td>
                            <td style="width: 20%; text-align: center;"><%#Eval("Value") %></td>
                        </tr>
                    </ItemTemplate>
                </asp:ListView>
            </div>
        </div>
        <div class="col-md-4">
            <h2>Count our Numbers!</h2>
            <p>
                <label>Minimum Number</label><asp:TextBox ID="text_MinimumNumber" runat="server" />
            </p>
            <p>
                <label>Maximum Number</label><asp:TextBox ID="text_MaximumNumber" runat="server" />
            </p>
            <p>
                <asp:Button ID="btn_CountNumbers" Text="Count using Strings" runat="server" />
            </p>
        </div>
    </div>
    <div class="col-md-4">
        <h2>Current Replacements Using Strings</h2>
        <div>
            <asp:ListView ID="numberCountListView" runat="server">
                <LayoutTemplate>
                    <table style="width: 20%; text-align: left;">
                        <tr>
                            <td style="width: 20%; text-align: center;">Number</td>
                        </tr>
                        <tr runat="server" id="itemPlaceHolder"></tr>
                        <tr>
                            <td colspan="3">
                                <asp:DataPager ID="CountListViewPager" runat="server" PagedControlID="numberCountListView" PageSize="10">
                                    <Fields>
                                        <asp:NextPreviousPagerField ButtonType="Link" ShowFirstPageButton="true" ShowPreviousPageButton="true" ShowNextPageButton="false" />
                                        <asp:NumericPagerField ButtonType="Link" />
                                        <asp:NextPreviousPagerField ButtonType="Link" ShowNextPageButton="true" ShowLastPageButton="true" ShowPreviousPageButton="false" />
                                    </Fields>
                                </asp:DataPager>
                            </td>
                        </tr>
                    </table>
                </LayoutTemplate>
                <ItemTemplate>
                    <tr id="itemPlaceHolder">
                        <td style="width: 20%; text-align: center;"><%# Container.DataItem %></td>
                    </tr>
                </ItemTemplate>
            </asp:ListView>
        </div>
    </div>
</asp:Content>
