// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class UpdateServiceSourceRequest : TeaModel {
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
        /// <para>The address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c9ad2a0717032427e920754e25b49e3b5</para>
        /// </summary>
        [NameInMap("Address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        /// <summary>
        /// <para>The ID of the gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>429</para>
        /// </summary>
        [NameInMap("GatewayId")]
        [Validation(Required=false)]
        public long? GatewayId { get; set; }

        /// <summary>
        /// <para>The unique ID of the gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-cdd1bb9bfb8341e9805f931a3ba1f4c6</para>
        /// </summary>
        [NameInMap("GatewayUniqueId")]
        [Validation(Required=false)]
        public string GatewayUniqueId { get; set; }

        /// <summary>
        /// <para>The ID of the service source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>63</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The configurations of Ingress resources.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("IngressOptionsRequest")]
        [Validation(Required=false)]
        public UpdateServiceSourceRequestIngressOptionsRequest IngressOptionsRequest { get; set; }
        public class UpdateServiceSourceRequestIngressOptionsRequest : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable Ingress.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableIngress")]
            [Validation(Required=false)]
            public bool? EnableIngress { get; set; }

            /// <summary>
            /// <para>Specifies whether to update the Ingress status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableStatus")]
            [Validation(Required=false)]
            public bool? EnableStatus { get; set; }

            /// <summary>
            /// <para>Specifies whether to monitor Ingress classes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>com.test.xxx</para>
            /// </summary>
            [NameInMap("IngressClass")]
            [Validation(Required=false)]
            public string IngressClass { get; set; }

            /// <summary>
            /// <para>The namespace whose resources you want to monitor.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("WatchNamespace")]
            [Validation(Required=false)]
            public string WatchNamespace { get; set; }

        }

        /// <summary>
        /// <para>The name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>istio</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>An array of service root paths.</para>
        /// </summary>
        [NameInMap("PathList")]
        [Validation(Required=false)]
        public List<string> PathList { get; set; }

        /// <summary>
        /// <para>The service source. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>K8s: ACK cluster.</description></item>
        /// <item><description>MSE: Nacos instance.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>K8s</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The type of the service source. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>K8s: ACK cluster.</description></item>
        /// <item><description>NACOS: Nacos instance.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>K8s</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
