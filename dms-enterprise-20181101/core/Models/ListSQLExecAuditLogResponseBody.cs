// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListSQLExecAuditLogResponseBody : TeaModel {
        /// <summary>
        /// The error code returned.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The error message returned.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The entries returned.
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
                /// The number of rows affected by the SQL statement. For example, if you execute an SQL statement to query data, the number of retrieved rows is returned.
                /// </summary>
                [NameInMap("AffectRows")]
                [Validation(Required=false)]
                public long? AffectRows { get; set; }

                /// <summary>
                /// The ID of the database.
                /// </summary>
                [NameInMap("DbId")]
                [Validation(Required=false)]
                public long? DbId { get; set; }

                /// <summary>
                /// The amount of time consumed by the execution of the SQL statement. Unit: milliseconds.
                /// </summary>
                [NameInMap("ElapsedTime")]
                [Validation(Required=false)]
                public long? ElapsedTime { get; set; }

                /// <summary>
                /// The execution status of the SQL statement. Valid values:
                /// 
                /// *   **FAIL**: The SQL statement fails to be executed.
                /// *   **NOEXE**: The SQL statement has not been executed.
                /// *   **RUNNING**: The SQL statement is being executed.
                /// *   **CANCEL**: The execution of the SQL statement is canceled.
                /// *   **SUCCESS**: The SQL statement is executed.
                /// </summary>
                [NameInMap("ExecState")]
                [Validation(Required=false)]
                public string ExecState { get; set; }

                /// <summary>
                /// The ID of the instance.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public long? InstanceId { get; set; }

                /// <summary>
                /// The name of the database.
                /// 
                /// >  If the SQL statement takes effect on an instance, the name of the instance is returned.
                /// </summary>
                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                /// <summary>
                /// Indicates whether the database is a logical database. Valid values:
                /// 
                /// *   **true**: The database is a logical database.
                /// *   **false**: The database is a physical database.
                /// </summary>
                [NameInMap("Logic")]
                [Validation(Required=false)]
                public bool? Logic { get; set; }

                /// <summary>
                /// The time when the operation specified by the SQL statement was performed on the instance or database.
                /// </summary>
                [NameInMap("OpTime")]
                [Validation(Required=false)]
                public string OpTime { get; set; }

                /// <summary>
                /// The comment on the SQL statement.
                /// </summary>
                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                /// <summary>
                /// The SQL statement that was written.
                /// </summary>
                [NameInMap("SQL")]
                [Validation(Required=false)]
                public string SQL { get; set; }

                /// <summary>
                /// The type of the SQL statement. Valid values:
                /// 
                /// *   **SELECT**: the SQL statement that is used to query data.
                /// *   **INSERT**: the SQL statement that is used to insert data.
                /// *   **DELETE**: the SQL statement that is used to delete data.
                /// *   **CREATE_TABLE**: the SQL statement that is used to create tables.
                /// 
                /// >  To view more types of SQL statements, log on to the DMS console and click Security and Specifications. In the left-side navigation pane, click **Operation Audit**. Then, you can view all supported types of SQL statements from the **SQL type** drop-down list.
                /// </summary>
                [NameInMap("SQLType")]
                [Validation(Required=false)]
                public string SQLType { get; set; }

                /// <summary>
                /// The name of the database.
                /// </summary>
                [NameInMap("SchemaName")]
                [Validation(Required=false)]
                public string SchemaName { get; set; }

                /// <summary>
                /// The ID of the user who wrote the SQL statement.
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public long? UserId { get; set; }

                /// <summary>
                /// The nickname of the user who wrote the SQL statement.
                /// </summary>
                [NameInMap("UserName")]
                [Validation(Required=false)]
                public string UserName { get; set; }

            }

        }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   **true**: The request was successful.
        /// *   **false**: The request failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
