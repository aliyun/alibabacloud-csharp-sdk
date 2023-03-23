// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200630.Models
{
    public class CreateSubCACertificateRequest : TeaModel {
        /// <summary>
        /// The type of the key algorithm of the intermediate CA. The key algorithm is in the `<Encryption algorithm>_<Key length>` format. Valid values:
        /// 
        /// *   **RSA\_1024**: The signature algorithm is Sha256WithRSA.
        /// *   **RSA\_2048**: The signature algorithm is Sha256WithRSA.
        /// *   **RSA\_4096**: The signature algorithm is Sha256WithRSA.
        /// *   **ECC\_256**: The signature algorithm is Sha256WithECDSA.
        /// *   **SM2\_256**: The signature algorithm is SM3WithSM2.
        /// 
        /// The encryption algorithm of an intermediate CA certificate must be consistent with the encryption algorithm of a root CA certificate. The length of the keys can be different. For example, if the key algorithm of the root CA certificate is **RSA\_2048**, the key algorithm of the intermediate CA certificate must be **RSA\_1024**, **RSA\_2048**, or **RSA\_4096**.
        /// 
        /// >  You can call the [DescribeCACertificate](~~328096~~) operation to query the key algorithm of a root CA certificate.
        /// </summary>
        [NameInMap("Algorithm")]
        [Validation(Required=false)]
        public string Algorithm { get; set; }

        /// <summary>
        /// The common name or abbreviation of the organization. The value can contain letters.
        /// </summary>
        [NameInMap("CommonName")]
        [Validation(Required=false)]
        public string CommonName { get; set; }

        /// <summary>
        /// The code of the country or region in which the organization is located. You can enter an alpha-2 or alpha-3 code. For example, you can use **CN** to indicate China and use **US** to indicate the United States.
        /// 
        /// For more information about country codes, see the **"Country codes"** section of the [Manage company profiles](~~198289~~) topic.
        /// </summary>
        [NameInMap("CountryCode")]
        [Validation(Required=false)]
        public string CountryCode { get; set; }

        [NameInMap("ExtendedKeyUsages")]
        [Validation(Required=false)]
        public List<string> ExtendedKeyUsages { get; set; }

        /// <summary>
        /// The name of the city in which the organization is located. The value can contain letters.
        /// </summary>
        [NameInMap("Locality")]
        [Validation(Required=false)]
        public string Locality { get; set; }

        /// <summary>
        /// The name of the organization that is associated with the intermediate CA certificate. You can enter the name of your enterprise or company. The value can contain letters.
        /// </summary>
        [NameInMap("Organization")]
        [Validation(Required=false)]
        public string Organization { get; set; }

        /// <summary>
        /// The name of the department or branch in the organization. The value can contain letters.
        /// </summary>
        [NameInMap("OrganizationUnit")]
        [Validation(Required=false)]
        public string OrganizationUnit { get; set; }

        /// <summary>
        /// The unique identifier of the root CA certificate.
        /// 
        /// >  You can call the [DescribeCACertificateList](~~328095~~) operation to query the unique identifiers of all CA certificates.
        /// </summary>
        [NameInMap("ParentIdentifier")]
        [Validation(Required=false)]
        public string ParentIdentifier { get; set; }

        [NameInMap("PathLenConstraint")]
        [Validation(Required=false)]
        public int? PathLenConstraint { get; set; }

        /// <summary>
        /// The name of the province, municipality, or autonomous region in which the organization is located. The value can contain letters.
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// The validity period of the intermediate CA certificate. Unit: years.
        /// 
        /// We recommend that you set this parameter to 5 to 10.
        /// 
        /// >  The validity period of the intermediate CA certificate cannot exceed the validity period of the root CA certificate. You can call the [DescribeCACertificate](~~328095~~) operation to query the validity period of a root CA certificate.
        /// </summary>
        [NameInMap("Years")]
        [Validation(Required=false)]
        public int? Years { get; set; }

    }

}
