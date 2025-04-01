// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DeleteShardingNodeRequest : TeaModel {
        /// <summary>
        /// <para>The time when you want to delete the proxy nodes for instance in the proxy mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0 or Immediately</b> (default): immediately delete the proxy nodes.</description></item>
        /// <item><description><b>1 or MaintainTime</b>: delete the proxy nodes during the maintenance window.</description></item>
        /// </list>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/473775.html">ModifyInstanceMaintainTime</a> operation to modify the maintenance window of an instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Immediately</para>
        /// </summary>
        [NameInMap("EffectiveTime")]
        [Validation(Required=false)]
        public string EffectiveTime { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable forced transmission during a configuration change. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b> (default): Before the configuration change, the system checks the minor version of the instance. If the minor version of the instance is outdated, an error is reported. You must update the minor version of the instance and try again.</description></item>
        /// <item><description><b>true</b>: The system skips the version check and directly performs the configuration change.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ForceTrans")]
        [Validation(Required=false)]
        public bool? ForceTrans { get; set; }

        /// <summary>
        /// <para>The ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>r-bp1zxszhcgatnx****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The ID of the data shard that you want to remove. You can specify multiple IDs at a time. Separate multiple IDs with commas (,).</para>
        /// <remarks>
        /// <para>If you specify both the NodeId and ShardCount parameters, the system prioritizes the NodeId parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>r-bp1zxszhcgatnx****-db-0,r-bp1zxszhcgatnx****-db-1</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        [Obsolete]
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
        /// <para>The number of data shards that you want to remove. Shard removal starts from the end of the shard list.</para>
        /// <remarks>
        /// <para>For example, the instance has the following data shards: db-0, db-1, db-2, db-3, and db-4. In this case, if you set this parameter to 2, db-3 and db-4 are removed.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ShardCount")]
        [Validation(Required=false)]
        public int? ShardCount { get; set; }

    }

}
