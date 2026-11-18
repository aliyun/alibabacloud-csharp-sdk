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
        /// <para>The ID of the child node of a Cluster Edition instance.</para>
        /// <remarks>
        /// <para>If this parameter is not specified, all shards are switched to the target zone.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>r-bp1zxszhcgatnx****-db-0</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// <para>The switchover mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ReliabilityPriority</b> (default): Reliability priority. A primary/secondary switchover is performed only when there is no replication lag between the primary and secondary nodes to ensure zero data loss. In scenarios with heavy write traffic and continuous replication lag, the switchover may fail.</description></item>
        /// <item><description><b>AvailablePriority</b>: Availability priority. A primary/secondary switchover is performed immediately regardless of the replication lag between the primary and secondary nodes. A small amount of data may be lost.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Select a switchover mode based on your business requirements for data and services.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ReliabilityPriority</para>
        /// </summary>
        [NameInMap("SwitchType")]
        [Validation(Required=false)]
        public string SwitchType { get; set; }

        /// <summary>
        /// <para>The ID of the target zone.</para>
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
