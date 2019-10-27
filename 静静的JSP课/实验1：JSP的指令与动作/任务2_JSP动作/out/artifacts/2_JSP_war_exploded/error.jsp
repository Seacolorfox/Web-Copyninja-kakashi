<%--
  Created by IntelliJ IDEA.
  User: Seacolorfox
  Date: 2019/10/27
  Time: 17:03
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=GBK" language="java" %>
<html>
<head>
    <title>error.jsp</title>
</head>
<body style="background-color: yellow">
    <jsp:include page="head.html"></jsp:include>
    <p style="font-size: 20px; color:blue;">This is three.jsp</p>
    <p style="font-size: 25px; color: red">
        <%
            String s=request.getParameter("mess");
            out.println("<br>传递过来的错误信息"+s);
        %>
    </p>
</body>
</html>
