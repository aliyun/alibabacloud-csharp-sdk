// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class CreateIpSetsRequest : TeaModel {
        /// <summary>
        /// The information about the acceleration regions.
        /// </summary>
        [NameInMap("AccelerateRegion")]
        [Validation(Required=false)]
        public List<CreateIpSetsRequestAccelerateRegion> AccelerateRegion { get; set; }
        public class CreateIpSetsRequestAccelerateRegion : TeaModel {
            /// <summary>
            /// The ID of the acceleration region.
            /// 
            /// The number of regions that you can add varies based on the specification of the GA instance. For more information, see [Overview](~~153127~~).
            /// </summary>
            [NameInMap("AccelerateRegionId")]
            [Validation(Required=false)]
            public string AccelerateRegionId { get; set; }

            /// <summary>
            /// The bandwidth that you want to allocate to the acceleration region. Unit: **Mbit/s**.
            /// 
            /// >*  This parameter is required.
            /// >*   You must allocate at least 2 Mbit/s of bandwidth to each acceleration region.
            /// >*   The total bandwidth of all acceleration regions cannot exceed the bandwidth limit of your basic bandwidth plan.
            /// </summary>
            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public int? Bandwidth { get; set; }

            /// <summary>
            /// The IP version used to connect to the GA instance. Valid values:
            /// 
            /// *   **IPv4** (default)
            /// *   **IPv6**
            /// *   **DUAL_STACK**: IPv4 and IPv6
            /// 
            /// > Only pay-as-you-go standard GA instances support DUAL_STACK.
            /// </summary>
            [NameInMap("IpVersion")]
            [Validation(Required=false)]
            public string IpVersion { get; set; }

            /// <summary>
            /// The line type of the elastic IP address (EIP) in the acceleration region. Valid values:
            /// 
            /// *   **BGP**: BGP (Multi-ISP) lines.
            /// *   **BGP_PRO**: BGP (Multi-ISP) Pro lines
            /// 
            /// > *   This parameter is required only if the bandwidth metering method of the GA instance is **pay-by-data transfer**.
            /// >*   Different acceleration regions support different line types of EIPs.
            /// </summary>
            [NameInMap("IspType")]
            [Validation(Required=false)]
            public string IspType { get; set; }

        }

        /// <summary>
        /// The GA instance ID.
        /// </summary>
        [NameInMap("AcceleratorId")]
        [Validation(Required=false)]
        public string AcceleratorId { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.
        /// 
        /// >  If you do not specify this parameter, the system automatically uses the **request ID** as the **client token**. The **request ID** may be different for each request.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The region ID of the GA instance. Set the value to **cn-hangzhou**.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
