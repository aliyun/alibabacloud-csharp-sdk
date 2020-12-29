// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDomainDnssecInfoResponseBody : TeaModel {
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Digest")]
        [Validation(Required=false)]
        public string Digest { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("PublicKey")]
        [Validation(Required=false)]
        public string PublicKey { get; set; }

        [NameInMap("DigestType")]
        [Validation(Required=false)]
        public string DigestType { get; set; }

        [NameInMap("DsRecord")]
        [Validation(Required=false)]
        public string DsRecord { get; set; }

        [NameInMap("KeyTag")]
        [Validation(Required=false)]
        public string KeyTag { get; set; }

        [NameInMap("Flags")]
        [Validation(Required=false)]
        public string Flags { get; set; }

        [NameInMap("Algorithm")]
        [Validation(Required=false)]
        public string Algorithm { get; set; }

    }

}
