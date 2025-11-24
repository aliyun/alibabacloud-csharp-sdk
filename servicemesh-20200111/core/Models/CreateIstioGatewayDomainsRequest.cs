// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class CreateIstioGatewayDomainsRequest : TeaModel {
        /// <summary>
        /// <para>The name of the secret that contains the Transport Layer Security (TLS) certificate and certificate authority (CA) certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bookinfo-secret</para>
        /// </summary>
        [NameInMap("Credential")]
        [Validation(Required=false)]
        public string Credential { get; set; }

        /// <summary>
        /// <para>Specifies whether to forcibly use TLS to protect connection security.</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: forcibly uses TLS to protect connection security.</description></item>
        /// <item><description><c>false</c>: does not forcibly use TLS to protect connection security.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ForceHttps")]
        [Validation(Required=false)]
        public bool? ForceHttps { get; set; }

        /// <summary>
        /// <para>The one or more domain names that are exposed by the ASM gateway. Separate multiple domain names with commas (,).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com,demo.com</para>
        /// </summary>
        [NameInMap("Hosts")]
        [Validation(Required=false)]
        public string Hosts { get; set; }

        /// <summary>
        /// <para>The name of the ASM gateway.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ingressgateway</para>
        /// </summary>
        [NameInMap("IstioGatewayName")]
        [Validation(Required=false)]
        public string IstioGatewayName { get; set; }

        /// <summary>
        /// <para>The maximum number of ASM gateways to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Limit")]
        [Validation(Required=false)]
        public string Limit { get; set; }

        /// <summary>
        /// <para>The name of the namespace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The port that is provided by the ASM gateway.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>443</para>
        /// </summary>
        [NameInMap("Number")]
        [Validation(Required=false)]
        public int? Number { get; set; }

        /// <summary>
        /// <para>The name of the port.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>http-demo</para>
        /// </summary>
        [NameInMap("PortName")]
        [Validation(Required=false)]
        public string PortName { get; set; }

        /// <summary>
        /// <para>The type of the protocol. Valid values: <c>HTTP</c>, <c>HTTPS</c>, <c>GRPC</c>, <c>HTTP2</c>, <c>MONGO</c>, <c>TCP</c>, and <c>TLS</c>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HTTPS</para>
        /// </summary>
        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        /// <summary>
        /// <para>The ASM instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c08ba3fd1e6484b0f8cc1ad8fe10d****</para>
        /// </summary>
        [NameInMap("ServiceMeshId")]
        [Validation(Required=false)]
        public string ServiceMeshId { get; set; }

    }

}
