// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class GetBasicIpSetResponseBody : TeaModel {
        /// <summary>
        /// The ID of the region where the basic GA instance is deployed.
        /// </summary>
        [NameInMap("AccelerateRegionId")]
        [Validation(Required=false)]
        public string AccelerateRegionId { get; set; }

        /// <summary>
        /// The ID of the basic GA instance.
        /// </summary>
        [NameInMap("AcceleratorId")]
        [Validation(Required=false)]
        public string AcceleratorId { get; set; }

        /// <summary>
        /// The bandwidth of the acceleration region of the basic GA instance. Unit: Mbit/s.
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public long? Bandwidth { get; set; }

        /// <summary>
        /// The accelerated IP address.
        /// </summary>
        [NameInMap("IpAddress")]
        [Validation(Required=false)]
        public string IpAddress { get; set; }

        /// <summary>
        /// The ID of the acceleration region of the basic GA instance.
        /// </summary>
        [NameInMap("IpSetId")]
        [Validation(Required=false)]
        public string IpSetId { get; set; }

        /// <summary>
        /// The Internet protocol version. Only **IPv4** may be returned.
        /// </summary>
        [NameInMap("IpVersion")]
        [Validation(Required=false)]
        public string IpVersion { get; set; }

        /// <summary>
        /// The line type of the elastic IP address (EIP) in the acceleration region. Valid values:
        /// 
        /// *   **BGP** (default): BGP (Multi-ISP) lines.
        /// *   **BGP_PRO**: BGP (Multi-ISP) Pro lines.
        /// 
        /// Valid values if you are allowed to use single-ISP bandwidth:
        /// 
        /// *   **ChinaTelecom**
        /// *   **ChinaUnicom**
        /// *   **ChinaMobile**
        /// *   **ChinaTelecom_L2**
        /// *   **ChinaUnicom_L2**
        /// *   **ChinaMobile_L2**
        /// </summary>
        [NameInMap("IspType")]
        [Validation(Required=false)]
        public string IspType { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The status of the acceleration region of the basic GA instance. Valid values:
        /// 
        /// *   **init**: The acceleration region is being initialized.
        /// *   **active**: The acceleration region is in the running state.
        /// *   **updating**: The acceleration region is being configured.
        /// *   **Deleting**: The acceleration region is being deleted.
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

    }

}
