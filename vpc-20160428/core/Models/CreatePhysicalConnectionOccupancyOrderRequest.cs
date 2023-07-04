// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreatePhysicalConnectionOccupancyOrderRequest : TeaModel {
        /// <summary>
        /// Specifies whether to enable automatic payments. Valid values:
        /// 
        /// *   **true**: yes Make sure that you have a sufficient balance in your account. Otherwise, your order becomes invalid and is automatically canceled.
        /// *   **false**: disables automatic payment. This is the default value.
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the value, but you must ensure that it is unique among different requests.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The billing method of the Express Connect circuit. Set the value to
        /// 
        /// **PrePaid**, which specifies the subscription billing method. If you choose this billing method, make sure that your Alibaba Cloud account supports balance payments or credit payments.
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The subscription duration.
        /// 
        /// *   If **PricingCycle** is set to **Month**, set **Period** to a value from **1 to 9**.
        /// *   If **PricingCycle** is set to **Year**, set **Period** to a value from **1 to 5**.
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// The ID of the Express Connect circuit.
        /// </summary>
        [NameInMap("PhysicalConnectionId")]
        [Validation(Required=false)]
        public string PhysicalConnectionId { get; set; }

        /// <summary>
        /// The billing cycle of the subscription. Valid values:
        /// 
        /// *   **Month**: Bills are paid on a monthly basis. This is the default value.
        /// *   **Year**: Bills are paid on an annual basis.
        /// </summary>
        [NameInMap("PricingCycle")]
        [Validation(Required=false)]
        public string PricingCycle { get; set; }

        /// <summary>
        /// The region ID of the Express Connect circuit.
        /// 
        /// You can call the [DescribeRegions](~~36063~~) operation to query the most recent region list.
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
