// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pvtz20180101.Models
{
    public class DescribeChangeLogsResponseBody : TeaModel {
        /// <summary>
        /// The operation logs.
        /// </summary>
        [NameInMap("ChangeLogs")]
        [Validation(Required=false)]
        public DescribeChangeLogsResponseBodyChangeLogs ChangeLogs { get; set; }
        public class DescribeChangeLogsResponseBodyChangeLogs : TeaModel {
            [NameInMap("ChangeLog")]
            [Validation(Required=false)]
            public List<DescribeChangeLogsResponseBodyChangeLogsChangeLog> ChangeLog { get; set; }
            public class DescribeChangeLogsResponseBodyChangeLogsChangeLog : TeaModel {
                /// <summary>
                /// The details of the operation.
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// The operator ID.
                /// </summary>
                [NameInMap("CreatorId")]
                [Validation(Required=false)]
                public string CreatorId { get; set; }

                /// <summary>
                /// The subtype of the operator. Valid values:
                /// 
                /// *   CUSTOMER: Alibaba Cloud account
                /// *   SUB: RAM user
                /// *   STS: assumed role that obtains the Security Token Service (STS) token of a RAM role
                /// *   OTHER: other types
                /// </summary>
                [NameInMap("CreatorSubType")]
                [Validation(Required=false)]
                public string CreatorSubType { get; set; }

                /// <summary>
                /// The operator type. No value or **USER** is returned for this parameter.
                /// </summary>
                [NameInMap("CreatorType")]
                [Validation(Required=false)]
                public string CreatorType { get; set; }

                /// <summary>
                /// The ID of the object on which the operation was performed.
                /// </summary>
                [NameInMap("EntityId")]
                [Validation(Required=false)]
                public string EntityId { get; set; }

                /// <summary>
                /// The name of the object on which the operation was performed.
                /// </summary>
                [NameInMap("EntityName")]
                [Validation(Required=false)]
                public string EntityName { get; set; }

                /// <summary>
                /// The log ID.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// The operation type.
                /// </summary>
                [NameInMap("OperAction")]
                [Validation(Required=false)]
                public string OperAction { get; set; }

                /// <summary>
                /// The IP address of the client.
                /// </summary>
                [NameInMap("OperIp")]
                [Validation(Required=false)]
                public string OperIp { get; set; }

                /// <summary>
                /// The type of the object on which the operation is performed.
                /// </summary>
                [NameInMap("OperObject")]
                [Validation(Required=false)]
                public string OperObject { get; set; }

                /// <summary>
                /// The time when the operation is performed. The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ssZ format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("OperTime")]
                [Validation(Required=false)]
                public string OperTime { get; set; }

                /// <summary>
                /// The time when the operation was performed. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
                /// </summary>
                [NameInMap("OperTimestamp")]
                [Validation(Required=false)]
                public long? OperTimestamp { get; set; }

            }

        }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalItems")]
        [Validation(Required=false)]
        public int? TotalItems { get; set; }

        /// <summary>
        /// The total number of pages.
        /// </summary>
        [NameInMap("TotalPages")]
        [Validation(Required=false)]
        public int? TotalPages { get; set; }

    }

}
