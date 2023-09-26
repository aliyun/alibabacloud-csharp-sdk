// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160701.Models
{
    public class SetDomainCertificateRequest : TeaModel {
        [NameInMap("CaCertificateBody")]
        [Validation(Required=false)]
        public string CaCertificateBody { get; set; }

        [NameInMap("CertificateBody")]
        [Validation(Required=false)]
        public string CertificateBody { get; set; }

        [NameInMap("CertificateName")]
        [Validation(Required=false)]
        public string CertificateName { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        [NameInMap("PrivateKey")]
        [Validation(Required=false)]
        public string PrivateKey { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
