// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeAtiCertificateResponseBody : TeaModel {
        /// <summary>
        /// <para>The access denied details. This field is returned only when RAM authentication fails.</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public DescribeAtiCertificateResponseBodyAccessDeniedDetail AccessDeniedDetail { get; set; }
        public class DescribeAtiCertificateResponseBodyAccessDeniedDetail : TeaModel {
            /// <summary>
            /// <para>The unauthorized operation that was attempted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CreateUser</para>
            /// </summary>
            [NameInMap("AuthAction")]
            [Validation(Required=false)]
            public string AuthAction { get; set; }

            /// <summary>
            /// <para>The display name of the authorization principal.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2015555733387XXXX</para>
            /// </summary>
            [NameInMap("AuthPrincipalDisplayName")]
            [Validation(Required=false)]
            public string AuthPrincipalDisplayName { get; set; }

            /// <summary>
            /// <para>The owner ID of the authorization principal.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10469733312XXX</para>
            /// </summary>
            [NameInMap("AuthPrincipalOwnerId")]
            [Validation(Required=false)]
            public string AuthPrincipalOwnerId { get; set; }

            /// <summary>
            /// <para>The identity type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SubUser</para>
            /// </summary>
            [NameInMap("AuthPrincipalType")]
            [Validation(Required=false)]
            public string AuthPrincipalType { get; set; }

            /// <summary>
            /// <para>The encrypted complete diagnostic message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AQEAAAAAaNIARXXXXUQwNjE0LUQzN0XXXXVEQy1BQzExLTMzXXXXNTkxRjk1Ng==</para>
            /// </summary>
            [NameInMap("EncodedDiagnosticMessage")]
            [Validation(Required=false)]
            public string EncodedDiagnosticMessage { get; set; }

            /// <summary>
            /// <para>The reason for the authentication failure. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ExplicitDeny: Explicit deny.</description></item>
            /// <item><description>ImplicitDeny: Implicit deny.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ImplicitDeny</para>
            /// </summary>
            [NameInMap("NoPermissionType")]
            [Validation(Required=false)]
            public string NoPermissionType { get; set; }

            /// <summary>
            /// <para>The policy type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DlpSend</para>
            /// </summary>
            [NameInMap("PolicyType")]
            [Validation(Required=false)]
            public string PolicyType { get; set; }

        }

        /// <summary>
        /// <para>The agent host address.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.example.com">www.example.com</a></para>
        /// </summary>
        [NameInMap("AgentHost")]
        [Validation(Required=false)]
        public string AgentHost { get; set; }

        /// <summary>
        /// <para>The agent ID. After CNNIC real-name authentication, CNNIC assigns a unified agent ID. The agent ID serves as the unique identifier that binds the agent to the real-name authenticated registrant.</para>
        /// 
        /// <b>Example:</b>
        /// <para>csp01860716@5e0964fd-951c-4e45-b518-d09d4d2db8ca</para>
        /// </summary>
        [NameInMap("AgentId")]
        [Validation(Required=false)]
        public string AgentId { get; set; }

        /// <summary>
        /// <para>The encryption algorithm of the certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RSA-2048</para>
        /// </summary>
        [NameInMap("Algorithm")]
        [Validation(Required=false)]
        public string Algorithm { get; set; }

        /// <summary>
        /// <para>The certificate file in PEM format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN CERTIFICATE-----
        /// MIIDrzCCApegAwIBAgIQCDvgVpBCRrGhdWrJWZHHSjANBgkqhkiG9w0BAQUFAD...
        /// （中间是一长串经过 Base64 编码的数据）
        /// ...
        /// -----END CERTIFICATE-----</para>
        /// </summary>
        [NameInMap("CertPem")]
        [Validation(Required=false)]
        public string CertPem { get; set; }

        /// <summary>
        /// <para>The certificate type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Server: server certificate.</description></item>
        /// <item><description>Identity: identity certificate.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Server</para>
        /// </summary>
        [NameInMap("CertType")]
        [Validation(Required=false)]
        public string CertType { get; set; }

        /// <summary>
        /// <para>The creation time of the health check template (timestamp).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1527690629357</para>
        /// </summary>
        [NameInMap("CreateTimestamp")]
        [Validation(Required=false)]
        public long? CreateTimestamp { get; set; }

        /// <summary>
        /// <para>The issuer information of the certificate, identified in Distinguished Names (DN) format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DigiCert Inc</para>
        /// </summary>
        [NameInMap("Issuer")]
        [Validation(Required=false)]
        public string Issuer { get; set; }

        /// <summary>
        /// <para>The end time of the certificate validity period.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2027-05-09 02:19:49</para>
        /// </summary>
        [NameInMap("NotAfter")]
        [Validation(Required=false)]
        public string NotAfter { get; set; }

        /// <summary>
        /// <para>The start time of the certificate validity period.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-01-26 02:16:38</para>
        /// </summary>
        [NameInMap("NotBefore")]
        [Validation(Required=false)]
        public string NotBefore { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>29D0F8F8-5499-4F6C-9FDC-1EE13BF55925</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The Subject Alternative Name (SAN), which specifies additional identities for the certificate subject.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;dNSName: example.com, dNSName: <a href="http://www.example.com">www.example.com</a>&quot;,</para>
        /// </summary>
        [NameInMap("San")]
        [Validation(Required=false)]
        public string San { get; set; }

        /// <summary>
        /// <para>The serial number that indicates the priority of the returned address. A smaller value indicates a higher priority.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SerialNumber")]
        [Validation(Required=false)]
        public string SerialNumber { get; set; }

        /// <summary>
        /// <para>The certificate source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BYOC</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The validity status of the certificate. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Valid</description></item>
        /// <item><description>Invalid</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Valid</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The certificate subject (owner), identified in DN format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:eventbridge:cn-hangzhou:1825725063814405:eventstreaming/dsadsad123213-trigger1</para>
        /// </summary>
        [NameInMap("Subject")]
        [Validation(Required=false)]
        public string Subject { get; set; }

        /// <summary>
        /// <para>The DNS TLSA record value that stores the certificate public key fingerprint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3 1 1 2ea103e8c5ba3466ff7f94cc28336b40ce7432e55a2fc37e86b65e55737c45662</para>
        /// </summary>
        [NameInMap("TlsaFingerprint")]
        [Validation(Required=false)]
        public string TlsaFingerprint { get; set; }

        /// <summary>
        /// <para>The update time (timestamp).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1527690629357</para>
        /// </summary>
        [NameInMap("UpdateTimestamp")]
        [Validation(Required=false)]
        public long? UpdateTimestamp { get; set; }

    }

}
