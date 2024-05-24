// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class ModifyLoadBalancerInstanceSpecRequest : TeaModel {
        /// <summary>
        /// Specifies whether to enable automatic payment. Valid values:
        /// 
        /// *   **true**: automatically completes the payment.
        /// *   **false** (default): If you select this option, you must complete the payment in the Order Center.
        /// 
        /// > This parameter takes effect only for subscription instances.
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// The ID of the CLB instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        /// <summary>
        /// The specification of the CLB instance. Valid values:
        /// 
        /// *   **slb.s1.small**
        /// *   **slb.s2.small**
        /// *   **slb.s2.medium**
        /// *   **slb.s3.small**
        /// *   **slb.s3.medium**
        /// *   **slb.s3.large**
        /// 
        /// The specifications available vary by region. For more information about the specifications, see [High-performance CLB instance](https://help.aliyun.com/document_detail/85931.html).
        /// 
        /// > When you switch a shared-resource CLB instance to a high-performance CLB instance, your service may be interrupted for 10 to 30 seconds. We recommend that you modify the specification during off-peak hours or use Alibaba Cloud DNS to schedule your workloads to another CLB instance before you modify the specification.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("LoadBalancerSpec")]
        [Validation(Required=false)]
        public string LoadBalancerSpec { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The region ID of the CLB instance.
        /// 
        /// You can query the region ID from the [Regions and zones](https://help.aliyun.com/document_detail/40654.html) list or by calling the [DescribeRegions](https://help.aliyun.com/document_detail/27584.html) operation.
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
