// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class ModifyWebRuleRequest : TeaModel {
        /// <summary>
        /// <para>The domain name of the website.</para>
        /// <remarks>
        /// <para> A forwarding rule must be configured for the domain name. You can call the <a href="https://help.aliyun.com/document_detail/91724.html">DescribeDomains</a> operation to query the domain names for which forwarding rules are configured.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.aliyun.com">www.aliyun.com</a></para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>The advanced HTTPS settings. This parameter takes effect only when the value of <b>ProxyType</b> includes <b>https</b>. The value is a string that consists of a JSON struct. The JSON struct contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Http2https</b>: specifies whether to turn on Enforce HTTPS Routing. This field is optional and must be an integer. Valid values: <b>0</b> and <b>1</b>. The value 0 indicates that Enforce HTTPS Routing is turned off. The value 1 indicates that Enforce HTTPS Routing is turned on. The default value is 0.</para>
        /// <para>If your website supports both HTTP and HTTPS, this feature suits your needs. If you turn on the switch, all HTTP requests are redirected to HTTPS requests on port 443 by default.</para>
        /// </description></item>
        /// <item><description><para><b>Https2http</b>: specifies whether to turn on Enable HTTP. This field is optional and must be an integer. Valid values: <b>0</b> and <b>1</b>. The value 0 indicates that Enable HTTP is turned off. The value 1 indicates that Enable HTTP is turned on. The default value is 0.</para>
        /// <para>If your website does not support HTTPS, this feature suits your needs. If you turn on the switch, all HTTPS requests are redirected to HTTP requests and forwarded to origin servers. The feature can also redirect WebSockets requests to WebSocket requests. All requests are redirected over port 80.</para>
        /// </description></item>
        /// <item><description><para><b>Http2</b>: specifies whether to turn on Enable HTTP/2. This field is optional and must be an integer. Valid values: <b>0</b> and <b>1</b>. The value 0 indicates that Enable HTTP/2 is turned off. The value 1 indicates that Enable HTTP/2 is turned on. The default value is 0.</para>
        /// <para>After you turn on the switch, the protocol type is HTTP/2.</para>
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
        /// <b>Example:</b>
        /// <para>ddoscoo-cn-mp91j1ao****</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// <para>The protocol of the forwarding rule. The value is a string that consists of JSON arrays. Each element in a JSON array is a JSON struct that contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><b>ProxyType</b>: the protocol type. This field is required and must be a string. Valid values: <b>http</b>, <b>https</b>, <b>websocket</b>, and <b>websockets</b>.</description></item>
        /// <item><description><b>ProxyPort</b>: the port number. This field is required and must be an array.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;ProxyType&quot;:&quot;https&quot;,&quot;ProxyPorts&quot;:[443]}]</para>
        /// </summary>
        [NameInMap("ProxyTypes")]
        [Validation(Required=false)]
        public string ProxyTypes { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.xxx.xxx.1</para>
        /// </summary>
        [NameInMap("RealServers")]
        [Validation(Required=false)]
        public List<string> RealServers { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the instance belongs in Resource Management. This parameter is empty by default, which indicates that the instance belongs to the default resource group.</para>
        /// <para>For more information about resource groups, see <a href="https://help.aliyun.com/document_detail/94485.html">Create a resource group</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm2pz25js****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The address type of the origin server. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: IP address.</description></item>
        /// <item><description><b>1</b>: domain name. Use the domain name of the origin server if you deploy proxies, such as Web Application Firewall (WAF), between the origin server and the Anti-DDoS Pro or Anti-DDoS Premium instance. If you use the domain name, you must enter the address of the proxy, such as the CNAME of WAF.</description></item>
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
