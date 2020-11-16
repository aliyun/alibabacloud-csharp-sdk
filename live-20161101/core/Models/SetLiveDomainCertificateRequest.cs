// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class SetLiveDomainCertificateRequest : TeaModel {
        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=true)]
        public string DomainName { get; set; }

        [NameInMap("CertName")]
        [Validation(Required=false)]
        public string CertName { get; set; }

        [NameInMap("CertType")]
        [Validation(Required=false)]
        public string CertType { get; set; }

        [NameInMap("SSLProtocol")]
        [Validation(Required=true)]
        public string SSLProtocol { get; set; }

        [NameInMap("SSLPub")]
        [Validation(Required=false)]
        public string SSLPub { get; set; }

        [NameInMap("SSLPri")]
        [Validation(Required=false)]
        public string SSLPri { get; set; }

        [NameInMap("ForceSet")]
        [Validation(Required=false)]
        public string ForceSet { get; set; }

    }

}
