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
            /// The acceleration region IDs.
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
            /// 
            /// *   Each acceleration region must be allocated a minimum of 2 Mbit/s of bandwidth.
            /// 
            /// *   The total bandwidth for all acceleration regions cannot exceed the maximum bandwidth of the basic bandwidth plan.
            /// </summary>
            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public int? Bandwidth { get; set; }

            /// <summary>
            /// The IP version used to connect to the GA instance. Valid values:
            /// 
            /// *   **IPv4** (default)
            /// *   **IPv6**
            /// </summary>
            [NameInMap("IpVersion")]
            [Validation(Required=false)]
            public string IpVersion { get; set; }

            /// <summary>
            /// The line type of the elastic IP address (EIP) in the acceleration region. Valid values:
            /// 
            /// *   **BGP**
            /// *   **BGP_PRO** If the acceleration region is China (Hong Kong) and a basic bandwidth plan whose bandwidth type is Premium is associated with the GA instance, the default value of IspType is BGP_PRO.
            /// 
            /// If you are allowed to use single-ISP bandwidth, you can also specify one of the following values:
            /// 
            /// *   **ChinaTelecom**: China Telecom (single ISP)
            /// *   **ChinaUnicom**: China Unicom (single ISP)
            /// *   **ChinaMobile**: China Mobile (single ISP)
            /// *   **ChinaTelecom_L2**: China Telecom \_L2 (single ISP)
            /// *   **ChinaUnicom_L2**: China Unicom \_L2 (single ISP)
            /// *   **ChinaMobile_L2**: China Mobile \_L2 (single ISP)
            /// 
            /// > Different acceleration regions support different single-ISP BGP lines.
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
        /// You can use the client to generate the token, but you must make sure that the token is unique among all requests. The token can contain only ASCII characters.
        /// 
        /// > If you do not specify this parameter, the system automatically uses the **request ID** as the **client token**. The **request ID** may be different for each request.
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
