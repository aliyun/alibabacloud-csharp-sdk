// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class GetBasicAccelerateIpResponseBody : TeaModel {
        /// <summary>
        /// The accelerated IP address.
        /// </summary>
        [NameInMap("AccelerateIpAddress")]
        [Validation(Required=false)]
        public string AccelerateIpAddress { get; set; }

        /// <summary>
        /// The ID of the accelerated IP address.
        /// </summary>
        [NameInMap("AccelerateIpId")]
        [Validation(Required=false)]
        public string AccelerateIpId { get; set; }

        /// <summary>
        /// The ID of the basic GA instance to which the queried accelerated IP address belongs.
        /// </summary>
        [NameInMap("AcceleratorId")]
        [Validation(Required=false)]
        public string AcceleratorId { get; set; }

        /// <summary>
        /// The ID of the acceleration region of the basic GA instance.
        /// </summary>
        [NameInMap("IpSetId")]
        [Validation(Required=false)]
        public string IpSetId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The status of the accelerated IP address. Valid values:
        /// 
        /// *   **active**: The accelerated IP address is available.
        /// *   **binding**: The accelerated IP address is being associated.
        /// *   **bound**: The accelerated IP address is associated.
        /// *   **unbinding**: The basic GA instance is being disassociated.
        /// *   **deleting**: The accelerated IP address is being deleted.
        /// 
        /// >  This parameter is not returned when the queried accelerated IP address is being created.
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

    }

}
