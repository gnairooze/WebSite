using Basics;
using LogInterface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace SimpleLog
{
    public class DataSQL : IDataBasic
    {
        public string LogDbConnectionString { get; set; }

        public Result Add(LogModel model)
        {
            Result result = new Result();

            try
            {
                using (var conn = new SqlConnection(LogDbConnectionString))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "Log_Add";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandTimeout = 30;
                    cmd.Connection = conn;

                    cmd.Parameters.AddWithValue("@ID", 0);
                    cmd.Parameters["@ID"].Direction = System.Data.ParameterDirection.Output;
                    cmd.Parameters.AddWithValue("@CreateDate", model.CreateDate);
                    cmd.Parameters.AddWithValue("@LogLevel", model.LogLevel);
                    cmd.Parameters.AddWithValue("@CorrelationID", model.CorrelationID);
                    cmd.Parameters.AddWithValue("@Step", model.Step);
                    cmd.Parameters.AddWithValue("@Who", model.Who);
                    cmd.Parameters.AddWithValue("@Message", model.Message);
                    cmd.Parameters.AddWithValue("@RefName", model.RefName);
                    cmd.Parameters.AddWithValue("@RefValue", model.RefValue);
                    cmd.Parameters.AddWithValue("@Path", model.Path);
                    cmd.Parameters.AddWithValue("@Assembly", model.Assembly);
                    cmd.Parameters.AddWithValue("@ClassName", model.ClassName);
                    cmd.Parameters.AddWithValue("@MethodName", model.MethodName);
                    cmd.Parameters.AddWithValue("@IP", model.IP);
                    cmd.Parameters.AddWithValue("@URL", model.URL.ToString());
                    cmd.Parameters.AddWithValue("@Notes1", model.Notes1);
                    cmd.Parameters.AddWithValue("@Notes2", model.Notes2);


                    conn.Open();
                    cmd.ExecuteNonQuery();

                    model.ID = long.Parse(cmd.Parameters["@ID"].Value.ToString());
                    dynamic jsonObject = new Newtonsoft.Json.Linq.JObject();
                    jsonObject.ID = model.ID;

                    result.ResultStatus = Basics.Enums.Status.Succeeded;
                    result.Code = Messages.CODE_SUCCESS;
                    result.Data = jsonObject;

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                result.Code = Messages.CODE_GENERAL_ERROR;
                result.Description = ex.Message;
                result.ResultStatus = Basics.Enums.Status.Failed;
                result.Data = Newtonsoft.Json.Linq.JObject.Parse(Newtonsoft.Json.JsonConvert.SerializeObject(ex));
            }
 
            return result;
        }
    }
}
