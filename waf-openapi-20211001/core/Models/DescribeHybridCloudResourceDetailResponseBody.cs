// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeHybridCloudResourceDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The domain name information.</para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public DescribeHybridCloudResourceDetailResponseBodyDomain Domain { get; set; }
        public class DescribeHybridCloudResourceDetailResponseBodyDomain : TeaModel {
            /// <summary>
            /// <para>CNAME</para>
            /// 
            /// <b>Example:</b>
            /// <para>kdmqyi3ck7xogegxpiyfpb0fj21mgkxn.****.com</para>
            /// </summary>
            [NameInMap("Cname")]
            [Validation(Required=false)]
            public string Cname { get; set; }

            /// <summary>
            /// <para>The domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>www.*****.com</para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <para>id</para>
            /// 
            /// <b>Example:</b>
            /// <para>31323</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The listening information.</para>
            /// </summary>
            [NameInMap("Listen")]
            [Validation(Required=false)]
            public DescribeHybridCloudResourceDetailResponseBodyDomainListen Listen { get; set; }
            public class DescribeHybridCloudResourceDetailResponseBodyDomainListen : TeaModel {
                /// <summary>
                /// <para>The certificate ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>19312542-cn-hangzhou</para>
                /// </summary>
                [NameInMap("CertId")]
                [Validation(Required=false)]
                public string CertId { get; set; }

                /// <summary>
                /// <para>The type of cipher suite. Valid values:</para>
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
                /// <para>0</para>
                /// </summary>
                [NameInMap("CipherSuite")]
                [Validation(Required=false)]
                public int? CipherSuite { get; set; }

                /// <summary>
                /// <para>The custom cipher suites.</para>
                /// </summary>
                [NameInMap("CustomCiphers")]
                [Validation(Required=false)]
                public List<string> CustomCiphers { get; set; }

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
                /// <para>Indicates whether an exclusive IP address is supported. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>true</b>: Supported.</para>
                /// </description></item>
                /// <item><description><para><b>false</b>: Not supported.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("ExclusiveIp")]
                [Validation(Required=false)]
                public bool? ExclusiveIp { get; set; }

                /// <summary>
                /// <para>Indicates whether HTTPS forced redirect is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>true</b>: HTTPS forced redirect is enabled.</para>
                /// </description></item>
                /// <item><description><para><b>false</b>: HTTPS forced redirect is disabled.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("FocusHttps")]
                [Validation(Required=false)]
                public bool? FocusHttps { get; set; }

                /// <summary>
                /// <para>Indicates whether HTTP/2 is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>true</b>: HTTP/2 is enabled.</para>
                /// </description></item>
                /// <item><description><para><b>false</b>: HTTP/2 is disabled.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Http2Enabled")]
                [Validation(Required=false)]
                public bool? Http2Enabled { get; set; }

                /// <summary>
                /// <para>The list of available ports for the HTTP protocol. The value is a string. When multiple ports are available, they are returned in the format of <b>port1,port2,port3</b>.</para>
                /// </summary>
                [NameInMap("HttpPorts")]
                [Validation(Required=false)]
                public List<long?> HttpPorts { get; set; }

                /// <summary>
                /// <para>The ports for the HTTPS protocol.</para>
                /// </summary>
                [NameInMap("HttpsPorts")]
                [Validation(Required=false)]
                public List<long?> HttpsPorts { get; set; }

                /// <summary>
                /// <para>Indicates whether IPv6 is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>true</b>: IPv6 is enabled.</para>
                /// </description></item>
                /// <item><description><para><b>false</b>: IPv6 is disabled.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IPv6Enabled")]
                [Validation(Required=false)]
                public bool? IPv6Enabled { get; set; }

                /// <summary>
                /// <para>The type of protection resource to use. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>share</b>: shared cluster.</para>
                /// </description></item>
                /// <item><description><para><b>gslb</b>: shared cluster with intelligent load balancing.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>share</para>
                /// </summary>
                [NameInMap("ProtectionResource")]
                [Validation(Required=false)]
                public string ProtectionResource { get; set; }

                /// <summary>
                /// <para>The TLS version. Valid values:</para>
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

                /// <summary>
                /// <para>The method that WAF uses to obtain the actual client IP address. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>0</b>: No Layer 7 proxy is deployed in front of WAF.</para>
                /// </description></item>
                /// <item><description><para><b>1</b>: WAF reads the first value of the X-Forwarded-For (XFF) header field as the client IP address.</para>
                /// </description></item>
                /// <item><description><para><b>2</b>: WAF reads the value of a custom header field that you specify as the client IP address.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("XffHeaderMode")]
                [Validation(Required=false)]
                public int? XffHeaderMode { get; set; }

                /// <summary>
                /// <para>The custom header fields used to obtain the client IP address, in the format of [<b>&quot;header1&quot;,&quot;header2&quot;,……</b>].</para>
                /// <remarks>
                /// <para>This parameter is required only when <b>XffHeaderMode</b> is set to 2, which indicates that WAF reads the value of a custom header field that you specify in the request header as the client IP address.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("XffHeaders")]
                [Validation(Required=false)]
                public List<string> XffHeaders { get; set; }

            }

            /// <summary>
            /// <para>The rules for returning response header values.</para>
            /// </summary>
            [NameInMap("Redirect")]
            [Validation(Required=false)]
            public DescribeHybridCloudResourceDetailResponseBodyDomainRedirect Redirect { get; set; }
            public class DescribeHybridCloudResourceDetailResponseBodyDomainRedirect : TeaModel {
                /// <summary>
                /// <para>The custom port configuration. By default, this is the same as the listening port.</para>
                /// </summary>
                [NameInMap("BackendPorts")]
                [Validation(Required=false)]
                public List<DescribeHybridCloudResourceDetailResponseBodyDomainRedirectBackendPorts> BackendPorts { get; set; }
                public class DescribeHybridCloudResourceDetailResponseBodyDomainRedirectBackendPorts : TeaModel {
                    /// <summary>
                    /// <para>The back-to-origin port.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>80</para>
                    /// </summary>
                    [NameInMap("BackendPort")]
                    [Validation(Required=false)]
                    public int? BackendPort { get; set; }

                    /// <summary>
                    /// <para>The listening port.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>80</para>
                    /// </summary>
                    [NameInMap("ListenPort")]
                    [Validation(Required=false)]
                    public int? ListenPort { get; set; }

                    /// <summary>
                    /// <para>The protocol type of the listening port. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>http: HTTP protocol.</description></item>
                    /// <item><description>https: HTTPS protocol.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>http</para>
                    /// </summary>
                    [NameInMap("Protocol")]
                    [Validation(Required=false)]
                    public string Protocol { get; set; }

                }

                /// <summary>
                /// <para>The IP address of the origin server or the domain name used for back-to-origin.</para>
                /// </summary>
                [NameInMap("Backends")]
                [Validation(Required=false)]
                public List<string> Backends { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable public cloud disaster recovery. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>true</b>: Public cloud disaster recovery is enabled.</para>
                /// </description></item>
                /// <item><description><para><b>false</b>: Public cloud disaster recovery is disabled.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("CnameEnabled")]
                [Validation(Required=false)]
                public bool? CnameEnabled { get; set; }

                /// <summary>
                /// <para>The connection timeout period. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ConnectTimeout")]
                [Validation(Required=false)]
                public long? ConnectTimeout { get; set; }

                /// <summary>
                /// <para>Indicates whether forced HTTP back-to-origin is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>true</b>: Forced HTTP back-to-origin is enabled.</para>
                /// </description></item>
                /// <item><description><para><b>false</b>: Forced HTTP back-to-origin is disabled.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("FocusHttpBackend")]
                [Validation(Required=false)]
                public bool? FocusHttpBackend { get; set; }

                /// <summary>
                /// <para>Indicates whether persistent connections are enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>true</b> (default): Persistent connections are enabled.</para>
                /// </description></item>
                /// <item><description><para><b>false</b>: Persistent connections are disabled.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Keepalive")]
                [Validation(Required=false)]
                public bool? Keepalive { get; set; }

                /// <summary>
                /// <para>The number of requests that reuse persistent connections. Valid values: 60 to 1000.</para>
                /// <remarks>
                /// <para>This specifies how many persistent connections are reused after persistent connections are enabled.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("KeepaliveRequests")]
                [Validation(Required=false)]
                public long? KeepaliveRequests { get; set; }

                /// <summary>
                /// <para>The idle timeout period of persistent connections.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("KeepaliveTimeout")]
                [Validation(Required=false)]
                public long? KeepaliveTimeout { get; set; }

                /// <summary>
                /// <para>The load balancing algorithm used for back-to-origin. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>iphash</b>: IP hash algorithm.</para>
                /// </description></item>
                /// <item><description><para><b>roundRobin</b>: round-robin algorithm.</para>
                /// </description></item>
                /// <item><description><para><b>leastTime</b>: least-time back-to-origin algorithm.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>iphash</para>
                /// </summary>
                [NameInMap("Loadbalance")]
                [Validation(Required=false)]
                public string Loadbalance { get; set; }

                /// <summary>
                /// <para>Indicates whether the client source IP preservation feature is enabled.</para>
                /// <list type="bullet">
                /// <item><description>true: The client source IP preservation feature is enabled. After this feature is enabled, the backend service can view the originating IP address of the client.</description></item>
                /// <item><description>false: The client source IP preservation feature is disabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("ProxyProtocol")]
                [Validation(Required=false)]
                public bool? ProxyProtocol { get; set; }

                /// <summary>
                /// <para>The read timeout period of the request.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ReadTimeout")]
                [Validation(Required=false)]
                public long? ReadTimeout { get; set; }

                /// <summary>
                /// <para>The HTTP request headers.</para>
                /// </summary>
                [NameInMap("RequestHeaders")]
                [Validation(Required=false)]
                public List<DescribeHybridCloudResourceDetailResponseBodyDomainRedirectRequestHeaders> RequestHeaders { get; set; }
                public class DescribeHybridCloudResourceDetailResponseBodyDomainRedirectRequestHeaders : TeaModel {
                    /// <summary>
                    /// <para>The key of the tag.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>L2x1ZmZ5L2NvcmUvYXBwcy9tLnl1bmR1bi53YWYuMS9wbHVnaW5z</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>9506360478730</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>Indicates whether WAF retries when back-to-origin fails. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>true</b>: WAF retries.</para>
                /// </description></item>
                /// <item><description><para><b>false</b>: WAF does not retry.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Retry")]
                [Validation(Required=false)]
                public bool? Retry { get; set; }

                /// <summary>
                /// <para>The hybrid cloud forwarding rules, expressed as a string converted from a JSON array. Each element in the JSON array is a structure that contains the following field:</para>
                /// <list type="bullet">
                /// <item><description><b>rs</b>: Array type.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>[{\&quot;backupRs\&quot;:[],\&quot;location\&quot;:\&quot;v3-test\&quot;,\&quot;locationId\&quot;:1148,\&quot;rs\&quot;:[\&quot;39.98.217.197\&quot;,\&quot;2.2.2.2\&quot;]}]</para>
                /// </summary>
                [NameInMap("RoutingRules")]
                [Validation(Required=false)]
                public string RoutingRules { get; set; }

                /// <summary>
                /// <para>Indicates whether back-to-origin Server Name Indication (SNI) is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>true</b>: Back-to-origin SNI is enabled.</para>
                /// </description></item>
                /// <item><description><para><b>false</b>: Back-to-origin SNI is disabled.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("SniEnabled")]
                [Validation(Required=false)]
                public bool? SniEnabled { get; set; }

                /// <summary>
                /// <para>The custom value of the SNI extension field. If the value is empty, the SNI value is not customized, and the value of the <b>Host</b> field in the request header is used as the value of the SNI extension field by default.</para>
                /// <remarks>
                /// <para>This parameter is returned only when <b>SniStatus</b> is set to <b>1</b>, which indicates that back-to-origin SNI is enabled.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>eew111</para>
                /// </summary>
                [NameInMap("SniHost")]
                [Validation(Required=false)]
                public string SniHost { get; set; }

                /// <summary>
                /// <para>The write timeout period. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("WriteTimeout")]
                [Validation(Required=false)]
                public long? WriteTimeout { get; set; }

            }

            /// <summary>
            /// <para>The resource group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-***aby</para>
            /// </summary>
            [NameInMap("ResourceManagerResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceManagerResourceGroupId { get; set; }

            /// <summary>
            /// <para>The resource status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1046011128270720</para>
            /// </summary>
            [NameInMap("Uid")]
            [Validation(Required=false)]
            public string Uid { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>66A98669-CC6E-4F3E-80A6-3014697B11AE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
