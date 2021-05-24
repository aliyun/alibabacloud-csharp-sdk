// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class UploadCACertificateResponseBody : TeaModel {
        [NameInMap("CreateTimeStamp")]
        [Validation(Required=false)]
        public long? CreateTimeStamp { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        [NameInMap("Fingerprint")]
        [Validation(Required=false)]
        public string Fingerprint { get; set; }

        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("CommonName")]
        [Validation(Required=false)]
        public string CommonName { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("CACertificateName")]
        [Validation(Required=false)]
        public string CACertificateName { get; set; }

        [NameInMap("ExpireTimeStamp")]
        [Validation(Required=false)]
        public long? ExpireTimeStamp { get; set; }

        [NameInMap("CACertificateId")]
        [Validation(Required=false)]
        public string CACertificateId { get; set; }

    }

}
