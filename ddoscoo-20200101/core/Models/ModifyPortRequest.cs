// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class ModifyPortRequest : TeaModel {
        /// <summary>
        /// The port of the origin server. Valid values: **0** to **65535**.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("BackendPort")]
        [Validation(Required=false)]
        public string BackendPort { get; set; }

        /// <summary>
        /// The forwarding port. Valid values: **0** to **65535**.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("FrontendPort")]
        [Validation(Required=false)]
        public string FrontendPort { get; set; }

        /// <summary>
        /// The type of the forwarding protocol. Valid values:
        /// 
        /// *   **tcp**
        /// *   **udp**
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("FrontendProtocol")]
        [Validation(Required=false)]
        public string FrontendProtocol { get; set; }

        /// <summary>
        /// The ID of the Anti-DDoS Pro or Anti-DDoS Premium instance to which the port forwarding rule belongs.
        /// 
        /// > You can call the [DescribeInstanceIds](https://help.aliyun.com/document_detail/157459.html) operation to query the IDs of all instances.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("ProxyEnable")]
        [Validation(Required=false)]
        public long? ProxyEnable { get; set; }

        /// <summary>
        /// An array that consists of the IP addresses of origin servers.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RealServers")]
        [Validation(Required=false)]
        public List<string> RealServers { get; set; }

    }

}
