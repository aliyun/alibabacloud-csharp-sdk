// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class CreateDomainRequest : TeaModel {
        /// <summary>
        /// <para>The mode in which you want to add the domain name to WAF. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>share:</b> adds the domain name to WAF in CNAME record mode. This is the default value.</description></item>
        /// <item><description><b>hybrid_cloud_cname:</b> adds the domain name to WAF in hybrid cloud reverse proxy mode.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>share</para>
        /// </summary>
        [NameInMap("AccessType")]
        [Validation(Required=false)]
        public string AccessType { get; set; }

        /// <summary>
        /// <para>The domain name that you want to add to WAF.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.aliyundoc.com">www.aliyundoc.com</a></para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>The ID of the Web Application Firewall (WAF) instance.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/433756.html">DescribeInstance</a> operation to obtain the ID of the WAF instance.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>waf_cdnsdf3****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The listener configurations.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Listen")]
        [Validation(Required=false)]
        public CreateDomainRequestListen Listen { get; set; }
        public class CreateDomainRequestListen : TeaModel {
            /// <summary>
            /// <para>The ID of the certificate that you want to add. This parameter is available only if you specify <b>HttpsPorts</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("CertId")]
            [Validation(Required=false)]
            public string CertId { get; set; }

            /// <summary>
            /// <para>The type of the cipher suites that you want to add. This parameter is available only if you specify <b>HttpsPorts</b>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: all cipher suites.</description></item>
            /// <item><description><b>2</b>: strong cipher suites. This value is available only if you set <b>TLSVersion</b> to <b>tlsv1.2</b>.</description></item>
            /// <item><description><b>99</b>: custom cipher suites.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("CipherSuite")]
            [Validation(Required=false)]
            public int? CipherSuite { get; set; }

            /// <summary>
            /// <para>The custom cipher suites that you want to add.</para>
            /// </summary>
            [NameInMap("CustomCiphers")]
            [Validation(Required=false)]
            public List<string> CustomCiphers { get; set; }

            /// <summary>
            /// <para>Specifies whether to support TLS 1.3. This parameter is available only if you specify <b>HttpsPorts</b>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("EnableTLSv3")]
            [Validation(Required=false)]
            public bool? EnableTLSv3 { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the exclusive IP address feature. This parameter is available only if you set <b>IPv6Enabled</b> to <b>false</b> and <b>ProtectionResource</b> to <b>share</b>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b> (default)</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ExclusiveIp")]
            [Validation(Required=false)]
            public bool? ExclusiveIp { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable force redirect from HTTP to HTTPS for received requests. This parameter is available only if you specify HttpsPorts and leave HttpPorts empty. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("FocusHttps")]
            [Validation(Required=false)]
            public bool? FocusHttps { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable HTTP/2. This parameter is available only if you specify <b>HttpsPorts</b>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b> (default)</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Http2Enabled")]
            [Validation(Required=false)]
            public bool? Http2Enabled { get; set; }

            /// <summary>
            /// <para>The HTTP listener ports.</para>
            /// </summary>
            [NameInMap("HttpPorts")]
            [Validation(Required=false)]
            public List<int?> HttpPorts { get; set; }

            /// <summary>
            /// <para>The HTTPS listener ports.</para>
            /// </summary>
            [NameInMap("HttpsPorts")]
            [Validation(Required=false)]
            public List<int?> HttpsPorts { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable IPv6 protection. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b> (default)</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IPv6Enabled")]
            [Validation(Required=false)]
            public bool? IPv6Enabled { get; set; }

            /// <summary>
            /// <para>The type of the protection resource. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>share</b> (default): a shared cluster.</description></item>
            /// <item><description><b>gslb</b>: shared cluster-based intelligent load balancing.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>share</para>
            /// </summary>
            [NameInMap("ProtectionResource")]
            [Validation(Required=false)]
            public string ProtectionResource { get; set; }

            /// <summary>
            /// <para>Specifies whether to allow access only from SM certificate-based clients. This parameter is available only if you set SM2Enabled to true.</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("SM2AccessOnly")]
            [Validation(Required=false)]
            public bool? SM2AccessOnly { get; set; }

            /// <summary>
            /// <para>The ID of the SM certificate that you want to add. This parameter is available only if you set SM2Enabled to true.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123-cn-hangzhou</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("SM2CertId")]
            [Validation(Required=false)]
            public string SM2CertId { get; set; }

            /// <summary>
            /// <para>Specifies whether to add an SM certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("SM2Enabled")]
            [Validation(Required=false)]
            public bool? SM2Enabled { get; set; }

            /// <summary>
            /// <para>The Transport Layer Security (TLS) version that you want to add. This parameter is available only if you specify <b>HttpsPorts</b>. Valid values:</para>
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
            /// <para>The method that is used to obtain the originating IP address of a client. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b> (default): Client traffic is not filtered by a Layer 7 proxy before the traffic reaches WAF.</description></item>
            /// <item><description><b>1</b>: WAF reads the first value of the X-Forwarded-For (XFF) header field as the originating IP address of the client.</description></item>
            /// <item><description><b>2</b>: WAF reads the value of a custom header field as the originating IP address of the client.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("XffHeaderMode")]
            [Validation(Required=false)]
            public int? XffHeaderMode { get; set; }

            /// <summary>
            /// <para>The custom header fields that are used to obtain the originating IP address of a client.</para>
            /// </summary>
            [NameInMap("XffHeaders")]
            [Validation(Required=false)]
            public List<string> XffHeaders { get; set; }

        }

        /// <summary>
        /// <para>The forwarding configurations.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Redirect")]
        [Validation(Required=false)]
        public CreateDomainRequestRedirect Redirect { get; set; }
        public class CreateDomainRequestRedirect : TeaModel {
            [NameInMap("BackendPorts")]
            [Validation(Required=false)]
            public List<CreateDomainRequestRedirectBackendPorts> BackendPorts { get; set; }
            public class CreateDomainRequestRedirectBackendPorts : TeaModel {
                [NameInMap("BackendPort")]
                [Validation(Required=false)]
                public int? BackendPort { get; set; }

                [NameInMap("ListenPort")]
                [Validation(Required=false)]
                public int? ListenPort { get; set; }

                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

            }

            /// <summary>
            /// <para>The IP addresses or domain names of the origin server.</para>
            /// </summary>
            [NameInMap("Backends")]
            [Validation(Required=false)]
            public List<string> Backends { get; set; }

            /// <summary>
            /// <para>The secondary IP addresses or domain names of the origin server.</para>
            /// </summary>
            [NameInMap("BackupBackends")]
            [Validation(Required=false)]
            public List<string> BackupBackends { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the public cloud disaster recovery feature. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b> (default)</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("CnameEnabled")]
            [Validation(Required=false)]
            public bool? CnameEnabled { get; set; }

            /// <summary>
            /// <para>The timeout period of connections. Unit: seconds. Valid values: 1 to 3600.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120</para>
            /// </summary>
            [NameInMap("ConnectTimeout")]
            [Validation(Required=false)]
            public int? ConnectTimeout { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable force redirect from HTTPS to HTTP for back-to-origin requests. This parameter is available only if you specify <b>HttpsPorts</b>. Valid values:</para>
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
            /// <para>Specifies whether to enable the persistent connection feature. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b> (default)</description></item>
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
            /// <para> This parameter specifies the number of persistent connections that can be reused after you enable the persistent connection feature.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("KeepaliveRequests")]
            [Validation(Required=false)]
            public int? KeepaliveRequests { get; set; }

            /// <summary>
            /// <para>The timeout period of idle persistent connections. Valid values: 1 to 60. Default value: 15. Unit: seconds.</para>
            /// <remarks>
            /// <para> This parameter specifies the period of time after which an idle persistent connection is closed.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>15</para>
            /// </summary>
            [NameInMap("KeepaliveTimeout")]
            [Validation(Required=false)]
            public int? KeepaliveTimeout { get; set; }

            /// <summary>
            /// <para>The load balancing algorithm that you want to use to forward requests to the origin server. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>iphash</b></description></item>
            /// <item><description><b>roundRobin</b></description></item>
            /// <item><description><b>leastTime</b>: This value is available only if you set <b>ProtectionResource</b> to <b>gslb</b>.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>roundRobin</para>
            /// </summary>
            [NameInMap("Loadbalance")]
            [Validation(Required=false)]
            public string Loadbalance { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("MaxBodySize")]
            [Validation(Required=false)]
            public int? MaxBodySize { get; set; }

            /// <summary>
            /// <para>The timeout period of read connections. Unit: seconds. Valid values: 1 to 3600.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("ReadTimeout")]
            [Validation(Required=false)]
            public int? ReadTimeout { get; set; }

            /// <summary>
            /// <para>The custom header fields, which are key-value pairs. The fields are used to mark requests that pass through WAF.</para>
            /// <para>When a request passes through WAF, WAF automatically adds the custom header fields to the request to mark the request. This way, the backend service can identify requests that are processed by WAF.</para>
            /// </summary>
            [NameInMap("RequestHeaders")]
            [Validation(Required=false)]
            public List<CreateDomainRequestRedirectRequestHeaders> RequestHeaders { get; set; }
            public class CreateDomainRequestRedirectRequestHeaders : TeaModel {
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
            /// <para>Specifies whether WAF retries if WAF fails to forward requests to the origin server. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b> (default)</description></item>
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
            /// <para>The forwarding rules for the hybrid cloud mode. The value is a string that consists of JSON arrays. Each element in a JSON array is a JSON struct that contains the following fields:</para>
            /// <list type="bullet">
            /// <item><description><b>rs</b>: the back-to-origin IP addresses or CNAMEs. Data type: array.</description></item>
            /// <item><description><b>location</b>: the name of the protection node. Data type: string.</description></item>
            /// <item><description><b>locationId</b>: the ID of the protection node. Data type: long.</description></item>
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
            /// <para>Specifies whether to enable the Server Name Indication (SNI) feature for back-to-origin requests. This parameter is available only if you specify <b>HttpsPorts</b>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b> (default)</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SniEnabled")]
            [Validation(Required=false)]
            public bool? SniEnabled { get; set; }

            /// <summary>
            /// <para>The custom value of the SNI field. If you do not specify this parameter, the value of the <b>Host</b> header field is automatically used. In most cases, you do not need to specify a custom value for the SNI field. However, if you want WAF to use an SNI field whose value is different from the value of the Host header field in back-to-origin requests, you can specify a custom value for the SNI field.</para>
            /// <remarks>
            /// <para> This parameter is required only if you set <b>SniEnabled</b> to <b>true</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://www.aliyundoc.com">www.aliyundoc.com</a></para>
            /// </summary>
            [NameInMap("SniHost")]
            [Validation(Required=false)]
            public string SniHost { get; set; }

            [NameInMap("WLProxyClientIp")]
            [Validation(Required=false)]
            public bool? WLProxyClientIp { get; set; }

            [NameInMap("WebServerType")]
            [Validation(Required=false)]
            public bool? WebServerType { get; set; }

            /// <summary>
            /// <para>The timeout period of write connections. Unit: seconds. Valid values: 1 to 3600.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("WriteTimeout")]
            [Validation(Required=false)]
            public int? WriteTimeout { get; set; }

            [NameInMap("XClientIp")]
            [Validation(Required=false)]
            public bool? XClientIp { get; set; }

            [NameInMap("XTrueIp")]
            [Validation(Required=false)]
            public bool? XTrueIp { get; set; }

            /// <summary>
            /// <para>Specifies whether to use the X-Forward-For-Proto header field to pass the protocol used by WAF to forward requests to the origin server. Valid values:</para>
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
        /// <para>The region where the WAF instance resides. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cn-hangzhou</b>: the Chinese mainland</description></item>
        /// <item><description><b>ap-southeast-1</b>: outside the Chinese mainland</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm***q</para>
        /// </summary>
        [NameInMap("ResourceManagerResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceManagerResourceGroupId { get; set; }

        /// <summary>
        /// <para>The tags. You can specify up to 20 tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateDomainRequestTag> Tag { get; set; }
        public class CreateDomainRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of the tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Tagkey1</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TagValue1</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
