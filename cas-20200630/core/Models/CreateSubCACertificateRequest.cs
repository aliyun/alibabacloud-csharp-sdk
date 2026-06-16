// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200630.Models
{
    public class CreateSubCACertificateRequest : TeaModel {
        /// <summary>
        /// <para>The key algorithm for the intermediate CA certificate. The algorithm is in the <c>&lt;Encryption algorithm&gt;_&lt;Key length&gt;</c> format. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>RSA_1024</b>: The corresponding signature algorithm is Sha256WithRSA.</para>
        /// </description></item>
        /// <item><description><para><b>RSA_2048</b>: The corresponding signature algorithm is Sha256WithRSA.</para>
        /// </description></item>
        /// <item><description><para><b>RSA_4096</b>: The corresponding signature algorithm is Sha256WithRSA.</para>
        /// </description></item>
        /// <item><description><para><b>ECC_256</b>: The corresponding signature algorithm is Sha256WithECDSA.</para>
        /// </description></item>
        /// <item><description><para><b>SM2_256</b>: The corresponding signature algorithm is SM3WithSM2.</para>
        /// </description></item>
        /// </list>
        /// <para>The encryption algorithm of the intermediate CA certificate must be the same as that of the root CA certificate, but the key length can be different. For example, if the root CA certificate uses the <b>RSA_2048</b> algorithm, the intermediate CA certificate must use <b>RSA_1024</b>, <b>RSA_2048</b>, or <b>RSA_4096</b>.</para>
        /// <remarks>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/465954.html">DescribeCACertificate</a> operation to get the key algorithm of the root CA certificate.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RSA_2048</para>
        /// </summary>
        [NameInMap("Algorithm")]
        [Validation(Required=false)]
        public string Algorithm { get; set; }

        [NameInMap("CertMaxTime")]
        [Validation(Required=false)]
        public int? CertMaxTime { get; set; }

        /// <summary>
        /// <para>A client-generated token that is used to ensure the idempotence of the request. The token must be unique for each request. The token can be up to 64 ASCII characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>XXX</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The common name of your organization. The name can contain Chinese characters and English letters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Aliyun</para>
        /// </summary>
        [NameInMap("CommonName")]
        [Validation(Required=false)]
        public string CommonName { get; set; }

        /// <summary>
        /// <para>The two- or three-letter country or region code in uppercase. For example, <b>CN</b> indicates China and <b>US</b> indicates the United States.</para>
        /// <para>For more information, see the <b>Country codes</b> section in <a href="https://help.aliyun.com/document_detail/198289.html">Manage company information</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CN</para>
        /// </summary>
        [NameInMap("CountryCode")]
        [Validation(Required=false)]
        public string CountryCode { get; set; }

        /// <summary>
        /// <para>The validity period of the CRL, in days. Valid values: 1 to 365.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("CrlDay")]
        [Validation(Required=false)]
        public int? CrlDay { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the certificate revocation list (CRL) feature.</para>
        /// <list type="bullet">
        /// <item><description><para>false: No</para>
        /// </description></item>
        /// <item><description><para>true: Yes</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableCrl")]
        [Validation(Required=false)]
        public bool? EnableCrl { get; set; }

        /// <summary>
        /// <para>The extended key usages.</para>
        /// </summary>
        [NameInMap("ExtendedKeyUsages")]
        [Validation(Required=false)]
        public List<string> ExtendedKeyUsages { get; set; }

        /// <summary>
        /// <para>The name of the city where your organization is located. The name can contain Chinese characters and English letters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Hangzhou</para>
        /// </summary>
        [NameInMap("Locality")]
        [Validation(Required=false)]
        public string Locality { get; set; }

        /// <summary>
        /// <para>The name of your organization, such as your company. The name can contain Chinese characters and English letters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Alibaba</para>
        /// </summary>
        [NameInMap("Organization")]
        [Validation(Required=false)]
        public string Organization { get; set; }

        /// <summary>
        /// <para>The name of the department in your organization. The name can contain Chinese characters and English letters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Security</para>
        /// </summary>
        [NameInMap("OrganizationUnit")]
        [Validation(Required=false)]
        public string OrganizationUnit { get; set; }

        /// <summary>
        /// <para>The unique identifier of the root CA certificate.</para>
        /// <remarks>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/465957.html">DescribeCACertificateList</a> operation to get the unique identifiers of all CA certificates.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1a83bcbb89e562885e40aa0108f5****</para>
        /// </summary>
        [NameInMap("ParentIdentifier")]
        [Validation(Required=false)]
        public string ParentIdentifier { get; set; }

        /// <summary>
        /// <para>The certificate path length constraint. The default value is 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("PathLenConstraint")]
        [Validation(Required=false)]
        public int? PathLenConstraint { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-ae****vty</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>&lt;props=&quot;china&quot;&gt;The name of the province, municipality, or autonomous region where the organization is located. Chinese characters and English letters are supported.
        /// &lt;props=&quot;intl&quot;&gt;The name of the province or state where the organization is located. Chinese characters and English letters are supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Zhejiang</para>
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// <para>A list of tags.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<CreateSubCACertificateRequestTags> Tags { get; set; }
        public class CreateSubCACertificateRequestTags : TeaModel {
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
            /// <para>test</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The validity period of the intermediate CA certificate, in years. Valid values: 5 to 10.</para>
        /// <para>Set this parameter to a value from 5 to 10.</para>
        /// <remarks>
        /// <para>The validity period of the intermediate CA certificate cannot exceed that of the root CA certificate. Call the <a href="https://help.aliyun.com/document_detail/465954.html">DescribeCACertificate</a> operation to get the validity period of the root CA certificate.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("Years")]
        [Validation(Required=false)]
        public int? Years { get; set; }

    }

}
