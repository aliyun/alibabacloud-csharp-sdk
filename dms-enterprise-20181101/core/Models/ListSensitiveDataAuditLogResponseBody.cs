// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListSensitiveDataAuditLogResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>403</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E0D21075-CD3E-4D98-8264-FD8AD04A63B6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The audit logs for sensitive data.</para>
        /// </summary>
        [NameInMap("SensitiveDataAuditLogList")]
        [Validation(Required=false)]
        public List<ListSensitiveDataAuditLogResponseBodySensitiveDataAuditLogList> SensitiveDataAuditLogList { get; set; }
        public class ListSensitiveDataAuditLogResponseBodySensitiveDataAuditLogList : TeaModel {
            /// <summary>
            /// <para>The name of the database that stores the sensitive data.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:ExampleDbName@xxx.xxx.xxx.xxx">ExampleDbName@xxx.xxx.xxx.xxx</a>:3306</para>
            /// </summary>
            [NameInMap("DbDisplayName")]
            [Validation(Required=false)]
            public string DbDisplayName { get; set; }

            /// <summary>
            /// <para>The ID of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public long? InstanceId { get; set; }

            /// <summary>
            /// <para>The name of the function module whose audit logs were queried.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SQL_CONSOLE</para>
            /// </summary>
            [NameInMap("ModuleName")]
            [Validation(Required=false)]
            public string ModuleName { get; set; }

            /// <summary>
            /// <para>The time when the operation was performed. The time is in the yyyy-MM-DD HH:mm:ss format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-11-18 10:01:00</para>
            /// </summary>
            [NameInMap("OpTime")]
            [Validation(Required=false)]
            public string OpTime { get; set; }

            /// <summary>
            /// <para>The logs for sensitive data.</para>
            /// </summary>
            [NameInMap("SensitiveDataLog")]
            [Validation(Required=false)]
            public List<ListSensitiveDataAuditLogResponseBodySensitiveDataAuditLogListSensitiveDataLog> SensitiveDataLog { get; set; }
            public class ListSensitiveDataAuditLogResponseBodySensitiveDataAuditLogListSensitiveDataLog : TeaModel {
                /// <summary>
                /// <para>The name of the column that contains sensitive data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ExampleColumnName</para>
                /// </summary>
                [NameInMap("ColumnName")]
                [Validation(Required=false)]
                public string ColumnName { get; set; }

                /// <summary>
                /// <para>The permission that the user has on the column. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>No permission</b></description></item>
                /// <item><description><b>Partial redaction</b></description></item>
                /// <item><description><b>Plaintext</b></description></item>
                /// <item><description><b>Change</b></description></item>
                /// <item><description><b>Enable data masking</b></description></item>
                /// <item><description><b>Disable data masking</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Change</para>
                /// </summary>
                [NameInMap("ColumnPermissionType")]
                [Validation(Required=false)]
                public string ColumnPermissionType { get; set; }

                /// <summary>
                /// <para>The algorithm used for data masking.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Default - Full redaction</para>
                /// </summary>
                [NameInMap("DesensitizationRule")]
                [Validation(Required=false)]
                public string DesensitizationRule { get; set; }

                /// <summary>
                /// <para>The sensitivity level of the data. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Low</b></description></item>
                /// <item><description><b>Medium</b></description></item>
                /// <item><description><b>High</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Low</para>
                /// </summary>
                [NameInMap("SecurityLevel")]
                [Validation(Required=false)]
                public string SecurityLevel { get; set; }

                /// <summary>
                /// <para>The name of the table that stores the sensitive data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ExampleTableName</para>
                /// </summary>
                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

            }

            /// <summary>
            /// <para>The details of the object on which the operation was performed. The value of this parameter is in one of the following formats:</para>
            /// <list type="bullet">
            /// <item><description>Object name - object ID</description></item>
            /// <item><description>Object name (object ID)</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Ticket - 1\<em>\</em>\<em>\</em></para>
            /// </summary>
            [NameInMap("TargetName")]
            [Validation(Required=false)]
            public string TargetName { get; set; }

            /// <summary>
            /// <para>The user ID of the requester.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1**</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public long? UserId { get; set; }

            /// <summary>
            /// <para>The username of the requester.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ExampleUserName</para>
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

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
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
