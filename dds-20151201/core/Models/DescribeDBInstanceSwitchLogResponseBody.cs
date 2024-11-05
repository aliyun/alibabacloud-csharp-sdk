// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeDBInstanceSwitchLogResponseBody : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dds-uf68f1b5a57exxxx</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The primary/secondary switchover logs.</para>
        /// </summary>
        [NameInMap("LogItems")]
        [Validation(Required=false)]
        public List<DescribeDBInstanceSwitchLogResponseBodyLogItems> LogItems { get; set; }
        public class DescribeDBInstanceSwitchLogResponseBodyLogItems : TeaModel {
            /// <summary>
            /// <para>The ID of the replica set instance or the ID of the node on which a primary/secondary switchover is performed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dds-uf68f1b5a57exxxx</para>
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            /// <summary>
            /// <para>The code that indicates the reason of a primary/secondary switchover. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>USER_CONSOLE_OPERATION: The switchover is manually performed.</description></item>
            /// <item><description>OPERATION_AND_MAINTENANCE: Potential risks exist.</description></item>
            /// <item><description>MACHINE_DOWNTIME: The host is offline.</description></item>
            /// <item><description>PRIMARY_UNHEALTHY: An exception occurs on the primary node of the instance.</description></item>
            /// <item><description>SECONDARY_UNHEALTHY: An exception occurs on the secondary node of the instance.</description></item>
            /// <item><description>MULTIPLE_NODE_FAILURES: An exception occurs on multiple nodes of the instance.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>USER_CONSOLE_OPERATION</para>
            /// </summary>
            [NameInMap("SwitchCode")]
            [Validation(Required=false)]
            public string SwitchCode { get; set; }

            /// <summary>
            /// <para>The switchover status. Valid values: <b>1</b> and <b>0</b>. The value 1 indicates a successful primary/secondary switchover and the value 0 indicates a failed primary/secondary switchover.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SwitchStatus")]
            [Validation(Required=false)]
            public string SwitchStatus { get; set; }

            /// <summary>
            /// <para>The point in time when a primary/secondary switchover was performed. The time follows the ISO 8601 standard in the <em>yyyy-mm-dd</em>T<em>hh:mm:ss</em>Z format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-02-07T18:00:00Z</para>
            /// </summary>
            [NameInMap("SwitchTime")]
            [Validation(Required=false)]
            public string SwitchTime { get; set; }

        }

        /// <summary>
        /// <para>The page number returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ECBCA991-XXXX-XXXX-834C-B3E8007F33AA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of primary/secondary switching entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
