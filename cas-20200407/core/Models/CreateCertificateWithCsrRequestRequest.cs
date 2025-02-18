// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class CreateCertificateWithCsrRequestRequest : TeaModel {
        /// <summary>
        /// <para>The content of the CSR file.\
        /// The key algorithm in the CSR file must be Rivest-Shamir-Adleman (RSA) or elliptic-curve cryptography (ECC), and the key length of the RSA algorithm must be greater than or equal to 2,048 characters. For more information about how to create a CSR file, see <a href="https://help.aliyun.com/document_detail/42218.html">How do I create a CSR file?</a>\
        /// A CSR file contains the information about your server and company. When you apply for a certificate, you must submit the CSR file to the CA. The CA signs the CSR file by using the private key of the root certificate and generates a public key file to issue your certificate.</para>
        /// <remarks>
        /// <para> The <b>CN</b> field in the CSR file specifies the domain name that is bound to the certificate.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN CERTIFICATE REQUEST----- ...... -----END CERTIFICATE REQUEST-----</para>
        /// </summary>
        [NameInMap("Csr")]
        [Validation(Required=false)]
        public string Csr { get; set; }

        /// <summary>
        /// <para>The contact email address of the applicant.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:username@example.com">username@example.com</a></para>
        /// </summary>
        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// <para>The phone number of the applicant.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1390000****</para>
        /// </summary>
        [NameInMap("Phone")]
        [Validation(Required=false)]
        public string Phone { get; set; }

        /// <summary>
        /// <para>The specifications of the certificate that you want to apply for. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>digicert-free-1-free</b> (default): DigiCert single-domain DV certificate in a three-month free trial, available only on the China site (aliyun.com).</description></item>
        /// <item><description><b>symantec-free-1-free</b>: DigiCert single-domain DV certificate in a one-year free trial, available only on the China site (aliyun.com).</description></item>
        /// <item><description><b>symantec-dv-1-starter</b>: DigiCert wildcard DV certificate.</description></item>
        /// <item><description><b>geotrust-dv-1-starter</b>: GeoTrust single-domain DV certificate.</description></item>
        /// <item><description><b>geotrust-dv-w-starter</b>: GeoTrust wildcard DV certificate.</description></item>
        /// <item><description><b>globalsign-dv-1-personal</b>: GlobalSign single-domain DV certificate.</description></item>
        /// <item><description><b>globalsign-dv-w-advanced</b>: GlobalSign wildcard DV certificate.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>symantec-free-1-free</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The tag list.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<CreateCertificateWithCsrRequestRequestTags> Tags { get; set; }
        public class CreateCertificateWithCsrRequestRequestTags : TeaModel {
            /// <summary>
            /// <para>The tag key. Valid values of N: 1 to 20. The tag key cannot be an empty string. The tag key can be up to 128 characters in length and cannot start with <c>acs:</c> or <c>aliyun</c>. The tag key cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>database</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The name of the applicant.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Tom</para>
        /// </summary>
        [NameInMap("Username")]
        [Validation(Required=false)]
        public string Username { get; set; }

        /// <summary>
        /// <para>The method to verify the ownership of a domain name. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>DNS</b>: DNS verification. If you use this method, you must add a TXT record to the DNS records of the domain name in the management platform of the domain name. You must have operation permissions on domain name resolution to verify the ownership of the domain name.</description></item>
        /// <item><description><b>FILE</b>: file verification. If you use this method, you must create a specified file on the DNS server. You must have administrative rights on the DNS server to verify the ownership of the domain name.</description></item>
        /// </list>
        /// <para>For more information about the verification methods, see <a href="https://help.aliyun.com/document_detail/48016.html">Verify the ownership of a domain name</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DNS</para>
        /// </summary>
        [NameInMap("ValidateType")]
        [Validation(Required=false)]
        public string ValidateType { get; set; }

    }

}
