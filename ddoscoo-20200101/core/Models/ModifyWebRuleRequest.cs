// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class ModifyWebRuleRequest : TeaModel {
        /// <summary>
        /// <para>The domain name of the website business to operate.</para>
        /// <remarks>
        /// <para>The domain name must have a website forwarding rule configured. You can call <a href="https://help.aliyun.com/document_detail/91724.html">DescribeDomains</a> to query all domain names that have website forwarding rules configured.</para>
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
        /// <para>The HTTPS advanced settings, which take effect only when the website protocol type supports HTTPS (<b>ProxyType</b> includes <b>https</b>). This parameter is a string converted from a JSON struct that contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Http2https</b>: Integer type | Optional | Specifies whether to enable the HTTPS force redirect feature. Valid values: <b>0</b> (disabled) | <b>1</b> (enabled). Default value: 0 (disabled).</para>
        /// <para>This is applicable when your website supports both HTTP and HTTPS protocols. After this setting is enabled, all HTTP requests will be forcibly converted to HTTPS requests and redirected to port 443 by default.</para>
        /// </description></item>
        /// <item><description><para><b>Https2http</b>: Integer type | Optional | Specifies whether to enable the HTTP back-to-origin feature. Valid values: <b>0</b> (disabled) | <b>1</b> (enabled). Default value: 0 (disabled).</para>
        /// <para>This is applicable when your website does not support HTTPS back-to-origin. After this setting is enabled, all HTTPS protocol requests will be forwarded to the origin through HTTP (Websockets protocol requests will be forwarded through Websocket), and the default back-to-origin port is 80.</para>
        /// </description></item>
        /// <item><description><para><b>Http2</b>: Integer type | Optional | Specifies whether to enable the HTTP2.0 protocol type. Valid values: <b>0</b> (disabled) | <b>1</b> (enabled). Default value: 0 (disabled).</para>
        /// <para>After this setting is enabled, the protocol version is HTTP2.0.</para>
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
        /// <para>The list of Anti-DDoS Proxy instance IDs to associate. You can associate up to 100 instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ddoscoo-cn-mp91j1ao****</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// <para>The protocol information of the website forwarding rule. This parameter is a string converted from a JSON array. Each element in the JSON array is a JSON struct that contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><para><b>ProxyType</b>: String type | Required | The website protocol type. Valid values: <b>http</b> | <b>https</b> | <b>websocket</b> | <b>websockets</b>.</para>
        /// </description></item>
        /// <item><description><para><b>ProxyPorts</b>: array type | Required | The port numbers corresponding to the protocol.</para>
        /// </description></item>
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
        /// <para>The list of origin server addresses.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.xxx.xxx.1</para>
        /// </summary>
        [NameInMap("RealServers")]
        [Validation(Required=false)]
        public List<string> RealServers { get; set; }

        /// <summary>
        /// <para>The resource group ID of the Anti-DDoS Proxy instance in Resource Management. Default value: empty, which indicates that the instance belongs to the default resource group.</para>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/94485.html">Create a resource group</a>.</para>
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
        /// <item><description><para><b>0</b>: indicates the IP address of the origin server.</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: indicates the domain name of the origin server. This is typically applicable to scenarios where other proxy services (such as WAF) are deployed between the origin server and Anti-DDoS Proxy, specifically referring to the redirect address of the proxy service (such as the WAF CNAME address).</para>
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
