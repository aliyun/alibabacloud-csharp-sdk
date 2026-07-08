// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class CreateWHClientCertificateRequest : TeaModel {
        /// <summary>
        /// <para>The expiration time of the client certificate, specified as a Unix timestamp in seconds.</para>
        /// <remarks>
        /// <para>The <c>BeforeTime</c> and <c>AfterTime</c> parameters must be specified together or not at all.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1665819958</para>
        /// </summary>
        [NameInMap("AfterTime")]
        [Validation(Required=false)]
        public long? AfterTime { get; set; }

        /// <summary>
        /// <para>The key algorithm for the client certificate. The format is <c>&lt;encryption_algorithm&gt;_&lt;key_length&gt;</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>RSA_1024</b>: The corresponding signature algorithm is Sha256WithRSA.</para>
        /// </description></item>
        /// <item><description><para><b>RSA_2048</b>: The corresponding signature algorithm is Sha256WithRSA.</para>
        /// </description></item>
        /// <item><description><para><b>RSA_4096</b>: The corresponding signature algorithm is Sha256WithRSA.</para>
        /// </description></item>
        /// <item><description><para><b>ECC_256</b>: The corresponding signature algorithm is Sha256WithECDSA.</para>
        /// </description></item>
        /// <item><description><para><b>ECC_384</b>: The corresponding signature algorithm is Sha256WithECDSA.</para>
        /// </description></item>
        /// <item><description><para><b>ECC_512</b>: The corresponding signature algorithm is Sha256WithECDSA.</para>
        /// </description></item>
        /// <item><description><para><b>SM2_256</b>: The corresponding signature algorithm is SM3WithSM2.</para>
        /// </description></item>
        /// </list>
        /// <para>The encryption algorithm of the client certificate must match that of the issuing subordinate CA certificate, but the key lengths can differ. For example, if the key algorithm of the subordinate CA certificate is RSA_2048, the key algorithm for the client certificate must be one of RSA_1024, RSA_2048, or RSA_4096.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RSA_2048</para>
        /// </summary>
        [NameInMap("Algorithm")]
        [Validation(Required=false)]
        public string Algorithm { get; set; }

        /// <summary>
        /// <para>The issuance time of the client certificate, as a Unix timestamp in seconds. If omitted, this defaults to the time of the API call.</para>
        /// <remarks>
        /// <para>The <c>BeforeTime</c> and <c>AfterTime</c> parameters must be specified together or not at all.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1634283958</para>
        /// </summary>
        [NameInMap("BeforeTime")]
        [Validation(Required=false)]
        public long? BeforeTime { get; set; }

        /// <summary>
        /// <para>The common name of the client certificate. Supports Chinese, English, and other characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aliyun</para>
        /// </summary>
        [NameInMap("CommonName")]
        [Validation(Required=false)]
        public string CommonName { get; set; }

        /// <summary>
        /// <para>The country where the organization is located.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CN</para>
        /// </summary>
        [NameInMap("Country")]
        [Validation(Required=false)]
        public string Country { get; set; }

        /// <summary>
        /// <para>The content of the certificate signing request (CSR). You can generate a CSR with tools like OpenSSL or Keytool.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN CERTIFICATE REQUEST----- ...... -----END CERTIFICATE REQUEST-----</para>
        /// </summary>
        [NameInMap("Csr")]
        [Validation(Required=false)]
        public string Csr { get; set; }

        /// <summary>
        /// <para>The validity period of the client certificate, in days.</para>
        /// <para>You cannot leave the <c>Days</c>, <c>BeforeTime</c>, and <c>AfterTime</c> parameters all empty. The <c>BeforeTime</c> and <c>AfterTime</c> parameters must be specified together or not at all.</para>
        /// <list type="bullet">
        /// <item><description><para>If you specify the <c>Days</c> parameter, specifying <c>BeforeTime</c> and <c>AfterTime</c> is optional.</para>
        /// </description></item>
        /// <item><description><para>If you do not specify the <c>Days</c> parameter, you must specify both <c>BeforeTime</c> and <c>AfterTime</c>.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If you specify <c>Days</c>, <c>BeforeTime</c>, and <c>AfterTime</c> simultaneously, the <c>Days</c> parameter takes precedence in determining the validity period.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>365</para>
        /// </summary>
        [NameInMap("Days")]
        [Validation(Required=false)]
        public long? Days { get; set; }

        /// <summary>
        /// <para>Specifies which certificate content to return in the response.</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: Does not return the certificate (default).</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: Returns the certificate.</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: Returns the certificate and its certificate chain.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Immediately")]
        [Validation(Required=false)]
        public long? Immediately { get; set; }

        /// <summary>
        /// <para>The city where the organization is located. Chinese, English, and other characters are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Hangzhou</para>
        /// </summary>
        [NameInMap("Locality")]
        [Validation(Required=false)]
        public string Locality { get; set; }

        /// <summary>
        /// <para>The validity period of the certificate, in months.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("Months")]
        [Validation(Required=false)]
        public long? Months { get; set; }

        /// <summary>
        /// <para>The organization name associated with the root CA certificate, typically your company or enterprise name. Supports Chinese, English, and other characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>阿里巴巴网络技术有限公司</para>
        /// </summary>
        [NameInMap("Organization")]
        [Validation(Required=false)]
        public string Organization { get; set; }

        /// <summary>
        /// <para>The name of the department or business unit within the organization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IT</para>
        /// </summary>
        [NameInMap("OrganizationUnit")]
        [Validation(Required=false)]
        public string OrganizationUnit { get; set; }

        /// <summary>
        /// <para>The unique identifier of the issuing subordinate CA certificate.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>273ae6bb538d538c70c01f81jh2****</para>
        /// </summary>
        [NameInMap("ParentIdentifier")]
        [Validation(Required=false)]
        public string ParentIdentifier { get; set; }

        /// <summary>
        /// <para>The type of the subject alternative name (SAN) for the client certificate. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b>: email address.</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: domain name.</para>
        /// </description></item>
        /// <item><description><para><b>6</b>: Uniform Resource Identifier (URI).</para>
        /// </description></item>
        /// <item><description><para><b>7</b>: IP address.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("SanType")]
        [Validation(Required=false)]
        public long? SanType { get; set; }

        /// <summary>
        /// <para>The value of the SAN extension. To specify multiple values, separate them with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("SanValue")]
        [Validation(Required=false)]
        public string SanValue { get; set; }

        /// <summary>
        /// <para>The province, municipality, or autonomous region where the organization is located. Chinese, English, and other characters are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Zhejiang</para>
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// <para>The validity period of the certificate, in years.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Years")]
        [Validation(Required=false)]
        public long? Years { get; set; }

    }

}
