// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeCertsResponseBody : TeaModel {
        /// <summary>
        /// <para>The certificate list.</para>
        /// </summary>
        [NameInMap("Certs")]
        [Validation(Required=false)]
        public List<DescribeCertsResponseBodyCerts> Certs { get; set; }
        public class DescribeCertsResponseBodyCerts : TeaModel {
            /// <summary>
            /// <para>The expiration time. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1976256736582</para>
            /// </summary>
            [NameInMap("AfterDate")]
            [Validation(Required=false)]
            public long? AfterDate { get; set; }

            /// <summary>
            /// <para>The effective period. The value is a UNIX timestamp in the format of milliseconds (ms).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1976256836582</para>
            /// </summary>
            [NameInMap("BeforeDate")]
            [Validation(Required=false)]
            public long? BeforeDate { get; set; }

            /// <summary>
            /// <para>The global certificate ID, which is in the format of certificate ID + &quot;-cn-hangzhou&quot;. For example, if the certificate ID is 123, the CertIdentifier is &quot;123-cn-hangzhou&quot;.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12345-cn-hangzhou</para>
            /// </summary>
            [NameInMap("CertIdentifier")]
            [Validation(Required=false)]
            public string CertIdentifier { get; set; }

            /// <summary>
            /// <para>The certificate name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>waf1234</para>
            /// </summary>
            [NameInMap("CertName")]
            [Validation(Required=false)]
            public string CertName { get; set; }

            /// <summary>
            /// <para>The common name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>*.example.com</para>
            /// </summary>
            [NameInMap("CommonName")]
            [Validation(Required=false)]
            public string CommonName { get; set; }

            /// <summary>
            /// <para>The domain name supported by the certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://www.example.com">www.example.com</a></para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <para>Indicates whether the certificate chain is complete. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: The certificate chain is complete.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: The certificate chain is incomplete.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsChainCompleted")]
            [Validation(Required=false)]
            public bool? IsChainCompleted { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>19511B0D-5AE0-5600-BB8A-DC2C8345****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
