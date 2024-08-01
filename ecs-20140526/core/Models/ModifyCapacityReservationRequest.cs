// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyCapacityReservationRequest : TeaModel {
        [NameInMap("PrivatePoolOptions")]
        [Validation(Required=false)]
        public ModifyCapacityReservationRequestPrivatePoolOptions PrivatePoolOptions { get; set; }
        public class ModifyCapacityReservationRequestPrivatePoolOptions : TeaModel {
            /// <summary>
            /// The capacity reservation ID.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// The name of the capacity reservation. The name must be 2 to 128 characters in length. It must start with a letter and cannot start with `http://` or `https://`. It can contain letters, digits, colons (:), underscores (_), and hyphens (-).
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// The description of the capacity reservation. The description must be 2 to 256 characters in length. It cannot start with `http://` or `https://`.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The expiration time of the capacity reservation. This parameter takes effect only when `EndTimeType` is set to Limited. Specify the time in the ISO 8601 standard in the `yyyy-MM-ddTHH:mm:ssZ` format. The time must be in UTC. For more information, see [ISO 8601](https://help.aliyun.com/document_detail/25696.html).
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The release mode of the capacity reservation. Valid values:
        /// 
        /// *   Limited: The capacity reservation is automatically released at the specified point in time. If you configure this parameter, you must also configure `EndTime`.
        /// *   Unlimited: The capacity reservation must be manually released. You can release it anytime.
        /// </summary>
        [NameInMap("EndTimeType")]
        [Validation(Required=false)]
        public string EndTimeType { get; set; }

        /// <summary>
        /// The total number of instances for which capacity is reserved. Valid values: the number of used instances to 1000.
        /// 
        /// > When you increase the number of instances, the increase may fail due to insufficient resources.
        /// </summary>
        [NameInMap("InstanceAmount")]
        [Validation(Required=false)]
        public int? InstanceAmount { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The operating system of the image used by the instance. Valid values:
        /// 
        /// *   Windows
        /// *   Linux
        /// 
        /// > This parameter is unavailable.
        /// </summary>
        [NameInMap("Platform")]
        [Validation(Required=false)]
        public string Platform { get; set; }

        /// <summary>
        /// The region ID of the capacity reservation. You can call the [DescribeRegions](https://help.aliyun.com/document_detail/25609.html) operation to query the most recent region list.
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

        /// <summary>
        /// The mode in which the capacity reservation takes effect. Only immediate capacity reservations are supported. You do not need to specify a value for this parameter.
        /// 
        /// > If you do not specify a value for this parameter, the capacity reservation immediately takes effect.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
