// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class DescribeCertificateStateResponseBody : TeaModel {
        /// <summary>
        /// <para>The certificate ID.</para>
        /// <remarks>
        /// <para>This parameter is returned when the certificate is issued.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>111111</para>
        /// </summary>
        [NameInMap("CertId")]
        [Validation(Required=false)]
        public string CertId { get; set; }

        /// <summary>
        /// <para>The certificate content (in PEM format). For more information about the PEM format and how to convert the format of a certificate, see <a href="https://help.aliyun.com/document_detail/42214.html">What are the formats of mainstream digital certificates?</a>.</para>
        /// <remarks>
        /// <para>This parameter is returned only when <b>Type</b> is set to <b>certificate</b> (indicating that the certificate has been issued).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN CERTIFICATE----- …… -----END CERTIFICATE-----</para>
        /// </summary>
        [NameInMap("Certificate")]
        [Validation(Required=false)]
        public string Certificate { get; set; }

        /// <summary>
        /// <para>The content that you need to write to the newly created file when you use the file validation method for domain validation.</para>
        /// <remarks>
        /// <para>This parameter is returned only when <b>Type</b> is set to <b>domain_verify</b> (indicating the domain validation stage) and <b>ValidateType</b> is set to <b>FILE</b> (indicating the file validation method).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://example.com/.well-known/pki-validation/fileauth.txt">http://example.com/.well-known/pki-validation/fileauth.txt</a></para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The domain name to be validated when you use the file validation method for domain validation. You need to connect to the server corresponding to this domain name and create the specified file (i.e., <b>Uri</b>) on the server.</para>
        /// <remarks>
        /// <para>This parameter is returned only when <b>Type</b> is set to <b>domain_verify</b> (indicating the domain validation stage) and <b>ValidateType</b> is set to <b>FILE</b> (indicating the file validation method).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.example.com">www.example.com</a></para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>The content of the certificate private key (in PEM format). For more information about the PEM format and how to convert the format of a certificate, see <a href="https://help.aliyun.com/document_detail/42214.html">What are the formats of mainstream digital certificates?</a>.</para>
        /// <remarks>
        /// <para>This parameter is returned only when <b>Type</b> is set to <b>certificate</b> (indicating that the certificate has been issued).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN RSA PRIVATE KEY-----…… -----END RSA PRIVATE KEY-----</para>
        /// </summary>
        [NameInMap("PrivateKey")]
        [Validation(Required=false)]
        public string PrivateKey { get; set; }

        /// <summary>
        /// <para>The host record that you need to operate when you use the DNS validation method for domain validation.</para>
        /// <remarks>
        /// <para>This parameter is returned only when <b>Type</b> is set to <b>domain_verify</b> (indicating the domain validation stage) and <b>ValidateType</b> is set to <b>DNS</b> (indicating the DNS validation method).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>_dnsauth</para>
        /// </summary>
        [NameInMap("RecordDomain")]
        [Validation(Required=false)]
        public string RecordDomain { get; set; }

        /// <summary>
        /// <para>The type of DNS record that you need to add when you use the DNS validation method for domain validation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>TXT</b>: text record.</para>
        /// </description></item>
        /// <item><description><para><b>CNAME</b>: alias record.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is returned only when <b>Type</b> is set to <b>domain_verify</b> (indicating the domain validation stage) and <b>ValidateType</b> is set to <b>DNS</b> (indicating the DNS validation method).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>TXT</para>
        /// </summary>
        [NameInMap("RecordType")]
        [Validation(Required=false)]
        public string RecordType { get; set; }

        /// <summary>
        /// <para>The record value that you need to add when you use the DNS validation method for domain validation.</para>
        /// <remarks>
        /// <para>This parameter is returned only when <b>Type</b> is set to <b>domain_verify</b> (indicating the domain validation stage) and <b>ValidateType</b> is set to <b>DNS</b> (indicating the DNS validation method).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>20200420000000223erigacv46uhaubchcm0o7spxi7i2isvjq59mlx9lucnkqcy</para>
        /// </summary>
        [NameInMap("RecordValue")]
        [Validation(Required=false)]
        public string RecordValue { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>082FAB35-6AB9-4FD5-8750-D36673548E76</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status of the certificate request order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>domain_verify</b>: <b>Pending validation</b>, which indicates that you have not completed domain validation after submitting the certificate request.</para>
        /// <remarks>
        /// <para>After you submit a certificate request, you must manually complete domain ownership validation before the certificate request can enter the review stage. If you have not completed domain validation, you can refer to the response parameters of this operation to complete domain validation.</para>
        /// </remarks>
        /// </description></item>
        /// <item><description><para><b>process</b>: <b>Under review</b>, which indicates that the certificate request is being reviewed by the CA center.</para>
        /// </description></item>
        /// <item><description><para><b>verify_fail</b>: <b>Review failed</b>, which indicates that the certificate request failed the review.</para>
        /// <remarks>
        /// <para>The review may fail because the certificate request information you submitted is incorrect. We recommend that you call <a href="https://help.aliyun.com/document_detail/455294.html">DeleteCertificateRequest</a> to delete the order that failed the review (deleted orders do not consume certificate resource plan quota) and submit a new certificate request.</para>
        /// </remarks>
        /// </description></item>
        /// <item><description><para><b>certificate</b>: <b>Issued</b>, which indicates that the certificate has been issued.</para>
        /// </description></item>
        /// <item><description><para><b>payed</b>: <b>Pending request</b>, which indicates that the certificate is pending request.</para>
        /// </description></item>
        /// <item><description><para><b>unknow</b>: <b>Unknown status</b>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>domain_verify</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The file that you need to create on the domain server when you use the file validation method for domain validation. <b>Uri</b> includes the file path and name.</para>
        /// <remarks>
        /// <para>This parameter is returned only when <b>Type</b> is set to <b>domain_verify</b> (indicating the domain validation stage) and <b>ValidateType</b> is set to <b>FILE</b> (indicating the file validation method).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>/.well-known/pki-validation/fileauth.txt</para>
        /// </summary>
        [NameInMap("Uri")]
        [Validation(Required=false)]
        public string Uri { get; set; }

        /// <summary>
        /// <para>The domain validation method selected when submitting the certificate request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>DNS</b>: DNS validation. This method validates domain ownership by adding the specified DNS record to the domain on the DNS management platform.</para>
        /// </description></item>
        /// <item><description><para><b>FILE</b>: file validation. This method validates domain ownership by creating the specified file on the domain server.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is returned only when <b>Type</b> is set to <b>domain_verify</b> (indicating the domain validation stage).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>FILE</para>
        /// </summary>
        [NameInMap("ValidateType")]
        [Validation(Required=false)]
        public string ValidateType { get; set; }

    }

}
