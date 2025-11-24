// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeIstioGatewayDomainsResponseBody : TeaModel {
        /// <summary>
        /// <para>The domain names that are exposed by the ASM gateway.</para>
        /// </summary>
        [NameInMap("GatewaySecretDetails")]
        [Validation(Required=false)]
        public List<DescribeIstioGatewayDomainsResponseBodyGatewaySecretDetails> GatewaySecretDetails { get; set; }
        public class DescribeIstioGatewayDomainsResponseBodyGatewaySecretDetails : TeaModel {
            /// <summary>
            /// <para>The name of the secret that contains the Transport Layer Security (TLS) certificate and certificate authority (CA) certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bookinfo-secret</para>
            /// </summary>
            [NameInMap("CredentialName")]
            [Validation(Required=false)]
            public string CredentialName { get; set; }

            /// <summary>
            /// <para>The details of the domain name in the JSON format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{   &quot;servers&quot;: [     {       &quot;port&quot;: {         &quot;number&quot;: 27018,         &quot;name&quot;: &quot;mongo&quot;,         &quot;protocol&quot;: &quot;MONGO&quot;       },       &quot;hosts&quot;: [         &quot;*&quot;       ]     }   ] }</para>
            /// </summary>
            [NameInMap("Detail")]
            [Validation(Required=false)]
            public string Detail { get; set; }

            /// <summary>
            /// <para>The list of domain names.</para>
            /// </summary>
            [NameInMap("Domains")]
            [Validation(Required=false)]
            public List<string> Domains { get; set; }

            /// <summary>
            /// <para>The name of the Istio gateway.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ingressgateway</para>
            /// </summary>
            [NameInMap("GatewayCRName")]
            [Validation(Required=false)]
            public string GatewayCRName { get; set; }

            /// <summary>
            /// <para>The namespace in which the ASM gateway resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// <para>The port name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>https-demo</para>
            /// </summary>
            [NameInMap("PortName")]
            [Validation(Required=false)]
            public string PortName { get; set; }

            /// <summary>
            /// <para>The type of the protocol. Valid values: <c>HTTP</c>, <c>HTTPS</c>, <c>GRPC</c>, <c>HTTP2</c>, <c>MONGO</c>, <c>TCP</c>, and <c>TLS</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HTTPS</para>
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>31d3a0f0-07ed-4f6e-9004-1804498c****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
