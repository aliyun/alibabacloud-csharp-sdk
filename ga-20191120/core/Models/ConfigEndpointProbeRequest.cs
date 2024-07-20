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
        /// You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.
        /// 
        /// >  If you do not specify this parameter, the system automatically uses the **request ID** as the **client token**. The **request ID** may be different for each request.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Specifies whether to enable latency monitoring. Valid values:
        /// 
        /// *   **true**
        /// *   **false** (default)
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public string Enable { get; set; }

        /// <summary>
        /// The endpoint.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Endpoint")]
        [Validation(Required=false)]
        public string Endpoint { get; set; }

        /// <summary>
        /// The endpoint group ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EndpointGroupId")]
        [Validation(Required=false)]
        public string EndpointGroupId { get; set; }

        /// <summary>
        /// The type of the endpoint. Valid values:
        /// 
        /// *   **Ip:** a custom IP address.
        /// *   **Domain:** a custom domain name.
        /// *   **EIP:** an Alibaba Cloud elastic IP address (EIP).
        /// *   **PublicIp:** an Alibaba Cloud public IP address.
        /// 
        /// This parameter is required.
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
        /// *   **tcp:** TCP.
        /// *   **icmp:** ICMP.
        /// </summary>
        [NameInMap("ProbeProtocol")]
        [Validation(Required=false)]
        public string ProbeProtocol { get; set; }

        /// <summary>
        /// The region ID of the GA instance. Set the value to **cn-hangzhou**.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
