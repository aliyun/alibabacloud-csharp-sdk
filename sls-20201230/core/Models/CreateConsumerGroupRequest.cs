// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class CreateConsumerGroupRequest : TeaModel {
        /// <summary>
        /// <para>The name of the consumer group. The name must be unique in a project.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>consumerGroupX</para>
        /// </summary>
        [NameInMap("consumerGroup")]
        [Validation(Required=false)]
        public string ConsumerGroup { get; set; }

        /// <summary>
        /// <para>Specifies whether to consume data in sequence. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true</para>
        /// <list type="bullet">
        /// <item><description>In a shard, data is consumed in ascending order based on the value of the \<em>\</em><b>tag</b>:<b>receive_time</b>\<em>\</em> field.</description></item>
        /// <item><description>If a shard is split, data in the original shard is consumed first. Then, data in the new shards is consumed at the same time.</description></item>
        /// <item><description>If shards are merged, data in the original shards is consumed first. Then, data in the new shard is consumed.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>false Data in all shards is consumed at the same time. If a new shard is generated after a shard is split or after shards are merged, data in the new shard is immediately consumed.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("order")]
        [Validation(Required=false)]
        public bool? Order { get; set; }

        /// <summary>
        /// <para>The timeout period. If the server does not receive heartbeats from a consumer within the timeout period, the server deletes the consumer. Unit: seconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

    }

}
