// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200630.Models
{
    public class CreateExternalCACertificateRequest : TeaModel {
        /// <summary>
        /// <para>Specifies API parameters that override content from the CSR or add information to the CA certificate.</para>
        /// </summary>
        [NameInMap("ApiPassthrough")]
        [Validation(Required=false)]
        public CreateExternalCACertificateRequestApiPassthrough ApiPassthrough { get; set; }
        public class CreateExternalCACertificateRequestApiPassthrough : TeaModel {
            /// <summary>
            /// <para>Specifies the extensions for the CA certificate. If specified, these values override the corresponding extensions in the CSR or are added to the CA certificate.</para>
            /// </summary>
            [NameInMap("Extensions")]
            [Validation(Required=false)]
            public CreateExternalCACertificateRequestApiPassthroughExtensions Extensions { get; set; }
            public class CreateExternalCACertificateRequestApiPassthroughExtensions : TeaModel {
                /// <summary>
                /// <para>The extended key usages.</para>
                /// </summary>
                [NameInMap("ExtendedKeyUsages")]
                [Validation(Required=false)]
                public List<string> ExtendedKeyUsages { get; set; }

                /// <summary>
                /// <para>The certificate path length constraint. For an end-entity CA, set this parameter to 0. A value of 0 indicates the CA will issue end-entity certificates.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PathLenConstraint")]
                [Validation(Required=false)]
                public int? PathLenConstraint { get; set; }

            }

            /// <summary>
            /// <para>The subject information for the CA certificate. If specified, this value overwrites the SubjectDN from the CSR.</para>
            /// </summary>
            [NameInMap("Subject")]
            [Validation(Required=false)]
            public CreateExternalCACertificateRequestApiPassthroughSubject Subject { get; set; }
            public class CreateExternalCACertificateRequestApiPassthroughSubject : TeaModel {
                /// <summary>
                /// <para>The name of the CA certificate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Testing CA</para>
                /// </summary>
                [NameInMap("CommonName")]
                [Validation(Required=false)]
                public string CommonName { get; set; }

                /// <summary>
                /// <para>The two-letter country code (ISO 3166-1).</para>
                /// 
                /// <b>Example:</b>
                /// <para>CN</para>
                /// </summary>
                [NameInMap("Country")]
                [Validation(Required=false)]
                public string Country { get; set; }

                /// <summary>
                /// <para>The city or region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Hangzhou</para>
                /// </summary>
                [NameInMap("Locality")]
                [Validation(Required=false)]
                public string Locality { get; set; }

                /// <summary>
                /// <para>The organization or company.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Alibaba</para>
                /// </summary>
                [NameInMap("Organization")]
                [Validation(Required=false)]
                public string Organization { get; set; }

                /// <summary>
                /// <para>The organizational subdivision, such as a department, team, project group, or branch.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Cloud Security</para>
                /// </summary>
                [NameInMap("OrganizationUnit")]
                [Validation(Required=false)]
                public string OrganizationUnit { get; set; }

                /// <summary>
                /// <para>The state or province.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Zhejiang</para>
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

            }

        }

        [NameInMap("CertMaxTime")]
        [Validation(Required=false)]
        public int? CertMaxTime { get; set; }

        /// <summary>
        /// <para>The certificate signing request (CSR). The CSR can contain information such as the SubjectDN and custom extensions for the CA certificate. The CA generates the SubjectKeyIdentifier, AuthorityKeyIdentifier, and CRLDistributionPoints extensions, ignoring any corresponding values in the CSR.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN CERTIFICATE REQUEST-----
        /// MIIBczCCARgCAQAwgYoxFDASBgNVBAMMC2FsaXl1bi50ZXN0MQ0wCwYDVQQ
        /// ...
        /// vbIgMQIhAKHDWD6/WAMbtezAt4bysJ/BZIDz1jPWuUR5GV4TJ/mS
        /// -----END CERTIFICATE REQUEST-----</para>
        /// </summary>
        [NameInMap("Csr")]
        [Validation(Required=false)]
        public string Csr { get; set; }

        /// <summary>
        /// <para>The ID of the external subordinate CA instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cas_deposit-cn-1234abcd</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The tags to add to the certificate.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<CreateExternalCACertificateRequestTags> Tags { get; set; }
        public class CreateExternalCACertificateRequestTags : TeaModel {
            /// <summary>
            /// <para>The tag\&quot;s key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>database</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag\&quot;s value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The certificate validity period. You can specify this using either relative or absolute time.</para>
        /// <remarks>
        /// <para>Relative time: Supported units are year, month, and day.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>y - year</para>
        /// </description></item>
        /// <item><description><para>m - month</para>
        /// </description></item>
        /// <item><description><para>d - day</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Absolute time: Use GMT time in the <c>yyyy-MM-dd\\&quot;T\\&quot;HH:mm:ss\\&quot;Z\\&quot;</c> format.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>To specify only the expiration time, use <c>$NotAfter</c>.</para>
        /// </description></item>
        /// <item><description><para>To specify both the start and expiration times, use <c>$NotBefore/$NotAfter</c>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10y</para>
        /// </summary>
        [NameInMap("Validity")]
        [Validation(Required=false)]
        public string Validity { get; set; }

    }

}
