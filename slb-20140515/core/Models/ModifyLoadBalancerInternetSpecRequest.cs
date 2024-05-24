// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class ModifyLoadBalancerInternetSpecRequest : TeaModel {
        /// <summary>
        /// Specifies whether to automatically pay the subscription fee of the Internet-facing CLB instance. Valid values:
        /// 
        /// *   **true**: enables automatic payments. This is the default value.
        /// *   **false**: disables automatic payment. You must complete the payment in Order Center.
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// The maximum bandwidth of the Internet-facing CLB instance that uses the pay-by-bandwidth metering method. Unit: Mbit/s.
        /// 
        /// Valid values: **1 to 5000**. The maximum bandwidth varies based on the region where the CLB instance is created.****
        /// 
        /// >  You do not need to specify this parameter if you set **InternetChargeType** to **paybytraffic** (pay-by-data-transfer).
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        /// <summary>
        /// The metering method of the Internet-facing CLB instance. Valid values:
        /// 
        /// *   **paybybandwidth**: pay-by-bandwidth
        /// *   **paybytraffic**: pay-by-data-transfer
        /// </summary>
        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

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
        /// The ID of the region where the CLB instance is deployed.
        /// 
        /// You can call the [DescribeRegions](https://help.aliyun.com/document_detail/27584.html) operation to query the most recent region list.
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
