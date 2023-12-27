// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeDBInstanceSwitchLogResponseBody : TeaModel {
        /// <summary>
        /// The instance ID.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The primary/secondary switchover logs.
        /// </summary>
        [NameInMap("LogItems")]
        [Validation(Required=false)]
        public List<DescribeDBInstanceSwitchLogResponseBodyLogItems> LogItems { get; set; }
        public class DescribeDBInstanceSwitchLogResponseBodyLogItems : TeaModel {
            /// <summary>
            /// The ID of the replica set instance or the ID of the node on which a primary/secondary switchover is performed.
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            /// <summary>
            /// The code that indicates the reason of a primary/secondary switchover. Valid values:
            /// 
            /// *   USER_CONSOLE_OPERATION: The switchover is manually performed.
            /// *   OPERATION_AND_MAINTENANCE: Potential risks exist.
            /// *   MACHINE_DOWNTIME: The host is offline.
            /// *   PRIMARY_UNHEALTHY: An exception occurs on the primary node of the instance.
            /// *   SECONDARY_UNHEALTHY: An exception occurs on the secondary node of the instance.
            /// *   MULTIPLE_NODE_FAILURES: An exception occurs on multiple nodes of the instance.
            /// </summary>
            [NameInMap("SwitchCode")]
            [Validation(Required=false)]
            public string SwitchCode { get; set; }

            /// <summary>
            /// The switchover status. Valid values: **1** and **0**. The value 1 indicates a successful primary/secondary switchover and the value 0 indicates a failed primary/secondary switchover.
            /// </summary>
            [NameInMap("SwitchStatus")]
            [Validation(Required=false)]
            public string SwitchStatus { get; set; }

            /// <summary>
            /// The point in time when a primary/secondary switchover was performed. The time follows the ISO 8601 standard in the *yyyy-mm-dd*T*hh:mm:ss*Z format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("SwitchTime")]
            [Validation(Required=false)]
            public string SwitchTime { get; set; }

        }

        /// <summary>
        /// The page number returned.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned on each page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The number of primary/secondary switching entries.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
