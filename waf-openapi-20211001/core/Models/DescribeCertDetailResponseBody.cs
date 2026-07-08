// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeCertDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The SSL certificate details.</para>
        /// </summary>
        [NameInMap("CertDetail")]
        [Validation(Required=false)]
        public DescribeCertDetailResponseBodyCertDetail CertDetail { get; set; }
        public class DescribeCertDetailResponseBodyCertDetail : TeaModel {
            /// <summary>
            /// <para>The expiration date of the CA certificate. The value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1976256736582</para>
            /// </summary>
            [NameInMap("AfterDate")]
            [Validation(Required=false)]
            public long? AfterDate { get; set; }

            /// <summary>
            /// <para>The issuance time of the certificate. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1976256736582</para>
            /// </summary>
            [NameInMap("BeforeDate")]
            [Validation(Required=false)]
            public long? BeforeDate { get; set; }

            /// <summary>
            /// <para>The certificate ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123-cn-hangzhou</para>
            /// </summary>
            [NameInMap("CertIdentifier")]
            [Validation(Required=false)]
            public string CertIdentifier { get; set; }

            /// <summary>
            /// <para>The certificate name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testCertName</para>
            /// </summary>
            [NameInMap("CertName")]
            [Validation(Required=false)]
            public string CertName { get; set; }

            /// <summary>
            /// <para>The common name of the certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>*.xxxaliyun.com</para>
            /// </summary>
            [NameInMap("CommonName")]
            [Validation(Required=false)]
            public string CommonName { get; set; }

            /// <summary>
            /// <para>The domain name associated with the certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>demo.xxxaliyun.com</para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <para>The list of other domain names associated with the certificate.</para>
            /// </summary>
            [NameInMap("Sans")]
            [Validation(Required=false)]
            public List<string> Sans { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3C115DBE-8E53-5A12-9CAF-FD3F****CDF6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
