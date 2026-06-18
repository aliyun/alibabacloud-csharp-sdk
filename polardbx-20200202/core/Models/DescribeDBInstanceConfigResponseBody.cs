// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeDBInstanceConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The data struct.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeDBInstanceConfigResponseBodyData Data { get; set; }
        public class DescribeDBInstanceConfigResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The configuration key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>htap</para>
            /// </summary>
            [NameInMap("ConfigName")]
            [Validation(Required=false)]
            public string ConfigName { get; set; }

            /// <summary>
            /// <para>The configuration item. The following parameters are included:</para>
            /// <list type="bullet">
            /// <item><description>attendHtapList: the list of instances for which HTAP is enabled.</description></item>
            /// <item><description>autoAttendHtap: specifies whether to automatically add newly created read-only instances to the HTAP list.</description></item>
            /// <item><description>delayExecutionStrategy: when the read-only instance lag reaches the value specified by storageDelayThreshold, read-only traffic is routed back to the primary instance. Default value: 1. Valid values: 0 and 1.</description></item>
            /// <item><description>enableConsistentReplicaRead: specifies whether to enable consistent reads.</description></item>
            /// <item><description>storageDelayThreshold: the latency threshold for read-only instances. Default value: 3s. Valid values: 0 to 86400.</description></item>
            /// <item><description>enableHtap: specifies whether to enable HTAP.</description></item>
            /// <item><description>masterReadWeight: the read weight of the primary node. A value of 100 indicates that 100% of traffic is routed to the primary node. Valid values: 0 to 100.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;attendHtapList\&quot;:[\&quot;pxc-hzruyzes08****\&quot;],\&quot;autoAttendHtap\&quot;:\&quot;true\&quot;,\&quot;delayExecutionStrategy\&quot;:1,\&quot;enableConsistentReplicaRead\&quot;:true,\&quot;enableHtap\&quot;:\&quot;true\&quot;,\&quot;masterReadWeight\&quot;:100,\&quot;storageDelayThreshold\&quot;:3}</para>
            /// </summary>
            [NameInMap("ConfigValue")]
            [Validation(Required=false)]
            public string ConfigValue { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pxc-sprcym7g7w****</para>
            /// </summary>
            [NameInMap("DbInstanceName")]
            [Validation(Required=false)]
            public string DbInstanceName { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C458B1E8-1683-3645-B154-6BA32080EEA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
