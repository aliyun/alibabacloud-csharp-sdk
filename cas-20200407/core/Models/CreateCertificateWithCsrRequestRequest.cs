// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class CreateCertificateWithCsrRequestRequest : TeaModel {
        /// <summary>
        /// The content of the existing CSR file.\
        /// The key algorithm in the CSR file must be Rivest-Shamir-Adleman (RSA) or elliptic-curve cryptography (ECC), and the key length of the RSA algorithm must be greater than or equal to 2,048 characters. For more information about how to create a CSR file, see [How do I create a CSR file?](~~42218~~) You can also create a CSR in the [Certificate Management Service console](https://yundunnext.console.aliyun.com/?\&p=cas). For more information, see [Create a CSR](~~313297~~).\
        /// A CSR file contains the information about your server and company. When you apply for a certificate, you must submit the CSR file to the CA. The CA signs the CSR file by using the private key of the root certificate and generates a public key file to issue your certificate.
        /// 
        /// >  The **CN** field in the CSR file specifies the domain name that is bound to the certificate.
        /// </summary>
        [NameInMap("Csr")]
        [Validation(Required=false)]
        public string Csr { get; set; }

        /// <summary>
        /// The contact email address of the applicant.
        /// </summary>
        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// The phone number of the applicant.
        /// </summary>
        [NameInMap("Phone")]
        [Validation(Required=false)]
        public string Phone { get; set; }

        /// <summary>
        /// The specifications of the certificate. Valid values:
        /// 
        /// *   **digicert-free-1-free**: DigiCert single-domain DV certificate in 3 months free trial. This is the default value.
        /// *   **symantec-free-1-free**: DigiCert single-domain DV certificate in 1 year free trial.
        /// *   **symantec-dv-1-starter**: DigiCert wildcard DV certificate.
        /// *   **geotrust-dv-1-starter**: GeoTrust single-domain DV certificate.
        /// *   **geotrust-dv-w-starter**: GeoTrust wildcard DV certificate.
        /// *   **globalsign-dv-1-personal**: GlobalSign single-domain DV certificate.
        /// *   **globalsign-dv-w-advanced**: GlobalSign wildcard DV certificate.
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// The name of the applicant.
        /// </summary>
        [NameInMap("Username")]
        [Validation(Required=false)]
        public string Username { get; set; }

        /// <summary>
        /// The method to verify the ownership of a domain name. Valid values:
        /// 
        /// *   **DNS**: DNS verification. If you use this method, you must add a TXT record to the DNS records of the domain name in the management platform of the domain name. You must have operation permissions on domain name resolution to verify the ownership of the domain name.
        /// *   **FILE**: file verification. If you use this method, you must create a specified file on the DNS server. You must have administrative rights on the DNS server to verify the ownership of the domain name.
        /// 
        /// For more information about the verification methods, see [Verify the ownership of a domain name](~~48016~~).
        /// </summary>
        [NameInMap("ValidateType")]
        [Validation(Required=false)]
        public string ValidateType { get; set; }

    }

}
