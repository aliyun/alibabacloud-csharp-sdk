// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListSensitiveDataAuditLogResponseBody : TeaModel {
        /// <summary>
        /// The error code returned if the request failed.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The error message returned if the request failed.
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
        /// The audit logs for sensitive data.
        /// </summary>
        [NameInMap("SensitiveDataAuditLogList")]
        [Validation(Required=false)]
        public List<ListSensitiveDataAuditLogResponseBodySensitiveDataAuditLogList> SensitiveDataAuditLogList { get; set; }
        public class ListSensitiveDataAuditLogResponseBodySensitiveDataAuditLogList : TeaModel {
            /// <summary>
            /// The name of the database that stores the sensitive data.
            /// </summary>
            [NameInMap("DbDisplayName")]
            [Validation(Required=false)]
            public string DbDisplayName { get; set; }

            /// <summary>
            /// The ID of the instance.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public long? InstanceId { get; set; }

            /// <summary>
            /// The name of the function module whose audit logs were queried.
            /// </summary>
            [NameInMap("ModuleName")]
            [Validation(Required=false)]
            public string ModuleName { get; set; }

            /// <summary>
            /// The time when the operation was performed. The time is in the yyyy-MM-DD HH:mm:ss format.
            /// </summary>
            [NameInMap("OpTime")]
            [Validation(Required=false)]
            public string OpTime { get; set; }

            /// <summary>
            /// The logs for sensitive data.
            /// </summary>
            [NameInMap("SensitiveDataLog")]
            [Validation(Required=false)]
            public List<ListSensitiveDataAuditLogResponseBodySensitiveDataAuditLogListSensitiveDataLog> SensitiveDataLog { get; set; }
            public class ListSensitiveDataAuditLogResponseBodySensitiveDataAuditLogListSensitiveDataLog : TeaModel {
                /// <summary>
                /// The name of the column that contains sensitive data.
                /// </summary>
                [NameInMap("ColumnName")]
                [Validation(Required=false)]
                public string ColumnName { get; set; }

                /// <summary>
                /// The permission that the user has on the column. Valid values:
                /// 
                /// *   **No permission**
                /// *   **Partial redaction**
                /// *   **Plaintext**
                /// *   **Change**
                /// *   **Enable data masking**
                /// *   **Disable data masking**
                /// </summary>
                [NameInMap("ColumnPermissionType")]
                [Validation(Required=false)]
                public string ColumnPermissionType { get; set; }

                /// <summary>
                /// The algorithm used for data masking.
                /// </summary>
                [NameInMap("DesensitizationRule")]
                [Validation(Required=false)]
                public string DesensitizationRule { get; set; }

                /// <summary>
                /// The sensitivity level of the data. Valid values:
                /// 
                /// *   **Low**
                /// *   **Medium**
                /// *   **High**
                /// </summary>
                [NameInMap("SecurityLevel")]
                [Validation(Required=false)]
                public string SecurityLevel { get; set; }

                /// <summary>
                /// The name of the table that stores the sensitive data.
                /// </summary>
                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

            }

            /// <summary>
            /// The details of the object on which the operation was performed. The value of this parameter is in one of the following formats:
            /// 
            /// *   Object name - object ID
            /// *   Object name (object ID)
            /// </summary>
            [NameInMap("TargetName")]
            [Validation(Required=false)]
            public string TargetName { get; set; }

            /// <summary>
            /// The user ID of the requester.
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public long? UserId { get; set; }

            /// <summary>
            /// The username of the requester.
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

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
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
