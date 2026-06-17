// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class TransportEncryptionInfo : TeaModel {
        [NameInMap("certificates")]
        [Validation(Required=false)]
        public List<TransportCertificateInfo> Certificates { get; set; }

        [NameInMap("deployError")]
        [Validation(Required=false)]
        public string DeployError { get; set; }

        [NameInMap("deployStatus")]
        [Validation(Required=false)]
        public string DeployStatus { get; set; }

        [NameInMap("http2Enabled")]
        [Validation(Required=false)]
        public bool? Http2Enabled { get; set; }

        [NameInMap("tlsPolicy")]
        [Validation(Required=false)]
        public string TlsPolicy { get; set; }

    }

}
