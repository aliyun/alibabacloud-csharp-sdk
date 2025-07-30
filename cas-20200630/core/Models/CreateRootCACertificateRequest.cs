// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200630.Models
{
    public class CreateRootCACertificateRequest : TeaModel {
        /// <summary>
        /// <para>The key algorithm of the root CA certificate. The key algorithm is in the <c>&lt;Encryption algorithm&gt;_&lt;Key length&gt;</c> format. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>RSA_1024</b>: The signature algorithm is Sha256WithRSA.</description></item>
        /// <item><description><b>RSA_2048</b>: The signature algorithm is Sha256WithRSA.</description></item>
        /// <item><description><b>RSA_4096</b>: The signature algorithm is Sha256WithRSA.</description></item>
        /// <item><description><b>ECC_256</b>: The signature algorithm is Sha256WithECDSA.</description></item>
        /// <item><description><b>ECC_384</b>: The signature algorithm is Sha256WithECDSA.</description></item>
        /// <item><description><b>ECC_512</b>: The signature algorithm is Sha256WithECDSA.</description></item>
        /// <item><description><b>SM2_256</b>: The signature algorithm is SM3WithSM2.</description></item>
        /// </list>
        /// <para>The encryption algorithm of the root CA certificate must be consistent with the <b>encryption algorithm</b> of the private root CA instance that you purchase. For example, if the <b>encryption algorithm</b> of the private root CA instance that you purchase is <b>RSA</b>, the key algorithm of the root CA certificate must be <b>RSA_1024</b>, <b>RSA_2048</b>, or <b>RSA_4096</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RSA_2048</para>
        /// </summary>
        [NameInMap("Algorithm")]
        [Validation(Required=false)]
        public string Algorithm { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The common name or abbreviation of the organization. The value can contain letters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Alibaba</para>
        /// </summary>
        [NameInMap("CommonName")]
        [Validation(Required=false)]
        public string CommonName { get; set; }

        /// <summary>
        /// <para>The code of the country or region in which the organization is located. You can enter an alpha-2 code. For example, you can use <b>CN</b> to indicate China and use <b>US</b> to indicate the United States.</para>
        /// <para>For more information about country codes, see the <b>&quot;Country codes&quot;</b> section of the <a href="https://help.aliyun.com/document_detail/198289.html">Manage company profiles</a> topic.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CN</para>
        /// </summary>
        [NameInMap("CountryCode")]
        [Validation(Required=false)]
        public string CountryCode { get; set; }

        /// <summary>
        /// <para>The name of the city in which the organization is located. The value can contain letters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Hangzhou</para>
        /// </summary>
        [NameInMap("Locality")]
        [Validation(Required=false)]
        public string Locality { get; set; }

        /// <summary>
        /// <para>The name of the organization that is associated with the root CA certificate. You can enter the name of your enterprise or company. The value can contain letters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Alibaba</para>
        /// </summary>
        [NameInMap("Organization")]
        [Validation(Required=false)]
        public string Organization { get; set; }

        /// <summary>
        /// <para>The name of the department or branch in the organization. The value can contain letters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Security</para>
        /// </summary>
        [NameInMap("OrganizationUnit")]
        [Validation(Required=false)]
        public string OrganizationUnit { get; set; }

        /// <summary>
        /// <para>The name of the province, municipality, or autonomous region in which the organization is located. The value can contain letters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Zhejiang</para>
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// <para>The validity period of the root CA certificate. Unit: years.</para>
        /// <remarks>
        /// <para> We recommend that you set this parameter to a value from 5 to 10.</para>
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
