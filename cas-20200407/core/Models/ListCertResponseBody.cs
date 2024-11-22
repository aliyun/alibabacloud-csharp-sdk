// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class ListCertResponseBody : TeaModel {
        /// <summary>
        /// <para>An array that consists of the certificates.</para>
        /// </summary>
        [NameInMap("CertList")]
        [Validation(Required=false)]
        public List<ListCertResponseBodyCertList> CertList { get; set; }
        public class ListCertResponseBodyCertList : TeaModel {
            /// <summary>
            /// <para>The expiration time of the certificate. The value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1634283958000</para>
            /// </summary>
            [NameInMap("AfterDate")]
            [Validation(Required=false)]
            public long? AfterDate { get; set; }

            /// <summary>
            /// <para>The issuance time of the certificate. The value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1665819958000</para>
            /// </summary>
            [NameInMap("BeforeDate")]
            [Validation(Required=false)]
            public long? BeforeDate { get; set; }

            /// <summary>
            /// <para>证书的类型 。取值：</para>
            /// <list type="bullet">
            /// <item><description><b>CA</b>：表示CA证书。</description></item>
            /// <item><description><b>CERT</b>：表示签发的证书。</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CERT</para>
            /// </summary>
            [NameInMap("CertType")]
            [Validation(Required=false)]
            public string CertType { get; set; }

            /// <summary>
            /// <para>The domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aliyun.alibaba.com</para>
            /// </summary>
            [NameInMap("CommonName")]
            [Validation(Required=false)]
            public string CommonName { get; set; }

            /// <summary>
            /// <para>Indicates whether the certificate contains a private key. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("ExistPrivateKey")]
            [Validation(Required=false)]
            public bool? ExistPrivateKey { get; set; }

            /// <summary>
            /// <para>The unique identifier of the certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>14dcc8afc7578e</para>
            /// </summary>
            [NameInMap("Identifier")]
            [Validation(Required=false)]
            public string Identifier { get; set; }

            /// <summary>
            /// <para>The issuer of the certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mySSL</para>
            /// </summary>
            [NameInMap("Issuer")]
            [Validation(Required=false)]
            public string Issuer { get; set; }

            /// <summary>
            /// <para>The domain names that are bound to the certificate. Multiple domain names are separated by commas.</para>
            /// 
            /// <b>Example:</b>
            /// <para>*.alibaba.com,aliyun.alibaba.com</para>
            /// </summary>
            [NameInMap("Sans")]
            [Validation(Required=false)]
            public string Sans { get; set; }

            /// <summary>
            /// <para>The source of the certificate. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>upload</b>: uploaded certificate</description></item>
            /// <item><description><b>aliyun</b>: Alibaba Cloud certificate</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>aliyun</para>
            /// </summary>
            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            /// <summary>
            /// <para>The status of the certificate. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ISSUE</b>: issued</description></item>
            /// <item><description><b>REVOKE</b>: revoked</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ISSUE</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The ID of the certificate repository.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("WhId")]
            [Validation(Required=false)]
            public long? WhId { get; set; }

            /// <summary>
            /// <para>The instance ID of the certificate repository.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_whInstanceId</para>
            /// </summary>
            [NameInMap("WhInstanceId")]
            [Validation(Required=false)]
            public string WhInstanceId { get; set; }

        }

        /// <summary>
        /// <para>The page number of the returned page. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15C66C7B-671A-4297-9187-2C4477247A74</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page. Default value: 50.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
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
