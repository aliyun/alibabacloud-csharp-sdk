// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeCloudResourceAccessPortDetailsResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the ports of cloud services that are added to WAF.</para>
        /// </summary>
        [NameInMap("AccessPortDetails")]
        [Validation(Required=false)]
        public List<DescribeCloudResourceAccessPortDetailsResponseBodyAccessPortDetails> AccessPortDetails { get; set; }
        public class DescribeCloudResourceAccessPortDetailsResponseBodyAccessPortDetails : TeaModel {
            /// <summary>
            /// <para>The certificates that are associated with the ports of cloud services.</para>
            /// </summary>
            [NameInMap("Certificates")]
            [Validation(Required=false)]
            public List<DescribeCloudResourceAccessPortDetailsResponseBodyAccessPortDetailsCertificates> Certificates { get; set; }
            public class DescribeCloudResourceAccessPortDetailsResponseBodyAccessPortDetailsCertificates : TeaModel {
                /// <summary>
                /// <para>The type of the HTTPS certificate. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>default</b>: default certificate.</description></item>
                /// <item><description><b>extension</b>: additional certificate.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("AppliedType")]
                [Validation(Required=false)]
                public string AppliedType { get; set; }

                /// <summary>
                /// <para>The ID of the certificate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123-cn-hangzhou</para>
                /// </summary>
                [NameInMap("CertificateId")]
                [Validation(Required=false)]
                public string CertificateId { get; set; }

                /// <summary>
                /// <para>The name of the certificate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cert-name1</para>
                /// </summary>
                [NameInMap("CertificateName")]
                [Validation(Required=false)]
                public string CertificateName { get; set; }

            }

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
            public int? CipherSuite { get; set; }

            [NameInMap("CloudResourceId")]
            [Validation(Required=false)]
            public string CloudResourceId { get; set; }

            /// <summary>
            /// <para>The custom cipher suites that you want to add. This parameter is available only if you set <b>CipherSuite</b> to <b>99</b>.</para>
            /// </summary>
            [NameInMap("CustomCiphers")]
            [Validation(Required=false)]
            public List<string> CustomCiphers { get; set; }

            /// <summary>
            /// <para>Indicates whether to support TLS 1.3. Valid values:</para>
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
            /// <para>Indicates whether to enable HTTP/2. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>True</para>
            /// </summary>
            [NameInMap("Http2Enabled")]
            [Validation(Required=false)]
            public bool? Http2Enabled { get; set; }

            /// <summary>
            /// <para>Indicates whether to enable the persistent connection feature. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b> (default)</description></item>
            /// <item><description><b>false:</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Keepalive")]
            [Validation(Required=false)]
            public bool? Keepalive { get; set; }

            /// <summary>
            /// <para>The number of reused persistent connections. Valid values: 60 to 1000.</para>
            /// <remarks>
            /// <para> This parameter specifies the number of requests that reuse persistent connections after you enable the persistent connection feature.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("KeepaliveRequests")]
            [Validation(Required=false)]
            public int? KeepaliveRequests { get; set; }

            /// <summary>
            /// <para>The timeout period for idle persistent connections. Valid values: 10 to 3600. Default value: 15. Unit: seconds.</para>
            /// <remarks>
            /// <para> If no new requests are initiated over the idle persistent connection within the specified timeout period, the connection is closed.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("KeepaliveTimeout")]
            [Validation(Required=false)]
            public int? KeepaliveTimeout { get; set; }

            /// <summary>
            /// <para>The custom header field that you want to use to label requests that are processed by WAF.</para>
            /// <remarks>
            /// <para> This parameter is returned only when the traffic marking feature is enabled for the domain name.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("LogHeaders")]
            [Validation(Required=false)]
            public List<DescribeCloudResourceAccessPortDetailsResponseBodyAccessPortDetailsLogHeaders> LogHeaders { get; set; }
            public class DescribeCloudResourceAccessPortDetailsResponseBodyAccessPortDetailsLogHeaders : TeaModel {
                /// <summary>
                /// <para>The key of the custom header field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>key1</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The value of the custom header field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>value1</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("MaxBodySize")]
            [Validation(Required=false)]
            public int? MaxBodySize { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account to which the resource belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("OwnerUserId")]
            [Validation(Required=false)]
            public string OwnerUserId { get; set; }

            /// <summary>
            /// <para>The port of the cloud service that is added to WAF.</para>
            /// 
            /// <b>Example:</b>
            /// <para>443</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// <para>The type of the protocol. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>http</b></description></item>
            /// <item><description><b>https</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>https</para>
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// <para>The timeout period for read connections. Unit: seconds. Valid values: 1 to 3600.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("ReadTimeout")]
            [Validation(Required=false)]
            public int? ReadTimeout { get; set; }

            /// <summary>
            /// <para>The status of the domain name. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: indicates that the port is available.</description></item>
            /// <item><description><b>2</b>: indicates that the port is being created.</description></item>
            /// <item><description><b>3</b>: indicates that the port is being modified.</description></item>
            /// <item><description><b>4</b>: indicates that the port is being released.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("SubStatus")]
            [Validation(Required=false)]
            public string SubStatus { get; set; }

            [NameInMap("SubStatusDetails")]
            [Validation(Required=false)]
            public List<DescribeCloudResourceAccessPortDetailsResponseBodyAccessPortDetailsSubStatusDetails> SubStatusDetails { get; set; }
            public class DescribeCloudResourceAccessPortDetailsResponseBodyAccessPortDetailsSubStatusDetails : TeaModel {
                [NameInMap("AppliedType")]
                [Validation(Required=false)]
                public string AppliedType { get; set; }

                [NameInMap("CertId")]
                [Validation(Required=false)]
                public string CertId { get; set; }

                [NameInMap("CertName")]
                [Validation(Required=false)]
                public string CertName { get; set; }

                [NameInMap("CommonName")]
                [Validation(Required=false)]
                public string CommonName { get; set; }

                [NameInMap("Domain")]
                [Validation(Required=false)]
                public string Domain { get; set; }

                [NameInMap("ExpireTime")]
                [Validation(Required=false)]
                public long? ExpireTime { get; set; }

                [NameInMap("ProductCertId")]
                [Validation(Required=false)]
                public string ProductCertId { get; set; }

                [NameInMap("ProductCertName")]
                [Validation(Required=false)]
                public string ProductCertName { get; set; }

                [NameInMap("ReasonCode")]
                [Validation(Required=false)]
                public string ReasonCode { get; set; }

            }

            /// <summary>
            /// <para>The version of the Transport Layer Security (TLS) protocol. Valid values:</para>
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

            /// <summary>
            /// <para>The timeout period for write connections. Unit: seconds. Valid values: 1 to 3600.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("WriteTimeout")]
            [Validation(Required=false)]
            public int? WriteTimeout { get; set; }

            /// <summary>
            /// <para>The method that WAF uses to obtain the originating IP address of a client. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: No Layer 7 proxies are deployed in front of WAF.</description></item>
            /// <item><description><b>1</b>: WAF reads the first value of the X-Forwarded-For (XFF) header field as the originating IP address of the client.</description></item>
            /// <item><description><b>2</b>: WAF reads the value of a custom header field as the originating IP address of the client.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("XffHeaderMode")]
            [Validation(Required=false)]
            public int? XffHeaderMode { get; set; }

            /// <summary>
            /// <para>The custom header field that is used to obtain the originating IP address of a client. Specify the value in the [&quot;header1&quot;,&quot;header2&quot;,...] format.</para>
            /// <remarks>
            /// <para> This parameter is required only if you set <b>XffHeaderMode</b> to 2.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("XffHeaders")]
            [Validation(Required=false)]
            public List<string> XffHeaders { get; set; }

            /// <summary>
            /// <para>Indicates whether to use the X-Forward-For-Proto header to identify the protocol used by WAF to forward requests to the origin server. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b> (default)</description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("XffProto")]
            [Validation(Required=false)]
            public bool? XffProto { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2EFCFE18-78F8-5079-B312-07***48B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
