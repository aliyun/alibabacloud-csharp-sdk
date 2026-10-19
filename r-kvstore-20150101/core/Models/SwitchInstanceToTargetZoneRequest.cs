// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class SwitchInstanceToTargetZoneRequest : TeaModel {
        /// <summary>
        /// <para>Instance ID of the instance. You can call the <a href="https://help.aliyun.com/document_detail/473778.html">DescribeInstances</a> operation to query instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>r-bp1zxszhcgatnx****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the child node in a cluster instance.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, all shards are switched to the destination zone.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>r-bp1zxszhcgatnx****-db-0</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// <para>The switch mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ReliabilityPriority</b> (default): Reliability priority. A primary/secondary switchover is performed only when data synchronization between the primary and secondary nodes has no latency. This ensures that no data is lost. However, in scenarios with a large write volume and continuous synchronization latency, the switchover may fail.</description></item>
        /// <item><description><b>AvailablePriority</b>: Availability priority. A primary/secondary switchover is performed immediately regardless of the synchronization latency between the primary and secondary nodes. A small amount of data may be lost.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Select a switch mode based on your business requirements for data and services.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ReliabilityPriority</para>
        /// </summary>
        [NameInMap("SwitchType")]
        [Validation(Required=false)]
        public string SwitchType { get; set; }

        /// <summary>
        /// <para>The ID of the destination zone.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-j</para>
        /// </summary>
        [NameInMap("TargetZoneId")]
        [Validation(Required=false)]
        public string TargetZoneId { get; set; }

    }

}
