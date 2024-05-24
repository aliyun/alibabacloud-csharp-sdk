// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class ModifyLoadBalancerPayTypeRequest : TeaModel {
        /// <summary>
        /// Specifies whether to enable automatic payment. Valid values:
        /// 
        /// *   **true**: yes
        /// *   **false** (default): no
        /// 
        /// >  This parameter is valid only when the `PayType` parameter is set to **PrePay**. This parameter is valid only for pay-as-you-go instances.
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// The subscription duration.
        /// 
        /// *   If **PricingCycle** is set to **month**, the valid values are **1** to **9**.
        /// *   If **PricingCycle** is set to **year**, the valid values are **1** to **3**.
        /// 
        /// >  This parameter is valid only when the **PayType** parameter is set to **PrePay**. This parameter is valid only for pay-as-you-go instances.
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public int? Duration { get; set; }

        /// <summary>
        /// The ID of the CLB instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The billing method of the CLB instance. Valid values:
        /// 
        /// *   **PayOnDemand** (default): pay-as-you-go
        /// 
        /// To change the billing method of a pay-as-you-go CLB instance to subscription, you must set the parameter to **PrePay**. In addition, the previous billing method of the CLB instance must be **PayOnDemand**.
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// The billing cycle.
        /// 
        /// Valid values: **year** and **month**.
        /// 
        /// >  This parameter is valid only when the **PayType** parameter is set to **PrePay**. This parameter is valid only for pay-as-you-go instances.
        /// </summary>
        [NameInMap("PricingCycle")]
        [Validation(Required=false)]
        public string PricingCycle { get; set; }

        /// <summary>
        /// The ID of the region where the CLB instance is deployed.
        /// 
        /// You can query the region ID from the [Regions and zones](https://help.aliyun.com/document_detail/40654.html) list or by calling the [DescribeRegions](https://help.aliyun.com/document_detail/25609.html) operation.
        /// 
        /// This parameter is required.
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
