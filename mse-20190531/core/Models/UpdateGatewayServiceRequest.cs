// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class UpdateGatewayServiceRequest : TeaModel {
        /// <summary>
        /// <para>The language in which you want the results to be displayed. Valid values: zh (default): Chinese. en: English.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>The list of Domain Name System (DNS) servers (for DNS domain name services only).</para>
        /// </summary>
        [NameInMap("DnsServerList")]
        [Validation(Required=false)]
        public List<string> DnsServerList { get; set; }

        /// <summary>
        /// <para>The gateway ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>501</para>
        /// </summary>
        [NameInMap("GatewayId")]
        [Validation(Required=false)]
        public long? GatewayId { get; set; }

        /// <summary>
        /// <para>The unique ID of the gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-c9bc5afd61014165bd58f621b491*****</para>
        /// </summary>
        [NameInMap("GatewayUniqueId")]
        [Validation(Required=false)]
        public string GatewayUniqueId { get; set; }

        /// <summary>
        /// <para>The service ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>322</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The address list of fixed address services or domain name list of Domain Name System (DNS) services.</para>
        /// </summary>
        [NameInMap("IpList")]
        [Validation(Required=false)]
        public List<string> IpList { get; set; }

        /// <summary>
        /// <para>The service name. This parameter is deprecated and cannot be modified. The value of this parameter must be the same as the current service name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The service port. Specify this parameter for DNS services.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("ServicePort")]
        [Validation(Required=false)]
        public string ServicePort { get; set; }

        /// <summary>
        /// <para>The service protocol.</para>
        /// <list type="bullet">
        /// <item><description><para>HTTP</para>
        /// </description></item>
        /// <item><description><para>HTTPS</para>
        /// </description></item>
        /// <item><description><para>HTTP2</para>
        /// </description></item>
        /// <item><description><para>GRPC</para>
        /// </description></item>
        /// <item><description><para>DUBBO</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>HTTP</para>
        /// </summary>
        [NameInMap("ServiceProtocol")]
        [Validation(Required=false)]
        public string ServiceProtocol { get; set; }

        /// <summary>
        /// <para>The Transport Layer Security (TLS) settings. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>mode: TLS mode</para>
        /// </description></item>
        /// <item><description><para>certId: certificate ID</para>
        /// </description></item>
        /// <item><description><para>caCertId: CA certificate ID</para>
        /// </description></item>
        /// <item><description><para>caCertContent: CA certificate public key</para>
        /// </description></item>
        /// <item><description><para>sni: service name identification</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///       &quot;mode&quot;: &quot;MUTUAL&quot;,
        ///       &quot;certId&quot;: &quot;1*****-cn-hangzhou&quot;,
        ///       &quot;caCertContent&quot;: &quot;123&quot;,
        ///       &quot;sni&quot;: &quot;ceshi&quot;
        /// }</para>
        /// </summary>
        [NameInMap("TlsSetting")]
        [Validation(Required=false)]
        public string TlsSetting { get; set; }

    }

}
