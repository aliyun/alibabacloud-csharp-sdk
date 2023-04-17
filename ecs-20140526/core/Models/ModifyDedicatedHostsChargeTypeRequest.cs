// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyDedicatedHostsChargeTypeRequest : TeaModel {
        /// <summary>
        /// Specifies whether to enable automatic payment. Valid values:
        /// 
        /// *   true: enables automatic payment. Make sure that your account balance is sufficient. Otherwise, your order becomes invalid and must be canceled.
        /// *   false: An order is generated but no payment is made.
        /// 
        /// Default value: true.
        /// 
        /// >  If your account balance is insufficient, you can set the `AutoPay` parameter to `false` to generate an unpaid order. Then, you can pay for the order.
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must make sure that the value is unique among different requests. The `ClientToken` value can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see [How to ensure idempotence](~~25693~~).
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The new billing method for the dedicated host. Valid values:
        /// 
        /// *   PrePaid: changes the billing method from pay-as-you-go to subscription.
        /// *   PostPaid: changes the billing method from subscription to pay-as-you-go.
        /// 
        /// Default value: PrePaid.
        /// </summary>
        [NameInMap("DedicatedHostChargeType")]
        [Validation(Required=false)]
        public string DedicatedHostChargeType { get; set; }

        /// <summary>
        /// The IDs of dedicated hosts. The value can be a JSON array that consists of up to 20 dedicated host IDs. Separate the dedicated host IDs with commas (,).
        /// </summary>
        [NameInMap("DedicatedHostIds")]
        [Validation(Required=false)]
        public string DedicatedHostIds { get; set; }

        /// <summary>
        /// Specifies whether to return the billing details of the order when the billing method is changed from subscription to pay-as-you-go.
        /// 
        /// Default value: false.
        /// </summary>
        [NameInMap("DetailFee")]
        [Validation(Required=false)]
        public bool? DetailFee { get; set; }

        /// <summary>
        /// Specifies whether to check the validity of the request without actually making the request. Valid values:
        /// 
        /// *   true: The validity of the request is checked but the request is not made. Check items include whether your AccessKey pair is valid, whether RAM users are granted required permissions, and whether the required parameters are specified. If the check fails, the corresponding error is returned. If the check succeeds, the `DryRunOperation` error code is returned.
        /// *   false: The validity of the request is checked. If the check succeeds, a 2XX HTTP status code is returned, and the request is made.
        /// 
        /// Default value: false.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The renewal duration of the subscription dedicated host. Valid values:
        /// 
        /// *   When `PeriodUnit` is set to Week, valid values of `Period` are 1, 2, 3, and 4.
        /// *   When `PeriodUnit` is set to Month, valid values of `Period` are 1, 2, 3, 4, 5, 6, 7, 8, 9, 12, 24, 36, 48, and 60.
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// The unit of the renewal duration (`Period`). Valid values:
        /// 
        /// *   Week
        /// *   Month
        /// 
        /// Default value: Month.
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// The region ID of the dedicated host. You can call the [DescribeRegions](~~25609~~) operation to query the most recent region list.
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
