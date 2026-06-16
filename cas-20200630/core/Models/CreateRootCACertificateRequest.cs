// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200630.Models
{
    public class CreateRootCACertificateRequest : TeaModel {
        /// <summary>
        /// <para>The key algorithm of the root CA certificate. The key algorithm is in the <c>&lt;encryption algorithm&gt;_&lt;key length&gt;</c> format. Valid values:</para>
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
        /// <para>The encryption algorithm of the root CA certificate must be the same as the <b>Certificate Algorithm</b> of the private root CA that you purchased. For example, if you set <b>Certificate Algorithm</b> to <b>RSA</b> when you purchase a private root CA, the key algorithm of the root CA certificate must be <b>RSA_1024</b>, <b>RSA_2048</b>, or <b>RSA_4096</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RSA_2048</para>
        /// </summary>
        [NameInMap("Algorithm")]
        [Validation(Required=false)]
        public string Algorithm { get; set; }

        /// <summary>
        /// <para>A client token to ensure the idempotence of the request.</para>
        /// <para>Generate a unique value for this parameter from your client. The token supports only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system uses the <b>RequestId</b> of the request as the <b>ClientToken</b>. The <b>RequestId</b> may be different for each request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3838B684-3075-582B-9A45-8C99104029DF</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The common name or abbreviation of the organization. Supports Chinese characters and letters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Alibaba</para>
        /// </summary>
        [NameInMap("CommonName")]
        [Validation(Required=false)]
        public string CommonName { get; set; }

        /// <summary>
        /// <para>The two-letter uppercase code of the country or region where the organization is located. For example, <b>CN</b> indicates China and <b>US</b> indicates the United States.</para>
        /// <para>For more information about country codes, see the <b>Country codes</b> section in <a href="https://help.aliyun.com/document_detail/198289.html">Manage company information</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CN</para>
        /// </summary>
        [NameInMap("CountryCode")]
        [Validation(Required=false)]
        public string CountryCode { get; set; }

        /// <summary>
        /// <para>The name of the city where the organization is located. Supports Chinese characters and letters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Hangzhou</para>
        /// </summary>
        [NameInMap("Locality")]
        [Validation(Required=false)]
        public string Locality { get; set; }

        /// <summary>
        /// <para>The name of the organization for the root CA certificate. This is typically your company or enterprise name. Supports Chinese characters and letters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Aliyun</para>
        /// </summary>
        [NameInMap("Organization")]
        [Validation(Required=false)]
        public string Organization { get; set; }

        /// <summary>
        /// <para>The name of the department or branch in the organization. Supports Chinese characters and letters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Security</para>
        /// </summary>
        [NameInMap("OrganizationUnit")]
        [Validation(Required=false)]
        public string OrganizationUnit { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aek****wia</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>&lt;props=&quot;intl&quot;&gt;The name of the province or state where the organization is located. Supports Chinese characters and letters.</para>
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
        public List<CreateRootCACertificateRequestTags> Tags { get; set; }
        public class CreateRootCACertificateRequestTags : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>runtime</para>
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
        /// <para>The validity period of the root CA certificate. Unit: years.</para>
        /// <remarks>
        /// <para>Set the validity period to 5 to 10 years.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Years")]
        [Validation(Required=false)]
        public int? Years { get; set; }

    }

}
