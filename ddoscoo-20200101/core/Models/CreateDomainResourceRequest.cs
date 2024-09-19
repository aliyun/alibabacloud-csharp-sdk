// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class CreateDomainResourceRequest : TeaModel {
        /// <summary>
        /// The domain name of the website that you want to add to the Anti-DDoS Pro or Anti-DDoS Premium instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// The advanced HTTPS settings. This parameter takes effect only when the value of the **ProxyType** parameter includes **https**. The value is a string that consists of a JSON struct. The JSON struct contains the following fields:
        /// 
        /// *   **Http2https**: specifies whether to turn on Enforce HTTPS Routing. This field is optional and must be an integer. Valid values: **0** and **1**. The value 0 indicates that Enforce HTTPS Routing is turned off. The value 1 indicates that Enforce HTTPS Routing is turned on. The default value is 0.
        /// 
        ///     If your website supports both HTTP and HTTPS, this feature meets your business requirements. If you enable this feature, all HTTP requests to access the website are redirected to HTTPS requests on the standard port 443.
        /// 
        /// *   **Https2http**: specifies whether to turn on Enable HTTP. This field is optional and must be an integer. Valid values: **0** and **1**. The value 0 indicates that Enable HTTP is turned off. The value 1 indicates that Enable HTTP is turned on. The default value is 0.
        /// 
        ///     If your website does not support HTTPS, this feature meets your business requirements If this feature is enabled, all HTTPS requests are redirected to HTTP requests and forwarded to origin servers. This feature can redirect WebSockets requests to WebSocket requests. Requests are redirected over the standard port 80.
        /// 
        /// *   **Http2**: specifies whether to turn on Enable HTTP/2. This field is optional. Data type: integer. Valid values: **0** and **1**. The value 0 indicates that Enable HTTP/2 is turned off. The value 1 indicates that Enable HTTP/2 is turned on. The default value is 0.
        /// 
        ///     After you turn on the switch, HTTP/2 is used.
        /// </summary>
        [NameInMap("HttpsExt")]
        [Validation(Required=false)]
        public string HttpsExt { get; set; }

        /// <summary>
        /// An array consisting of the IDs of instances that you want to associate.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// The details about the protocol type and port number.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ProxyTypes")]
        [Validation(Required=false)]
        public List<CreateDomainResourceRequestProxyTypes> ProxyTypes { get; set; }
        public class CreateDomainResourceRequestProxyTypes : TeaModel {
            /// <summary>
            /// The port numbers.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("ProxyPorts")]
            [Validation(Required=false)]
            public List<int?> ProxyPorts { get; set; }

            /// <summary>
            /// The type of the protocol. Valid values:
            /// 
            /// *   **http**
            /// *   **https**
            /// *   **websocket**
            /// *   **websockets**
            /// </summary>
            [NameInMap("ProxyType")]
            [Validation(Required=false)]
            public string ProxyType { get; set; }

        }

        /// <summary>
        /// An array that consists of the addresses of origin servers.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RealServers")]
        [Validation(Required=false)]
        public List<string> RealServers { get; set; }

        /// <summary>
        /// The address type of the origin server. Valid values:
        /// 
        /// *   **0**: IP address.
        /// 
        /// *   **1**: domain name.
        /// 
        ///     This parameter is suitable for scenarios in which another proxy service, such as Web Application Firewall (WAF), is deployed between the origin server and Anti-DDoS Proxy. The address is the redirection address of the proxy service, such as the CNAME of WAF.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RsType")]
        [Validation(Required=false)]
        public int? RsType { get; set; }

    }

}
