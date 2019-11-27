<%--
  Created by IntelliJ IDEA.
  User: Seacolorfox
  Date: 2019/10/22
  Time: 16:52
  To change this template use File | Settings | File Templates.
--%>
<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<!doctype html>
<html lang="en">
<head>
  <meta charset="UTF-8">
  <meta name="viewport"
        content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0">
  <meta http-equiv="X-UA-Compatible" content="ie=edge">
  <title>HelloAjax!</title>
</head>
<body>
<script>
  var xmlHttp;
  function creatXMLHttp()
  {
    if (window.XMLHttpRequest)
    {// code for IE7, Firefox, Mozilla, etc.
      xmlhttp=new XMLHttpRequest();
    }
    else if (window.ActiveXObject)
    {// code for IE5, IE6
      xmlhttp=new ActiveXObject("Microsoft.XMLHTTP");
    }
  }
  function showMsg()
  {
    creatXMLHttp();
    xmlHttp.open("POST","content.html")
    xmlHttp.onreadystatechange = function ()
    {
      if(xmlHttp.readyState == 4)
      {
        if (xmlHttp.status == 200)
        {
          var text = xmlHttp.responseText;
          document.getElementById("msg").innerHTML = text;
        }
      }
    }
    xmlHttp.send(null);
  }
</script>
<input type="button" onclick="showMsg()" value="click!!">
<span id="msg"></span>
</body>
</html>
