// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeCertsResponseBody : TeaModel {
        /// <summary>
        /// <para>The certificates.</para>
        /// </summary>
        [NameInMap("Certs")]
        [Validation(Required=false)]
        public List<DescribeCertsResponseBodyCerts> Certs { get; set; }
        public class DescribeCertsResponseBodyCerts : TeaModel {
            /// <summary>
            /// <para>The time when the certificate becomes valid.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1976256736582</para>
            /// </summary>
            [NameInMap("AfterDate")]
            [Validation(Required=false)]
            public long? AfterDate { get; set; }

            /// <summary>
            /// <para>The time when the certificate expires.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1976256836582</para>
            /// </summary>
            [NameInMap("BeforeDate")]
            [Validation(Required=false)]
            public long? BeforeDate { get; set; }

            /// <summary>
            /// <para>The globally unique ID of the certificate. The value is in the &quot;Certificate ID-cn-hangzhou&quot; format. For example, if the ID of the certificate is 123, the value of CertIdentifier is 123-cn-hangzhou.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234567-cn-hangzhou</para>
            /// </summary>
            [NameInMap("CertIdentifier")]
            [Validation(Required=false)]
            public string CertIdentifier { get; set; }

            /// <summary>
            /// <para>The name of the certificate.</para>
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
            /// <para>The domain name that is added to WAF.</para>
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
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
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
