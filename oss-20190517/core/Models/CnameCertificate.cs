// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class CnameCertificate : TeaModel {
        [NameInMap("CertId")]
        [Validation(Required=false)]
        public string CertId { get; set; }

        [NameInMap("CreationDate")]
        [Validation(Required=false)]
        public string CreationDate { get; set; }

        [NameInMap("Fingerprint")]
        [Validation(Required=false)]
        public string Fingerprint { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("ValidEndDate")]
        [Validation(Required=false)]
        public string ValidEndDate { get; set; }

        [NameInMap("ValidStartDate")]
        [Validation(Required=false)]
        public string ValidStartDate { get; set; }

    }

}
