// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class PurchaseReservedInstancesOfferingRequest : TeaModel {
        /// <summary>
        /// Specifies whether to enable auto-renewal for the reserved instance. Valid values:
        /// 
        /// true: enables auto-renewal for the reserved instance. false: disables auto-renewal for the reserved instance. This is the default value.
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// The auto-renewal term of the reserved instance. Unit: months. This parameter takes effect only if you set the AutoRenew parameter to true.
        /// 
        /// Valid values: 1, 12, 36, and 60.
        /// 
        /// Default value if you set the PeriodUnit parameter to Month: 1.
        /// 
        /// Default value if you set the PeriodUnit parameter to Year: 12.
        /// </summary>
        [NameInMap("AutoRenewPeriod")]
        [Validation(Required=false)]
        public int? AutoRenewPeriod { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. **The token can contain only ASCII characters and cannot exceed 64 characters in length.** For more information, see [How to ensure idempotence](~~25693~~).
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The description of the reserved instance. The description must be 2 to 256 characters in length and cannot start with [http:// or https://](http://https://。).
        /// 
        /// By default, this parameter is left empty.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The number of pay-as-you-go instances of the same instance type to which the reserved instance can be matched at the same time. Valid values: 1 to 50.
        /// 
        /// For example, if you set the InstanceAmount parameter to 3 and the InstanceType parameter to ecs.g5.large, the reserved instance can be matched to three ecs.g5.large pay-as-you-go instances at the same time.
        /// </summary>
        [NameInMap("InstanceAmount")]
        [Validation(Required=false)]
        public int? InstanceAmount { get; set; }

        /// <summary>
        /// The type of the reserved instance. For more information, see [Instance families](~~25378~~).
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// The payment option of the reserved instance. Valid values:
        /// 
        /// *   No Upfront
        /// *   Partial Upfront
        /// *   All Upfront
        /// 
        /// Default value: All Upfront.
        /// </summary>
        [NameInMap("OfferingType")]
        [Validation(Required=false)]
        public string OfferingType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The term of the reserved instance.
        /// 
        /// Valid values: 1 and 3.
        /// 
        /// Default value: 1.
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// The unit of the term of the reserved instance.
        /// 
        /// Valid value: Year.
        /// 
        /// Default value: Year.
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// The operating system of the image that is used by the instance. Valid values:
        /// 
        /// *   Windows: Windows Server operating system
        /// *   Linux: Linux and UNIX-like operating system
        /// 
        /// Default value: Linux.
        /// </summary>
        [NameInMap("Platform")]
        [Validation(Required=false)]
        public string Platform { get; set; }

        /// <summary>
        /// The region ID of the reserved instance. You can call the [DescribeRegions](~~25609~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The name of the reserved instance. The name must be 2 to 128 characters in length. The name must start with a letter and cannot start with http:// or https://. It can contain letters, digits, colons (:), underscores (\_), and hyphens (-).
        /// </summary>
        [NameInMap("ReservedInstanceName")]
        [Validation(Required=false)]
        public string ReservedInstanceName { get; set; }

        /// <summary>
        /// The ID of the resource group to which the reserved instance belongs.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The scope of the reserved instance. Valid values:
        /// 
        /// *   Region: regional
        /// *   Zone: zonal
        /// 
        /// Default value: Region.
        /// </summary>
        [NameInMap("Scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

        /// <summary>
        /// The tags of the reserved instance.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<PurchaseReservedInstancesOfferingRequestTag> Tag { get; set; }
        public class PurchaseReservedInstancesOfferingRequestTag : TeaModel {
            /// <summary>
            /// The key of tag N of the reserved instance. Valid values of N: 1 to 20. The tag value cannot be an empty string. The tag key can be up to 128 characters in length and cannot contain `http://` or `https://`. It cannot start with `acs:` or `aliyun`.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of tag N of the reserved instance. Valid values of N: 1 to 20. The tag value cannot be an empty string. The tag value can be up to 128 characters in length and cannot contain `http://` or `https://`. It cannot start with `acs:` or `aliyun`.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The zone ID of the instance. If you set the `Scope` parameter to `Zone`, you must specify this parameter. You can call the [DescribeZones](~~25610~~) operation to query the most recent list of zones.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
