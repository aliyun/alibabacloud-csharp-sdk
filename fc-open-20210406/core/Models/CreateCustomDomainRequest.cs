// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class CreateCustomDomainRequest : TeaModel {
        /// <summary>
        /// The configurations of the HTTPS certificate.
        /// </summary>
        [NameInMap("certConfig")]
        [Validation(Required=false)]
        public CertConfig CertConfig { get; set; }

        /// <summary>
        /// The domain name. Enter a custom domain name that has obtained an ICP filing in the Alibaba Cloud ICP Filing system, or a custom domain name whose ICP filing information includes Alibaba Cloud as a service provider.
        /// </summary>
        [NameInMap("domainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// The protocol types supported by the domain name. Valid values:
        /// 
        /// *   **HTTP**: Only HTTP is supported.
        /// *   **HTTPS**: Only HTTPS is supported.
        /// *   **HTTP,HTTPS**: HTTP and HTTPS are supported.
        /// </summary>
        [NameInMap("protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        /// <summary>
        /// The route table that maps the paths to functions when the functions are invoked by using the custom domain name.
        /// </summary>
        [NameInMap("routeConfig")]
        [Validation(Required=false)]
        public RouteConfig RouteConfig { get; set; }

        /// <summary>
        /// The Transport Layer Security (TLS) configuration.
        /// </summary>
        [NameInMap("tlsConfig")]
        [Validation(Required=false)]
        public TLSConfig TlsConfig { get; set; }

        /// <summary>
        /// The Web Application Firewall (WAF) configuration.
        /// </summary>
        [NameInMap("wafConfig")]
        [Validation(Required=false)]
        public WAFConfig WafConfig { get; set; }

    }

}
