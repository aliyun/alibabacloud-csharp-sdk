// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200630.Models
{
    public class CreateCustomCertificateRequest : TeaModel {
        /// <summary>
        /// <para>The passthrough parameters.</para>
        /// </summary>
        [NameInMap("ApiPassthrough")]
        [Validation(Required=false)]
        public CreateCustomCertificateRequestApiPassthrough ApiPassthrough { get; set; }
        public class CreateCustomCertificateRequestApiPassthrough : TeaModel {
            /// <summary>
            /// <para>The extensions of the certificate.</para>
            /// </summary>
            [NameInMap("Extensions")]
            [Validation(Required=false)]
            public CreateCustomCertificateRequestApiPassthroughExtensions Extensions { get; set; }
            public class CreateCustomCertificateRequestApiPassthroughExtensions : TeaModel {
                /// <summary>
                /// <para>If it is a necessary parameter, the critical list contains the parameter name.</para>
                /// </summary>
                [NameInMap("Criticals")]
                [Validation(Required=false)]
                public List<string> Criticals { get; set; }

                /// <summary>
                /// <para>The extended key usage.</para>
                /// </summary>
                [NameInMap("ExtendedKeyUsages")]
                [Validation(Required=false)]
                public List<string> ExtendedKeyUsages { get; set; }

                /// <summary>
                /// <para>The key usage.</para>
                /// </summary>
                [NameInMap("KeyUsage")]
                [Validation(Required=false)]
                public CreateCustomCertificateRequestApiPassthroughExtensionsKeyUsage KeyUsage { get; set; }
                public class CreateCustomCertificateRequestApiPassthroughExtensionsKeyUsage : TeaModel {
                    /// <summary>
                    /// <para>The original name of the parameter is NonRepudiation.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("ContentCommitment")]
                    [Validation(Required=false)]
                    public bool? ContentCommitment { get; set; }

                    /// <summary>
                    /// <para>Specifies whether the key can be used for data encryption.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("DataEncipherment")]
                    [Validation(Required=false)]
                    public bool? DataEncipherment { get; set; }

                    /// <summary>
                    /// <para>Specifies whether the key can be used only for data decryption.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("DecipherOnly")]
                    [Validation(Required=false)]
                    public bool? DecipherOnly { get; set; }

                    /// <summary>
                    /// <para>Specifies whether the key can be used for digital signing. If you set this parameter to true, the private key of the certificate can be used to generate digital signatures, and the public key of the certificate can be used to verify digital signatures.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("DigitalSignature")]
                    [Validation(Required=false)]
                    public bool? DigitalSignature { get; set; }

                    /// <summary>
                    /// <para>Specifies whether the key can be used only for data encryption.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("EncipherOnly")]
                    [Validation(Required=false)]
                    public bool? EncipherOnly { get; set; }

                    /// <summary>
                    /// <para>Specifies whether the key can be used for key agreement.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("KeyAgreement")]
                    [Validation(Required=false)]
                    public bool? KeyAgreement { get; set; }

                    /// <summary>
                    /// <para>Specifies whether the key can be used for data encipherment.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("KeyEncipherment")]
                    [Validation(Required=false)]
                    public bool? KeyEncipherment { get; set; }

                    /// <summary>
                    /// <para>Specifies whether the key can be used for non-repudiation. This parameter is renamed ContentCommitment in the X.509 standard.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("NonRepudiation")]
                    [Validation(Required=false)]
                    public bool? NonRepudiation { get; set; }

                }

                /// <summary>
                /// <para>The aliases of the entities.</para>
                /// </summary>
                [NameInMap("SubjectAlternativeNames")]
                [Validation(Required=false)]
                public List<CreateCustomCertificateRequestApiPassthroughExtensionsSubjectAlternativeNames> SubjectAlternativeNames { get; set; }
                public class CreateCustomCertificateRequestApiPassthroughExtensionsSubjectAlternativeNames : TeaModel {
                    /// <summary>
                    /// <para>The type of the alias. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>rfc822Name: email address</description></item>
                    /// <item><description>dNSName: domain name</description></item>
                    /// <item><description>uniformResourceIdentifier: URI</description></item>
                    /// <item><description>iPAddress: IP address</description></item>
                    /// </list>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>dNSName</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// <para>The alias that meets the requirement of a specified type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>rfc822Name:
                    /// <a href="mailto:exmaple@certqa.cn">exmaple@certqa.cn</a></para>
                    /// <para>dNSName:
                    /// <a href="http://www.certqa.cn">www.certqa.cn</a></para>
                    /// <para>uniformResourceIdentifier:
                    /// acs:ecs:regionid:15619224785*****:instance/i-bp1bzvz55uz27hf*****</para>
                    /// <para>iPAddress:
                    /// 127.0.0.1</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

            /// <summary>
            /// <para>The serial number MUST be a positive integer assigned by the CA to each certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16889526086333</para>
            /// </summary>
            [NameInMap("SerialNumber")]
            [Validation(Required=false)]
            public string SerialNumber { get; set; }

            /// <summary>
            /// <para>The name of the entity that uses the certificate.</para>
            /// </summary>
            [NameInMap("Subject")]
            [Validation(Required=false)]
            public CreateCustomCertificateRequestApiPassthroughSubject Subject { get; set; }
            public class CreateCustomCertificateRequestApiPassthroughSubject : TeaModel {
                /// <summary>
                /// <para>The common name of the certificate user.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Bob</para>
                /// </summary>
                [NameInMap("CommonName")]
                [Validation(Required=false)]
                public string CommonName { get; set; }

                /// <summary>
                /// <para>The code of the country. The value is an alpha-2 country code that complies with the ISO 3166-1 standard. For more information about country codes, visit <a href="https://www.iso.org/obp/ui/#search/code/">https://www.iso.org/obp/ui/#search/code/</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CN</para>
                /// </summary>
                [NameInMap("Country")]
                [Validation(Required=false)]
                public string Country { get; set; }

                /// <summary>
                /// <para>Customize the Subject attributes of the certificate.</para>
                /// </summary>
                [NameInMap("CustomAttributes")]
                [Validation(Required=false)]
                public List<CreateCustomCertificateRequestApiPassthroughSubjectCustomAttributes> CustomAttributes { get; set; }
                public class CreateCustomCertificateRequestApiPassthroughSubjectCustomAttributes : TeaModel {
                    /// <summary>
                    /// <para>Custom attribute type as:</para>
                    /// <list type="bullet">
                    /// <item><description>2.5.4.6 : country</description></item>
                    /// <item><description>2.5.4.10 : organization</description></item>
                    /// <item><description>2.5.4.11 : organizational unit</description></item>
                    /// <item><description>2.5.4.12 : title</description></item>
                    /// <item><description>2.5.4.3 : common name</description></item>
                    /// <item><description>2.5.4.9 : street</description></item>
                    /// <item><description>2.5.4.5 : serial number</description></item>
                    /// <item><description>2.5.4.7 : locality</description></item>
                    /// <item><description>2.5.4.8 : state</description></item>
                    /// <item><description>1.3.6.1.4.1.37244.1.1 : Matter Operational Certificate - Node ID</description></item>
                    /// <item><description>1.3.6.1.4.1.37244.1.5 : Matter Operational Certificate - Fabric ID</description></item>
                    /// <item><description>1.3.6.1.4.1.37244.2.1 : Matter Device Attestation Certificate Vender ID (VID)</description></item>
                    /// <item><description>1.3.6.1.4.1.37244.2.2 : Matter Device Attestation Certificate Product ID (PID).</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2.5.4.3</para>
                    /// </summary>
                    [NameInMap("ObjectIdentifier")]
                    [Validation(Required=false)]
                    public string ObjectIdentifier { get; set; }

                    /// <summary>
                    /// <para>Custom attribute value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Aliyun</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The name of the city in which the organization is located. The value can contain letters.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Hangzhou</para>
                /// </summary>
                [NameInMap("Locality")]
                [Validation(Required=false)]
                public string Locality { get; set; }

                /// <summary>
                /// <para>The name of the organization.</para>
                /// 
                /// <b>Example:</b>
                /// <para>XXX company</para>
                /// </summary>
                [NameInMap("Organization")]
                [Validation(Required=false)]
                public string Organization { get; set; }

                /// <summary>
                /// <para>The name of the department or branch in the organization.</para>
                /// 
                /// <b>Example:</b>
                /// <para>XXX department</para>
                /// </summary>
                [NameInMap("OrganizationUnit")]
                [Validation(Required=false)]
                public string OrganizationUnit { get; set; }

                /// <summary>
                /// <para>The name of the province or state in which the organization associated with the certificate is located.</para>
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
        /// <para>The content of the CSR. You can generate a CSR by using the OpenSSL tool or the Keytool tool. For more information, see <a href="https://help.aliyun.com/document_detail/42218.html">How do I create a CSR file?</a></para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN CERTIFICATE REQUEST-----
        /// MIIBczCCARgCAQAwgYoxFDASBgNVBAMMC2FsaXl1bi50ZXN0MQ0wCwYDVQQ
        /// ...
        /// ...
        /// ...
        /// vbIgMQIhAKHDWD6/WAMbtezAt4bysJ/BZIDz1jPWuUR5GV4TJ/mS
        /// -----END CERTIFICATE REQUEST-----</para>
        /// </summary>
        [NameInMap("Csr")]
        [Validation(Required=false)]
        public string Csr { get; set; }

        /// <summary>
        /// <para>include the CRL address.</para>
        /// <list type="bullet">
        /// <item><description>0- No</description></item>
        /// <item><description>1- Yes</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("EnableCrl")]
        [Validation(Required=false)]
        public long? EnableCrl { get; set; }

        /// <summary>
        /// <para>Specifies whether to immediately issue the certificate. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: asynchronously issues the certificate.</description></item>
        /// <item><description>1: immediately issues the certificate.</description></item>
        /// <item><description>2: immediately issues the certificate and returns the certificate chain.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Immediately")]
        [Validation(Required=false)]
        public int? Immediately { get; set; }

        /// <summary>
        /// <para>The identifier of the certificate.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1ed4068c-6f1b-6deb-8e32-3f8439a851cb</para>
        /// </summary>
        [NameInMap("ParentIdentifier")]
        [Validation(Required=false)]
        public string ParentIdentifier { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<CreateCustomCertificateRequestTags> Tags { get; set; }
        public class CreateCustomCertificateRequestTags : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The validity period of the certificate. The value cannot exceed the validity period of the certificate instance. Relative time and absolute time are supported.</para>
        /// <para>Units of relative time: year, month, and day.</para>
        /// <list type="bullet">
        /// <item><description>Use y to specify years.</description></item>
        /// <item><description>Use m to specify months.</description></item>
        /// <item><description>Use d to specify days.</description></item>
        /// </list>
        /// <para>Absolute time: Use Greenwich Mean Time (GMT). Format: <c>yyyy-MM-dd\\&quot;T\\&quot;HH:mm:ss\\&quot;Z\\&quot;</c></para>
        /// <list type="bullet">
        /// <item><description>Format of the end time: $NotAfter</description></item>
        /// <item><description>Format of the start time and end time: $NotBefore/$NotAfter</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Relative time:
        ///  ● 1y
        ///  ● 3m
        ///  ● 7d
        /// Absolute time: 
        /// ● 2006-01-02T15:04:05Z 
        /// ● 2006-01-02T15:04:05Z/2023-03-09T17:48:13Z</para>
        /// </summary>
        [NameInMap("Validity")]
        [Validation(Required=false)]
        public string Validity { get; set; }

    }

}
