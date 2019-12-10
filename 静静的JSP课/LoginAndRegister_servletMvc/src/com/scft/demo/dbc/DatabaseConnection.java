package com.scft.demo.dbc;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;

public class DatabaseConnection
{
    public static Connection getConnection()
    {
        Connection connection = null;
        try
        {
            Class.forName("com.mysql.jdbc.Driver");
            String url = "jdbc:mysql://:3306/db_test1?useUnicode=true&characterEncoding=utf-8";
            connection = DriverManager.getConnection(url, "db_test1", "123456");
        }
        catch (ClassNotFoundException | SQLException e)
        {
            e.printStackTrace();
        }
        return connection;
    }
    public static void closeConnection(Connection connection)
    {
        if (connection != null)
        {
            try
            {
                connection.close();
            }
            catch (SQLException e)
            {
                e.printStackTrace();
            }
        }
    }
}

