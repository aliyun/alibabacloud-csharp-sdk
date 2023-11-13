// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class ConfigNetworkRulesRequest : TeaModel {
        /// <summary>
        /// The details of the port forwarding rule. This parameter is a JSON string. The string contains the following fields:
        /// 
        /// *   **InstanceId**: the ID of the instance. This field is required and must be of the STRING type.
        /// *   **Protocol**: the forwarding protocol. This field is required and must be of the STRING type. Valid values: **tcp** and **udp**.
        /// *   **FrontendPort**: the forwarding port. This field is required and must be of the INTEGER type.
        /// *   **BackendPort**: the port of the origin server. This field is required and must be of the INTEGER type.
        /// *   **RealServers**: the IP addresses of the origin server. This field is required and must be a JSON array. You can specify up to 20 IP addresses.
        /// 
        /// > You can modify only the value of **RealServers** when you modify a port forwarding rule.
        /// </summary>
        [NameInMap("NetworkRules")]
        [Validation(Required=false)]
        public string NetworkRules { get; set; }

    }

}
