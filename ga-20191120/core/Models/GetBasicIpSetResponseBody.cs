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
        /// The version of the accelerated IP address. Only **IPv4** is returned. This indicates that an IPv4 address is used.
        /// </summary>
        [NameInMap("IpVersion")]
        [Validation(Required=false)]
        public string IpVersion { get; set; }

        /// <summary>
        /// The line type of the elastic IP address (EIP) in the acceleration region. Valid values:
        /// 
        /// *   **BGP** (default)
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
