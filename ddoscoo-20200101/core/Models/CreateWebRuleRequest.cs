// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class CreateWebRuleRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the associated defense. This parameter applies to scenarios in which other cloud services, such as Object Storage Service (OSS), are integrated with Anti-DDoS Pro or Anti-DDoS Premium.</para>
        /// <remarks>
        /// <para>This parameter is in internal preview. Do not use this parameter.</para>
        /// </remarks>
        /// <para>For example, if you integrate OSS with Anti-DDoS Pro or Anti-DDoS Premium, Anti-DDoS Pro or Anti-DDoS Premium allocates an IP address pool for the OSS production account. Each IP address corresponds to a unique defense ID. A defense ID is a CNAME, which is automatically resolved to the IP address of the required Anti-DDoS Pro or Anti-DDoS Premium instance. A defense ID can be resolved to the same IP address to facilitate scheduling.</para>
        /// <remarks>
        /// <para>You can specify only one of the following parameters: <b>InstanceIds</b> and <b>DefenseId</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>testid</para>
        /// </summary>
        [NameInMap("DefenseId")]
        [Validation(Required=false)]
        public string DefenseId { get; set; }

        /// <summary>
        /// <para>The domain name of the website that you want to add to the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.aliyundoc.com</para>
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
        /// <item><description><para><b>Http2</b>: specifies whether to turn on Enable HTTP/2. This field is optional and must be an integer. Valid values: <b>0</b> and <b>1</b>. The value 0 indicates that Enable HTTP/2 is turned off. The value 1 indicates that Enable HTTP/2 is turned on. The default value is 0.</para>
        /// <para>After you turn on Enable HTTP/2, the protocol type is HTTP/2.</para>
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
        /// 
        /// <b>Example:</b>
        /// <para>ddoscoo-cn-mp91j1ao****</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

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
        /// <item><description><b>0</b>: IP address</description></item>
        /// <item><description><b>1</b>: domain name The domain name of the origin server is returned if you deploy proxies, such as Web Application Firewall (WAF), between the origin server and the instance. In this case, the address of the proxy, such as the CNAME provided by WAF, is returned.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("RsType")]
        [Validation(Required=false)]
        public int? RsType { get; set; }

        /// <summary>
        /// <para>The details of the forwarding rule. The value is a string that consists of JSON arrays. Each element in a JSON array is a JSON struct that contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><para><b>ProxyRules</b>: the information about the origin server. The information includes the port number and IP address. This field is required and must be a JSON array. Each element in a JSON array is a JSON struct that contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><b>ProxyPort</b>: the port number. This field is required and must be an integer.</description></item>
        /// <item><description><b>RealServers</b>: the IP address. This field is required and must be a string array.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>ProxyType</b>: the protocol type. This field is required and must be a string. Valid values: <b>http</b>, <b>https</b>, <b>websocket</b>, and <b>websockets</b>.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;ProxyRules&quot;:[{&quot;ProxyPort&quot;:443,&quot;RealServers&quot;:[&quot;192.1.XX.XX&quot;]}],&quot;ProxyType&quot;:&quot;https&quot;}]</para>
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public string Rules { get; set; }

    }

}
