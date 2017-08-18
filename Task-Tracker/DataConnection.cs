using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace Task_Tracker
{
    class DataConnection
    {
        private string constring { get; set; }
        
        

        public DataConnection(string cs)
        {
            constring = cs;




        }

        public List<Task> GetAllTasks()
        {


            Console.WriteLine("GetAllTask");
            List<Task> result = new List<Task>();







            #region DB Method
            /*
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            var command = new SqlCommand("SELECT * FROM Task", con);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                string navn = dr[1].ToString();

                Task.TaskType tasktype = (Task.TaskType)int.Parse(dr[2].ToString());
                TimeSpan crit = TimeSpan.Parse(dr[5].ToString());
                TimeSpan med = TimeSpan.Parse(dr[6].ToString());
                Task t = new Task(navn, tasktype, crit, med);
                t.Status = (Task.TaskStatus)int.Parse(dr[3].ToString());
                t.LastDone = DateTime.Parse(dr[4].ToString());
                t.ID = int.Parse(dr[0].ToString());
                result.Add(t);
            }
            con.Close();
            */
#endregion
            return result;
            
        }
        public void UpdateTask(Task TaskToSave)
        {








            #region DB Method
            /*
            Console.WriteLine("Updating Task" + TaskToSave.ID);
            string _table = WhatTable(TaskToSave);
            string _parameters = WhatParameters(TaskToSave);

            using (SqlConnection connection = new SqlConnection(constring))
            {
                SqlCommand cmd = new SqlCommand("UPDATE " + _table + " SET Navn = '"+ TaskToSave.navn + "', TaskType = '"+ (int)TaskToSave.Type + "', TaskStatus = '"+ (int)TaskToSave.Status + "', LastDone = '"+ TaskToSave.LastDone+"', CritTime = '"+ TaskToSave.CritTime.ToString()+"', MedTime = '"+ TaskToSave.MedTime.ToString()+"' WHERE ID LIKE '"+TaskToSave.ID+"'");
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connection;

                cmd.Parameters.AddWithValue("@Navn", TaskToSave.navn);
                cmd.Parameters.AddWithValue("@TaskType", (int)TaskToSave.Type);
                cmd.Parameters.AddWithValue("@TaskStatus", (int)TaskToSave.Status);
                cmd.Parameters.AddWithValue("@LastDone", TaskToSave.LastDone);
                cmd.Parameters.AddWithValue("@CritTime", TaskToSave.CritTime.ToString());
                cmd.Parameters.AddWithValue("@MedTime", TaskToSave.MedTime.ToString());

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            */
#endregion
        }
        
        public Task GetTask(int ID)
        {
            Console.WriteLine("Get Task: "+ ID);
            Task result = new Task("",Task.TaskType.Activity_Event,new TimeSpan(0,0,0,0), new TimeSpan(0,0,0,0));





            #region DB Method
            /*
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            var command = new SqlCommand("SELECT * FROM Task WHERE ID LIKE '"+ID+"'", con);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                string navn = dr[1].ToString();

                Task.TaskType tasktype = (Task.TaskType)int.Parse(dr[2].ToString());
                TimeSpan crit = TimeSpan.Parse(dr[5].ToString());
                TimeSpan med = TimeSpan.Parse(dr[6].ToString());
                Task t = new Task(navn, tasktype, crit, med);
                t.LastDone = DateTime.Parse(dr[4].ToString());
                t.ID = int.Parse(dr[0].ToString());
                result = t;
                
            }
            */

#endregion
            return result;
        }
        

        public void DeleteTask(int ID)
        {







            #region DB Method
            /*
            Console.WriteLine("DELETE Task: "+ ID);
            using (SqlConnection connection = new SqlConnection(constring))
            {


                SqlCommand cmd = new SqlCommand("DELETE FROM Task WHERE ID = '"+ID+"'");
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connection;
                
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();

            }
            */
#endregion
        }


        public void CreateData(Task TaskToSave)
        {
            





            #region DB Method
            /*
            string _table = WhatTable(TaskToSave);
            string _parameters = WhatParameters(TaskToSave);

            using (SqlConnection connection = new SqlConnection(constring))
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO "+_table+" "+_parameters);
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connection;
                
                cmd.Parameters.AddWithValue("@Navn", TaskToSave.navn);
                cmd.Parameters.AddWithValue("@TaskType", (int)TaskToSave.Type);
                cmd.Parameters.AddWithValue("@TaskStatus", (int)TaskToSave.Status);
                cmd.Parameters.AddWithValue("@LastDone", TaskToSave.LastDone);
                cmd.Parameters.AddWithValue("@CritTime", TaskToSave.CritTime.ToString());
                cmd.Parameters.AddWithValue("@MedTime", TaskToSave.MedTime.ToString());

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            */
#endregion
        }


#region DB Private Methods
        private string WhatParameters(Task taskToSave)
        {
            return "(Navn, TaskType, TaskStatus, LastDone, CritTime, MedTime) VALUES (@Navn, @TaskType, @TaskStatus, @LastDone, @CritTime, @Medtime)";
        }

        private string WhatTable(Task taskToSave)
        {
            return "Task";
        }
#endregion
    }
}
