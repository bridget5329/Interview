<%@ Page Language="C#" AutoEventWireup="true" CodeFile="InterView.aspx.cs" Inherits="InterView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <script>
    </script>
    <style>
        table {border:solid;}
        table th  {border:solid;}
        table td {border:solid;}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div><h1>SQL</h1>
            <h2>Question1</h2><div>SELECT p.Firstname,p.Lastname,A.city,A.state FROM Person as p INNETR JOIN Address AS A on p.personId=A.PersonID 
                              </div>
            <h2>Question2</h2><div>SELECT name as Customers as V FROM Customers inner join Orders as O on O.customerId=C.id</div>
            <h2>Question3</h2><div>SELECT email FROM Person group by email having count(*) > 1</div>
        </div>
        <div>
            <h2>Html Question1</h2>
            <table >
                <thead>
                    <tr>
                        <th>Header1</th>
                        <th>Header2</th>
                        <th>Header3</th>
                        <th>Header4</th>
                    </tr>
                </thead>
                <tbody>
                    <tr >
                        <td rowspan="2" >&nbsp;</td>
                        <td colspan="3" >&nbsp;</td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                </tbody>
            </table>
            </div>
        <br />
        <h2>.NET MVC</h2>
        <h3>Question1</h3>
        <div><h3>Session</h3>預設20分鐘清除，或關掉頁就消失;存在sever端記憶體</div>
        <div><h3>tempdata</h3>用一次之後就刪除</div>
        <div><h3>Viewdata</h3>控制器傳送data給view，當動作消失即消失，類似字典，取用須以字典設定取用資料</div>
        <div><h3>Viewbag</h3>強行別的傳送方式，利用dynmic進行取用</div>
            
    </form>
</body>
</html>
