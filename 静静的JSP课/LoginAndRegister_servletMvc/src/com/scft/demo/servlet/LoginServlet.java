package com.scft.demo.servlet;

import com.scft.demo.dbc.UserDAO;
import com.scft.demo.vo.User;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import java.io.IOException;

@WebServlet("/LoginServlet")
public class LoginServlet extends HttpServlet
{
    protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException
    {
        String userName = request.getParameter("userName");
        String userPw = request.getParameter("userPw");
        UserDAO userDAO = new UserDAO();
        User user = userDAO.login(userName,userPw);
        if (user != null)
        {
            request.getSession().setAttribute("user",user);
            request.getRequestDispatcher("message.jsp").forward(request,response);
        }
        else
        {

        }
    }

    protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException
    {

    }
}
