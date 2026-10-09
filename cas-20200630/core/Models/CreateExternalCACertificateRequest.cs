// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200630.Models
{
    public class CreateExternalCACertificateRequest : TeaModel {
        /// <summary>
        /// <para>Overrides CSR content or adds content to the CA certificate through API parameters.</para>
        /// </summary>
        [NameInMap("ApiPassthrough")]
        [Validation(Required=false)]
        public CreateExternalCACertificateRequestApiPassthrough ApiPassthrough { get; set; }
        public class CreateExternalCACertificateRequestApiPassthrough : TeaModel {
            /// <summary>
            /// <para>The CA certificate extensions. If this value is specified, it overrides the extension values in the CSR or adds them to the CA certificate extensions.</para>
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
                /// <para>The certificate path length constraint. For an EndEntity CA, this value must be set to 0, which means the current CA certificate is used to issue end entity certificates.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PathLenConstraint")]
                [Validation(Required=false)]
                public int? PathLenConstraint { get; set; }

            }

            /// <summary>
            /// <para>The subject information of the CA certificate. If this value is specified, it overrides the SubjectDN in the CSR.</para>
            /// </summary>
            [NameInMap("Subject")]
            [Validation(Required=false)]
            public CreateExternalCACertificateRequestApiPassthroughSubject Subject { get; set; }
            public class CreateExternalCACertificateRequestApiPassthroughSubject : TeaModel {
                /// <summary>
                /// <para>The name of the current CA certificate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Testing CA</para>
                /// </summary>
                [NameInMap("CommonName")]
                [Validation(Required=false)]
                public string CommonName { get; set; }

                /// <summary>
                /// <para>The country. Uses the ISO 3166-1 two-letter country code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CN</para>
                /// </summary>
                [NameInMap("Country")]
                [Validation(Required=false)]
                public string Country { get; set; }

                /// <summary>
                /// <para>The city or locality.</para>
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
                /// <para>The organizational unit within the organization, such as a department, team, project group, or branch.</para>
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

        /// <summary>
        /// <para>The maximum validity period for issued certificates, as specified by the certMaxTime of the CA. Unit: days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("CertMaxTime")]
        [Validation(Required=false)]
        public int? CertMaxTime { get; set; }

        /// <summary>
        /// <para>The certificate signing request. The CSR can contain the SubjectDN and custom extensions of the CA certificate. The SubjectKeyIdentifier, AuthorityKeyIdentifier, and CRLDistributionPoints certificate extensions are generated by the CA, and the values in the CSR are ignored.</para>
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
        /// <para>The instance ID of the external subordinate CA instance to activate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cas_deposit-cn-1234abcd</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The list of tags.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<CreateExternalCACertificateRequestTags> Tags { get; set; }
        public class CreateExternalCACertificateRequestTags : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>database</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The certificate validity period. Both relative time and absolute time are supported.</para>
        /// <remarks>
        /// <para>Relative time: Supports the units of year, month, and day.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>Year - y</description></item>
        /// <item><description>Month - m</description></item>
        /// <item><description>Day - d</description></item>
        /// </list>
        /// <remarks>
        /// <para>Absolute time: Uses GMT time. Format: <c>yyyy-MM-dd\\&quot;T\\&quot;HH:mm:ss\\&quot;Z\\&quot;</c></para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>Specify the end time - <c>$NotAfter</c></description></item>
        /// <item><description>Specify the start time and end time - <c>$NotBefore/$NotAfter</c></description></item>
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
