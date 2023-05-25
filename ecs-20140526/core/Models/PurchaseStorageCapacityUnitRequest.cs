// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class PurchaseStorageCapacityUnitRequest : TeaModel {
        /// <summary>
        /// The number of SCUs that you want to purchase. Valid values: 1 to 20.
        /// 
        /// Default value: 1.
        /// </summary>
        [NameInMap("Amount")]
        [Validation(Required=false)]
        public int? Amount { get; set; }

        /// <summary>
        /// The SCU capacity. Unit: GiB. Valid values: 20, 40, 100, 200, 500, 1024, 2048, 5210, 10240, 20480, and 52100.
        /// </summary>
        [NameInMap("Capacity")]
        [Validation(Required=false)]
        public int? Capacity { get; set; }

        /// <summary>
        /// The client token that you want to use to ensure the idempotency of the request. You can use the client to generate the token, but make sure that the token is unique across requests. The value of `ClientToken` can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see [How to ensure idempotence](~~25693~~).
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The description of the SCU. The description must be 2 to 256 characters in length and cannot start with `http://` or `https://`.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The request source. The value is automatically set to OpenAPI and does not need to be changed. Default value: OpenAPI.
        /// </summary>
        [NameInMap("FromApp")]
        [Validation(Required=false)]
        public string FromApp { get; set; }

        /// <summary>
        /// The SCU name. The name must be 2 to 128 characters in length. It must start with a letter and cannot start with `http://` or `https://`. It can contain letters, digits, colons (:), underscores (\_), and hyphens (-).
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The SCU validity period. Valid values:
        /// 
        /// *   Valid values when PeriodUnit is set to Month: 1, 2, 3, and 6.
        /// *   Valid values when PeriodUnit is set to Year: 1, 3, and 5.
        /// 
        /// Default value: 1.
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// The unit of the the SCU validity period. Valid values:
        /// 
        /// *   Month
        /// *   Year
        /// 
        /// Default value: Month.
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// The ID of the region in which to purchase the SCU. After this parameter is specified, the purchased SCU can be used to offset the bills of only pay-as-you-go disks that reside in the specified region. You can call the [DescribeRegions](~~25609~~) operation to query the most recent region list.
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

        /// <summary>
        /// The time when the SCU takes effect. This can be up to six months later than the time when the SCU is created. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.
        /// 
        /// This parameter is empty by default. If this parameter is left empty, the SCU takes effect immediately after it is created.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// The tags to add to the SCUs.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<PurchaseStorageCapacityUnitRequestTag> Tag { get; set; }
        public class PurchaseStorageCapacityUnitRequestTag : TeaModel {
            /// <summary>
            /// The key of tag N to add to the SCU. N indicates the number of tag keys that can be specified. Valid values of N: 1 to 20. The tag value cannot be an empty string. The tag key can be up to 128 characters in length and cannot contain `http://` or `https://`. The tag key cannot start with `aliyun` or `acs:`.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of tag N to add to the SCU. N indicates the number of tag values that can be specified and corresponds to the N in `Tag.N.Key`. Valid values: 1 to 20. The tag value can be an empty string. The tag value can be up to 128 characters in length and cannot contain `http://` or `https://`. The tag value cannot start with `acs:`.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
