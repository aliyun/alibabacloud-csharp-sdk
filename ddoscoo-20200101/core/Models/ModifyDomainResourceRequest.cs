// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class ModifyDomainResourceRequest : TeaModel {
        /// <summary>
        /// <para>The domain name that is added to the Anti-DDoS Pro or Anti-DDoS Premium instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.example.com">www.example.com</a></para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>The advanced HTTPS settings. This parameter takes effect only when the value of the <b>ProxyType</b> parameter includes <b>https</b>. The value is a string that consists of a JSON struct. The JSON struct contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Http2https</b>: specifies whether to turn on Enforce HTTPS Routing. This field is optional and must be an integer. Valid values: <b>0</b> and <b>1</b>. The value 0 indicates that Enforce HTTPS Routing is turned off. The value 1 indicates that Enforce HTTPS Routing is turned on. The default value is 0.</para>
        /// <para>If your website supports both HTTP and HTTPS, this feature meets your business requirements. If you enable this feature, all HTTP requests to access the website are redirected to HTTPS requests on the standard port 443.</para>
        /// </description></item>
        /// <item><description><para><b>Https2http</b>: specifies whether to turn on Enable HTTP. This field is optional and must be an integer. Valid values: <b>0</b> and <b>1</b>. The value 0 indicates that Enable HTTP is turned off. The value 1 indicates that Enable HTTP is turned on. The default value is 0.</para>
        /// <para>If your website does not support HTTPS, this feature meets your business requirements If this feature is enabled, all HTTPS requests are redirected to HTTP requests and forwarded to origin servers. This feature can redirect WebSockets requests to WebSocket requests. Requests are redirected over the standard port 80.</para>
        /// </description></item>
        /// <item><description><para><b>Http2</b>: specifies whether to turn on Enable HTTP/2. This field is optional. Data type: integer. Valid values: <b>0</b> and <b>1</b>. The value 0 indicates that Enable HTTP/2 is turned off. The value 1 indicates that Enable HTTP/2 is turned on. The default value is 0.</para>
        /// <para>After you turn on the switch, HTTP/2 is used.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Http2&quot;:1,&quot;Http2https&quot;:1,&quot;Https2http&quot;:1}</para>
        /// </summary>
        [NameInMap("HttpsExt")]
        [Validation(Required=false)]
        public string HttpsExt { get; set; }

        /// <summary>
        /// <para>An array consisting of the IDs of instances that you want to associate.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// <para>The details about the protocol type and port number.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ProxyTypes")]
        [Validation(Required=false)]
        public List<ModifyDomainResourceRequestProxyTypes> ProxyTypes { get; set; }
        public class ModifyDomainResourceRequestProxyTypes : TeaModel {
            /// <summary>
            /// <para>The port numbers.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("ProxyPorts")]
            [Validation(Required=false)]
            public List<int?> ProxyPorts { get; set; }

            /// <summary>
            /// <para>The type of the protocol. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>http</b></description></item>
            /// <item><description><b>https</b></description></item>
            /// <item><description><b>websocket</b></description></item>
            /// <item><description><b>websockets</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>https</para>
            /// </summary>
            [NameInMap("ProxyType")]
            [Validation(Required=false)]
            public string ProxyType { get; set; }

        }

        /// <summary>
        /// <para>An array that consists of the addresses of origin servers.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("RealServers")]
        [Validation(Required=false)]
        public List<string> RealServers { get; set; }

        /// <summary>
        /// <para>The address type of the origin server. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: IP address</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: domain name</para>
        /// <para>If you deploy proxies, such as a Web Application Firewall (WAF) instance, between the origin server and the Anti-DDoS Pro or Anti-DDoS Premium instance, set the value to 1. If you use the domain name, you must enter the address of the proxy, such as the CNAME of WAF.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("RsType")]
        [Validation(Required=false)]
        public int? RsType { get; set; }

    }

}
