/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200630.Models
{
    public class CreateCertificateWithExtensionRequest : TeaModel {
        [NameInMap("AfterTime")]
        [Validation(Required=false)]
        public long? AfterTime { get; set; }

        [NameInMap("AlgorithmKeySize")]
        [Validation(Required=false)]
        public int? AlgorithmKeySize { get; set; }

        [NameInMap("AliasName")]
        [Validation(Required=false)]
        public string AliasName { get; set; }

        [NameInMap("AppendCrl")]
        [Validation(Required=false)]
        public bool? AppendCrl { get; set; }

        [NameInMap("BasicConstraintsCritical")]
        [Validation(Required=false)]
        public bool? BasicConstraintsCritical { get; set; }

        [NameInMap("BeforeTime")]
        [Validation(Required=false)]
        public long? BeforeTime { get; set; }

        [NameInMap("CertType")]
        [Validation(Required=false)]
        public string CertType { get; set; }

        [NameInMap("CommonName")]
        [Validation(Required=false)]
        public string CommonName { get; set; }

        [NameInMap("CountryCode")]
        [Validation(Required=false)]
        public string CountryCode { get; set; }

        [NameInMap("CsrPemString")]
        [Validation(Required=false)]
        public string CsrPemString { get; set; }

        [NameInMap("Locality")]
        [Validation(Required=false)]
        public string Locality { get; set; }

        [NameInMap("Organization")]
        [Validation(Required=false)]
        public string Organization { get; set; }

        [NameInMap("OrganizationUnit")]
        [Validation(Required=false)]
        public string OrganizationUnit { get; set; }

        [NameInMap("ParentIdentifier")]
        [Validation(Required=false)]
        public string ParentIdentifier { get; set; }

        [NameInMap("Sans")]
        [Validation(Required=false)]
        public string Sans { get; set; }

        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

    }

}
