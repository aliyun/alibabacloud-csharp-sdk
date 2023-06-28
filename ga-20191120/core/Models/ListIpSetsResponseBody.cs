// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class ListIpSetsResponseBody : TeaModel {
        /// <summary>
        /// Details of the acceleration regions.
        /// </summary>
        [NameInMap("IpSets")]
        [Validation(Required=false)]
        public List<ListIpSetsResponseBodyIpSets> IpSets { get; set; }
        public class ListIpSetsResponseBodyIpSets : TeaModel {
            /// <summary>
            /// The ID of the acceleration region.
            /// </summary>
            [NameInMap("AccelerateRegionId")]
            [Validation(Required=false)]
            public string AccelerateRegionId { get; set; }

            /// <summary>
            /// The bandwidth that is allocated to the acceleration region. Unit: **Mbit/s**.
            /// </summary>
            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public int? Bandwidth { get; set; }

            /// <summary>
            /// The list of accelerated IP addresses in the acceleration region.
            /// </summary>
            [NameInMap("IpAddressList")]
            [Validation(Required=false)]
            public List<string> IpAddressList { get; set; }

            /// <summary>
            /// The ID of the acceleration region.
            /// </summary>
            [NameInMap("IpSetId")]
            [Validation(Required=false)]
            public string IpSetId { get; set; }

            /// <summary>
            /// The version of the IP protocol. Valid values:
            /// 
            /// *   **IPv4**
            /// *   **IPv6**
            /// </summary>
            [NameInMap("IpVersion")]
            [Validation(Required=false)]
            public string IpVersion { get; set; }

            /// <summary>
            /// The line type of the elastic IP address (EIP) in the acceleration region. Valid values:
            /// 
            /// *   **BGP**: BGP (Multi-ISP) lines.
            /// *   **BGP_PRO**: BGP (Multi-ISP) Pro lines If the acceleration region is China (Hong Kong) and a basic bandwidth plan whose bandwidth type is Premium is associated with the GA instance, the default value of IspType is BGP_PRO.
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

            /// <summary>
            /// The status of the acceleration region. Valid values:
            /// 
            /// *   **init**: The acceleration region is being initialized.
            /// *   **active**: The acceleration region is running.
            /// *   **updating**: The acceleration region is being configured.
            /// *   **deleting**: The acceleration region is being deleted.
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

        }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
