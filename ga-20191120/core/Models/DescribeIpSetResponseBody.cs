// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class DescribeIpSetResponseBody : TeaModel {
        /// <summary>
        /// The ID of the region that is accelerated.
        /// </summary>
        [NameInMap("AccelerateRegionId")]
        [Validation(Required=false)]
        public string AccelerateRegionId { get; set; }

        /// <summary>
        /// The ID of the GA instance.
        /// </summary>
        [NameInMap("AcceleratorId")]
        [Validation(Required=false)]
        public string AcceleratorId { get; set; }

        /// <summary>
        /// The bandwidth that is allocated to the acceleration region. Unit: Mbit/s.
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
        /// The version of the accelerated IP address. Valid values:
        /// 
        /// *   **IPv4**
        /// *   **IPv6**
        /// </summary>
        [NameInMap("IpVersion")]
        [Validation(Required=false)]
        public string IpVersion { get; set; }

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
        /// The status of the acceleration region. Valid values:
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
