// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class CreateWebRuleRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the protection rule to associate. This parameter is used when an Alibaba Cloud service, such as Object Storage Service (OSS), is integrated with an Anti-DDoS instance.</para>
        /// <remarks>
        /// <para>This parameter is for internal use. Do not use this parameter.</para>
        /// </remarks>
        /// <para>For example, if your OSS is integrated with an Anti-DDoS Proxy instance, the instance allocates a resource pool of IP addresses to the OSS tenant account. Each IP address has a unique protection ID. The protection ID is a CNAME that resolves to the IP address of the Anti-DDoS instance by default. You can resolve the CNAME to an IP address. This lets you reuse the IP address for flexible scheduling.</para>
        /// <remarks>
        /// <para>You cannot specify both <b>InstanceIds</b> and <b>DefenseId</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>testid</para>
        /// </summary>
        [NameInMap("DefenseId")]
        [Validation(Required=false)]
        public string DefenseId { get; set; }

        /// <summary>
        /// <para>The domain name of the website to add to the Anti-DDoS Proxy instance for protection.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.aliyundoc.com</para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>The advanced HTTPS settings. This parameter takes effect only when the value of <b>ProxyType</b> includes <b>https</b>. This parameter is a JSON string. The value is a JSON object that contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Http2https</b>: This field is an integer. Optional. Specifies whether to forcibly redirect HTTP requests to HTTPS requests. Valid values: <b>0</b> (disabled) and <b>1</b> (enabled). The default value is 0.</para>
        /// <para>This setting is available when your website supports both HTTP and HTTPS. If you enable this setting, all HTTP requests are redirected to HTTPS requests over port 443.</para>
        /// </description></item>
        /// <item><description><para><b>Https2http</b>: This field is an integer. Optional. Specifies whether to enable HTTP back-to-origin. Valid values: <b>0</b> (disabled) and <b>1</b> (enabled). The default value is 0.</para>
        /// <para>This setting applies to websites that do not support HTTPS back-to-origin. If you enable this setting, all HTTPS requests are sent to the origin server over HTTP on port 80 by default. All WebSockets requests are sent to the origin server over WebSocket.</para>
        /// </description></item>
        /// <item><description><para><b>Http2</b>: This field is an integer. Optional. Specifies whether to enable HTTP/2. Valid values: <b>0</b> (disabled) and <b>1</b> (enabled). The default value is 0.</para>
        /// <para>If you enable this setting, HTTP/2 is used.</para>
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
        /// <para>The IDs of the Anti-DDoS Proxy instances to associate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ddoscoo-cn-mp91j1ao****</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the Anti-DDoS Proxy instance belongs in Resource Management. If you leave this parameter empty, the instance belongs to the default resource group.</para>
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
        /// <item><description><para><b>0</b>: IP address.</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: domain name. This value is typically used when a proxy service, such as Web Application Firewall (WAF), is deployed between the origin server and the Anti-DDoS Proxy instance. The domain name is the back-to-origin address of the proxy service, such as the canonical name (CNAME) of WAF.</para>
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

        /// <summary>
        /// <para>The details of the forwarding rule, in a JSON string format. The value is an array of objects. Each object contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><para><b>ProxyRules</b>: This field is a JSON array. Required. The information about the origin server, including the port number and server address. Each object in the array contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><para><b>ProxyPort</b>: This field is an integer. Required. The port number that is used by the protocol.</para>
        /// </description></item>
        /// <item><description><para><b>RealServers</b>: This field is a string array. Required. The addresses of the origin servers.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>ProxyType</b>: This field is a string. Required. The protocol of the website. Valid values: <b>http</b>, <b>https</b>, <b>websocket</b>, and <b>websockets</b>.</para>
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
