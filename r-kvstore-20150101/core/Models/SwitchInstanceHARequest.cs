// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class SwitchInstanceHARequest : TeaModel {
        /// <summary>
        /// <para>The ID of the instance. You can call the <a href="https://help.aliyun.com/document_detail/60933.html">DescribeInstances</a> operation to query the ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>r-bp1zxszhcgatnx****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the data shard. You can call the <a href="https://help.aliyun.com/document_detail/190794.html">DescribeRoleZoneInfo</a> operation to obtain the value of the CustinsId parameter. Separate multiple data shard IDs with commas (,). <c>all</c> indicates that all data shards are specified.</para>
        /// <remarks>
        /// <para>This parameter is available and required only for read/write splitting and cluster instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>56<b><b>19,56</b></b>20</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>The time when to perform the switchover. Default value: 0. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: immediately performs the switchover.</description></item>
        /// <item><description><b>1</b>: performs the switchover during the maintenance window.</description></item>
        /// </list>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/61000.html">ModifyInstanceMaintainTime</a> operation to modify the maintenance window of an ApsaraDB for Redis instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SwitchMode")]
        [Validation(Required=false)]
        public int? SwitchMode { get; set; }

        /// <summary>
        /// <para>The switching mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>AvailablePriority</b>: prioritizes the availability and performs a switchover immediately without considering the latency of data synchronization between the master and replica nodes. This may cause data loss.</description></item>
        /// <item><description><b>ReliabilityPriority</b>: prioritizes the reliability and performs a switchover after no latency of data synchronization between the master and replica nodes exists. This ensures data integrity. This mode may cause a switchover failure in scenarios that involve a large volume of data writes and persistent latency of data synchronization.</description></item>
        /// </list>
        /// <remarks>
        /// <para>You must evaluate the requirements for data and services based on your business scenarios and then select a switching mode.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>AvailablePriority</para>
        /// </summary>
        [NameInMap("SwitchType")]
        [Validation(Required=false)]
        public string SwitchType { get; set; }

    }

}
