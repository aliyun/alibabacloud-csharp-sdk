// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class CustomDomain : TeaModel {
        /// <summary>
        /// <para>The ID of your Alibaba Cloud account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>186851234023****</para>
        /// </summary>
        [NameInMap("accountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// <para>The API version of Function Compute.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-03-30</para>
        /// </summary>
        [NameInMap("apiVersion")]
        [Validation(Required=false)]
        public string ApiVersion { get; set; }

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

        [NameInMap("corsConfig")]
        [Validation(Required=false)]
        public CORSConfig CorsConfig { get; set; }

        /// <summary>
        /// <para>The time when the custom domain name was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-03-30T08:02:19Z</para>
        /// </summary>
        [NameInMap("createdTime")]
        [Validation(Required=false)]
        public string CreatedTime { get; set; }

        /// <summary>
        /// <para>The domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("domainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("isE2B")]
        [Validation(Required=false)]
        public bool? IsE2B { get; set; }

        /// <summary>
        /// <para>The time when the custom domain name was last updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-03-30T08:02:19Z</para>
        /// </summary>
        [NameInMap("lastModifiedTime")]
        [Validation(Required=false)]
        public string LastModifiedTime { get; set; }

        /// <summary>
        /// <para>The protocol types supported by the domain name. HTTP: supports only the HTTP protocol. HTTPS: supports only the HTTPS protocol. HTTP,HTTPS: supports both the HTTP and HTTPS protocols.</para>
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
        /// <para>The number of subdomains.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("subdomainCount")]
        [Validation(Required=false)]
        public string SubdomainCount { get; set; }

        /// <summary>
        /// <para>The TLS configuration.</para>
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
