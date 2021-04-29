﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace DAO
{
    [Serializable]
    public class DaoB {
        protected SqlConnection objCn;
        protected string objCnMySql;

        public DaoB() {
            Conexion cn = new Conexion();
            objCn = new SqlConnection(cn.StrCon);
            objCnMySql = cn.StrConMySQL;
        }

        public string ToString(string metodo) {
            return "\n\rClase error: " + base.ToString() + "\n\rMetodo error: " + metodo;
        }

        /// <summary>
        /// Permite pasar datos nulos a la BD
        /// </summary>
        protected object V_ValidaPrNull(object pr) {
            if (pr != null)
                if (pr.GetType().Name == "DateTime")
                {
                    if (pr.ToString().Substring(0, 10).Contains("01/01/0001") || pr.ToString().Substring(0, 10).Contains("1/1/0001 1") || pr.ToString().Substring(0, 10).Contains("1/01/0001"))
                        return DBNull.Value;
                }
            if (pr == null || pr.ToString().Trim() == "" || pr.Equals(0) || pr.Equals(decimal.Zero) || pr.Equals((Int64)0)) return DBNull.Value;
            return pr;
        }

        protected Fields GetValue(string mi_campo, SqlDataReader reader)
        {
            return reader.GetValue(reader.GetOrdinal(mi_campo)) == DBNull.Value ? new Fields(null) : new Fields(reader.GetValue(reader.GetOrdinal(mi_campo)));
        }

        protected Fields GetValue(object reader)
        {
            return reader == DBNull.Value ? new Fields(null) : new Fields(reader);
        }

        public byte[] ObjectToByteArray(object obj)
        {
            if (obj is null)
                return null;
            BinaryFormatter bf = new BinaryFormatter();
            using (MemoryStream ms = new MemoryStream())
            {
                bf.Serialize(ms, obj);
                List<byte> temp = ms.ToArray().ToList();
                temp.RemoveRange(0, 27);
                return temp.ToArray();
            }
        }

        public class Fields
        {
            private readonly object value_obj;
            public Fields(object value)
            {
                value_obj = value;
            }
            public Int16 Value_Int16 { get { return value_obj == null ? Convert.ToInt16(0) : Convert.ToInt16(value_obj); } }
            public Int32 Value_Int32 { get { return value_obj == null ? 0 : Convert.ToInt32(value_obj); } }
            public Int64 Value_Int64 { get { return value_obj == null ? Convert.ToInt64(0) : Convert.ToInt64(value_obj); } }
            public string Value_String { get { return value_obj == null ? string.Empty : Convert.ToString(value_obj); } }
            public bool Value_Bool { get { return value_obj == null ? false : Convert.ToBoolean(value_obj.Equals(true) || value_obj.Equals(false) ? value_obj : (int)value_obj); } }
            public DateTime Value_DateTime { get { return value_obj == null ? DateTime.MinValue : (DateTime)value_obj; } }
            public DateTime? Value_DateTimeReal { get { return value_obj == null ? null : (DateTime?)value_obj; } }
            public TimeSpan Value_TimeSpan { get { return value_obj == null ? TimeSpan.MinValue : (TimeSpan)value_obj; } }
            public decimal Value_Decimal { get { return value_obj == null ? decimal.Zero : (decimal)value_obj; } }
            public Guid Value_Guid { get { return value_obj == null ? Guid.NewGuid() : (Guid)value_obj; } }
            public char Value_Char { get { return value_obj == null ? Convert.ToChar(string.Empty) : Convert.ToChar(value_obj); } }
            public byte[] Value_Bytes { get { return value_obj == null ? null : new DaoB().ObjectToByteArray(value_obj); } }
        }
    }
}
