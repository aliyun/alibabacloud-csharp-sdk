// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class ModifyDomainRequest : TeaModel {
        /// <summary>
        /// <para>The mode in which you want to add the domain name to WAF. Set the value to share.</para>
        /// <list type="bullet">
        /// <item><description><b>share:</b> adds the domain name to WAF in CNAME record mode. This is the default value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>share</para>
        /// </summary>
        [NameInMap("AccessType")]
        [Validation(Required=false)]
        public string AccessType { get; set; }

        /// <summary>
        /// <para>The domain name whose access configurations you want to modify.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.aliyundoc.com">www.aliyundoc.com</a></para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>The ID of the WAF instance.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/433756.html">DescribeInstance</a> operation to obtain the ID of the WAF instance.</para>
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
        /// <para>The configurations of the listeners.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Listen")]
        [Validation(Required=false)]
        public ModifyDomainRequestListen Listen { get; set; }
        public class ModifyDomainRequestListen : TeaModel {
            /// <summary>
            /// <para>The ID of the certificate that you want to add.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("CertId")]
            [Validation(Required=false)]
            public string CertId { get; set; }

            /// <summary>
            /// <para>The type of cipher suite that you want to add. This parameter is available only when you specify the <b>HttpsPorts</b> parameter. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1:</b> all cipher suites.</description></item>
            /// <item><description><b>2:</b> strong cipher suites. You can select this value only when you set the <b>TLSVersion</b> parameter to <b>tlsv1.2</b>.</description></item>
            /// <item><description><b>99:</b> custom cipher suites.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("CipherSuite")]
            [Validation(Required=false)]
            public int? CipherSuite { get; set; }

            /// <summary>
            /// <para>The custom cipher suites that you want to add. This parameter is available only when you set the <b>CipherSuite</b> parameter to <b>99</b>.</para>
            /// </summary>
            [NameInMap("CustomCiphers")]
            [Validation(Required=false)]
            public List<string> CustomCiphers { get; set; }

            /// <summary>
            /// <para>Specifies whether to support TLS 1.3. This parameter is available only when you specify the <b>HttpsPorts</b> parameter. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true:</b> supports TLS 1.3.</description></item>
            /// <item><description><b>false:</b> does not support TLS 1.3.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableTLSv3")]
            [Validation(Required=false)]
            public bool? EnableTLSv3 { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable an exclusive IP address for the domain name. This parameter is available only when you set the <b>IPv6Enabled</b> parameter to false and the <b>ProtectionResource</b> parameter to <b>share</b>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true:</b> enables an exclusive IP address for the domain name.</description></item>
            /// <item><description><b>false:</b> does not enable an exclusive IP address for the domain name. This is the default value.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ExclusiveIp")]
            [Validation(Required=false)]
            public bool? ExclusiveIp { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable HTTP to HTTPS redirection for the domain name. This parameter is available only when you specify the <b>HttpsPorts</b> parameter and leave the <b>HttpPorts</b> parameter empty. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true:</b> enables HTTP to HTTPS redirection.</description></item>
            /// <item><description><b>false:</b> disables HTTP to HTTPS redirection.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("FocusHttps")]
            [Validation(Required=false)]
            public bool? FocusHttps { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable HTTP/2. This parameter is available only when you specify the <b>HttpsPorts</b> parameter. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true:</b> enables HTTP/2.</description></item>
            /// <item><description><b>false:</b> disables HTTP/2. This is the default value.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Http2Enabled")]
            [Validation(Required=false)]
            public bool? Http2Enabled { get; set; }

            /// <summary>
            /// <para>An array of HTTP listener ports. Specify the value of this parameter in the [port1,port2,...] format.</para>
            /// </summary>
            [NameInMap("HttpPorts")]
            [Validation(Required=false)]
            public List<int?> HttpPorts { get; set; }

            /// <summary>
            /// <para>An array of HTTPS listener ports. Specify the value of this parameter in the [port1,port2,...] format.</para>
            /// </summary>
            [NameInMap("HttpsPorts")]
            [Validation(Required=false)]
            public List<int?> HttpsPorts { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable IPv6. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true:</b> enables IPv6.</description></item>
            /// <item><description><b>false:</b> disables IPv6. This is the default value.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IPv6Enabled")]
            [Validation(Required=false)]
            public bool? IPv6Enabled { get; set; }

            /// <summary>
            /// <para>The type of the protection resource that you want to use. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>share:</b> shared cluster. This is the default value.</description></item>
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
            /// <para>Specifies whether to allow access only from SM certificate-based clients. This parameter is available only if you set SM2Enabled to true.</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SM2AccessOnly")]
            [Validation(Required=false)]
            public bool? SM2AccessOnly { get; set; }

            /// <summary>
            /// <para>The ID of the SM certificate that you want to add. This parameter is available only if you set SM2Enabled to true.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123-cn-hangzhou</para>
            /// </summary>
            [NameInMap("SM2CertId")]
            [Validation(Required=false)]
            public string SM2CertId { get; set; }

            /// <summary>
            /// <para>Indicates whether SM certificate-based verification is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SM2Enabled")]
            [Validation(Required=false)]
            public bool? SM2Enabled { get; set; }

            /// <summary>
            /// <para>The version of the Transport Layer Security (TLS) protocol. This parameter is available only when you specify the <b>HttpsPorts</b> parameter. Valid values:</para>
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
            /// <para>The method that you want WAF to use to obtain the actual IP address of a client. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0:</b> No Layer 7 proxies are deployed in front of WAF. This is the default value.</description></item>
            /// <item><description><b>1:</b> WAF reads the first value of the X-Forwarded-For (XFF) header field as the actual IP address of the client.</description></item>
            /// <item><description><b>2:</b> WAF reads the value of a custom header field as the actual IP address of the client.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("XffHeaderMode")]
            [Validation(Required=false)]
            public int? XffHeaderMode { get; set; }

            /// <summary>
            /// <para>The custom header fields that you want to use to obtain the actual IP address of a client. Specify the value of this parameter in the [&quot;header1&quot;,&quot;header2&quot;,...] format.</para>
            /// <remarks>
            /// <para> If you set the <b>XffHeaderMode</b> parameter to 2, this parameter is required.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("XffHeaders")]
            [Validation(Required=false)]
            public List<string> XffHeaders { get; set; }

        }

        /// <summary>
        /// <para>The configurations of the forwarding rule.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Redirect")]
        [Validation(Required=false)]
        public ModifyDomainRequestRedirect Redirect { get; set; }
        public class ModifyDomainRequestRedirect : TeaModel {
            /// <summary>
            /// <para>The IP addresses or domain names of the origin server. You can use only one of the address types. If you use the domain name type, the domain name can be resolved only to an IPv4 address.</para>
            /// <list type="bullet">
            /// <item><description>If you use the IP address type, specify the value in the [&quot;ip1&quot;,&quot;ip2&quot;,...] format. You can enter up to 20 IP addresses.</description></item>
            /// <item><description>If you use the domain name type, specify the value in the [&quot;domain&quot;] format. You can enter up to 20 domain names.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("Backends")]
            [Validation(Required=false)]
            public List<string> Backends { get; set; }

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
            /// <para>The timeout period for connections. Unit: seconds. Valid values: 1 to 3600.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120</para>
            /// </summary>
            [NameInMap("ConnectTimeout")]
            [Validation(Required=false)]
            public int? ConnectTimeout { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable HTTPS to HTTP redirection for back-to-origin requests. This parameter is available only if you specify <b>HttpsPorts</b>. Valid values:</para>
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
            /// <para> This parameter specifies the number of reused persistent connections after you enable the persistent connection feature.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("KeepaliveRequests")]
            [Validation(Required=false)]
            public int? KeepaliveRequests { get; set; }

            /// <summary>
            /// <para>The timeout period for idle persistent connections. Valid values: 1 to 60. Default value: 15. Unit: seconds.</para>
            /// <remarks>
            /// <para> This parameter specifies the time for which a reused persistent connection can remain in the Idle state before the persistent connection is released.</para>
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
            /// <item><description><b>ip_hash</b></description></item>
            /// <item><description><b>roundRobin</b></description></item>
            /// <item><description><b>leastTime</b> You can set the parameter to this value only if you set <b>ProtectionResource</b> to <b>gslb</b>.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>iphash</para>
            /// </summary>
            [NameInMap("Loadbalance")]
            [Validation(Required=false)]
            public string Loadbalance { get; set; }

            /// <summary>
            /// <para>The timeout period for read connections. Unit: seconds. Valid values: 1 to 3600.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("ReadTimeout")]
            [Validation(Required=false)]
            public int? ReadTimeout { get; set; }

            /// <summary>
            /// <para>The custom header field that you want to use to label requests that are processed by WAF.</para>
            /// <para>When a request passes through WAF, the custom header field is automatically used to label the request. This way, the backend service can identify requests that are processed by WAF.</para>
            /// </summary>
            [NameInMap("RequestHeaders")]
            [Validation(Required=false)]
            public List<ModifyDomainRequestRedirectRequestHeaders> RequestHeaders { get; set; }
            public class ModifyDomainRequestRedirectRequestHeaders : TeaModel {
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
            /// <para>Specifies whether WAF retries forwarding requests to the origin server when the requests fail to be forwarded to the origin server. Valid values:</para>
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
            /// <para>The forwarding rules that you want to configure for the domain name that you want to add to WAF in hybrid cloud mode. This parameter is a string that consists of JSON arrays. Each element in a JSON array is a JSON struct that contains the following fields:</para>
            /// <list type="bullet">
            /// <item><description><b>rs</b>: the back-to-origin IP addresses or CNAMEs. The value must be of the ARRAY type.</description></item>
            /// <item><description><b>location</b>: the name of the protection node. The value must be of the STRING type.</description></item>
            /// <item><description><b>locationId</b>: the ID of the protection node. The value must be of the LONG type.</description></item>
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
            /// <para>Specifies whether to enable origin Server Name Indication (SNI). This parameter is available only if you specify <b>HttpsPorts</b>. Valid values:</para>
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
            /// <para>The value of the SNI field. If you do not specify this parameter, the value of the <b>Host</b> field is automatically used. This parameter is optional. If you want WAF to use an SNI field value that is different from the Host field value in back-to-origin requests, you can specify a custom value for the SNI field.</para>
            /// <remarks>
            /// <para> This parameter is required only if you set <b>SniEnalbed</b> to xxx.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://www.aliyundoc.com">www.aliyundoc.com</a></para>
            /// </summary>
            [NameInMap("SniHost")]
            [Validation(Required=false)]
            public string SniHost { get; set; }

            /// <summary>
            /// <para>The timeout period for write connections. Unit: seconds. Valid values: 1 to 3600.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("WriteTimeout")]
            [Validation(Required=false)]
            public int? WriteTimeout { get; set; }

            /// <summary>
            /// <para>Specifies whether to use the X-Forward-For-Proto header to identify the protocol used by WAF to forward requests to the origin server. Valid values:</para>
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
        /// <item><description><b>cn-hangzhou:</b> the Chinese mainland.</description></item>
        /// <item><description><b>ap-southeast-1:</b> outside the Chinese mainland.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
