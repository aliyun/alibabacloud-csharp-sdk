// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ImportServicesShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>zh: Chinese.</description></item>
        /// <item><description>en: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>The Function Compute service alias. This parameter is required when the service source is Function Compute.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-alias</para>
        /// </summary>
        [NameInMap("FcAlias")]
        [Validation(Required=false)]
        public string FcAlias { get; set; }

        /// <summary>
        /// <para>The Function Compute service name. This parameter is required when the service source is Function Compute.</para>
        /// 
        /// <b>Example:</b>
        /// <para>guide</para>
        /// </summary>
        [NameInMap("FcServiceName")]
        [Validation(Required=false)]
        public string FcServiceName { get; set; }

        /// <summary>
        /// <para>The Function Compute service version. This parameter is required when the service source is Function Compute.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LATEST</para>
        /// </summary>
        [NameInMap("FcVersion")]
        [Validation(Required=false)]
        public string FcVersion { get; set; }

        /// <summary>
        /// <para>The unique ID of the gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-77e1153db6e14c0a8b1fae20bcb89ca5</para>
        /// </summary>
        [NameInMap("GatewayUniqueId")]
        [Validation(Required=false)]
        public string GatewayUniqueId { get; set; }

        /// <summary>
        /// <para>The service list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DNS</para>
        /// </summary>
        [NameInMap("ServiceList")]
        [Validation(Required=false)]
        public string ServiceListShrink { get; set; }

        /// <summary>
        /// <para>The service source ID. This parameter is used when you add a service from a specified source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("SourceId")]
        [Validation(Required=false)]
        public long? SourceId { get; set; }

        /// <summary>
        /// <para>The service source. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>MSE: Microservices Engine (MSE Nacos).</description></item>
        /// <item><description>K8s: Container Service for Kubernetes (ACK).</description></item>
        /// <item><description>VIP: Fixed address.</description></item>
        /// <item><description>DNS: DNS domain name.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DNS</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>The TLS settings.</para>
        /// <list type="bullet">
        /// <item><description><para>TLS pattern: mode</para>
        /// </description></item>
        /// <item><description><para>Certificate ID: certId</para>
        /// </description></item>
        /// <item><description><para>CA certificate ID: caCertId</para>
        /// </description></item>
        /// <item><description><para>CA certificate public key: caCertContent</para>
        /// </description></item>
        /// <item><description><para>Service name identity: sni</para>
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
