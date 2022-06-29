using System;
using System.IO;
using System.Collections.Generic;
using System.Collections;
using System.Data;
using System.Data.SqlClient;

public class Solution
{
	public Solution()
	{
	}

	/// <summary>
	/// Program-Qustion1
	/// </summary>
	/// <param name="nums">array of int</param>
	/// <param name="target">int</param>
	/// <returns></returns>
	public int[] Question1(int[] nums ,int target)
	{
		if (nums.Length < 2 || nums.Length > Math.Pow(10, 4))
			throw new Exception("nums length Out of range");
		if (target < Math.Pow(-10, 9) || target > Math.Pow(10, 9))
			throw new Exception(String.Format("{0} Out of range", target.ToString()));

		int[] result = new int[2];
		for(int i=0;i<nums.Length;i++)
        {
			if (nums[i] < Math.Pow(-10, 9) || nums[i] > Math.Pow(10, 9))
				throw new Exception(String.Format("nums[{0}] Out of range",i.ToString()));
			for (int j=i+1;j<nums.Length;j++)
            {
				if (nums[i] + nums[j] == target)
				{
					result[0] = i;
					result[1] = j;
					break; 
				}
            }
        }
		return result;
	}

	public bool Question6(int n)
	{
		if (n > Math.Pow(2, 31) - 1 || n < Math.Pow(-2, 31))
			throw new Exception("Out of range");
		if (n == 1)
			return true;
		if (n == 0 || n % 4 != 0)
			return false;
		return Question6(n / 4);
	}

	///SQL
	public DataTable Question2()
    {
		SqlConnection conn = new SqlConnection("connection");
		conn.Open();
		SqlCommand cmd = new SqlCommand("Create table If Not Exists Customers (id int, name varchar(255))", conn);
		cmd.ExecuteNonQuery();
		cmd = new SqlCommand("Create table If Not Exists Orders (id int, customerId int)", conn);
		cmd.ExecuteNonQuery();
		cmd = new SqlCommand("insert into Customers (id, name) values ('1', 'Joe')", conn);
		cmd.ExecuteNonQuery();
		cmd = new SqlCommand("insert into Customers (id, name) values ('2', 'Henry')", conn);
		cmd.ExecuteNonQuery();
		cmd = new SqlCommand("insert into Customers (id, name) values ('3', 'Sam')", conn);
		cmd.ExecuteNonQuery();
		cmd = new SqlCommand("insert into Customers (id, name) values ('4', 'Max')", conn);
		cmd.ExecuteNonQuery();
		cmd = new SqlCommand("insert into Orders (id, customerId) values ('1', '3')", conn);
		cmd.ExecuteNonQuery();
		cmd = new SqlCommand("insert into Orders (id, customerId) values ('2', '1')", conn);
		cmd.ExecuteNonQuery();
		conn.Close();

		DataTable dt = new DataTable();
		SqlDataAdapter adp = new SqlDataAdapter(@"SELECT name as Customers as V FROM Customers inner join Orders as O on O.customerId=C.id", conn);
		adp.Fill(dt);
		return dt;
	}

	public DataTable Question3()
	{
		SqlConnection conn = new SqlConnection("connection");
		conn.Open();
		SqlCommand cmd = new SqlCommand("Create table If Not Exists Person(id int, email varchar(255))", conn);
		cmd.ExecuteNonQuery();
		cmd = new SqlCommand("insert into Person(id, email) values('1', 'a@b.com')", conn);
		cmd.ExecuteNonQuery();
		cmd = new SqlCommand("insert into Person(id, email) values('2', 'c@d.com')", conn);
		cmd.ExecuteNonQuery();
		cmd = new SqlCommand("insert into Person(id, email) values('3', 'a@b.com')", conn);
		cmd.ExecuteNonQuery();
		conn.Close();

		DataTable dt = new DataTable();
		SqlDataAdapter adp = new SqlDataAdapter(@"select email from Person group by email having count(*) > 1 ", conn);
		adp.Fill(dt);
		return dt;
	}
}
