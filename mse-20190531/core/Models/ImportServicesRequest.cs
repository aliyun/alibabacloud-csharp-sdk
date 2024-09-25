// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ImportServicesRequest : TeaModel {
        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>zh: Chinese</description></item>
        /// <item><description>en: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        [NameInMap("FcAlias")]
        [Validation(Required=false)]
        public string FcAlias { get; set; }

        [NameInMap("FcServiceName")]
        [Validation(Required=false)]
        public string FcServiceName { get; set; }

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
        /// <para>The information about services.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DNS</para>
        /// </summary>
        [NameInMap("ServiceList")]
        [Validation(Required=false)]
        public List<ImportServicesRequestServiceList> ServiceList { get; set; }
        public class ImportServicesRequestServiceList : TeaModel {
            /// <summary>
            /// <para>The group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// <para>The IP addresses of the service.</para>
            /// </summary>
            [NameInMap("Ips")]
            [Validation(Required=false)]
            public List<string> Ips { get; set; }

            /// <summary>
            /// <para>The name of the service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The namespace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>public</para>
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// <para>The port of the service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8080</para>
            /// </summary>
            [NameInMap("ServicePort")]
            [Validation(Required=false)]
            public long? ServicePort { get; set; }

            /// <summary>
            /// <para>The protocol of the service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>GRPC, HTTP</para>
            /// </summary>
            [NameInMap("ServiceProtocol")]
            [Validation(Required=false)]
            public string ServiceProtocol { get; set; }

        }

        /// <summary>
        /// <para>The service source. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>MSE: MSE Nacos instance</description></item>
        /// <item><description>K8s: ACK cluster</description></item>
        /// <item><description>VIP: fixed address</description></item>
        /// <item><description>DNS: DNS domain</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DNS</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>The Transport Layer Security (TLS) settings. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>mode: TLS mode</description></item>
        /// <item><description>certId: certificate ID</description></item>
        /// <item><description>caCertId: CA certificate ID</description></item>
        /// <item><description>caCertContent: CA certificate public key</description></item>
        /// <item><description>sni: service name identification</description></item>
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
