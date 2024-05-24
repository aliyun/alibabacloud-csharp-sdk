// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class SetLoadBalancerStatusRequest : TeaModel {
        /// <summary>
        /// The ID of the CLB instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        /// <summary>
        /// The state of the CLB instance. Valid values: **active** and **inactive**.
        /// 
        /// *   **active** (default)
        /// 
        ///     If a CLB instance is in the **active** state, listeners of the CLB instance can forward traffic based on forwarding rules.
        /// 
        ///     By default, newly created CLB instances are in the **active** state.
        /// 
        /// *   **inactive**
        /// 
        ///     If a CLB instance is in the **inactive** state, listeners of the CLB instance do not forward traffic.
        /// 
        /// >  If all listeners of a CLB instance are deleted, the CLB instance automatically switches to the **inactive** state.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("LoadBalancerStatus")]
        [Validation(Required=false)]
        public string LoadBalancerStatus { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The ID of the region where the CLB instance is deployed.
        /// 
        /// You can query region IDs from the [Regions and zones](https://help.aliyun.com/document_detail/40654.html) list or by calling the [DescribeRegions](https://help.aliyun.com/document_detail/25609.html) operation.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
