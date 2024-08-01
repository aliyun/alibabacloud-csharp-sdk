// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyInstanceChargeTypeRequest : TeaModel {
        /// <summary>
        /// Specifies whether to automatically complete the payment. Valid values:
        /// 
        /// *   true: The payment is automatically completed. Make sure that your account balance is sufficient. Otherwise, your order becomes invalid and is canceled.
        /// *   false: An order is generated but no payment is made.
        /// 
        /// Default value: true.
        /// 
        /// > If your account balance is insufficient, you can set AutoPay to false to generate an unpaid order. Then, you can log on to the ECS console to pay for the order.
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The **token** can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see [How to ensure idempotence](https://help.aliyun.com/document_detail/25693.html).
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Specifies whether to perform only a dry run. Valid Values:
        /// 
        /// *   true: performs only a dry run. The system checks whether your AccessKey pair is valid, whether Resource Access Management (RAM) users are granted permissions, and whether the required parameters are specified. If the request fails the dry run, an error message is returned. If the request passes the dry run, the `DryRunOperation` error code is returned.
        /// *   false: performs a dry run and performs the actual request. If the request passes the dry run, a 2xx HTTP status code is returned and the operation is performed.
        /// 
        /// Default value: false.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// Specifies whether to change the billing method of all data disks attached to the instance from pay-as-you-go to subscription.
        /// 
        /// Default value: false.
        /// </summary>
        [NameInMap("IncludeDataDisks")]
        [Validation(Required=false)]
        public bool? IncludeDataDisks { get; set; }

        /// <summary>
        /// The new billing method. Valid values:
        /// 
        /// *   PrePaid
        /// *   PostPaid
        /// 
        /// Default value: PrePaid.
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        /// <summary>
        /// The instance IDs. The value can be a JSON array that consists of up to 20 instance IDs. Separate the instance IDs with commas (,).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public string InstanceIds { get; set; }

        /// <summary>
        /// Specifies whether to return cost details of the order after the billing method is changed from subscription to pay-as-you-go.
        /// 
        /// Default value: false.
        /// </summary>
        [NameInMap("IsDetailFee")]
        [Validation(Required=false)]
        public bool? IsDetailFee { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The renewal duration of the subscription instance. If the instance is hosted on a dedicated host, the renewal duration of the instance cannot exceed the subscription duration of the dedicated host. Valid values:
        /// 
        /// Valid values when `PeriodUnit` is set to Month: `1, 2, 3, 4, 5, 6, 7, 8, 9, and 12`.
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// The unit of the renewal duration specified by `Period`. Valid values:
        /// 
        /// Month
        /// 
        /// Default value: Month.
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// The region ID of the instance. You can call the [DescribeRegions](https://help.aliyun.com/document_detail/25609.html) operation to query the most recent region list.
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
