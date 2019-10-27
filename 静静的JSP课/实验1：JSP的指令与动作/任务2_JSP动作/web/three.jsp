<%--
  Created by IntelliJ IDEA.
  User: Seacolorfox
  Date: 2019/10/27
  Time: 17:02
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=GBK" language="java" %>
<html>
<head>
    <title>three.jsp</title>
</head>
<body bgcolor="yellow">
    <jsp:include page="head.html"></jsp:include>
    <p style="font-size: 20px; color:blue;">This is three.jsp</p>
    <p style="font-size: 25px; color: red">
        <%
            String s = request.getParameter("number");
            out.print("传过来的值是"+s);
        %>
    </p>
</body>
</html>
