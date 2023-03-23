// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200630.Models
{
    public class CreateCustomCertificateRequest : TeaModel {
        [NameInMap("ApiPassthrough")]
        [Validation(Required=false)]
        public CreateCustomCertificateRequestApiPassthrough ApiPassthrough { get; set; }
        public class CreateCustomCertificateRequestApiPassthrough : TeaModel {
            [NameInMap("Extensions")]
            [Validation(Required=false)]
            public CreateCustomCertificateRequestApiPassthroughExtensions Extensions { get; set; }
            public class CreateCustomCertificateRequestApiPassthroughExtensions : TeaModel {
                [NameInMap("ExtendedKeyUsages")]
                [Validation(Required=false)]
                public List<string> ExtendedKeyUsages { get; set; }

                [NameInMap("KeyUsage")]
                [Validation(Required=false)]
                public CreateCustomCertificateRequestApiPassthroughExtensionsKeyUsage KeyUsage { get; set; }
                public class CreateCustomCertificateRequestApiPassthroughExtensionsKeyUsage : TeaModel {
                    [NameInMap("ContentCommitment")]
                    [Validation(Required=false)]
                    public bool? ContentCommitment { get; set; }

                    [NameInMap("DataEncipherment")]
                    [Validation(Required=false)]
                    public bool? DataEncipherment { get; set; }

                    [NameInMap("DecipherOnly")]
                    [Validation(Required=false)]
                    public bool? DecipherOnly { get; set; }

                    [NameInMap("DigitalSignature")]
                    [Validation(Required=false)]
                    public bool? DigitalSignature { get; set; }

                    [NameInMap("EncipherOnly")]
                    [Validation(Required=false)]
                    public bool? EncipherOnly { get; set; }

                    [NameInMap("KeyAgreement")]
                    [Validation(Required=false)]
                    public bool? KeyAgreement { get; set; }

                    [NameInMap("KeyEncipherment")]
                    [Validation(Required=false)]
                    public bool? KeyEncipherment { get; set; }

                    [NameInMap("NonRepudiation")]
                    [Validation(Required=false)]
                    public bool? NonRepudiation { get; set; }

                }

                [NameInMap("SubjectAlternativeNames")]
                [Validation(Required=false)]
                public List<CreateCustomCertificateRequestApiPassthroughExtensionsSubjectAlternativeNames> SubjectAlternativeNames { get; set; }
                public class CreateCustomCertificateRequestApiPassthroughExtensionsSubjectAlternativeNames : TeaModel {
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

            [NameInMap("Subject")]
            [Validation(Required=false)]
            public CreateCustomCertificateRequestApiPassthroughSubject Subject { get; set; }
            public class CreateCustomCertificateRequestApiPassthroughSubject : TeaModel {
                [NameInMap("CommonName")]
                [Validation(Required=false)]
                public string CommonName { get; set; }

                [NameInMap("Country")]
                [Validation(Required=false)]
                public string Country { get; set; }

                [NameInMap("Locality")]
                [Validation(Required=false)]
                public string Locality { get; set; }

                [NameInMap("Organization")]
                [Validation(Required=false)]
                public string Organization { get; set; }

                [NameInMap("OrganizationUnit")]
                [Validation(Required=false)]
                public string OrganizationUnit { get; set; }

                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

            }

        }

        [NameInMap("Csr")]
        [Validation(Required=false)]
        public string Csr { get; set; }

        [NameInMap("Immediately")]
        [Validation(Required=false)]
        public int? Immediately { get; set; }

        [NameInMap("ParentIdentifier")]
        [Validation(Required=false)]
        public string ParentIdentifier { get; set; }

        [NameInMap("Validity")]
        [Validation(Required=false)]
        public string Validity { get; set; }

    }

}
