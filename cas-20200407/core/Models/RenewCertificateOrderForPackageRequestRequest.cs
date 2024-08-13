// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class RenewCertificateOrderForPackageRequestRequest : TeaModel {
        /// <summary>
        /// The content of the certificate signing request (CSR) file that is manually generated for the domain name by using OpenSSL or Keytool. The key algorithm in the CSR file must be Rivest-Shamir-Adleman (RSA) or elliptic-curve cryptography (ECC), and the key length of the RSA algorithm must be greater than or equal to 2,048 characters. For more information about how to create a CSR file, see [How do I create a CSR file?](https://help.aliyun.com/document_detail/42218.html)
        /// 
        /// If you do not specify this parameter, Certificate Management Service automatically generates a CSR file for the domain name in the certificate application order that you want to renew.
        /// 
        /// A CSR file contains the information about your server and company. When you apply for a certificate, you must submit the CSR file to the CA. The CA signs the CSR file by using the private key of the root certificate and generates a public key file to issue your certificate.
        /// 
        /// >  The **CN** field in the CSR file specifies the domain name that is bound to the certificate.
        /// </summary>
        [NameInMap("Csr")]
        [Validation(Required=false)]
        public string Csr { get; set; }

        /// <summary>
        /// The ID of the certificate application order that you want to renew.
        /// 
        /// >  After you call the [CreateCertificateForPackageRequest](https://help.aliyun.com/document_detail/455296.html), [CreateCertificateRequest](https://help.aliyun.com/document_detail/455292.html), or [CreateCertificateWithCsrRequest](https://help.aliyun.com/document_detail/455801.html) operation to submit a certificate application, you can obtain the ID of the certificate application order from the **OrderId** response parameter. You can also call the [ListUserCertificateOrder](https://help.aliyun.com/document_detail/455804.html) operation to obtain the order ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public long? OrderId { get; set; }

    }

}
