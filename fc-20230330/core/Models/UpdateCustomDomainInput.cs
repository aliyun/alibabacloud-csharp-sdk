// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class UpdateCustomDomainInput : TeaModel {
        /// <summary>
        /// <para>The authentication configuration.</para>
        /// </summary>
        [NameInMap("authConfig")]
        [Validation(Required=false)]
        public AuthConfig AuthConfig { get; set; }

        /// <summary>
        /// <para>The HTTPS certificate information.</para>
        /// </summary>
        [NameInMap("certConfig")]
        [Validation(Required=false)]
        public CertConfig CertConfig { get; set; }

        /// <summary>
        /// <para>The CORS configuration.</para>
        /// </summary>
        [NameInMap("corsConfig")]
        [Validation(Required=false)]
        public CORSConfig CorsConfig { get; set; }

        /// <summary>
        /// <para>The protocol type supported by the domain name. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>HTTP: Only the HTTP protocol is supported.</description></item>
        /// <item><description>HTTPS: Only the HTTPS protocol is supported.</description></item>
        /// <item><description>HTTP,HTTPS: Both HTTP and HTTPS protocols are supported.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>HTTP</para>
        /// </summary>
        [NameInMap("protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        /// <summary>
        /// <para>The route table that maps paths to functions when the custom domain name is accessed.</para>
        /// </summary>
        [NameInMap("routeConfig")]
        [Validation(Required=false)]
        public RouteConfig RouteConfig { get; set; }

        /// <summary>
        /// <para>The TLS configuration information.</para>
        /// </summary>
        [NameInMap("tlsConfig")]
        [Validation(Required=false)]
        public TLSConfig TlsConfig { get; set; }

        /// <summary>
        /// <para>The Web Application Protection configuration information.</para>
        /// </summary>
        [NameInMap("wafConfig")]
        [Validation(Required=false)]
        public WAFConfig WafConfig { get; set; }

    }

}
