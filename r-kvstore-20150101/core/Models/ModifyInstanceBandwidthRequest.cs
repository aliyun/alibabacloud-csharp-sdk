// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class ModifyInstanceBandwidthRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID. You can call <a href="https://help.aliyun.com/document_detail/473778.html">DescribeInstances</a> to query the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>r-bp1zxszhcgatnx****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

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
        /// <para>The total target bandwidth value of the instance.</para>
        /// <remarks>
        /// <para>Notice:  If the instance is a Cluster Edition instance, the total target bandwidth value must be evenly divisible by the number of shards. This operation is not supported for new-architecture read/write splitting instances.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>260</para>
        /// </summary>
        [NameInMap("TargetIntranetBandwidth")]
        [Validation(Required=false)]
        public string TargetIntranetBandwidth { get; set; }

    }

}
