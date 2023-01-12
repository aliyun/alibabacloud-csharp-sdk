// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class ConfigEndpointProbeRequest : TeaModel {
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
        /// Specifies whether to enable latency monitoring. Default value: false. Valid values:
        /// 
        /// *   **true**: enables latency monitoring.
        /// *   **false**: disables latency monitoring.
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public string Enable { get; set; }

        /// <summary>
        /// The endpoint.
        /// </summary>
        [NameInMap("Endpoint")]
        [Validation(Required=false)]
        public string Endpoint { get; set; }

        /// <summary>
        /// The ID of the endpoint group.
        /// </summary>
        [NameInMap("EndpointGroupId")]
        [Validation(Required=false)]
        public string EndpointGroupId { get; set; }

        /// <summary>
        /// The type of endpoint. Valid values:
        /// 
        /// *   **Ip**: a custom IP address
        /// *   **Domain**: a custom domain name
        /// *   **EIP**: an Alibaba Cloud elastic IP address (EIP)
        /// *   **PublicIp**: an Alibaba Cloud public IP address
        /// </summary>
        [NameInMap("EndpointType")]
        [Validation(Required=false)]
        public string EndpointType { get; set; }

        /// <summary>
        /// The port that is used to monitor latency. Valid values: **0** to **65535**.
        /// </summary>
        [NameInMap("ProbePort")]
        [Validation(Required=false)]
        public string ProbePort { get; set; }

        /// <summary>
        /// The protocol that is used to monitor latency. Valid values:
        /// 
        /// *   **tcp**
        /// *   **icmp**
        /// </summary>
        [NameInMap("ProbeProtocol")]
        [Validation(Required=false)]
        public string ProbeProtocol { get; set; }

        /// <summary>
        /// The ID of the region where the GA instance is deployed. Set the value to **cn-hangzhou**.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
