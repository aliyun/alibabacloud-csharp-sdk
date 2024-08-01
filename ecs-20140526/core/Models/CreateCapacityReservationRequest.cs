// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreateCapacityReservationRequest : TeaModel {
        [NameInMap("PrivatePoolOptions")]
        [Validation(Required=false)]
        public CreateCapacityReservationRequestPrivatePoolOptions PrivatePoolOptions { get; set; }
        public class CreateCapacityReservationRequestPrivatePoolOptions : TeaModel {
            /// <summary>
            /// The type of the private pool to generate after the capacity reservation takes effect. Valid values:
            /// 
            /// *   Open: open private pool
            /// *   Target: targeted private pool
            /// 
            /// Default value: Open.
            /// </summary>
            [NameInMap("MatchCriteria")]
            [Validation(Required=false)]
            public string MatchCriteria { get; set; }

            /// <summary>
            /// The capacity reservation name. The name must be 2 to 128 characters in length. It must start with a letter but cannot start with `http://` or `https://`. The name can contain letters, digits, colons (:), underscores (_), and hyphens (-).
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// The client token that is used to ensure the idempotency of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The `token` can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see [How to ensure idempotence](https://help.aliyun.com/document_detail/25693.html).
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The description of the capacity reservation. The description must be 2 to 256 characters in length and cannot start with `http://` or `https://`.
        /// 
        /// This parameter is empty by default.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The time when the capacity reservation expires. Specify the time in the ISO 8601 standard in the `yyyy-MM-ddTHH:mm:ssZ` format. The time must be in UTC. For more information, see [ISO 8601](https://help.aliyun.com/document_detail/25696.html).
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The release mode of the capacity reservation. Valid values:
        /// 
        /// *   Limited: The capacity reservation is automatically released at a specified time. If you specify this parameter, you must specify the `EndTime` parameter.
        /// *   Unlimited: The capacity reservation is manually released. The capacity reservation can be released anytime.
        /// </summary>
        [NameInMap("EndTimeType")]
        [Validation(Required=false)]
        public string EndTimeType { get; set; }

        /// <summary>
        /// The total number of instances for which the capacity of an instance type is reserved.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceAmount")]
        [Validation(Required=false)]
        public int? InstanceAmount { get; set; }

        /// <summary>
        /// The instance type. You can create a capacity reservation to reserve the capacity of only one instance type. You can call the [DescribeInstanceTypes](https://help.aliyun.com/document_detail/25620.html) operation to query the instance types provided by ECS.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The operating system of the image used by the instance. This parameter corresponds to the `Platform` parameter of regional reserved instances. If the operating system of a capacity reservation matches the operating system of a regional reserved instance, you can apply the regional reserved instance to offset fees of the unused capacity of the capacity reservation. Valid values:
        /// 
        /// *   Windows: Windows Server operating system
        /// *   Linux: Linux and UNIX-like operating system
        /// 
        /// Default value: Linux.
        /// 
        /// > This parameter is unavailable.
        /// </summary>
        [NameInMap("Platform")]
        [Validation(Required=false)]
        public string Platform { get; set; }

        /// <summary>
        /// The ID of the region in which to create the capacity reservation. You can call the [DescribeRegions](https://help.aliyun.com/document_detail/25609.html) operation to query the most recent region list.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group to which you want to assign the capacity reservation.
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
        /// The mode in which the capacity reservation takes effect. You can call the CreateCapacityReservation operation to create only immediate capacity reservations.
        /// 
        /// > If you do not specify this parameter, the capacity reservation immediately takes effect.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// The tags to add to the capacity reservation.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateCapacityReservationRequestTag> Tag { get; set; }
        public class CreateCapacityReservationRequestTag : TeaModel {
            /// <summary>
            /// The key of tag N to add to the capacity reservation. Valid values of N: 1 to 20. The tag key cannot be an empty string. The tag key can be up to 128 characters in length and cannot contain `http://` or `https://`. The tag key cannot start with `acs:` or `aliyun`.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of tag N to add to the capacity reservation. Valid values of N: 1 to 20. The tag value can be an empty string. The tag value can be up to 128 characters in length and cannot contain `http://` or `https://`. The tag value cannot start with `acs:`.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The ID of the zone in which you want to create the capacity reservation. A capacity reservation can reserve resources within only one zone.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public List<string> ZoneId { get; set; }

    }

}
