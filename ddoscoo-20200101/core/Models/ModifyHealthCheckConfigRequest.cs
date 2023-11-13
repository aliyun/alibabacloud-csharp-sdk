// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class ModifyHealthCheckConfigRequest : TeaModel {
        /// <summary>
        /// The forwarding protocol. Valid values:
        /// 
        /// *   **tcp**
        /// *   **udp**
        /// </summary>
        [NameInMap("ForwardProtocol")]
        [Validation(Required=false)]
        public string ForwardProtocol { get; set; }

        /// <summary>
        /// The forwarding port.
        /// </summary>
        [NameInMap("FrontendPort")]
        [Validation(Required=false)]
        public int? FrontendPort { get; set; }

        /// <summary>
        /// The details of the health check configuration. This parameter is a JSON string. The string contains the following fields:
        /// 
        /// *   **Type**: the protocol type. This field is required and must be of the STRING type. Valid values: **tcp** (Layer 4) and **http** (Layer 7).
        /// 
        /// *   **Domain**: the domain name, which must be of the STRING type.
        /// 
        ///     **
        /// 
        ///     **Note**This parameter is returned only when the Layer 7 health check configuration is queried.
        /// 
        /// *   **Uri**: the check path, which must be of the STRING type.
        /// 
        ///     **
        /// 
        ///     **Note**This parameter is returned only when the Layer 7 health check configuration is queried.
        /// 
        /// *   **Timeout**: the response timeout period, which must be of the INTEGER type. Valid values: **1** to **30**. Unit: seconds.
        /// 
        /// *   **Port**: the port on which you want to perform the health check, which must be of the INTEGER type.
        /// 
        /// *   **Interval**: the health check interval, which must be of the INTEGER type. Valid values: **1** to **30**. Unit: seconds.
        /// 
        /// *   **Up**: the number of consecutive successful health checks that must occur before declaring a port healthy, which must be of the INTEGER type. Valid values: **1** to **10**.
        /// 
        /// *   **Down**: the number of consecutive failed health checks that must occur before declaring a port unhealthy, which must be of the INTEGER type. Valid values: **1** to **10**.
        /// </summary>
        [NameInMap("HealthCheck")]
        [Validation(Required=false)]
        public string HealthCheck { get; set; }

        /// <summary>
        /// The ID of the instance.
        /// 
        /// > You can call the [DescribeInstanceIds](~~157459~~) operation to query the IDs of all instances.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
