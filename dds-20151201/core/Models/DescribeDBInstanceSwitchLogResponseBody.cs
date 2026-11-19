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
        /// <para>The list of primary/secondary switchover logs.</para>
        /// </summary>
        [NameInMap("LogItems")]
        [Validation(Required=false)]
        public List<DescribeDBInstanceSwitchLogResponseBodyLogItems> LogItems { get; set; }
        public class DescribeDBInstanceSwitchLogResponseBodyLogItems : TeaModel {
            /// <summary>
            /// <para>Instance ID of the instance if the instance is a replica set instance, or instance ID of the switched node if the instance is a sharded cluster instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>If the instance is a replica set instance: dds-uf68f1b5a57exxxx.
            /// If the instance is a sharded cluster instance: d-uf652b73f554xxxx</para>
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            /// <summary>
            /// <para>The cause code of the switchover. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>USER_CONSOLE_OPERATION: manual operation</description></item>
            /// <item><description>OPERATION_AND_MAINTENANCE: potential risk</description></item>
            /// <item><description>MACHINE_DOWNTIME: host offline</description></item>
            /// <item><description>PRIMARY_UNHEALTHY: instance failures</description></item>
            /// <item><description>SECONDARY_UNHEALTHY: instance failures</description></item>
            /// <item><description>MULTIPLE_NODE_FAILURES: instance failures</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>USER_CONSOLE_OPERATION</para>
            /// </summary>
            [NameInMap("SwitchCode")]
            [Validation(Required=false)]
            public string SwitchCode { get; set; }

            /// <summary>
            /// <para>The switchover status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: The switchover is successful.</description></item>
            /// <item><description><b>0</b>: The switchover failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SwitchStatus")]
            [Validation(Required=false)]
            public string SwitchStatus { get; set; }

            /// <summary>
            /// <para>The switchover time. The time is in the <i>yyyy-mm-dd</i>T<i>hh:mm:ss</i>Z format (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-02-07T18:00:00Z</para>
            /// </summary>
            [NameInMap("SwitchTime")]
            [Validation(Required=false)]
            public string SwitchTime { get; set; }

        }

        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ECBCA991-XXXX-XXXX-834C-B3E8007F33AA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of primary/secondary switchover records returned in the query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
