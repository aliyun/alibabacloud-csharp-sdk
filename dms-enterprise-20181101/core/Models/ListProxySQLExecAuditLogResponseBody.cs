// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListProxySQLExecAuditLogResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InvalidStartTime</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Specified parameter StartTime is not valid.</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The audit information about the database instance that is provided by the secure access proxy feature.</para>
        /// </summary>
        [NameInMap("ProxySQLExecAuditLogList")]
        [Validation(Required=false)]
        public ListProxySQLExecAuditLogResponseBodyProxySQLExecAuditLogList ProxySQLExecAuditLogList { get; set; }
        public class ListProxySQLExecAuditLogResponseBodyProxySQLExecAuditLogList : TeaModel {
            [NameInMap("ProxySQLExecAuditLog")]
            [Validation(Required=false)]
            public List<ListProxySQLExecAuditLogResponseBodyProxySQLExecAuditLogListProxySQLExecAuditLog> ProxySQLExecAuditLog { get; set; }
            public class ListProxySQLExecAuditLogResponseBodyProxySQLExecAuditLogListProxySQLExecAuditLog : TeaModel {
                /// <summary>
                /// <para>Indicates the total number of rows returned after the SQL statement was executed. If an SELECT SQL statement is executed, the return value of this parameter indicates the total number of the queried data rows.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("AffectRows")]
                [Validation(Required=false)]
                public long? AffectRows { get; set; }

                /// <summary>
                /// <para>The amount of time that is consumed to execute the SQL statement. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1324</para>
                /// </summary>
                [NameInMap("ElapsedTime")]
                [Validation(Required=false)]
                public long? ElapsedTime { get; set; }

                /// <summary>
                /// <para>The execution status of the SQL statement. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>FAIL</b>: The execution of the SQL statement fails.</description></item>
                /// <item><description><b>CANCEL</b>: The execution of the SQL statement is canceled.</description></item>
                /// <item><description><b>SUCCESS</b>: The SQL statement is executed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>SUCCESS</para>
                /// </summary>
                [NameInMap("ExecState")]
                [Validation(Required=false)]
                public string ExecState { get; set; }

                /// <summary>
                /// <para>The ID of the database instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4***</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public long? InstanceId { get; set; }

                /// <summary>
                /// <para>The name of the database instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pc-uf662nrg017c6****.mysql.polardb.rds.aliyuncs.com:3306【test】</para>
                /// </summary>
                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                /// <summary>
                /// <para>The time at which the user executes the SQL statement on the database instance. The value of this parameter must be a timestamp that follows the UNIX time format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1636876446000</para>
                /// </summary>
                [NameInMap("OpTime")]
                [Validation(Required=false)]
                public string OpTime { get; set; }

                /// <summary>
                /// <para>The description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>success</para>
                /// </summary>
                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                /// <summary>
                /// <para>The SQL statement that was executed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>select 1;</para>
                /// </summary>
                [NameInMap("SQL")]
                [Validation(Required=false)]
                public string SQL { get; set; }

                /// <summary>
                /// <para>The type of the SQL statement. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>SELECT</b></description></item>
                /// <item><description><b>INSERT</b></description></item>
                /// <item><description><b>DELETE</b></description></item>
                /// <item><description><b>CREATE_TABLE</b></description></item>
                /// </list>
                /// <remarks>
                /// <para> You can choose Operation Audit &gt; Secure Access Proxy in the top navigation bar of the DMS console to view more types of SQL statements.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>SELECT</para>
                /// </summary>
                [NameInMap("SQLType")]
                [Validation(Required=false)]
                public string SQLType { get; set; }

                /// <summary>
                /// <para>The name of the database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test_db</para>
                /// </summary>
                [NameInMap("SchemaName")]
                [Validation(Required=false)]
                public string SchemaName { get; set; }

                /// <summary>
                /// <para>The ID of the user.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4****</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public long? UserId { get; set; }

                /// <summary>
                /// <para>The nickname of the user.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testNickName</para>
                /// </summary>
                [NameInMap("UserName")]
                [Validation(Required=false)]
                public string UserName { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50ECB006-2C35-5FCA-91B9-01987A0B****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The request was successful.</description></item>
        /// <item><description><b>false</b>: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
