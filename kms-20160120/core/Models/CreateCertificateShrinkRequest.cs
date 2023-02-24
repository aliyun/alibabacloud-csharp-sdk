// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class CreateCertificateShrinkRequest : TeaModel {
        /// <summary>
        /// Specifies whether the private key of the certificate can be exported for use. Valid values:
        /// 
        /// *   true: The private key of the certificate can be exported for use. This is the default value.
        /// *   false: The private key of the certificate cannot be exported for use. We recommend that you set this parameter to false to protect keys with a higher security level.
        /// </summary>
        [NameInMap("ExportablePrivateKey")]
        [Validation(Required=false)]
        public bool? ExportablePrivateKey { get; set; }

        /// <summary>
        /// The type of the key. Valid values:
        /// 
        /// *   RSA\_2048
        /// *   EC_P256
        /// *   EC_SM2
        /// </summary>
        [NameInMap("KeySpec")]
        [Validation(Required=false)]
        public string KeySpec { get; set; }

        /// <summary>
        /// The certificate subject, which is the owner of the certificate.
        /// 
        /// Specify the value in the distinguished name (DN) format, as defined in [RFC 2253](https://tools.ietf.org/html/rfc2253?spm=a2c4g.11186623.2.13.265f1a1cGFCn3Q). A DN is a sequence of relative distinguished names (RDNs).
        /// 
        /// RDNs are key-value pairs in the format of `attribute1=value1,attribute2=value2`. Separate multiple RDNs with commas (,).
        /// 
        /// The Subject parameter consists of the following fields:
        /// 
        /// *   CN: required. The name of the certificate subject.
        /// *   C: required. The two-character country or region code in the [ISO 3166-1](https://www.iso.org/obp/ui/#search/code/) standard. For example, CN indicates China.
        /// *   O: required. The legal name of the enterprise, company, organization, or institution.
        /// *   OU: required. The name of the department.
        /// *   ST: optional. The name of the province, municipality, autonomous region, or special administrative region.
        /// *   L: optional. The name of the city.
        /// </summary>
        [NameInMap("Subject")]
        [Validation(Required=false)]
        public string Subject { get; set; }

        /// <summary>
        /// The subject alternative names.
        /// 
        /// A domain name list is supported. A maximum of 10 domain names are supported.
        /// </summary>
        [NameInMap("SubjectAlternativeNames")]
        [Validation(Required=false)]
        public string SubjectAlternativeNamesShrink { get; set; }

    }

}
