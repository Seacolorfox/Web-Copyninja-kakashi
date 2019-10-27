<%--
  Created by IntelliJ IDEA.
  User: Seacolorfox
  Date: 2019/10/27
  Time: 20:35
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=GBK" language="java" %>
<html>
<head>
    <title>one.jsp</title>
</head>
<body bgcolor="yellow">
    <jsp:include page="head.html"></jsp:include>
    <form action="" method="get" name="form">
        请输入1至100之间的整数:
        <input type="text" name="number">
        <br>
        <input type="submit" value="送出" name="submit">
    </form>
<%
    String num=request.getParameter("number");
    if (num == null)
    {
        num = "0";
    }
    try
    {
        int n=Integer.parseInt(num);
        if (n>=1&&n<=50)
        {
%>
    <jsp:forward page="two.jsp">
         <jsp:param name="number" value="<%=n%>"></jsp:param>
    </jsp:forward>
<%        }
        else if (n>50&&n<=100)
        {
    %>
    <jsp:forward page="three.jsp">
        <jsp:param name="number" value="<%=n%>"></jsp:param>
    </jsp:forward>
<%      }
    }
    catch (Exception e)
    {
%>      <jsp:forward page="error.jsp">
            <jsp:param name="mess" value="<%=e.toString()%>"></jsp:param>
        </jsp:forward>
<%    }
%>
</body>
</html>
