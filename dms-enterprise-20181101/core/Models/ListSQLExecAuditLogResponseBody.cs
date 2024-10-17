// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListSQLExecAuditLogResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MissingStartTime</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>StartTime is mandatory for this action.</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>39BC9C86-95AE-58F2-9862-A7C3D896****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The entries returned.</para>
        /// </summary>
        [NameInMap("SQLExecAuditLogList")]
        [Validation(Required=false)]
        public ListSQLExecAuditLogResponseBodySQLExecAuditLogList SQLExecAuditLogList { get; set; }
        public class ListSQLExecAuditLogResponseBodySQLExecAuditLogList : TeaModel {
            [NameInMap("SQLExecAuditLog")]
            [Validation(Required=false)]
            public List<ListSQLExecAuditLogResponseBodySQLExecAuditLogListSQLExecAuditLog> SQLExecAuditLog { get; set; }
            public class ListSQLExecAuditLogResponseBodySQLExecAuditLogListSQLExecAuditLog : TeaModel {
                /// <summary>
                /// <para>The number of rows affected by the SQL statement. For example, if you execute an SQL statement to query data, the number of retrieved rows is returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("AffectRows")]
                [Validation(Required=false)]
                public long? AffectRows { get; set; }

                /// <summary>
                /// <para>The ID of the database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2157****</para>
                /// </summary>
                [NameInMap("DbId")]
                [Validation(Required=false)]
                public long? DbId { get; set; }

                /// <summary>
                /// <para>The amount of time consumed by the execution of the SQL statement. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>18</para>
                /// </summary>
                [NameInMap("ElapsedTime")]
                [Validation(Required=false)]
                public long? ElapsedTime { get; set; }

                /// <summary>
                /// <para>The execution status of the SQL statement. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>FAIL</b>: The SQL statement fails to be executed.</description></item>
                /// <item><description><b>NOEXE</b>: The SQL statement has not been executed.</description></item>
                /// <item><description><b>RUNNING</b>: The SQL statement is being executed.</description></item>
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
                /// <para>The ID of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>185***</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public long? InstanceId { get; set; }

                /// <summary>
                /// <para>The name of the database.</para>
                /// <remarks>
                /// <para> If the SQL statement takes effect on an instance, the name of the instance is returned.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>polar123@pc-bp1h9tgq4st9g****.mysql.polardb.rds.aliyuncs.com:3306[polar_qw_test]</para>
                /// </summary>
                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                /// <summary>
                /// <para>Indicates whether the database is a logical database. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: The database is a logical database.</description></item>
                /// <item><description><b>false</b>: The database is a physical database.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Logic")]
                [Validation(Required=false)]
                public bool? Logic { get; set; }

                /// <summary>
                /// <para>The time when the operation specified by the SQL statement was performed on the instance or database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-11-08 11:04:27</para>
                /// </summary>
                [NameInMap("OpTime")]
                [Validation(Required=false)]
                public string OpTime { get; set; }

                /// <summary>
                /// <para>The comment on the SQL statement.</para>
                /// 
                /// <b>Example:</b>
                /// <para>success</para>
                /// </summary>
                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                /// <summary>
                /// <para>The SQL statement that was written.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SELECT * FROM <c>polar123</c>.<c>p_qw</c> ORDER BY <c>id</c> DESC</para>
                /// </summary>
                [NameInMap("SQL")]
                [Validation(Required=false)]
                public string SQL { get; set; }

                /// <summary>
                /// <para>The type of the SQL statement. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>SELECT</b>: the SQL statement that is used to query data.</description></item>
                /// <item><description><b>INSERT</b>: the SQL statement that is used to insert data.</description></item>
                /// <item><description><b>DELETE</b>: the SQL statement that is used to delete data.</description></item>
                /// <item><description><b>CREATE_TABLE</b>: the SQL statement that is used to create tables.</description></item>
                /// </list>
                /// <remarks>
                /// <para> To view more types of SQL statements, log on to the DMS console and click Security and Specifications. In the left-side navigation pane, click <b>Operation Audit</b>. Then, you can view all supported types of SQL statements from the <b>SQL type</b> drop-down list.</para>
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
                /// <para>polar123</para>
                /// </summary>
                [NameInMap("SchemaName")]
                [Validation(Required=false)]
                public string SchemaName { get; set; }

                /// <summary>
                /// <para>The ID of the user who wrote the SQL statement.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12****</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public long? UserId { get; set; }

                /// <summary>
                /// <para>The nickname of the user who wrote the SQL statement.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test_UserName</para>
                /// </summary>
                [NameInMap("UserName")]
                [Validation(Required=false)]
                public string UserName { get; set; }

            }

        }

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
