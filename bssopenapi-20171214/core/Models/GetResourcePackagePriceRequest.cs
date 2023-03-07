// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class GetResourcePackagePriceRequest : TeaModel {
        /// <summary>
        /// The validity period of the resource plan. The value must be the same as the duration of the resource plan specified in the specifications.
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public int? Duration { get; set; }

        /// <summary>
        /// The time when the resource plan takes effect. If you do not specify this parameter, the resource plan immediately takes effect by default. Specify the time in the ISO 8601 standard in the yyyy-MM-ddThh:mm:ssZ format. The time must be in UTC.
        /// </summary>
        [NameInMap("EffectiveDate")]
        [Validation(Required=false)]
        public string EffectiveDate { get; set; }

        /// <summary>
        /// The ID of the instance.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The type of the order. Valid values:
        /// 
        /// *   BUY: You place the order to purchase an instance.
        /// *   UPGRADE: You place the order to upgrade an instance.
        /// *   RENEW: You place the order to renew an instance.
        /// 
        /// Default value: BUY.
        /// </summary>
        [NameInMap("OrderType")]
        [Validation(Required=false)]
        public string OrderType { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The type of the resource plan. The value must be the same as the value of the **ProductCode** parameter that is returned when you call the **DescribeResourcePackageProduct** operation.
        /// </summary>
        [NameInMap("PackageType")]
        [Validation(Required=false)]
        public string PackageType { get; set; }

        /// <summary>
        /// The unit of validity period of the resource plan. Valid values:
        /// 
        /// *   Month
        /// *   Year
        /// </summary>
        [NameInMap("PricingCycle")]
        [Validation(Required=false)]
        public string PricingCycle { get; set; }

        /// <summary>
        /// The code of service. You can query the service code by calling the **QueryProductList** operation or viewing **Codes of Alibaba Cloud Services**.
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// The specifications of the resource plan.
        /// </summary>
        [NameInMap("Specification")]
        [Validation(Required=false)]
        public string Specification { get; set; }

    }

}
