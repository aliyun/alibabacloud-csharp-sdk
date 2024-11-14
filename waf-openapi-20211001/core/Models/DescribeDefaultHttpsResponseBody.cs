// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeDefaultHttpsResponseBody : TeaModel {
        /// <summary>
        /// <para>The default SSL and TLS settings.</para>
        /// </summary>
        [NameInMap("DefaultHttps")]
        [Validation(Required=false)]
        public DescribeDefaultHttpsResponseBodyDefaultHttps DefaultHttps { get; set; }
        public class DescribeDefaultHttpsResponseBodyDefaultHttps : TeaModel {
            /// <summary>
            /// <para>The certificate ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123-cn-hangzhou</para>
            /// </summary>
            [NameInMap("CertId")]
            [Validation(Required=false)]
            public string CertId { get; set; }

            /// <summary>
            /// <para>The type of the cipher suites. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: all cipher suites.</description></item>
            /// <item><description><b>2</b>: strong cipher suites.</description></item>
            /// <item><description><b>99</b>: custom cipher suites.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CipherSuite")]
            [Validation(Required=false)]
            public string CipherSuite { get; set; }

            /// <summary>
            /// <para>The custom cipher suite.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ECDHE-ECDSA-AES128-GCM-SHA256:ECDHE-ECDSA-AES256-GCM-SHA384:ECDHE-RSA-AES128-GCM-SHA256:ECDHE-RSA-AES256-GCM-SHA384</para>
            /// </summary>
            [NameInMap("CustomCiphers")]
            [Validation(Required=false)]
            public string CustomCiphers { get; set; }

            /// <summary>
            /// <para>Indicates whether TLS 1.3 is supported. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableTLSv3")]
            [Validation(Required=false)]
            public bool? EnableTLSv3 { get; set; }

            /// <summary>
            /// <para>The version of the TLS protocol. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>tlsv1</b></description></item>
            /// <item><description><b>tlsv1.1</b></description></item>
            /// <item><description><b>tlsv1.2</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>tlsv1</para>
            /// </summary>
            [NameInMap("TLSVersion")]
            [Validation(Required=false)]
            public string TLSVersion { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F35F45B0-5D6B-4238-BE02-A62D****E840</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
