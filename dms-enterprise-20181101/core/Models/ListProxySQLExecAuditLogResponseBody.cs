// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListProxySQLExecAuditLogResponseBody : TeaModel {
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
        /// The audit information about the database instance that is provided by the secure access proxy feature.
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
                /// Indicates the total number of rows returned after the SQL statement was executed. If an SELECT SQL statement is executed, the return value of this parameter indicates the total number of the queried data rows.
                /// </summary>
                [NameInMap("AffectRows")]
                [Validation(Required=false)]
                public long? AffectRows { get; set; }

                /// <summary>
                /// The amount of time that is consumed to execute the SQL statement. Unit: milliseconds.
                /// </summary>
                [NameInMap("ElapsedTime")]
                [Validation(Required=false)]
                public long? ElapsedTime { get; set; }

                /// <summary>
                /// The execution status of the SQL statement. Valid values:
                /// 
                /// *   **FAIL**: The execution of the SQL statement fails.
                /// *   **CANCEL**: The execution of the SQL statement is canceled.
                /// *   **SUCCESS**: The SQL statement is executed.
                /// </summary>
                [NameInMap("ExecState")]
                [Validation(Required=false)]
                public string ExecState { get; set; }

                /// <summary>
                /// The ID of the database instance.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public long? InstanceId { get; set; }

                /// <summary>
                /// The name of the database instance.
                /// </summary>
                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                /// <summary>
                /// The time at which the user executes the SQL statement on the database instance. The value of this parameter must be a timestamp that follows the UNIX time format.
                /// </summary>
                [NameInMap("OpTime")]
                [Validation(Required=false)]
                public string OpTime { get; set; }

                /// <summary>
                /// The description.
                /// </summary>
                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                /// <summary>
                /// The SQL statement that was executed.
                /// </summary>
                [NameInMap("SQL")]
                [Validation(Required=false)]
                public string SQL { get; set; }

                /// <summary>
                /// The type of the SQL statement. Valid values:
                /// 
                /// *   **SELECT**
                /// *   **INSERT**
                /// *   **DELETE**
                /// *   **CREATE_TABLE**
                /// 
                /// >  You can choose Operation Audit > Secure Access Proxy in the top navigation bar of the DMS console to view more types of SQL statements.
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
                /// The ID of the user.
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public long? UserId { get; set; }

                /// <summary>
                /// The nickname of the user.
                /// </summary>
                [NameInMap("UserName")]
                [Validation(Required=false)]
                public string UserName { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

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
