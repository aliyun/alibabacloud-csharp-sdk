// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class CreateCustomDomainInput : TeaModel {
        [NameInMap("applicationName")]
        [Validation(Required=false)]
        public string ApplicationName { get; set; }

        [NameInMap("certConfig")]
        [Validation(Required=false)]
        public CertConfig CertConfig { get; set; }

        [NameInMap("domainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("keepFullPath")]
        [Validation(Required=false)]
        public bool? KeepFullPath { get; set; }

        [NameInMap("namespaceID")]
        [Validation(Required=false)]
        public string NamespaceID { get; set; }

        [NameInMap("protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        [NameInMap("tlsConfig")]
        [Validation(Required=false)]
        public TLSConfig TlsConfig { get; set; }

        [NameInMap("wafConfig")]
        [Validation(Required=false)]
        public WAFConfig WafConfig { get; set; }

    }

}
