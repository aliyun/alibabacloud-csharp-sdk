// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class ListCustomDomainsResponseBody : TeaModel {
        /// <summary>
        /// The information about custom domain names.
        /// </summary>
        [NameInMap("customDomains")]
        [Validation(Required=false)]
        public List<ListCustomDomainsResponseBodyCustomDomains> CustomDomains { get; set; }
        public class ListCustomDomainsResponseBodyCustomDomains : TeaModel {
            /// <summary>
            /// The ID of the account.
            /// </summary>
            [NameInMap("accountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <summary>
            /// The version of the API.
            /// </summary>
            [NameInMap("apiVersion")]
            [Validation(Required=false)]
            public string ApiVersion { get; set; }

            /// <summary>
            /// The configurations of the HTTPS certificate.
            /// </summary>
            [NameInMap("certConfig")]
            [Validation(Required=false)]
            public CertConfig CertConfig { get; set; }

            /// <summary>
            /// The time when the domain name was added.
            /// </summary>
            [NameInMap("createdTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            /// <summary>
            /// The domain name.
            /// </summary>
            [NameInMap("domainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            /// <summary>
            /// The time when the domain name was last modified.
            /// </summary>
            [NameInMap("lastModifiedTime")]
            [Validation(Required=false)]
            public string LastModifiedTime { get; set; }

            /// <summary>
            /// The protocol types supported by the domain name. Valid values: 
            /// 
            /// - **HTTP**: Only HTTP is supported. 
            /// - **HTTPS**: Only HTTPS is supported. 
            /// - **HTTP,HTTPS**: Both HTTP and HTTPS are supported.
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
            /// The configurations of the TLS.
            /// </summary>
            [NameInMap("tlsConfig")]
            [Validation(Required=false)]
            public TLSConfig TlsConfig { get; set; }

        }

        /// <summary>
        /// The token used to obtain more results. If the number of resources exceeds the limit, the nextToken parameter is returned. You can include the parameter in subsequent calls to obtain more results. You do not need to provide this parameter in the first call.
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
