// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class ListCsrResponseBody : TeaModel {
        /// <summary>
        /// <para>The CSRs.</para>
        /// </summary>
        [NameInMap("CsrList")]
        [Validation(Required=false)]
        public List<ListCsrResponseBodyCsrList> CsrList { get; set; }
        public class ListCsrResponseBodyCsrList : TeaModel {
            /// <summary>
            /// <para>The algorithm. Valid values: RSA, SM2, and ECC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RSA</para>
            /// </summary>
            [NameInMap("Algorithm")]
            [Validation(Required=false)]
            public string Algorithm { get; set; }

            /// <summary>
            /// <para>The primary domain name, which is a common name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com</para>
            /// </summary>
            [NameInMap("CommonName")]
            [Validation(Required=false)]
            public string CommonName { get; set; }

            /// <summary>
            /// <para>The name of the company.</para>
            /// 
            /// <b>Example:</b>
            /// <para>corp_name</para>
            /// </summary>
            [NameInMap("CorpName")]
            [Validation(Required=false)]
            public string CorpName { get; set; }

            /// <summary>
            /// <para>The code of the country or region in which the organization is located. For example, you can use CN to indicate China and use US to indicate the United States. The default value is the code of the country or region in which the organization is located. The organization is associated with the intermediate CA certificate from which the certificate is issued. For more information about country codes, see the &quot;Country codes&quot; section of the <a href="https://help.aliyun.com/document_detail/198289.html">Manage company profiles</a> topic.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CN</para>
            /// </summary>
            [NameInMap("CountryCode")]
            [Validation(Required=false)]
            public string CountryCode { get; set; }

            /// <summary>
            /// <para>The ID of the CSR.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3454</para>
            /// </summary>
            [NameInMap("CsrId")]
            [Validation(Required=false)]
            public long? CsrId { get; set; }

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
            /// <para>Indicates whether the certificate contains a private key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HasPrivateKey")]
            [Validation(Required=false)]
            public bool? HasPrivateKey { get; set; }

            /// <summary>
            /// <para>The public key that is calculated by using the SHA256 algorithm.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("KeySha2")]
            [Validation(Required=false)]
            public string KeySha2 { get; set; }

            /// <summary>
            /// <para>The key length that is used by the algorithm. The key length for RSA algorithms can be 2,048, 3,072, and 4,096 bits. The key length for ECC and SM2 algorithms can be 256 bits.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2048</para>
            /// </summary>
            [NameInMap("KeySize")]
            [Validation(Required=false)]
            public int? KeySize { get; set; }

            /// <summary>
            /// <para>The city where the company is located.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Beijing</para>
            /// </summary>
            [NameInMap("Locality")]
            [Validation(Required=false)]
            public string Locality { get; set; }

            /// <summary>
            /// <para>The name of the CSR.</para>
            /// 
            /// <b>Example:</b>
            /// <para>name</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The province or location.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Beijing</para>
            /// </summary>
            [NameInMap("Province")]
            [Validation(Required=false)]
            public string Province { get; set; }

            /// <summary>
            /// <para>The secondary domain names. Separate multiple domain names with commas (,).</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://www.example.com,www.aliyundoc.com">www.example.com,www.aliyundoc.com</a></para>
            /// </summary>
            [NameInMap("Sans")]
            [Validation(Required=false)]
            public string Sans { get; set; }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E865F6AD-0294-4A24-A58B-DAC6BE2BDD20</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 50.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("ShowSize")]
        [Validation(Required=false)]
        public long? ShowSize { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
