// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class CustomDomain : TeaModel {
        [NameInMap("accountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        [NameInMap("apiVersion")]
        [Validation(Required=false)]
        public string ApiVersion { get; set; }

        [NameInMap("certConfig")]
        [Validation(Required=false)]
        public CertConfig CertConfig { get; set; }

        [NameInMap("createdTime")]
        [Validation(Required=false)]
        public string CreatedTime { get; set; }

        [NameInMap("domainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("keepFullPath")]
        [Validation(Required=false)]
        public bool? KeepFullPath { get; set; }

        [NameInMap("lastModifiedTime")]
        [Validation(Required=false)]
        public string LastModifiedTime { get; set; }

        [NameInMap("namespaceID")]
        [Validation(Required=false)]
        public string NamespaceID { get; set; }

        [NameInMap("protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("subdomainCount")]
        [Validation(Required=false)]
        public string SubdomainCount { get; set; }

        [NameInMap("tlsConfig")]
        [Validation(Required=false)]
        public TLSConfig TlsConfig { get; set; }

        [NameInMap("wafConfig")]
        [Validation(Required=false)]
        public WAFConfig WafConfig { get; set; }

    }

}
