// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200630.Models
{
    public class CreateServerCertificateRequest : TeaModel {
        /// <summary>
        /// <para>The expiration time of the server certificate in timestamp format. Unit: seconds.</para>
        /// <remarks>
        /// <para>The <b>BeforeTime</b> and <b>AfterTime</b> parameters must both be empty or both be specified.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1665819958</para>
        /// </summary>
        [NameInMap("AfterTime")]
        [Validation(Required=false)]
        public long? AfterTime { get; set; }

        /// <summary>
        /// <para>The key algorithm of the server certificate. The key algorithm is in the <c>&lt;encryption algorithm&gt;_&lt;key length&gt;</c> format. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>RSA_1024</b>: The signature algorithm is Sha256WithRSA.</description></item>
        /// <item><description><b>RSA_2048</b>: The signature algorithm is Sha256WithRSA.</description></item>
        /// <item><description><b>RSA_4096</b>: The signature algorithm is Sha256WithRSA.</description></item>
        /// <item><description><b>ECC_256</b>: The signature algorithm is Sha256WithECDSA.</description></item>
        /// <item><description><b>ECC_384</b>: The signature algorithm is Sha256WithECDSA.</description></item>
        /// <item><description><b>ECC_512</b>: The signature algorithm is Sha256WithECDSA.</description></item>
        /// <item><description><b>SM2_256</b>: The signature algorithm is SM3WithSM2.</description></item>
        /// </list>
        /// <para>The encryption algorithm of the server certificate must be the same as that of the subordinate CA certificate, but the key length can be different. For example, if the key algorithm of the subordinate CA certificate is RSA_2048, the key algorithm of the server certificate must be RSA_1024, RSA_2048, or RSA_4096.</para>
        /// <remarks>
        /// <para>You can call <a href="https://help.aliyun.com/document_detail/465954.html">DescribeCACertificate</a> to query the key algorithm of the subordinate CA certificate.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RSA_2048</para>
        /// </summary>
        [NameInMap("Algorithm")]
        [Validation(Required=false)]
        public string Algorithm { get; set; }

        /// <summary>
        /// <para>The asynchronous processing flag. If the value is &quot;true&quot;, the backend service issues the certificate asynchronously.
        /// After the request is submitted, you can call the ListClientCertificate operation to obtain the latest certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AsynchronousFlag")]
        [Validation(Required=false)]
        public bool? AsynchronousFlag { get; set; }

        /// <summary>
        /// <para>The issuance time of the server certificate in timestamp format. Default value: the time when you call this operation. Unit: seconds.</para>
        /// <remarks>
        /// <para>The <b>BeforeTime</b> and <b>AfterTime</b> parameters must both be empty or both be specified.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1634283958</para>
        /// </summary>
        [NameInMap("BeforeTime")]
        [Validation(Required=false)]
        public long? BeforeTime { get; set; }

        /// <summary>
        /// <para>The name of the certificate user. For a server authentication (ServerAuth) certificate, the user is a server. Enter the domain name or IP address bound to the server.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.example.com">www.example.com</a></para>
        /// </summary>
        [NameInMap("CommonName")]
        [Validation(Required=false)]
        public string CommonName { get; set; }

        /// <summary>
        /// <para>The country code, such as CN or US.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CN</para>
        /// </summary>
        [NameInMap("Country")]
        [Validation(Required=false)]
        public string Country { get; set; }

        /// <summary>
        /// <para>The custom identifier, which is a unique key.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>6bb538d538c70c01f81dg3</b></b></para>
        /// </summary>
        [NameInMap("CustomIdentifier")]
        [Validation(Required=false)]
        public string CustomIdentifier { get; set; }

        /// <summary>
        /// <para>The validity period of the server certificate. Unit: days.
        /// The <b>Days</b>, <b>BeforeTime</b>, and <b>AfterTime</b> parameters cannot all be empty. The <b>BeforeTime</b> and <b>AfterTime</b> parameters must both be empty or both be specified. The following rules apply:</para>
        /// <list type="bullet">
        /// <item><description><para>If you set the <b>Days</b> parameter, you can choose to set or not set the <b>BeforeTime</b> and <b>AfterTime</b> parameters.</para>
        /// </description></item>
        /// <item><description><para>If you do not set the <b>Days</b> parameter, you must set the <b>BeforeTime</b> and <b>AfterTime</b> parameters.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If you set the <b>Days</b>, <b>BeforeTime</b>, and <b>AfterTime</b> parameters at the same time, the validity period of the server certificate is determined by the value of the <b>Days</b> parameter.</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>The validity period of the server certificate cannot exceed the validity period of the subordinate CA certificate. You can call <a href="https://help.aliyun.com/document_detail/465954.html">DescribeCACertificate</a> to query the validity period of the subordinate CA certificate.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>365</para>
        /// </summary>
        [NameInMap("Days")]
        [Validation(Required=false)]
        public int? Days { get; set; }

        /// <summary>
        /// <para>The extended domain names and extended IP addresses of the server certificate. After you add extended information to the certificate, you can apply the certificate to multiple domain names and IP addresses.</para>
        /// <para>Separate multiple domain names and IP addresses with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>Specifies whether to include the Certificate Revocation List (CRL) address. Valid values:</para>
        /// <para>0: no. </para>
        /// <para>1: yes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("EnableCrl")]
        [Validation(Required=false)]
        public long? EnableCrl { get; set; }

        /// <summary>
        /// <para>Specifies whether to immediately return the digital certificate. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: does not return the certificate. This is the default value.</description></item>
        /// <item><description><b>1</b>: returns the certificate.</description></item>
        /// <item><description><b>2</b>: returns the certificate and its certificate chain.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Immediately")]
        [Validation(Required=false)]
        public int? Immediately { get; set; }

        /// <summary>
        /// <para>The name of the city where the certificate organization is located. Chinese and English characters are supported.
        /// Default value: the name of the city where the organization of the subordinate CA certificate that issues this certificate is located.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Hangzhou</para>
        /// </summary>
        [NameInMap("Locality")]
        [Validation(Required=false)]
        public string Locality { get; set; }

        /// <summary>
        /// <para>The certificate validity period. Unit: months.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("Months")]
        [Validation(Required=false)]
        public int? Months { get; set; }

        /// <summary>
        /// <para>The organization name. Default value: Alibaba Inc.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Alibaba Cloud</para>
        /// </summary>
        [NameInMap("Organization")]
        [Validation(Required=false)]
        public string Organization { get; set; }

        /// <summary>
        /// <para>The department name. Default value: Aliyun CDN.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IT</para>
        /// </summary>
        [NameInMap("OrganizationUnit")]
        [Validation(Required=false)]
        public string OrganizationUnit { get; set; }

        /// <summary>
        /// <para>The unique identifier of the subordinate CA certificate that issues this certificate.</para>
        /// <remarks>
        /// <para>You can call <a href="https://help.aliyun.com/document_detail/465957.html">DescribeCACertificateList</a> to query the unique identifier of the subordinate CA certificate.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>271ae6bb538d538c70c01f81dg3****</para>
        /// </summary>
        [NameInMap("ParentIdentifier")]
        [Validation(Required=false)]
        public string ParentIdentifier { get; set; }

        /// <summary>
        /// <para>The resource group ID. You can obtain this ID by calling the <a href="https://help.aliyun.com/document_detail/2716559.html">ListResources</a> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>&lt;props=&quot;china&quot;&gt;The name of the province, municipality, or autonomous region where the certificate organization is located. Chinese and English characters are supported. Default value: the name of the province, municipality, or autonomous region where the organization of the subordinate CA certificate that issues this certificate is located.
        /// &lt;props=&quot;intl&quot;&gt;The name of the province or state where the certificate organization is located. Chinese and English characters are supported. Default value: the name of the province or state where the organization of the subordinate CA certificate that issues this certificate is located.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Zhejiang</para>
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// <para>The tag list.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<CreateServerCertificateRequestTags> Tags { get; set; }
        public class CreateServerCertificateRequestTags : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>account</para>
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
        /// <para>The certificate validity period. Unit: years.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Years")]
        [Validation(Required=false)]
        public int? Years { get; set; }

    }

}
