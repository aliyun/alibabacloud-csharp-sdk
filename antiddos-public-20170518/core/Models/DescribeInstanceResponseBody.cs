// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Antiddos_public20170518.Models
{
    public class DescribeInstanceResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of the details of the asset.
        /// </summary>
        [NameInMap("InstanceList")]
        [Validation(Required=false)]
        public DescribeInstanceResponseBodyInstanceList InstanceList { get; set; }
        public class DescribeInstanceResponseBodyInstanceList : TeaModel {
            [NameInMap("Instance")]
            [Validation(Required=false)]
            public List<DescribeInstanceResponseBodyInstanceListInstance> Instance { get; set; }
            public class DescribeInstanceResponseBodyInstanceListInstance : TeaModel {
                /// <summary>
                /// The basic protection threshold for the asset. Unit: Mbit/s.
                /// </summary>
                [NameInMap("BlackholeThreshold")]
                [Validation(Required=false)]
                public int? BlackholeThreshold { get; set; }

                /// <summary>
                /// The traffic scrubbing threshold for the asset. Unit: Mbit/s.
                /// </summary>
                [NameInMap("DefenseBpsThreshold")]
                [Validation(Required=false)]
                public int? DefenseBpsThreshold { get; set; }

                /// <summary>
                /// The packet scrubbing threshold for the asset. Unit: packets per second (pps).
                /// </summary>
                [NameInMap("DefensePpsThreshold")]
                [Validation(Required=false)]
                public int? DefensePpsThreshold { get; set; }

                /// <summary>
                /// The burstable protection threshold for the asset. Unit: Mbit/s.
                /// </summary>
                [NameInMap("ElasticThreshold")]
                [Validation(Required=false)]
                public int? ElasticThreshold { get; set; }

                /// <summary>
                /// The ID of the asset.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The IP address of the asset.
                /// </summary>
                [NameInMap("InstanceIp")]
                [Validation(Required=false)]
                public string InstanceIp { get; set; }

                /// <summary>
                /// The name of the asset.
                /// </summary>
                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                /// <summary>
                /// The DDoS mitigation status of the asset. Valid values:
                /// 
                /// *   **mitigating**: indicates that traffic scrubbing is triggered for the asset.
                /// *   **blackholed**: indicates that blackhole filtering is triggered for the asset.
                /// *   **normal**: indicates that the instance is normal.
                /// </summary>
                [NameInMap("InstanceStatus")]
                [Validation(Required=false)]
                public string InstanceStatus { get; set; }

                /// <summary>
                /// The type of the asset. Valid values:
                /// 
                /// *   **ecs**: ECS instance
                /// *   **slb**: SLB instance
                /// *   **eip**: EIP
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                /// <summary>
                /// The IP protocol that is supported by the asset. Valid values:
                /// 
                /// *   **v4**: IPv4
                /// *   **v6**: IPv6
                /// </summary>
                [NameInMap("IpVersion")]
                [Validation(Required=false)]
                public string IpVersion { get; set; }

                /// <summary>
                /// Indicates whether the asset is associated with an Anti-DDoS Origin Basic instance. Valid values:
                /// 
                /// *   **true**: yes
                /// *   **false**: no
                /// </summary>
                [NameInMap("IsBgppack")]
                [Validation(Required=false)]
                public bool? IsBgppack { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of the assets.
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
