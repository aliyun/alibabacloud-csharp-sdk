// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class CreateCsrRequest : TeaModel {
        /// <summary>
        /// <para>The algorithm. Valid values: RSA, SM2, and ECC. For more information about algorithms, see <a href="https://help.aliyun.com/document_detail/197871.html">Select an SSL certificate</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RSA</para>
        /// </summary>
        [NameInMap("Algorithm")]
        [Validation(Required=false)]
        public string Algorithm { get; set; }

        /// <summary>
        /// <para>The primary domain name, which is a common name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123.com</para>
        /// </summary>
        [NameInMap("CommonName")]
        [Validation(Required=false)]
        public string CommonName { get; set; }

        /// <summary>
        /// <para>The name of the company.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aly</para>
        /// </summary>
        [NameInMap("CorpName")]
        [Validation(Required=false)]
        public string CorpName { get; set; }

        /// <summary>
        /// <para>The code of the country or region in which the organization is located. For example, you can use CN to indicate China and use US to indicate the United States.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CN</para>
        /// </summary>
        [NameInMap("CountryCode")]
        [Validation(Required=false)]
        public string CountryCode { get; set; }

        /// <summary>
        /// <para>The department that uses the certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IT</para>
        /// </summary>
        [NameInMap("Department")]
        [Validation(Required=false)]
        public string Department { get; set; }

        /// <summary>
        /// <para>The key length that is used by the algorithm.</para>
        /// <list type="bullet">
        /// <item><description>The key length for RSA algorithms can be 2,048, 3,072, and 4,096 bits.</description></item>
        /// <item><description>The key length for ECC and SM2 algorithms can be 256 bits.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2048</para>
        /// </summary>
        [NameInMap("KeySize")]
        [Validation(Required=false)]
        public int? KeySize { get; set; }

        /// <summary>
        /// <para>The city where the company is located.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Beijing</para>
        /// </summary>
        [NameInMap("Locality")]
        [Validation(Required=false)]
        public string Locality { get; set; }

        /// <summary>
        /// <para>The name of the CSR. The name can be up to 50 characters in length and can contain letters, digits, underscores (_), hyphens (-), and periods (.).</para>
        /// 
        /// <b>Example:</b>
        /// <para>csr-123</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The province or location where the company is located.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Beijing</para>
        /// </summary>
        [NameInMap("Province")]
        [Validation(Required=false)]
        public string Province { get; set; }

        /// <summary>
        /// <para>The secondary domain names. Separate multiple domain names with commas (,). You can use the CSR to apply for a certificate for both the primary and secondary domain names.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.example.com,www.aliyundoc.com">www.example.com,www.aliyundoc.com</a></para>
        /// </summary>
        [NameInMap("Sans")]
        [Validation(Required=false)]
        public string Sans { get; set; }

    }

}
