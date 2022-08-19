// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class DissociateAdditionalCertificatesFromListenerRequest : TeaModel {
        [NameInMap("Certificates")]
        [Validation(Required=false)]
        public List<DissociateAdditionalCertificatesFromListenerRequestCertificates> Certificates { get; set; }
        public class DissociateAdditionalCertificatesFromListenerRequestCertificates : TeaModel {
            [NameInMap("CertificateId")]
            [Validation(Required=false)]
            public string CertificateId { get; set; }

        }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        [NameInMap("ListenerId")]
        [Validation(Required=false)]
        public string ListenerId { get; set; }

    }

}
