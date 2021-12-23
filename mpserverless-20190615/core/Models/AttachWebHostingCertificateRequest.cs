// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPServerless20190615.Models
{
    public class AttachWebHostingCertificateRequest : TeaModel {
        [NameInMap("CertName")]
        [Validation(Required=false)]
        public string CertName { get; set; }

        [NameInMap("CertType")]
        [Validation(Required=false)]
        public string CertType { get; set; }

        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        [NameInMap("PrivateKey")]
        [Validation(Required=false)]
        public string PrivateKey { get; set; }

        [NameInMap("ServerCertificate")]
        [Validation(Required=false)]
        public string ServerCertificate { get; set; }

        [NameInMap("SpaceId")]
        [Validation(Required=false)]
        public string SpaceId { get; set; }

    }

}
