// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200630.Models
{
    public class CreateRootCACertificateRequest : TeaModel {
        /// <summary>
        /// The key algorithm of the root CA certificate. The key algorithm is in the `<Encryption algorithm>_<Key length>` format. Valid values:
        /// 
        /// *   **RSA\_1024**: The signature algorithm is Sha256WithRSA.
        /// *   **RSA\_2048**: The signature algorithm is Sha256WithRSA.
        /// *   **RSA\_4096**: The signature algorithm is Sha256WithRSA.
        /// *   **ECC\_256**: The signature algorithm is Sha256WithECDSA.
        /// *   **ECC\_384**: The signature algorithm is Sha256WithECDSA.
        /// *   **ECC\_512**: The signature algorithm is Sha256WithECDSA.
        /// *   **SM2\_256**: The signature algorithm is SM3WithSM2.
        /// 
        /// The encryption algorithm of the root CA certificate must be consistent with the **encryption algorithm** of the private root CA instance that you purchase. For example, if the **encryption algorithm** of the private root CA instance that you purchase is **RSA**, the key algorithm of the root CA certificate must be **RSA\_1024**, **RSA\_2048**, or **RSA\_4096**.
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
        /// The code of the country or region in which the organization is located. You can enter an alpha-2 code. For example, you can use **CN** to indicate China and use **US** to indicate the United States.
        /// 
        /// For more information about country codes, see the **"Country codes"** section of the [Manage company profiles](~~198289~~) topic.
        /// </summary>
        [NameInMap("CountryCode")]
        [Validation(Required=false)]
        public string CountryCode { get; set; }

        /// <summary>
        /// The name of the city in which the organization is located. The value can contain letters.
        /// </summary>
        [NameInMap("Locality")]
        [Validation(Required=false)]
        public string Locality { get; set; }

        /// <summary>
        /// The name of the organization that is associated with the root CA certificate. You can enter the name of your enterprise or company. The value can contain letters.
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
        /// The name of the province, municipality, or autonomous region in which the organization is located. The value can contain letters.
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// The validity period of the root CA certificate. Unit: years.
        /// 
        /// >  We recommend that you set this parameter to a value from 5 to 10.
        /// </summary>
        [NameInMap("Years")]
        [Validation(Required=false)]
        public int? Years { get; set; }

    }

}
