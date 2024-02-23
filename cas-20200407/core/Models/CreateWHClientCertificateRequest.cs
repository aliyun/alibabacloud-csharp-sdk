// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class CreateWHClientCertificateRequest : TeaModel {
        [NameInMap("AfterTime")]
        [Validation(Required=false)]
        public long? AfterTime { get; set; }

        [NameInMap("Algorithm")]
        [Validation(Required=false)]
        public string Algorithm { get; set; }

        [NameInMap("BeforeTime")]
        [Validation(Required=false)]
        public long? BeforeTime { get; set; }

        [NameInMap("CommonName")]
        [Validation(Required=false)]
        public string CommonName { get; set; }

        [NameInMap("Country")]
        [Validation(Required=false)]
        public string Country { get; set; }

        [NameInMap("Csr")]
        [Validation(Required=false)]
        public string Csr { get; set; }

        [NameInMap("Days")]
        [Validation(Required=false)]
        public long? Days { get; set; }

        [NameInMap("Immediately")]
        [Validation(Required=false)]
        public long? Immediately { get; set; }

        [NameInMap("Locality")]
        [Validation(Required=false)]
        public string Locality { get; set; }

        [NameInMap("Months")]
        [Validation(Required=false)]
        public long? Months { get; set; }

        [NameInMap("Organization")]
        [Validation(Required=false)]
        public string Organization { get; set; }

        [NameInMap("OrganizationUnit")]
        [Validation(Required=false)]
        public string OrganizationUnit { get; set; }

        [NameInMap("ParentIdentifier")]
        [Validation(Required=false)]
        public string ParentIdentifier { get; set; }

        [NameInMap("SanType")]
        [Validation(Required=false)]
        public long? SanType { get; set; }

        [NameInMap("SanValue")]
        [Validation(Required=false)]
        public string SanValue { get; set; }

        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        [NameInMap("Years")]
        [Validation(Required=false)]
        public long? Years { get; set; }

    }

}
