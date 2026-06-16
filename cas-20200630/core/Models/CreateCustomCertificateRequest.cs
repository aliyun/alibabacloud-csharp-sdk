// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200630.Models
{
    public class CreateCustomCertificateRequest : TeaModel {
        /// <summary>
        /// <para>Pass-through parameters.</para>
        /// </summary>
        [NameInMap("ApiPassthrough")]
        [Validation(Required=false)]
        public CreateCustomCertificateRequestApiPassthrough ApiPassthrough { get; set; }
        public class CreateCustomCertificateRequestApiPassthrough : TeaModel {
            /// <summary>
            /// <para>The certificate extensions.</para>
            /// </summary>
            [NameInMap("Extensions")]
            [Validation(Required=false)]
            public CreateCustomCertificateRequestApiPassthroughExtensions Extensions { get; set; }
            public class CreateCustomCertificateRequestApiPassthroughExtensions : TeaModel {
                /// <summary>
                /// <para>If an extension is critical, its name is included in the criticals list.</para>
                /// </summary>
                [NameInMap("Criticals")]
                [Validation(Required=false)]
                public List<string> Criticals { get; set; }

                /// <summary>
                /// <para>The extended key usages.</para>
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
                    /// <para>Content commitment. Formerly known as NonRepudiation. Allows the certificate key to be used for content commitment.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("ContentCommitment")]
                    [Validation(Required=false)]
                    public bool? ContentCommitment { get; set; }

                    /// <summary>
                    /// <para>Data encipherment.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("DataEncipherment")]
                    [Validation(Required=false)]
                    public bool? DataEncipherment { get; set; }

                    /// <summary>
                    /// <para>When KeyAgreement is true, this marks that the certificate key can only be used for decryption.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("DecipherOnly")]
                    [Validation(Required=false)]
                    public bool? DecipherOnly { get; set; }

                    /// <summary>
                    /// <para>Digital signature. Allows the private key of the certificate to be used for digital signatures and the public key to be used to verify digital signatures.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("DigitalSignature")]
                    [Validation(Required=false)]
                    public bool? DigitalSignature { get; set; }

                    /// <summary>
                    /// <para>When KeyAgreement is true, this marks that the certificate key can only be used for encryption.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("EncipherOnly")]
                    [Validation(Required=false)]
                    public bool? EncipherOnly { get; set; }

                    /// <summary>
                    /// <para>Key agreement.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("KeyAgreement")]
                    [Validation(Required=false)]
                    public bool? KeyAgreement { get; set; }

                    /// <summary>
                    /// <para>Key encipherment. Allows the certificate key to be used to encrypt other keys.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("KeyEncipherment")]
                    [Validation(Required=false)]
                    public bool? KeyEncipherment { get; set; }

                    /// <summary>
                    /// <para>Non-repudiation. This has been renamed to ContentCommitment in the X.509 standard.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("NonRepudiation")]
                    [Validation(Required=false)]
                    public bool? NonRepudiation { get; set; }

                }

                /// <summary>
                /// <para>The subject alternative names (SANs) of the certificate.</para>
                /// </summary>
                [NameInMap("SubjectAlternativeNames")]
                [Validation(Required=false)]
                public List<CreateCustomCertificateRequestApiPassthroughExtensionsSubjectAlternativeNames> SubjectAlternativeNames { get; set; }
                public class CreateCustomCertificateRequestApiPassthroughExtensionsSubjectAlternativeNames : TeaModel {
                    /// <summary>
                    /// <para>The following values are allowed:</para>
                    /// <list type="bullet">
                    /// <item><description><para>rfc822Name - Email address</para>
                    /// </description></item>
                    /// <item><description><para>dNSName - Domain name</para>
                    /// </description></item>
                    /// <item><description><para>uniformResourceIdentifier - Uniform Resource Identifier (URI)</para>
                    /// </description></item>
                    /// <item><description><para>iPAddress - IP address</para>
                    /// </description></item>
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
                    /// <para>A value that matches the specified Type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>rfc822Name:
                    /// example.aliyundoc.com</para>
                    /// <para>dNSName:
                    /// learn.aliyundoc.com</para>
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
            /// <para>The custom serial number of the certificate. Must be a long integer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16889526086333</para>
            /// </summary>
            [NameInMap("SerialNumber")]
            [Validation(Required=false)]
            public string SerialNumber { get; set; }

            /// <summary>
            /// <para>The certificate subject.</para>
            /// </summary>
            [NameInMap("Subject")]
            [Validation(Required=false)]
            public CreateCustomCertificateRequestApiPassthroughSubject Subject { get; set; }
            public class CreateCustomCertificateRequestApiPassthroughSubject : TeaModel {
                /// <summary>
                /// <para>The common name of the certificate user.</para>
                /// 
                /// <b>Example:</b>
                /// <para>张三</para>
                /// </summary>
                [NameInMap("CommonName")]
                [Validation(Required=false)]
                public string CommonName { get; set; }

                /// <summary>
                /// <para>The country code. Use the two-letter country code from ISO 3166-1. For more information, see <a href="https://www.iso.org/obp/ui/#search/code/">ISO</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CN</para>
                /// </summary>
                [NameInMap("Country")]
                [Validation(Required=false)]
                public string Country { get; set; }

                /// <summary>
                /// <para>The custom subject properties of the certificate.</para>
                /// </summary>
                [NameInMap("CustomAttributes")]
                [Validation(Required=false)]
                public List<CreateCustomCertificateRequestApiPassthroughSubjectCustomAttributes> CustomAttributes { get; set; }
                public class CreateCustomCertificateRequestApiPassthroughSubjectCustomAttributes : TeaModel {
                    /// <summary>
                    /// <para>The key of the custom property. It must comply with industry standards. Examples:</para>
                    /// <list type="bullet">
                    /// <item><description><para>2.5.4.6: Country code</para>
                    /// </description></item>
                    /// <item><description><para>2.5.4.10: Organization</para>
                    /// </description></item>
                    /// <item><description><para>2.5.4.11: Organizational unit name</para>
                    /// </description></item>
                    /// <item><description><para>2.5.4.12: Title</para>
                    /// </description></item>
                    /// <item><description><para>2.5.4.3: Common name</para>
                    /// </description></item>
                    /// <item><description><para>2.5.4.9: Street</para>
                    /// </description></item>
                    /// <item><description><para>2.5.4.5: Serial number</para>
                    /// </description></item>
                    /// <item><description><para>2.5.4.7: Locality</para>
                    /// </description></item>
                    /// <item><description><para>2.5.4.8: State or province</para>
                    /// </description></item>
                    /// <item><description><para>1.3.6.1.4.1.37244.1.1: Matter certificate - Node ID</para>
                    /// </description></item>
                    /// <item><description><para>1.3.6.1.4.1.37244.1.5: Matter certificate - Fabric ID</para>
                    /// </description></item>
                    /// <item><description><para>1.3.6.1.4.1.37244.2.1: Matter certificate Vendor ID (VID)</para>
                    /// </description></item>
                    /// <item><description><para>1.3.6.1.4.1.37244.2.2: Matter certificate Product ID (PID)</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2.5.4.3</para>
                    /// </summary>
                    [NameInMap("ObjectIdentifier")]
                    [Validation(Required=false)]
                    public string ObjectIdentifier { get; set; }

                    /// <summary>
                    /// <para>The value of the custom property.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Aliyun</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The name of the city where the organization is located. Chinese characters and letters are supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>杭州市</para>
                /// </summary>
                [NameInMap("Locality")]
                [Validation(Required=false)]
                public string Locality { get; set; }

                /// <summary>
                /// <para>The name of the organization.</para>
                /// 
                /// <b>Example:</b>
                /// <para>XXX公司</para>
                /// </summary>
                [NameInMap("Organization")]
                [Validation(Required=false)]
                public string Organization { get; set; }

                /// <summary>
                /// <para>The name of the department or branch within the organization.</para>
                /// 
                /// <b>Example:</b>
                /// <para>XXX部门</para>
                /// </summary>
                [NameInMap("OrganizationUnit")]
                [Validation(Required=false)]
                public string OrganizationUnit { get; set; }

                /// <summary>
                /// <para>The province or state where the organization is located.</para>
                /// 
                /// <b>Example:</b>
                /// <para>浙江省</para>
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

            }

        }

        /// <summary>
        /// <para>The content of the CSR. You can generate a CSR using tools such as OpenSSL or Keytool. For more information, see <a href="https://help.aliyun.com/document_detail/42218.html">Create a CSR file</a>.</para>
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
        /// <para>Specifies whether to include a CRL address.</para>
        /// <list type="bullet">
        /// <item><description><para>0 - No</para>
        /// </description></item>
        /// <item><description><para>1 - Yes</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("EnableCrl")]
        [Validation(Required=false)]
        public long? EnableCrl { get; set; }

        /// <summary>
        /// <para>Obtain the certificate immediately.</para>
        /// <list type="bullet">
        /// <item><description><para>0 - Issue the certificate asynchronously.</para>
        /// </description></item>
        /// <item><description><para>1 - Issue the certificate immediately.</para>
        /// </description></item>
        /// <item><description><para>2 - Issue the certificate immediately and return the CA certificate chain.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Immediately")]
        [Validation(Required=false)]
        public int? Immediately { get; set; }

        /// <summary>
        /// <para>The identifier of the CA certificate.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1ed4068c-6f1b-6deb-8e32-3f8439a851cb</para>
        /// </summary>
        [NameInMap("ParentIdentifier")]
        [Validation(Required=false)]
        public string ParentIdentifier { get; set; }

        /// <summary>
        /// <para>The ID of the resource group. You can obtain this ID by calling the <a href="https://help.aliyun.com/document_detail/2716559.html">ListResources</a> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aek****wia</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The list of tags.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<CreateCustomCertificateRequestTags> Tags { get; set; }
        public class CreateCustomCertificateRequestTags : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testKey</para>
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
        /// <para>The validity period of the certificate. This period cannot exceed the validity period of the instance. You can use relative time or absolute time.</para>
        /// <para>Relative time: Supports years, months, and days.</para>
        /// <list type="bullet">
        /// <item><description><para>Year - y</para>
        /// </description></item>
        /// <item><description><para>Month - m</para>
        /// </description></item>
        /// <item><description><para>Day - d</para>
        /// </description></item>
        /// </list>
        /// <para>Absolute time: Uses GMT. Format: <c>yyyy-MM-dd\\&quot;T\\&quot;HH:mm:ss\\&quot;Z\\&quot;</c></para>
        /// <list type="bullet">
        /// <item><description><para>Specify the end time - $NotAfter</para>
        /// </description></item>
        /// <item><description><para>Specify the start and end times - $NotBefore/$NotAfter</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>相对时间：
        /// ● 1y
        /// ● 3m
        /// ● 7d</para>
        /// <para>绝对时间：
        /// ● 2006-01-02T15:04:05Z
        /// ● 2006-01-02T15:04:05Z/2023-03-09T17:48:13Z</para>
        /// </summary>
        [NameInMap("Validity")]
        [Validation(Required=false)]
        public string Validity { get; set; }

        /// <summary>
        /// <para>A custom identifier.</para>
        /// 
        /// <b>Example:</b>
        /// <para>XXX068c-6f1b-6deb-8e32-3f8439a8XXX</para>
        /// </summary>
        [NameInMap("customIdentifier")]
        [Validation(Required=false)]
        public string CustomIdentifier { get; set; }

    }

}
