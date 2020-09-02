// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreatePhysicalConnectionOccupancyOrderRequest : TeaModel {
        /// <summary>
        /// description: The ID of the region where the leased line is deployed.; 
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=true)]
        public string RegionId { get; set; }

        /// <summary>
        /// description: The instance ID of the physical connection interface.; 
        /// </summary>
        [NameInMap("PhysicalConnectionId")]
        [Validation(Required=true)]
        public string PhysicalConnectionId { get; set; }

        /// <summary>
        /// description: Optional. The validity period of a Subscription.; 
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// description: Optional. The billing method of the instance. Valid values:* PrePaid: Subscription. If you select this value, you must make sure that your account has enough available funds.* PostPaid (default value): Pay-As-You-Go; 
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        /// <summary>
        /// description: Optional. Indicates whether to pay automatically. Valid values:* true (default value): Pay automatically. If you select this value, you must ensure that your account has enough available funds. Otherwise, the order that is generated is invalid.* false: Generates the order only. No fee is deducted from your account.; 
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// description: Optional. The Subscription cycle. Valid values:* Month* Year; 
        /// </summary>
        [NameInMap("PricingCycle")]
        [Validation(Required=false)]
        public string PricingCycle { get; set; }

        /// <summary>
        /// description: Optional. The token used for client authentication.; 
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
