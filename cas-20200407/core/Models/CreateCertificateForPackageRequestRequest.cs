// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class CreateCertificateForPackageRequestRequest : TeaModel {
        /// <summary>
        /// The company name of the certificate application.
        /// 
        /// > This parameter is available only when you apply for OV certificates. If you want to apply for an OV certificate, you must add a company profile to the **Information Management** module of the [Certificate Management Service console](https://yundun.console.aliyun.com/?p=cas#/). For more information, see [Manage company profiles](~~198289~~). If you want to apply for a DV certificate, you do not need to add a company profile.
        /// 
        /// If you specify a company name, the information about the company that is configured in the **Information Management** module is used. If you do not specify this parameter, the information about the most recent company that is added to the **Information Management** module is used.
        /// </summary>
        [NameInMap("CompanyName")]
        [Validation(Required=false)]
        public string CompanyName { get; set; }

        /// <summary>
        /// The content of the certificate signing request (CSR) file that is manually generated for the domain name by using OpenSSL or Keytool. The key algorithm in the CSR file must be Rivest-Shamir-Adleman (RSA) or elliptic-curve cryptography (ECC), and the key length of the RSA algorithm must be greater than or equal to 2,048 characters. For more information about how to create a CSR file, see [Create a CSR file](~~313297~~). If you do not specify this parameter, Certificate Management Service automatically creates a CSR file.
        /// 
        /// A CSR file contains the information about your server and company. When you apply for a certificate, you must submit the CSR file to the CA. The CA signs the CSR file by using the private key of the root certificate and generates a public key file to issue your certificate.
        /// 
        /// > 
        /// 
        /// The **CN** field in the CSR file specifies the domain name that you want to bind to the certificate. You must include the field in the parameter value.
        /// </summary>
        [NameInMap("Csr")]
        [Validation(Required=false)]
        public string Csr { get; set; }

        /// <summary>
        /// The domain name that you want to bind to the certificate. The domain name must meet the following requirements:
        /// 
        /// *   The domain name must be a single domain name or a wildcard domain name. Example: `*.aliyundoc.com`.
        /// *   You can specify multiple domain names. Separate multiple domain names with commas (,). You can specify a maximum of five domain names.
        /// *   If you specify multiple domain names, the domain names must be only single domain names or only wildcard domain names. You cannot specify both single domain names and wildcard domain names.
        /// 
        /// > 
        /// 
        /// If you want to bind multiple domain names to the certificate, you must specify this parameter. You must specify at least one of the Domain parameter and the **Csr** parameter. If you specify both the Domain parameter and the **Csr** parameter, the value of the **CN** field in the **Csr** parameter is used as the domain name that can be bound to the certificate.
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// The email address of the applicant. After the CA receives your certificate application, the CA sends a verification email to the email address that you specify. You must log on to the mailbox, open the mail, and complete the verification of the domain name ownership based on the steps that are described in the email.
        /// 
        /// If you do not specify this parameter, the information about the most recent contact that is added to the **Information Management** module is used. For more information about how to add a contact to the **Information Management** module, see [Manage contacts](~~198262~~).
        /// </summary>
        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// The phone number of the applicant. CA staff can call the phone number to confirm the information in your certificate application.
        /// 
        /// If you do not specify this parameter, the information about the most recent contact that is added to the **Information Management** module is used. For more information about how to add a contact to the **Information Management** module, see [Manage contacts](~~198262~~).
        /// </summary>
        [NameInMap("Phone")]
        [Validation(Required=false)]
        public string Phone { get; set; }

        /// <summary>
        /// The specifications of the certificate. Valid values:
        /// 
        /// *   **digicert-free-1-free**: DigiCert single-domain domain validated (DV) certificate in 3 months free trial. This is the default value.
        /// *   **symantec-free-1-free**: DigiCert single-domain domain validated (DV) certificate in 1 year free trial.
        /// *   **symantec-dv-1-starter**: DigiCert wildcard DV certificate.
        /// *   **symantec-ov-1-personal**: DigiCert single-domain organization validated (OV) certificate.
        /// *   **symantec-ov-w-personal**: DigiCert wildcard OV certificate.
        /// *   **geotrust-dv-1-starter**: GeoTrust single-domain DV certificate.
        /// *   **geotrust-dv-w-starter**: GeoTrust wildcard DV certificate.
        /// *   **geotrust-ov-1-personal**: GeoTrust single-domain OV certificate.
        /// *   **geotrust-ov-w-personal**: GeoTrust wildcard OV certificate.
        /// *   **globalsign-dv-1-personal**: GlobalSign single-domain DV certificate.
        /// *   **globalsign-dv-w-advanced**: GlobalSign wildcard DV certificate.
        /// *   **globalsign-ov-1-personal**: GlobalSign single-domain OV certificate.
        /// *   **globalsign-ov-w-advanced**: GlobalSign wildcard OV certificate.
        /// *   **cfca-ov-1-personal**: China Financial Certification Authority (CFCA) single-domain OV certificate.
        /// *   **cfca-ev-w-advanced**: CFCA wildcard OV certificate.
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// The name of the applicant.
        /// 
        /// If you do not specify this parameter, the information about the most recent contact that is added to the **Information Management** module is used. For more information about how to add a contact to the **Information Management** module, see [Manage contacts](~~198262~~).
        /// </summary>
        [NameInMap("Username")]
        [Validation(Required=false)]
        public string Username { get; set; }

        /// <summary>
        /// The verification method of the domain name ownership. Valid values:
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
