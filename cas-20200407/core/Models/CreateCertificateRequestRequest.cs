// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class CreateCertificateRequestRequest : TeaModel {
        /// <summary>
        /// The domain name that you want to bind to the certificate. You can specify only one domain name.
        /// 
        /// >  The domain name must match the certificate specifications that you specify for the **ProductCode** parameter. If you apply for a single-domain certificate, you must specify a single domain name for this parameter. If you apply for a wildcard certificate, you must specify a wildcard domain name such as `*.aliyundoc.com` for this parameter.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// The contact email address of the applicant.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// The phone number of the applicant.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Phone")]
        [Validation(Required=false)]
        public string Phone { get; set; }

        /// <summary>
        /// The specifications of the certificate. Valid values:
        /// 
        /// *   **digicert-free-1-free** (default): DigiCert single-domain DV certificate, which is free and valid for 3 months.
        /// *   **symantec-free-1-free**: DigiCert single-domain DV certificate, which is free and valid for 1 year. This value is available only on the China site (aliyun.com).
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
        /// 
        /// This parameter is required.
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
        /// For more information about the verification methods, see [Verify the ownership of a domain name](https://help.aliyun.com/document_detail/48016.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ValidateType")]
        [Validation(Required=false)]
        public string ValidateType { get; set; }

    }

}
