// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyDedicatedHostsChargeTypeRequest : TeaModel {
        /// <summary>
        /// Specifies whether to automatically complete the payment. Valid values:
        /// 
        /// *   true: The payment is automatically completed. Make sure that your account balance is sufficient. Otherwise, your order becomes invalid and will be canceled.
        /// *   false: An order is generated but no payment is made.
        /// 
        /// Default value: true.
        /// 
        /// > If you do not have sufficient balance in your account, you can set `AutoPay` to `false` to generate an unpaid order. Then, you can pay for the order.
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The `token` can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see [How to ensure idempotence](https://help.aliyun.com/document_detail/25693.html).
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The new billing method of the dedicated hosts. Valid values:
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
        /// The IDs of the dedicated hosts. The value can be a JSON array that consists of up to 20 dedicated host IDs. Separate the IDs with commas (,).
        /// 
        /// This parameter is required.
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
        /// Specifies whether to perform only a dry run, without performing the actual request. Valid values:
        /// 
        /// *   true: performs only a dry run. The system checks your AccessKey pair, the permissions of the RAM user, and the required parameters. If the request fails the dry run, an error message is returned. If the request passes the dry run, the `DryRunOperation` error code is returned.
        /// *   false: performs a dry run and performs the actual request. If the request passes the dry run, a 2xx HTTP status code is returned and the operation is performed.
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
        /// The renewal duration of the subscription dedicated hosts. Valid values:
        /// 
        /// *   If you set `PeriodUnit` to Week, valid values of `Period` are 1, 2, 3, and 4.
        /// *   If you set `PeriodUnit` to Month, valid values of `Period` are 1, 2, 3, 4, 5, 6, 7, 8, 9, 12, 24, 36, 48, and 60.
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// The unit of the renewal duration specified by `Period`. Valid values:
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
        /// The region ID of the dedicated hosts. You can call the [DescribeRegions](https://help.aliyun.com/document_detail/25609.html) operation to query the most recent region list.
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
