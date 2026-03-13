// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class UpdateCustomDomainInput : TeaModel {
        /// <summary>
        /// <para>The configuration of permission authentication.</para>
        /// </summary>
        [NameInMap("authConfig")]
        [Validation(Required=false)]
        public AuthConfig AuthConfig { get; set; }

        /// <summary>
        /// <para>The configuration of the HTTPS certificate.</para>
        /// </summary>
        [NameInMap("certConfig")]
        [Validation(Required=false)]
        public CertConfig CertConfig { get; set; }

        [NameInMap("corsConfig")]
        [Validation(Required=false)]
        public CORSConfig CorsConfig { get; set; }

        /// <summary>
        /// <para>The protocol type that is supported by the custom domain name. Valid values: HTTP HTTPS HTTP,HTTPS</para>
        /// 
        /// <b>Example:</b>
        /// <para>HTTP</para>
        /// </summary>
        [NameInMap("protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        /// <summary>
        /// <para>The route table that maps paths to functions when the function is invoked by using the custom domain name.</para>
        /// </summary>
        [NameInMap("routeConfig")]
        [Validation(Required=false)]
        public RouteConfig RouteConfig { get; set; }

        /// <summary>
        /// <para>The Transport Layer Security (TLS) configuration.</para>
        /// </summary>
        [NameInMap("tlsConfig")]
        [Validation(Required=false)]
        public TLSConfig TlsConfig { get; set; }

        /// <summary>
        /// <para>The Web Application Firewall (WAF) configuration.</para>
        /// </summary>
        [NameInMap("wafConfig")]
        [Validation(Required=false)]
        public WAFConfig WafConfig { get; set; }

    }

}
