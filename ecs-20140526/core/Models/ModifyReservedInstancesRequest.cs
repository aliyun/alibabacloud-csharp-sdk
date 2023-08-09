// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyReservedInstancesRequest : TeaModel {
        /// <summary>
        /// The configurations of reserved instance N.
        /// </summary>
        [NameInMap("Configuration")]
        [Validation(Required=false)]
        public List<ModifyReservedInstancesRequestConfiguration> Configuration { get; set; }
        public class ModifyReservedInstancesRequestConfiguration : TeaModel {
            /// <summary>
            /// The ID of the request.
            /// </summary>
            [NameInMap("InstanceAmount")]
            [Validation(Required=false)]
            public int? InstanceAmount { get; set; }

            /// <summary>
            /// The number of pay-as-you-go instances of the same instance type that the reserved instance can match. The value of this parameter must be greater than or equal to 1. Valid values of N: 1 to 100.
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// The zone ID of reserved instance N. Valid values of N: 1 to 100.
            /// 
            /// This parameter is required when `Scope` is set to `Zone`.
            /// 
            /// You can call the [DescribeZones](~~25609~~) operation to query the most recent zone list.
            /// </summary>
            [NameInMap("ReservedInstanceName")]
            [Validation(Required=false)]
            public string ReservedInstanceName { get; set; }

            /// <summary>
            /// The instance type that reserved instance N can match. Valid values of N: 1 to 100.
            /// 
            /// > The supported instance types are regularly updated. For more information, see the "Attributes" section of [Overview](~~100370~~).
            /// </summary>
            [NameInMap("Scope")]
            [Validation(Required=false)]
            public string Scope { get; set; }

            /// <summary>
            /// The scope of reserved instance N. Valid values:
            /// 
            /// *   Region
            /// *   Zone
            /// 
            /// Valid values of N: 1 to 100.
            /// 
            /// Default value: Region.
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The IDs of reserved instances. Valid values of N: 1 to 20.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The IDs of reserved instances. Valid values of N: 1 to 20.
        /// </summary>
        [NameInMap("ReservedInstanceId")]
        [Validation(Required=false)]
        public List<string> ReservedInstanceId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
