// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class GetCertificateDetailResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>RSA</para>
        /// </summary>
        [NameInMap("Algorithm")]
        [Validation(Required=false)]
        public string Algorithm { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>21912069-cn-hangzhou</para>
        /// </summary>
        [NameInMap("CertIdentifier")]
        [Validation(Required=false)]
        public string CertIdentifier { get; set; }

        [NameInMap("CertificateChainList")]
        [Validation(Required=false)]
        public List<GetCertificateDetailResponseBodyCertificateChainList> CertificateChainList { get; set; }
        public class GetCertificateDetailResponseBodyCertificateChainList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>Digicert</para>
            /// </summary>
            [NameInMap("Issuer")]
            [Validation(Required=false)]
            public string Issuer { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>17326613180000</para>
            /// </summary>
            [NameInMap("NotAfter")]
            [Validation(Required=false)]
            public long? NotAfter { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>17321613180000</para>
            /// </summary>
            [NameInMap("NotBefore")]
            [Validation(Required=false)]
            public long? NotBefore { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("RemainDay")]
            [Validation(Required=false)]
            public int? RemainDay { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Digicert</para>
            /// </summary>
            [NameInMap("Subject")]
            [Validation(Required=false)]
            public string Subject { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>22559621</para>
        /// </summary>
        [NameInMap("CertificateId")]
        [Validation(Required=false)]
        public int? CertificateId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("CertificateName")]
        [Validation(Required=false)]
        public string CertificateName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>BUY</para>
        /// </summary>
        [NameInMap("CertificateSource")]
        [Validation(Required=false)]
        public string CertificateSource { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>issued</para>
        /// </summary>
        [NameInMap("CertificateStatus")]
        [Validation(Required=false)]
        public string CertificateStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="http://www.example.com">www.example.com</a></para>
        /// </summary>
        [NameInMap("CommonName")]
        [Validation(Required=false)]
        public string CommonName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>aliyundoc.com,example.aliyundoc.com</para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ExistPrivateKey")]
        [Validation(Required=false)]
        public bool? ExistPrivateKey { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("FingerPrint")]
        [Validation(Required=false)]
        public string FingerPrint { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cas_dv-cn-123</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Digicert</para>
        /// </summary>
        [NameInMap("Issuer")]
        [Validation(Required=false)]
        public string Issuer { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2048</para>
        /// </summary>
        [NameInMap("KeySize")]
        [Validation(Required=false)]
        public int? KeySize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>17326613180000</para>
        /// </summary>
        [NameInMap("NotAfter")]
        [Validation(Required=false)]
        public long? NotAfter { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>17321613180000</para>
        /// </summary>
        [NameInMap("NotBefore")]
        [Validation(Required=false)]
        public long? NotBefore { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5979d897-d69f-4fc9-87dd-f3bb73c40b80</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("Serial")]
        [Validation(Required=false)]
        public string Serial { get; set; }

        [NameInMap("SubjectAlternativeNames")]
        [Validation(Required=false)]
        public List<string> SubjectAlternativeNames { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<GetCertificateDetailResponseBodyTags> Tags { get; set; }
        public class GetCertificateDetailResponseBodyTags : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("TagKey")]
            [Validation(Required=false)]
            public string TagKey { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("TagValue")]
            [Validation(Required=false)]
            public string TagValue { get; set; }

        }

        [NameInMap("UsingProductList")]
        [Validation(Required=false)]
        public List<string> UsingProductList { get; set; }

    }

}
