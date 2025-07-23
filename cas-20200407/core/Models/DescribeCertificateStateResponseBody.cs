// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class DescribeCertificateStateResponseBody : TeaModel {
        [NameInMap("CertId")]
        [Validation(Required=false)]
        public string CertId { get; set; }

        /// <summary>
        /// <para>The content of the certificate in the PEM format. For more information about the PEM format and how to convert certificate formats, see <a href="https://help.aliyun.com/document_detail/42214.html">What formats are used for mainstream digital certificates?</a></para>
        /// <remarks>
        /// <para> This parameter is returned only when the value of the <b>Type</b> parameter is <b>certificate</b>. The value certificate indicates that the certificate is issued.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>——BEGIN CERTIFICATE—— …… ——END CERTIFICATE——</para>
        /// </summary>
        [NameInMap("Certificate")]
        [Validation(Required=false)]
        public string Certificate { get; set; }

        /// <summary>
        /// <para>The content that you need to write to the newly created file when you use the file verification method.</para>
        /// <remarks>
        /// <para> This parameter is returned only when the value of the <b>Type</b> parameter is <b>domain_verify</b> and the value of the <b>ValidateType</b> parameter is <b>FILE</b>. The value domain_verify indicates that the verification of the domain name ownership is not complete, and the value FILE indicates that the file verification method is used.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://example.com/.well-known/pki-validation/fileauth.txt">http://example.com/.well-known/pki-validation/fileauth.txt</a></para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The domain name to be verified when you use the file verification method. You must connect to the DNS server of the domain name and create a file on the server. The file is specified by the <b>Uri</b> parameter.</para>
        /// <remarks>
        /// <para> This parameter is returned only when the value of the <b>Type</b> parameter is <b>domain_verify</b> and the value of the <b>ValidateType</b> parameter is <b>FILE</b>. The value domain_verify indicates that the verification of the domain name ownership is not complete, and the value FILE indicates that the file verification method is used.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.example.com">www.example.com</a></para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>The private key of the certificate in the PEM format. For more information about the PEM format and how to convert certificate formats, see <a href="https://help.aliyun.com/document_detail/42214.html">What formats are used for mainstream digital certificates?</a></para>
        /// <remarks>
        /// <para> This parameter is returned only when the value of the <b>Type</b> parameter is <b>certificate</b>. The value certificate indicates that the certificate is issued.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>——BEGIN RSA PRIVATE KEY—— …… ——END RSA PRIVATE KEY——</para>
        /// </summary>
        [NameInMap("PrivateKey")]
        [Validation(Required=false)]
        public string PrivateKey { get; set; }

        /// <summary>
        /// <para>The DNS record that you need to manage when you use the DNS verification method.</para>
        /// <remarks>
        /// <para> This parameter is returned only when the value of the <b>Type</b> parameter is <b>domain_verify</b> and the value of the <b>ValidateType</b> parameter is <b>DNS</b>. The value domain_verify indicates that the verification of the domain name ownership is not complete, and the value DNS indicates that the DNS verification method is used.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>_dnsauth</para>
        /// </summary>
        [NameInMap("RecordDomain")]
        [Validation(Required=false)]
        public string RecordDomain { get; set; }

        /// <summary>
        /// <para>The type of the DNS record that you need to add when you use the DNS verification method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>TXT</b></description></item>
        /// <item><description><b>CNAME</b></description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter is returned only when the value of the <b>Type</b> parameter is <b>domain_verify</b> and the value of the <b>ValidateType</b> parameter is <b>DNS</b>. The value domain_verify indicates that the verification of the domain name ownership is not complete.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>TXT</para>
        /// </summary>
        [NameInMap("RecordType")]
        [Validation(Required=false)]
        public string RecordType { get; set; }

        /// <summary>
        /// <para>You need to add a TXT record to the DNS records only when you use the DNS verification method.</para>
        /// <remarks>
        /// <para> This parameter is returned only when the value of the <b>Type</b> parameter is <b>domain_verify</b> and the value of the <b>ValidateType</b> parameter is <b>DNS</b>. The value domain_verify indicates that the verification of the domain name ownership is not complete, and the value DNS indicates that the DNS verification method is used.</para>
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
        /// <para>The status of the certificate application order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>domain_verify</b>: <b>pending review</b>, which indicates that you have not completed the verification of the domain name ownership after you submit the certificate application.</para>
        /// <remarks>
        /// <para>After you submit a certificate application, you must manually complete the verification of the domain name ownership. The CA reviews the certificate application only after the verification is complete. If you have not completed the verification of the domain name ownership, you can complete the verification based on the data returned by this operation.</para>
        /// </remarks>
        /// </description></item>
        /// <item><description><para><b>process</b>: <b>being reviewed</b>, which indicates that the certificate application is being reviewed by the CA.</para>
        /// </description></item>
        /// <item><description><para><b>verify_fail</b>: <b>review failed</b>, which indicates that the certificate application failed to be reviewed.</para>
        /// <remarks>
        /// <para> If a certificate application fails to be reviewed, the information that you specified in the certificate application may be incorrect. We recommend that you call the <a href="https://help.aliyun.com/document_detail/164109.html">DeleteCertificateRequest</a> operation to delete the certificate application order and resubmit a certificate application. After the order is deleted, the quota that is consumed for the order is released.</para>
        /// </remarks>
        /// </description></item>
        /// <item><description><para><b>certificate</b>: <b>issued</b>, which indicates that the certificate is issued.</para>
        /// </description></item>
        /// <item><description><para><b>payed</b>: <b>pending application</b>, which indicates that you have not submitted a certificate application.</para>
        /// </description></item>
        /// <item><description><para><b>unknow</b>: The status is <b>unknown</b>.</para>
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
        /// <para>The file that you need to create on the DNS server when you use the file verification method. <b>The value of this parameter contains the file path and file name.</b></para>
        /// <remarks>
        /// <para> This parameter is returned only when the value of the <b>Type</b> parameter is <b>domain_verify</b> and the value of the <b>ValidateType</b> parameter is <b>FILE</b>. The value domain_verify indicates that the verification of the domain name ownership is not complete, and the value FILE indicates that the file verification method is used.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>/.well-known/pki-validation/fileauth.txt</para>
        /// </summary>
        [NameInMap("Uri")]
        [Validation(Required=false)]
        public string Uri { get; set; }

        /// <summary>
        /// <para>The verification method of the domain name ownership. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>DNS</b>: DNS verification. If you use this method, you must add a TXT record to the DNS records of the domain name in the management platform of the domain name.</description></item>
        /// <item><description><b>FILE</b>: file verification. If you use this method, you must create a specified file on the DNS server.</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter is returned only when the value of the <b>Type</b> parameter is <b>domain_verify</b>. The value domain_verify indicates that the verification of the domain name ownership is not complete.</para>
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
