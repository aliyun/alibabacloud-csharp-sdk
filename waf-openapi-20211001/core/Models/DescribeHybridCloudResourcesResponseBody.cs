// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeHybridCloudResourcesResponseBody : TeaModel {
        /// <summary>
        /// <para>The domain names.</para>
        /// </summary>
        [NameInMap("Domains")]
        [Validation(Required=false)]
        public List<DescribeHybridCloudResourcesResponseBodyDomains> Domains { get; set; }
        public class DescribeHybridCloudResourcesResponseBodyDomains : TeaModel {
            /// <summary>
            /// <para>The CNAME assigned by WAF.</para>
            /// <remarks>
            /// <para> This parameter is returned only if the value of <b>CnameEnabled</b> is true.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>50fqmu1ci7g0xtiyxnrhgx6qdhmn****.yundunwaf5.com</para>
            /// </summary>
            [NameInMap("Cname")]
            [Validation(Required=false)]
            public string Cname { get; set; }

            /// <summary>
            /// <para>The domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://www.aliyundoc.com">www.aliyundoc.com</a></para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <para>The access ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The listeners.</para>
            /// </summary>
            [NameInMap("Listen")]
            [Validation(Required=false)]
            public DescribeHybridCloudResourcesResponseBodyDomainsListen Listen { get; set; }
            public class DescribeHybridCloudResourcesResponseBodyDomainsListen : TeaModel {
                /// <summary>
                /// <para>The ID of the certificate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>72***76-cn-hangzhou</para>
                /// </summary>
                [NameInMap("CertId")]
                [Validation(Required=false)]
                public string CertId { get; set; }

                /// <summary>
                /// <para>The types of cipher suites that are added. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1:</b> all cipher suites.</description></item>
                /// <item><description><b>2:</b> strong cipher suites.</description></item>
                /// <item><description><b>99:</b> custom cipher suites.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("CipherSuite")]
                [Validation(Required=false)]
                public int? CipherSuite { get; set; }

                /// <summary>
                /// <para>The custom cipher suites.</para>
                /// <remarks>
                /// <para> This parameter is returned only if the value of <b>CipherSuite</b> is <b>99</b>.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("CustomCiphers")]
                [Validation(Required=false)]
                public List<string> CustomCiphers { get; set; }

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
                /// <para>Indicates whether exclusive IP addresses are supported. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("ExclusiveIp")]
                [Validation(Required=false)]
                public bool? ExclusiveIp { get; set; }

                /// <summary>
                /// <para>Indicates whether the HTTP to HTTPS redirection feature is enabled for the domain name. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("FocusHttps")]
                [Validation(Required=false)]
                public bool? FocusHttps { get; set; }

                /// <summary>
                /// <para>Indicates whether HTTP/2 is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Http2Enabled")]
                [Validation(Required=false)]
                public bool? Http2Enabled { get; set; }

                /// <summary>
                /// <para>The HTTP listener ports.</para>
                /// </summary>
                [NameInMap("HttpPorts")]
                [Validation(Required=false)]
                public List<long?> HttpPorts { get; set; }

                /// <summary>
                /// <para>The HTTPS listener ports.</para>
                /// </summary>
                [NameInMap("HttpsPorts")]
                [Validation(Required=false)]
                public List<long?> HttpsPorts { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable IPv6. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("IPv6Enabled")]
                [Validation(Required=false)]
                public bool? IPv6Enabled { get; set; }

                /// <summary>
                /// <para>The type of the protection resource. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>share:</b> shared cluster.</description></item>
                /// <item><description><b>gslb:</b> shared cluster-based intelligent load balancing.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>share</para>
                /// </summary>
                [NameInMap("ProtectionResource")]
                [Validation(Required=false)]
                public string ProtectionResource { get; set; }

                /// <summary>
                /// <para>The version of the Transport Layer Security (TLS) protocol. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>tlsv1</b></description></item>
                /// <item><description><b>tlsv1.1</b></description></item>
                /// <item><description><b>tlsv1.2</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>tlsv1.2</para>
                /// </summary>
                [NameInMap("TLSVersion")]
                [Validation(Required=false)]
                public string TLSVersion { get; set; }

                /// <summary>
                /// <para>The method that is used to obtain the actual IP address of a client. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: No Layer 7 proxies are deployed in front of WAF.</description></item>
                /// <item><description><b>1</b>: WAF reads the first value of the X-Forwarded-For (XFF) header field as the actual IP address of the client.</description></item>
                /// <item><description><b>2</b>: WAF reads the value of a custom header field as the actual IP address of the client.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("XffHeaderMode")]
                [Validation(Required=false)]
                public int? XffHeaderMode { get; set; }

                /// <summary>
                /// <para>The custom header fields that are used to obtain the actual IP addresses of clients. The value is in the [&quot;header1&quot;,&quot;header2&quot;,...] format.</para>
                /// <remarks>
                /// <para> This parameter is returned only if the value of <b>XffHeaderMode</b> is 2.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("XffHeaders")]
                [Validation(Required=false)]
                public List<string> XffHeaders { get; set; }

            }

            /// <summary>
            /// <para>The configurations of the forwarding rule.</para>
            /// </summary>
            [NameInMap("Redirect")]
            [Validation(Required=false)]
            public DescribeHybridCloudResourcesResponseBodyDomainsRedirect Redirect { get; set; }
            public class DescribeHybridCloudResourcesResponseBodyDomainsRedirect : TeaModel {
                /// <summary>
                /// <para>The IP addresses or domain names of the origin server.</para>
                /// </summary>
                [NameInMap("Backends")]
                [Validation(Required=false)]
                public List<string> Backends { get; set; }

                /// <summary>
                /// <para>Indicates whether the public cloud disaster recovery feature is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("CnameEnabled")]
                [Validation(Required=false)]
                public bool? CnameEnabled { get; set; }

                /// <summary>
                /// <para>The timeout period for connections. Unit: seconds. Valid values: 5 to 120.</para>
                /// 
                /// <b>Example:</b>
                /// <para>120</para>
                /// </summary>
                [NameInMap("ConnectTimeout")]
                [Validation(Required=false)]
                public long? ConnectTimeout { get; set; }

                /// <summary>
                /// <para>Indicates whether the HTTPS to HTTP redirection feature is enabled for back-to-origin requests. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("FocusHttpBackend")]
                [Validation(Required=false)]
                public bool? FocusHttpBackend { get; set; }

                /// <summary>
                /// <para>Indicates whether the persistent connection feature is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
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
                /// <para> This parameter indicates the number of reused persistent connections after the persistent connection feature is enabled.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("KeepaliveRequests")]
                [Validation(Required=false)]
                public long? KeepaliveRequests { get; set; }

                /// <summary>
                /// <para>The timeout period for persistent connections that are in the Idle state. Unit: seconds. Valid values: 1 to 60. Default value: 15.</para>
                /// <remarks>
                /// <para> This parameter indicates the period of time during which a reused persistent connection can remain in the Idle state before the persistent connection is released.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>15</para>
                /// </summary>
                [NameInMap("KeepaliveTimeout")]
                [Validation(Required=false)]
                public long? KeepaliveTimeout { get; set; }

                /// <summary>
                /// <para>The load balancing algorithm that is used to forward requests to the origin server. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>iphash</b></description></item>
                /// <item><description><b>roundRobin</b></description></item>
                /// <item><description><b>leastTime</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>iphash</para>
                /// </summary>
                [NameInMap("Loadbalance")]
                [Validation(Required=false)]
                public string Loadbalance { get; set; }

                /// <summary>
                /// <para>The timeout period for read connections. Unit: seconds. Valid values: 5 to 1800.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("ReadTimeout")]
                [Validation(Required=false)]
                public long? ReadTimeout { get; set; }

                /// <summary>
                /// <para>The key-value pair that is used to label requests that pass through WAF.</para>
                /// </summary>
                [NameInMap("RequestHeaders")]
                [Validation(Required=false)]
                public List<DescribeHybridCloudResourcesResponseBodyDomainsRedirectRequestHeaders> RequestHeaders { get; set; }
                public class DescribeHybridCloudResourcesResponseBodyDomainsRedirectRequestHeaders : TeaModel {
                    /// <summary>
                    /// <para>The key of the custom header field.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>aaa</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The value of the custom header field.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>bbb</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>Indicates whether WAF retries forwarding requests if requests fail to be forwarded to the origin server. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Retry")]
                [Validation(Required=false)]
                public bool? Retry { get; set; }

                /// <summary>
                /// <para>The forwarding rules that are configured for the domain name. This parameter is a string that consists of JSON arrays. Each element in a JSON array is a JSON struct that contains the following fields:</para>
                /// <list type="bullet">
                /// <item><description><b>rs</b>: the back-to-origin IP addresses or CNAMEs. The value is of the ARRAY type.</description></item>
                /// <item><description><b>location</b>: the name of the protection node. The value is of the STRING type.</description></item>
                /// <item><description><b>locationId</b>: the ID of the protection node. The value is of the LONG type.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>[
                ///       {
                ///             &quot;rs&quot;: [
                ///                   &quot;1.1.XX.XX&quot;
                ///             ],
                ///             &quot;locationId&quot;: 535,
                ///             &quot;location&quot;: &quot;test1111&quot;
                ///       }
                /// ]</para>
                /// </summary>
                [NameInMap("RoutingRules")]
                [Validation(Required=false)]
                public string RoutingRules { get; set; }

                /// <summary>
                /// <para>Indicates whether the origin Server Name Indication (SNI) feature is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("SniEnabled")]
                [Validation(Required=false)]
                public bool? SniEnabled { get; set; }

                /// <summary>
                /// <para>The value of the custom SNI field. If the parameter is left empty, the value of the <b>Host</b> field in the request header is automatically used as the value of the SNI field.</para>
                /// <remarks>
                /// <para> This parameter is returned only if the value of <b>SniEnabled</b> is <b>true</b>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://www.aliyundoc.com">www.aliyundoc.com</a></para>
                /// </summary>
                [NameInMap("SniHost")]
                [Validation(Required=false)]
                public string SniHost { get; set; }

                /// <summary>
                /// <para>The timeout period for write connections. Unit: seconds. Valid values: 5 to 1800.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("WriteTimeout")]
                [Validation(Required=false)]
                public long? WriteTimeout { get; set; }

            }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-acfmvtc5z52****</para>
            /// </summary>
            [NameInMap("ResourceManagerResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceManagerResourceGroupId { get; set; }

            /// <summary>
            /// <para>The status of the domain name. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1:</b> The domain name is in a normal state.</description></item>
            /// <item><description><b>2:</b> The domain name is being created.</description></item>
            /// <item><description><b>3:</b> The domain name is being modified.</description></item>
            /// <item><description><b>4:</b> The domain name is being released.</description></item>
            /// <item><description><b>5:</b> WAF no longer forwards the traffic of the domain name.</description></item>
            /// </list>
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
            /// <para>130715431409****</para>
            /// </summary>
            [NameInMap("Uid")]
            [Validation(Required=false)]
            public string Uid { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>98D2AA9A-5959-5CCD-83E3-B6606232A2BE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries that are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>24</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
