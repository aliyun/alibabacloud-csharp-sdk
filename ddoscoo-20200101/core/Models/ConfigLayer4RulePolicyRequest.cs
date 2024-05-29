// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class ConfigLayer4RulePolicyRequest : TeaModel {
        /// <summary>
        /// The port forwarding rule that you want to manage.
        /// 
        /// This parameter is a string that consists of JSON arrays. Each element in a JSON array indicates a port forwarding rule. You can perform this operation only on one port forwarding rule at a time.
        /// 
        /// > You can call the [DescribeNetworkRules](https://help.aliyun.com/document_detail/157484.html) to query existing port forwarding rules.
        /// 
        /// Each port forwarding rule contains the following fields:
        /// 
        /// *   **InstanceId**: the ID of the instance. This field is required and must be of the STRING type.
        /// 
        /// *   **Protocol**: the forwarding protocol. This field is required and must be of the STRING type. Valid values: **tcp** and **udp**.
        /// 
        /// *   **FrontendPort**: the forwarding port. This field is required and must be of the INTEGER type.
        /// 
        /// *   **BackendPort**: the port of the origin server. This field is required and must be of the INTEGER type.
        /// 
        /// *   **PriRealServers**: the IP addresses of the primary origin server. This field is required and must be a JSON array. Each element in a JSON array indicates an IP address of the primary origin server. You can configure a maximum of 20 IP addresses.
        /// 
        ///     Each element in the JSON array contains the following field:
        /// 
        ///     *   **RealServer**: the IP address of the primary origin server. This field is required and must be of the STRING type.
        /// 
        /// *   **SecRealServers**: the IP addresses of the secondary origin server. This field is required and must be a JSON array. Each element in a JSON array indicates an IP address of the secondary origin server. You can configure a maximum of 20 IP addresses.
        /// 
        ///     Each element in the JSON array contains the following field:
        /// 
        ///     *   **RealServer**: the IP address of the secondary origin server. This field is required and must be of the STRING type.
        /// 
        /// *   **CurrentRsIndex**: the origin server that you want to use to receive service traffic. This field is required and must be of the INTEGER type. Valid values:
        /// 
        ///     *   **1**: the primary origin server, which indicates that Anti-DDoS Pro or Anti-DDoS Premium forwards service traffic to the IP addresses of the primary origin server.
        ///     *   **2**: the secondary origin server, which indicates that Anti-DDoS Pro or Anti-DDoS Premium forwards service traffic to the IP addresses of the secondary origin server.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Listeners")]
        [Validation(Required=false)]
        public string Listeners { get; set; }

    }

}
