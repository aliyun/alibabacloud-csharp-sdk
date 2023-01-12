// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class CreateIpSetsRequest : TeaModel {
        [NameInMap("AccelerateRegion")]
        [Validation(Required=false)]
        public List<CreateIpSetsRequestAccelerateRegion> AccelerateRegion { get; set; }
        public class CreateIpSetsRequestAccelerateRegion : TeaModel {
            /// <summary>
            /// The ID of the region that requires acceleration.
            /// 
            /// The number of regions that can be added varies based on the specification of the GA instance. For more information, see [Overview](~~153127~~).
            /// </summary>
            [NameInMap("AccelerateRegionId")]
            [Validation(Required=false)]
            public string AccelerateRegionId { get; set; }

            /// <summary>
            /// The bandwidth to be allocated to the acceleration region. Unit: **Mbit/s**.
            /// 
            /// > 
            /// *   Each acceleration region must be allocated a minimum of 2 Mbit/s of bandwidth.
            /// *   The total bandwidth for all acceleration regions cannot exceed the bandwidth limit of your basic bandwidth plan.
            /// </summary>
            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public int? Bandwidth { get; set; }

            /// <summary>
            /// The IP version used to connect to the GA instance. Valid values:
            /// 
            /// *   **IPv4** (default): IPv4
            /// *   **IPv6**: IPv6
            /// </summary>
            [NameInMap("IpVersion")]
            [Validation(Required=false)]
            public string IpVersion { get; set; }

            [NameInMap("IspType")]
            [Validation(Required=false)]
            public string IspType { get; set; }

        }

        /// <summary>
        /// The ID of the GA instance.
        /// </summary>
        [NameInMap("AcceleratorId")]
        [Validation(Required=false)]
        public string AcceleratorId { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the value, but you must make sure that it is unique among different requests. ClientToken can contain only ASCII characters.
        /// 
        /// >  If you do not set this parameter, **ClientToken** is set to the value of **RequestId**. The value of **RequestId** may be different for each API request.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The ID of the region where the GA instance is deployed. Set the value to **cn-hangzhou**.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
