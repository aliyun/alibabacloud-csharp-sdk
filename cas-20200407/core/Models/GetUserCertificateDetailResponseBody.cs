// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class GetUserCertificateDetailResponseBody : TeaModel {
        /// <summary>
        /// The algorithm.
        /// </summary>
        [NameInMap("Algorithm")]
        [Validation(Required=false)]
        public string Algorithm { get; set; }

        /// <summary>
        /// Indicates whether the certificate was purchased from Alibaba Cloud. Valid values:
        /// 
        /// *   **true**: yes
        /// *   **false**: no
        /// </summary>
        [NameInMap("BuyInAliyun")]
        [Validation(Required=false)]
        public bool? BuyInAliyun { get; set; }

        /// <summary>
        /// The content of the certificate.
        /// </summary>
        [NameInMap("Cert")]
        [Validation(Required=false)]
        public string Cert { get; set; }

        /// <summary>
        /// The city of the company or organization to which the certificate purchaser belongs.
        /// </summary>
        [NameInMap("City")]
        [Validation(Required=false)]
        public string City { get; set; }

        /// <summary>
        /// The parent domain name that is bound to the certificate.
        /// </summary>
        [NameInMap("Common")]
        [Validation(Required=false)]
        public string Common { get; set; }

        /// <summary>
        /// The country or region of the company or organization to which the certificate purchaser belongs.
        /// </summary>
        [NameInMap("Country")]
        [Validation(Required=false)]
        public string Country { get; set; }

        /// <summary>
        /// The content of the encryption certificate in PEM format.
        /// </summary>
        [NameInMap("EncryptCert")]
        [Validation(Required=false)]
        public string EncryptCert { get; set; }

        /// <summary>
        /// The private key of the encryption certificate in the PEM format.
        /// </summary>
        [NameInMap("EncryptPrivateKey")]
        [Validation(Required=false)]
        public string EncryptPrivateKey { get; set; }

        /// <summary>
        /// The expiration date of the certificate.
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// Indicates whether the certificate has expired. Valid values:
        /// 
        /// *   **true**: yes
        /// *   **false**: no
        /// </summary>
        [NameInMap("Expired")]
        [Validation(Required=false)]
        public bool? Expired { get; set; }

        /// <summary>
        /// The fingerprint of the certificate.
        /// </summary>
        [NameInMap("Fingerprint")]
        [Validation(Required=false)]
        public string Fingerprint { get; set; }

        /// <summary>
        /// The ID of the certificate.
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// The certificate authority (CA) that issued the certificate.
        /// </summary>
        [NameInMap("Issuer")]
        [Validation(Required=false)]
        public string Issuer { get; set; }

        /// <summary>
        /// The private key.
        /// </summary>
        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        /// <summary>
        /// The name of the certificate.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The ID of the certificate application order.
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public long? OrderId { get; set; }

        /// <summary>
        /// The name of the company or organization to which the certificate purchaser belongs.
        /// </summary>
        [NameInMap("OrgName")]
        [Validation(Required=false)]
        public string OrgName { get; set; }

        /// <summary>
        /// The province of the company or organization to which the certificate purchaser belongs.
        /// </summary>
        [NameInMap("Province")]
        [Validation(Required=false)]
        public string Province { get; set; }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The ID of the resource group to which the certificate belongs.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// All domain names that are bound to the certificate.
        /// </summary>
        [NameInMap("Sans")]
        [Validation(Required=false)]
        public string Sans { get; set; }

        /// <summary>
        /// The content of the signing certificate in the PEM format.
        /// </summary>
        [NameInMap("SignCert")]
        [Validation(Required=false)]
        public string SignCert { get; set; }

        /// <summary>
        /// The private key of the signing certificate in the PEM format.
        /// </summary>
        [NameInMap("SignPrivateKey")]
        [Validation(Required=false)]
        public string SignPrivateKey { get; set; }

        /// <summary>
        /// The issuance date of the certificate.
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

    }

}
