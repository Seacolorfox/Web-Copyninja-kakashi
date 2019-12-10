package com.scft.demo.dbc;

import com.scft.demo.vo.User;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;

public class UserDAO
{
    public void doSaveUser(User user)
    {
        Connection connection = DatabaseConnection.getConnection();
        String sql ="insert into tb_user(userName,passWd) values(?,?)";
        try
        {
            PreparedStatement ps = connection.prepareStatement(sql);
            ps.setString(1,user.getUserName());
            ps.setString(2,user.getPassWd());
            ps.executeUpdate();
            ps.close();
        }
        catch (SQLException e)
        {
            e.printStackTrace();
        }
        finally
        {
            DatabaseConnection.closeConnection(connection);
        }
    }

    public User login(String userName,String userPw)
    {
        User user = null;
        Connection connection = DatabaseConnection.getConnection();
        String sql = "select * from tb_user where username = ? and passWd = ?";
        try
        {
            PreparedStatement ps = connection.prepareStatement(sql);
            ps.setString(1, userName);
            ps.setString(2, userPw);
            ResultSet rs = ps.executeQuery();
            if(rs.next())
            {
                user = new User();
                user.setUserName(rs.getString("userName"));
                user.setPassWd(rs.getString("passWd"));
            }
        }
        catch (SQLException e)
        {
            e.printStackTrace();
        }
        finally
        {
            DatabaseConnection.closeConnection(connection);
        }
        return user;
    }

    }
