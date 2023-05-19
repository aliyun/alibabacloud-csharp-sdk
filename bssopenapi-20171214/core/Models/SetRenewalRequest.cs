// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class SetRenewalRequest : TeaModel {
        /// <summary>
        /// The ID of the instance. You can enable auto-renewal for up to 100 subscription instances at a time. Separate multiple instance IDs with commas (,).
        /// </summary>
        [NameInMap("InstanceIDs")]
        [Validation(Required=false)]
        public string InstanceIDs { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The code of the service.
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// The type of the service.
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// The auto-renewal period. Valid values:
        /// 
        /// *   1
        /// *   2
        /// *   3
        /// *   6
        /// *   12
        /// 
        /// >  This parameter is required if the RenewalStatus parameter is set to AutoRenewal.
        /// </summary>
        [NameInMap("RenewalPeriod")]
        [Validation(Required=false)]
        public int? RenewalPeriod { get; set; }

        /// <summary>
        /// The unit of the auto-renewal period. Valid values:
        /// 
        /// *   M: months
        /// *   Y: years
        /// 
        /// >  This parameter is required if the RenewalStatus parameter is set to AutoRenewal.
        /// </summary>
        [NameInMap("RenewalPeriodUnit")]
        [Validation(Required=false)]
        public string RenewalPeriodUnit { get; set; }

        /// <summary>
        /// The status of renewal. Valid values:
        /// 
        /// *   AutoRenewal: The instance is automatically renewed.
        /// *   ManualRenewal: The instance is manually renewed.
        /// *   NotRenewal: The instance is not renewed.
        /// </summary>
        [NameInMap("RenewalStatus")]
        [Validation(Required=false)]
        public string RenewalStatus { get; set; }

        /// <summary>
        /// The billing method. Valid values:
        /// 
        /// *   Subscription: subscription
        /// *   PayAsYouGo: pay-as-you-go
        /// </summary>
        [NameInMap("SubscriptionType")]
        [Validation(Required=false)]
        public string SubscriptionType { get; set; }

    }

}
