// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeDefaultHttpsResponseBody : TeaModel {
        /// <summary>
        /// <para>The default SSL/TLS settings.</para>
        /// </summary>
        [NameInMap("DefaultHttps")]
        [Validation(Required=false)]
        public DescribeDefaultHttpsResponseBodyDefaultHttps DefaultHttps { get; set; }
        public class DescribeDefaultHttpsResponseBodyDefaultHttps : TeaModel {
            /// <summary>
            /// <para>The ID of the certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123-cn-hangzhou</para>
            /// </summary>
            [NameInMap("CertId")]
            [Validation(Required=false)]
            public string CertId { get; set; }

            /// <summary>
            /// <para>The type of the cipher suite. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>1</b>: all cipher suites.</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: strong cipher suites.</para>
            /// </description></item>
            /// <item><description><para><b>99</b>: custom cipher suites.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CipherSuite")]
            [Validation(Required=false)]
            public string CipherSuite { get; set; }

            /// <summary>
            /// <para>The custom cipher suites. This parameter is returned only when CipherSuite is set to 99.</para>
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
            /// <item><description><para><b>true</b>: TLS 1.3 is supported.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: TLS 1.3 is not supported.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableTLSv3")]
            [Validation(Required=false)]
            public bool? EnableTLSv3 { get; set; }

            /// <summary>
            /// <para>The minimum TLS version. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>tlsv1</b></para>
            /// </description></item>
            /// <item><description><para><b>tlsv1.1</b></para>
            /// </description></item>
            /// <item><description><para><b>tlsv1.2</b></para>
            /// </description></item>
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
