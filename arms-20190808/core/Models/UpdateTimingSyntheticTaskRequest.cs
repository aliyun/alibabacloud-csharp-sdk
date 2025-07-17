// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class UpdateTimingSyntheticTaskRequest : TeaModel {
        /// <summary>
        /// <para>The list of assertions.</para>
        /// </summary>
        [NameInMap("AvailableAssertions")]
        [Validation(Required=false)]
        public List<UpdateTimingSyntheticTaskRequestAvailableAssertions> AvailableAssertions { get; set; }
        public class UpdateTimingSyntheticTaskRequestAvailableAssertions : TeaModel {
            /// <summary>
            /// <para>The expected value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("Expect")]
            [Validation(Required=false)]
            public string Expect { get; set; }

            /// <summary>
            /// <para>The condition. gt: greater than. gte: greater than or equal to. lt: less than. lte: less than or equal to. eq: equal to. neq: not equal to. ctn: contain. nctn: does not contain. exist: exist. n_exist: does not exist. belong: belong to. n_belong: does not belong to. reg_match: regular expression.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eq</para>
            /// </summary>
            [NameInMap("Operator")]
            [Validation(Required=false)]
            public string Operator { get; set; }

            /// <summary>
            /// <para>The check target. If you set the type parameter to HttpResCode, HttpResBody, or HttpResponseTime, you do not need to set the target parameter. If you set the type parameter to HttpResHead, you must specify the key in the header. If you set the type parameter to HttpResBodyJson, use jsonPath.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HttpResponseTime</para>
            /// </summary>
            [NameInMap("Target")]
            [Validation(Required=false)]
            public string Target { get; set; }

            /// <summary>
            /// <para>The assertion type. Valid values: HttpResCode, HttpResHead, HttpResBody, HttpResBodyJson, HttpResponseTime, IcmpPackLoss (packet loss rate), IcmpPackMaxLatency (maximum packet latency), IcmpPackAvgLatency (average packet latency), TraceRouteHops (number of hops), DnsARecord (A record), DnsCName (CNAME), websiteTTFB (time to first packet), websiteTTLB (time to last packet), websiteFST (first paint time), websiteFFST (first meaningful paint), websiteOnload (full loaded time). For more information, see the following description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TraceRouteHops</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The general settings.</para>
        /// </summary>
        [NameInMap("CommonSetting")]
        [Validation(Required=false)]
        public UpdateTimingSyntheticTaskRequestCommonSetting CommonSetting { get; set; }
        public class UpdateTimingSyntheticTaskRequestCommonSetting : TeaModel {
            /// <summary>
            /// <para>The custom host settings.</para>
            /// </summary>
            [NameInMap("CustomHost")]
            [Validation(Required=false)]
            public UpdateTimingSyntheticTaskRequestCommonSettingCustomHost CustomHost { get; set; }
            public class UpdateTimingSyntheticTaskRequestCommonSettingCustomHost : TeaModel {
                /// <summary>
                /// <para>The list of hosts.</para>
                /// </summary>
                [NameInMap("Hosts")]
                [Validation(Required=false)]
                public List<UpdateTimingSyntheticTaskRequestCommonSettingCustomHostHosts> Hosts { get; set; }
                public class UpdateTimingSyntheticTaskRequestCommonSettingCustomHostHosts : TeaModel {
                    /// <summary>
                    /// <para>The domain name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="http://www.aliyun.com">www.aliyun.com</a></para>
                    /// </summary>
                    [NameInMap("Domain")]
                    [Validation(Required=false)]
                    public string Domain { get; set; }

                    /// <summary>
                    /// <para>The IP version. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>0: A version is automatically selected.</description></item>
                    /// <item><description>1: IPv4</description></item>
                    /// <item><description>2: IPv6</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("IpType")]
                    [Validation(Required=false)]
                    public int? IpType { get; set; }

                    /// <summary>
                    /// <para>The list of IP addresses.</para>
                    /// </summary>
                    [NameInMap("Ips")]
                    [Validation(Required=false)]
                    public List<string> Ips { get; set; }

                }

                /// <summary>
                /// <para>The selection mode. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: random</description></item>
                /// <item><description>1: polling</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SelectType")]
                [Validation(Required=false)]
                public int? SelectType { get; set; }

            }

            /// <summary>
            /// <para>The reserved parameters.</para>
            /// </summary>
            [NameInMap("CustomPrometheusSetting")]
            [Validation(Required=false)]
            public UpdateTimingSyntheticTaskRequestCommonSettingCustomPrometheusSetting CustomPrometheusSetting { get; set; }
            public class UpdateTimingSyntheticTaskRequestCommonSettingCustomPrometheusSetting : TeaModel {
                /// <summary>
                /// <para>A reserved parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>A reserved parameter.</para>
                /// </summary>
                [NameInMap("PrometheusClusterId")]
                [Validation(Required=false)]
                public string PrometheusClusterId { get; set; }

                /// <summary>
                /// <para>A reserved parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>A reserved parameter.</para>
                /// </summary>
                [NameInMap("PrometheusClusterRegion")]
                [Validation(Required=false)]
                public string PrometheusClusterRegion { get; set; }

                /// <summary>
                /// <para>The reserved parameters.</para>
                /// </summary>
                [NameInMap("PrometheusLabels")]
                [Validation(Required=false)]
                public Dictionary<string, string> PrometheusLabels { get; set; }

            }

            /// <summary>
            /// <para>The information about the virtual private cloud (VPC). If the destination URL is an Alibaba Cloud internal endpoint, you need to configure a VPC.</para>
            /// </summary>
            [NameInMap("CustomVPCSetting")]
            [Validation(Required=false)]
            public UpdateTimingSyntheticTaskRequestCommonSettingCustomVPCSetting CustomVPCSetting { get; set; }
            public class UpdateTimingSyntheticTaskRequestCommonSettingCustomVPCSetting : TeaModel {
                /// <summary>
                /// <para>The region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The ID of the security group to which the client belongs. The security group specifies the inbound and outbound rules of the client for the VPC. You need to allow the security group to which the client belongs to access the security group to which the VPC belongs. Otherwise, the client cannot access resources in the VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sg-xxxxxxxx</para>
                /// </summary>
                [NameInMap("SecureGroupId")]
                [Validation(Required=false)]
                public string SecureGroupId { get; set; }

                /// <summary>
                /// <para>The vSwitch ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-2zevek6r3mpny7wxxxxxv</para>
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// <para>VPC ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-bp15bjtubjytclwxxxxxx</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

            /// <summary>
            /// <para>The IP version. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: A version is automatically selected.</description></item>
            /// <item><description>1: IPv4</description></item>
            /// <item><description>2: IPv6</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("IpType")]
            [Validation(Required=false)]
            public int? IpType { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable tracing.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsOpenTrace")]
            [Validation(Required=false)]
            public bool? IsOpenTrace { get; set; }

            /// <summary>
            /// <para>Specifies whether to evenly distribute monitoring samples. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: no</description></item>
            /// <item><description>1: yes</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("MonitorSamples")]
            [Validation(Required=false)]
            public int? MonitorSamples { get; set; }

            /// <summary>
            /// <para>The type of the client for tracing. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: ARMS agent</description></item>
            /// <item><description>1: OpenTelemetry</description></item>
            /// <item><description>2: Jaeger</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TraceClientType")]
            [Validation(Required=false)]
            public int? TraceClientType { get; set; }

            /// <summary>
            /// <para>The region to which trace data is reported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("XtraceRegion")]
            [Validation(Required=false)]
            public string XtraceRegion { get; set; }

        }

        /// <summary>
        /// <para>The custom cycle.</para>
        /// </summary>
        [NameInMap("CustomPeriod")]
        [Validation(Required=false)]
        public UpdateTimingSyntheticTaskRequestCustomPeriod CustomPeriod { get; set; }
        public class UpdateTimingSyntheticTaskRequestCustomPeriod : TeaModel {
            /// <summary>
            /// <para>The hour at which the test ends. Valid values: 0 to 24.</para>
            /// 
            /// <b>Example:</b>
            /// <para>22</para>
            /// </summary>
            [NameInMap("EndHour")]
            [Validation(Required=false)]
            public int? EndHour { get; set; }

            /// <summary>
            /// <para>The hour at which the test starts. Valid values: 0 to 24.</para>
            /// 
            /// <b>Example:</b>
            /// <para>14</para>
            /// </summary>
            [NameInMap("StartHour")]
            [Validation(Required=false)]
            public int? StartHour { get; set; }

        }

        /// <summary>
        /// <para>The detection frequency. Valid values: 1m, 5m, 10m, 15m, 20m, 30m, 1h, 2h, 3h, 4h, 6h, 8h, 12h, and 24h.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5m</para>
        /// </summary>
        [NameInMap("Frequency")]
        [Validation(Required=false)]
        public string Frequency { get; set; }

        /// <summary>
        /// <para>The monitoring configurations.</para>
        /// </summary>
        [NameInMap("MonitorConf")]
        [Validation(Required=false)]
        public UpdateTimingSyntheticTaskRequestMonitorConf MonitorConf { get; set; }
        public class UpdateTimingSyntheticTaskRequestMonitorConf : TeaModel {
            /// <summary>
            /// <para>The parameters of the HTTP(S) synthetic test.</para>
            /// </summary>
            [NameInMap("ApiHTTP")]
            [Validation(Required=false)]
            public UpdateTimingSyntheticTaskRequestMonitorConfApiHTTP ApiHTTP { get; set; }
            public class UpdateTimingSyntheticTaskRequestMonitorConfApiHTTP : TeaModel {
                /// <summary>
                /// <para>Specifies whether to verify the certificate. Default value: false.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("CheckCert")]
                [Validation(Required=false)]
                public bool? CheckCert { get; set; }

                /// <summary>
                /// <para>The connection timeout period. Unit: milliseconds. Default value: 5000. Minimum value: 1000. Maximum value: 300000.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5000</para>
                /// </summary>
                [NameInMap("ConnectTimeout")]
                [Validation(Required=false)]
                public long? ConnectTimeout { get; set; }

                /// <summary>
                /// <para>The request method. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>POST</description></item>
                /// <item><description>GET</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>POST</para>
                /// </summary>
                [NameInMap("Method")]
                [Validation(Required=false)]
                public string Method { get; set; }

                /// <summary>
                /// <para>The ALPN protocol version. You can configure this parameter when you perform an HTTPS synthetic test on a WAP mobile client. Valid values:</para>
                /// <para>0: default</para>
                /// <para>1-http/1.1</para>
                /// <para>2-h2</para>
                /// <para>3: disables the ALPN protocol</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ProtocolAlpnProtocol")]
                [Validation(Required=false)]
                public int? ProtocolAlpnProtocol { get; set; }

                /// <summary>
                /// <para>The HTTP request body.</para>
                /// </summary>
                [NameInMap("RequestBody")]
                [Validation(Required=false)]
                public UpdateTimingSyntheticTaskRequestMonitorConfApiHTTPRequestBody RequestBody { get; set; }
                public class UpdateTimingSyntheticTaskRequestMonitorConfApiHTTPRequestBody : TeaModel {
                    /// <summary>
                    /// <para>The content of the request body. Format: JSON string. The parameter is required if the Type parameter is set to text/plain, application/json, application/xml, or text/html. Format: JSON string.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{
                    ///       &quot;key1&quot;: &quot;value1&quot;,
                    ///       &quot;key2&quot;: &quot;value2&quot;
                    /// }</para>
                    /// </summary>
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    /// <summary>
                    /// <para>The type of the request body. Valid values: text/plain, application/json, application/x-www-form-urlencoded, multipart/form-data, application/xml, and text/html.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>application/json</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>The custom header field.</para>
                /// </summary>
                [NameInMap("RequestHeaders")]
                [Validation(Required=false)]
                public Dictionary<string, string> RequestHeaders { get; set; }

                /// <summary>
                /// <para>The URL or request path for synthetic monitoring.</para>
                /// 
                /// <b>Example:</b>
                /// <para>https://********</para>
                /// </summary>
                [NameInMap("TargetUrl")]
                [Validation(Required=false)]
                public string TargetUrl { get; set; }

                /// <summary>
                /// <para>The timeout period. Unit: milliseconds. Default value: 10000. Minimum value: 1000. Maximum value: 300000.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5000</para>
                /// </summary>
                [NameInMap("Timeout")]
                [Validation(Required=false)]
                public long? Timeout { get; set; }

            }

            /// <summary>
            /// <para>The parameters of file downloading.</para>
            /// </summary>
            [NameInMap("FileDownload")]
            [Validation(Required=false)]
            public UpdateTimingSyntheticTaskRequestMonitorConfFileDownload FileDownload { get; set; }
            public class UpdateTimingSyntheticTaskRequestMonitorConfFileDownload : TeaModel {
                /// <summary>
                /// <para>Unit: milliseconds. Minimum value: 1000. Maximum value: 120000. Default value: 5000.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5000</para>
                /// </summary>
                [NameInMap("ConnectionTimeout")]
                [Validation(Required=false)]
                public long? ConnectionTimeout { get; set; }

                /// <summary>
                /// <para>The content of the custom request header. Format: JSON map.</para>
                /// </summary>
                [NameInMap("CustomHeaderContent")]
                [Validation(Required=false)]
                public Dictionary<string, string> CustomHeaderContent { get; set; }

                /// <summary>
                /// <para>The kernel type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: curl</description></item>
                /// <item><description>0: WinInet</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("DownloadKernel")]
                [Validation(Required=false)]
                public int? DownloadKernel { get; set; }

                /// <summary>
                /// <para>Specifies whether to ignore CA certificate authentication errors. Valid values: 0: no. 1: yes. Default value: 1.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("IgnoreCertificateAuthError")]
                [Validation(Required=false)]
                public int? IgnoreCertificateAuthError { get; set; }

                /// <summary>
                /// <para>Specifies whether to ignore certificate revocation errors. Valid values: 0: no. 1: yes. Default value: 1.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("IgnoreCertificateCanceledError")]
                [Validation(Required=false)]
                public int? IgnoreCertificateCanceledError { get; set; }

                /// <summary>
                /// <para>Specifies whether to ignore certificate invalidity. Valid values: 0: no. 1: yes. Default value: 1.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("IgnoreCertificateOutOfDateError")]
                [Validation(Required=false)]
                public int? IgnoreCertificateOutOfDateError { get; set; }

                /// <summary>
                /// <para>Specifies whether to ignore certificate status errors. 0: no. 1: yes. Default value: 1.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("IgnoreCertificateStatusError")]
                [Validation(Required=false)]
                public int? IgnoreCertificateStatusError { get; set; }

                /// <summary>
                /// <para>Specifies whether to ignore certificate incredibility. Valid values: 0: no. 1: yes. Default value: 1.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("IgnoreCertificateUntrustworthyError")]
                [Validation(Required=false)]
                public int? IgnoreCertificateUntrustworthyError { get; set; }

                /// <summary>
                /// <para>Specifies whether to ignore certificate usage errors. Valid values: 0: no. 1: yes. Default value: 1.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("IgnoreCertificateUsingError")]
                [Validation(Required=false)]
                public int? IgnoreCertificateUsingError { get; set; }

                /// <summary>
                /// <para>Specifies whether to ignore host invalidity. Valid values: 0: no. 1: yes. Default value: 1.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("IgnoreInvalidHostError")]
                [Validation(Required=false)]
                public int? IgnoreInvalidHostError { get; set; }

                /// <summary>
                /// <para>The monitoring timeout period. Unit: milliseconds. Minimum value: 1000. Maximum value: 120000. Default value: 60000.</para>
                /// 
                /// <b>Example:</b>
                /// <para>60000</para>
                /// </summary>
                [NameInMap("MonitorTimeout")]
                [Validation(Required=false)]
                public long? MonitorTimeout { get; set; }

                /// <summary>
                /// <para>The QUIC protocol type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: HTTP/1</description></item>
                /// <item><description>2: HTTP/2</description></item>
                /// <item><description>3: http3</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("QuickProtocol")]
                [Validation(Required=false)]
                public int? QuickProtocol { get; set; }

                /// <summary>
                /// <para>Specifies whether to support redirection. Valid values: 0: no. 1: yes. Default value: 1.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Redirection")]
                [Validation(Required=false)]
                public int? Redirection { get; set; }

                /// <summary>
                /// <para>The URL that is used to download the file.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://img.alicdn.com/tfs/TB13DzOjXP7gK0jSZFjXXc5aXXa-212-48.png">https://img.alicdn.com/tfs/TB13DzOjXP7gK0jSZFjXXc5aXXa-212-48.png</a></para>
                /// </summary>
                [NameInMap("TargetUrl")]
                [Validation(Required=false)]
                public string TargetUrl { get; set; }

                /// <summary>
                /// <para>The maximum file size of a single transfer. Unit: KB. Minimum value: 1. Maximum value: 20480. Valid values: 2048.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2048</para>
                /// </summary>
                [NameInMap("TransmissionSize")]
                [Validation(Required=false)]
                public long? TransmissionSize { get; set; }

                /// <summary>
                /// <para>The keyword that is used in verification.</para>
                /// 
                /// <b>Example:</b>
                /// <para>aliyun</para>
                /// </summary>
                [NameInMap("ValidateKeywords")]
                [Validation(Required=false)]
                public string ValidateKeywords { get; set; }

                /// <summary>
                /// <para>The verification method. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: no verification</description></item>
                /// <item><description>1: string verification</description></item>
                /// <item><description>2: MD5 verification</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("VerifyWay")]
                [Validation(Required=false)]
                public int? VerifyWay { get; set; }

                /// <summary>
                /// <para>The whitelisted objects that are used to avoid DNS hijacking. The objects can be IP addresses, wildcard mask, subnet mask, or CNAME records. Separate multiple objects with vertical bars (|). Example: <a href="http://www.aliyun.com:203.0.3.55%7C203.3.44.67">www.aliyun.com:203.0.3.55|203.3.44.67</a>. It indicates that all IP addresses that belong to the <a href="http://www.aliyun.com">www.aliyun.com</a> domain name except 203.0.3.55 and 203.3.44.67 are hijacked.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://www.aliyun.com:203.0.3.55%7C203.3.44.67">www.aliyun.com:203.0.3.55|203.3.44.67</a></para>
                /// </summary>
                [NameInMap("WhiteList")]
                [Validation(Required=false)]
                public string WhiteList { get; set; }

            }

            /// <summary>
            /// <para>The parameters of the DNS synthetic test.</para>
            /// </summary>
            [NameInMap("NetDNS")]
            [Validation(Required=false)]
            public UpdateTimingSyntheticTaskRequestMonitorConfNetDNS NetDNS { get; set; }
            public class UpdateTimingSyntheticTaskRequestMonitorConfNetDNS : TeaModel {
                /// <summary>
                /// <para>Specifies whether to use the dig command to display the data. Valid values: 0: no. 1: yes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Dig")]
                [Validation(Required=false)]
                public int? Dig { get; set; }

                /// <summary>
                /// <para>The IP version of the DNS server. Valid values: 0: IPv4. 1: IPv6. 2: A version is automatically selected. Default value: 0.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("DnsServerIpType")]
                [Validation(Required=false)]
                public int? DnsServerIpType { get; set; }

                /// <summary>
                /// <para>The IP address of the DNS server. Default value: 114.114.114.114.</para>
                /// 
                /// <b>Example:</b>
                /// <para>114.114.114.114</para>
                /// </summary>
                [NameInMap("NsServer")]
                [Validation(Required=false)]
                public string NsServer { get; set; }

                /// <summary>
                /// <para>The DNS query method. Valid values: 0: recursive. 1: iterative. Default value: 0.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("QueryMethod")]
                [Validation(Required=false)]
                public int? QueryMethod { get; set; }

                /// <summary>
                /// <para>The domain name.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://www.aliyun.com">www.aliyun.com</a></para>
                /// </summary>
                [NameInMap("TargetUrl")]
                [Validation(Required=false)]
                public string TargetUrl { get; set; }

                /// <summary>
                /// <para>The timeout period for the DNS synthetic test. Unit: milliseconds. Minimum value: 1000. Maximum value: 45000. Default value: 5000.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("Timeout")]
                [Validation(Required=false)]
                public long? Timeout { get; set; }

            }

            /// <summary>
            /// <para>The parameters of the ICMP synthetic test.</para>
            /// </summary>
            [NameInMap("NetICMP")]
            [Validation(Required=false)]
            public UpdateTimingSyntheticTaskRequestMonitorConfNetICMP NetICMP { get; set; }
            public class UpdateTimingSyntheticTaskRequestMonitorConfNetICMP : TeaModel {
                /// <summary>
                /// <para>The interval at which ICMP packets are sent. Unit: milliseconds. Minimum value: 200. Maximum value: 10000.</para>
                /// 
                /// <b>Example:</b>
                /// <para>300</para>
                /// </summary>
                [NameInMap("Interval")]
                [Validation(Required=false)]
                public long? Interval { get; set; }

                /// <summary>
                /// <para>The number of ICMP packets that are sent. Minimum value: 1. Maximum value: 50. Default value: 4.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("PackageNum")]
                [Validation(Required=false)]
                public int? PackageNum { get; set; }

                /// <summary>
                /// <para>The size of each ICMP packet. Unit: bytes. Valid values: 32, 64, 128, 256, 512, 1024, 1080, and 1450.</para>
                /// 
                /// <b>Example:</b>
                /// <para>32</para>
                /// </summary>
                [NameInMap("PackageSize")]
                [Validation(Required=false)]
                public int? PackageSize { get; set; }

                /// <summary>
                /// <para>Specifies whether to split ICMP packets. Default value: true.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("SplitPackage")]
                [Validation(Required=false)]
                public bool? SplitPackage { get; set; }

                /// <summary>
                /// <para>The IP address or domain name of the destination host. The value cannot contain port numbers, protocol headers, or request paths.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://www.aliyun.com">www.aliyun.com</a></para>
                /// </summary>
                [NameInMap("TargetUrl")]
                [Validation(Required=false)]
                public string TargetUrl { get; set; }

                /// <summary>
                /// <para>The timeout period for the ICMP synthetic test. Unit: milliseconds. Minimum value: 1000. Maximum value: 300000. Default value: 20000.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5000</para>
                /// </summary>
                [NameInMap("Timeout")]
                [Validation(Required=false)]
                public long? Timeout { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable the tracert command. Default value: true.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("TracertEnable")]
                [Validation(Required=false)]
                public bool? TracertEnable { get; set; }

                /// <summary>
                /// <para>The maximum number of hops for the tracert command. Minimum value: 1. Maximum value: 128. Default value: 20.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("TracertNumMax")]
                [Validation(Required=false)]
                public int? TracertNumMax { get; set; }

                /// <summary>
                /// <para>The timeout period of the tracert command. Unit: milliseconds. Minimum value: 1000. Maximum value: 300000. Default value: 60000.</para>
                /// 
                /// <b>Example:</b>
                /// <para>60000</para>
                /// </summary>
                [NameInMap("TracertTimeout")]
                [Validation(Required=false)]
                public long? TracertTimeout { get; set; }

            }

            /// <summary>
            /// <para>The parameters of the TCP synthetic test.</para>
            /// </summary>
            [NameInMap("NetTCP")]
            [Validation(Required=false)]
            public UpdateTimingSyntheticTaskRequestMonitorConfNetTCP NetTCP { get; set; }
            public class UpdateTimingSyntheticTaskRequestMonitorConfNetTCP : TeaModel {
                /// <summary>
                /// <para>The number of TCP connections that are established. Minimum value: 1. Maximum value: 16. Default value: 4.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("ConnectTimes")]
                [Validation(Required=false)]
                public int? ConnectTimes { get; set; }

                /// <summary>
                /// <para>The interval at which TCP connections are established. Unit: milliseconds. Minimum value: 200. Maximum value: 10000. Default value: 200.</para>
                /// 
                /// <b>Example:</b>
                /// <para>300</para>
                /// </summary>
                [NameInMap("Interval")]
                [Validation(Required=false)]
                public long? Interval { get; set; }

                /// <summary>
                /// <para>The IP address of the destination host.</para>
                /// 
                /// <b>Example:</b>
                /// <para>127.0.0.1:8888</para>
                /// </summary>
                [NameInMap("TargetUrl")]
                [Validation(Required=false)]
                public string TargetUrl { get; set; }

                /// <summary>
                /// <para>The timeout period for the TCP synthetic test. Unit: milliseconds. Minimum value: 1000. Maximum value: 300000. Default value: 20000.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("Timeout")]
                [Validation(Required=false)]
                public long? Timeout { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable the tracert command. Default value: true.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("TracertEnable")]
                [Validation(Required=false)]
                public bool? TracertEnable { get; set; }

                /// <summary>
                /// <para>The maximum number of hops for the tracert command. Minimum value: 1. Maximum value: 128. Default value: 20.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("TracertNumMax")]
                [Validation(Required=false)]
                public int? TracertNumMax { get; set; }

                /// <summary>
                /// <para>The timeout period of the tracert command. Unit: milliseconds. Minimum value: 1000. Maximum value: 300000. Default value: 60000.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("TracertTimeout")]
                [Validation(Required=false)]
                public long? TracertTimeout { get; set; }

            }

            /// <summary>
            /// <para>The parameters of the streaming-media synthetic test.</para>
            /// </summary>
            [NameInMap("Stream")]
            [Validation(Required=false)]
            public UpdateTimingSyntheticTaskRequestMonitorConfStream Stream { get; set; }
            public class UpdateTimingSyntheticTaskRequestMonitorConfStream : TeaModel {
                /// <summary>
                /// <para>The custom header. Format: JSON map.</para>
                /// </summary>
                [NameInMap("CustomHeaderContent")]
                [Validation(Required=false)]
                public Dictionary<string, string> CustomHeaderContent { get; set; }

                /// <summary>
                /// <para>The player. Default value: 12. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>12: VLC</description></item>
                /// <item><description>2: Flash Player</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("PlayerType")]
                [Validation(Required=false)]
                public int? PlayerType { get; set; }

                /// <summary>
                /// <para>The address type of the resource. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: resource URL.</description></item>
                /// <item><description>0: page URL. Default value: 0.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("StreamAddressType")]
                [Validation(Required=false)]
                public int? StreamAddressType { get; set; }

                /// <summary>
                /// <para>The monitoring duration. Unit: seconds. Maximum and default value: 60.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("StreamMonitorTimeout")]
                [Validation(Required=false)]
                public int? StreamMonitorTimeout { get; set; }

                /// <summary>
                /// <para>Specifies whether the resource is a video or audio. Valid values: 0: video. 1: audio.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("StreamType")]
                [Validation(Required=false)]
                public int? StreamType { get; set; }

                /// <summary>
                /// <para>The resource URL of the streaming media.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://www.aliyun.com/stream/test.mp4">http://www.aliyun.com/stream/test.mp4</a></para>
                /// </summary>
                [NameInMap("TargetUrl")]
                [Validation(Required=false)]
                public string TargetUrl { get; set; }

                /// <summary>
                /// <para>The whitelisted objects that are used to avoid DNS hijacking. The objects can be IP addresses, wildcard mask, subnet mask, or CNAME records. Separate multiple objects with vertical bars (|). Example: <a href="http://www.aliyun.com:203.0.3.55%7C203.3.44.67">www.aliyun.com:203.0.3.55|203.3.44.67</a>. It indicates that all IP addresses that belong to the <a href="http://www.aliyun.com">www.aliyun.com</a> domain name except 203.0.3.55 and 203.3.44.67 are hijacked.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://www.aliyun.com:203.0.3.55%7C203.3.44.67">www.aliyun.com:203.0.3.55|203.3.44.67</a></para>
                /// </summary>
                [NameInMap("WhiteList")]
                [Validation(Required=false)]
                public string WhiteList { get; set; }

            }

            /// <summary>
            /// <para>The parameters of the website speed measurement.</para>
            /// </summary>
            [NameInMap("Website")]
            [Validation(Required=false)]
            public UpdateTimingSyntheticTaskRequestMonitorConfWebsite Website { get; set; }
            public class UpdateTimingSyntheticTaskRequestMonitorConfWebsite : TeaModel {
                /// <summary>
                /// <para>Specifies whether to automatically scroll up and down the screen to load a page. Valid values: 0: no. 1: yes. Default value: 0.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AutomaticScrolling")]
                [Validation(Required=false)]
                public int? AutomaticScrolling { get; set; }

                /// <summary>
                /// <para>Specifies whether to create a custom header. Valid values: 0: no. 1: The first packet is modified. 2: All packets are modified. Default value: 0.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CustomHeader")]
                [Validation(Required=false)]
                public int? CustomHeader { get; set; }

                /// <summary>
                /// <para>The custom header. Format: JSON map.</para>
                /// </summary>
                [NameInMap("CustomHeaderContent")]
                [Validation(Required=false)]
                public Dictionary<string, string> CustomHeaderContent { get; set; }

                /// <summary>
                /// <para>If the IP address or CNAME record resolved from a domain name is not included in the DNS whitelist, you cannot access the domain name, or an IP address that belongs to a different domain name is returned. If the IP address or CNAME record is included in the DNS whitelist, DNS hijacking does not occur.</para>
                /// <para>Format: \<domain name>:\<objects>. The objects can be IP addresses, wildcard mask, subnet mask, or CNAME records. Separate multiple objects with vertical bars (|). Example: <a href="http://www.aliyun.com:203.0.3.55%7C203.3.44.67">www.aliyun.com:203.0.3.55|203.3.44.67</a>. It indicates that all IP addresses that belong to the <a href="http://www.aliyun.com">www.aliyun.com</a> domain name except 203.0.3.55 and 203.3.44.67 are hijacked.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://www.aliyun.com:203.0.3.55%7C203.3.44.67">www.aliyun.com:203.0.3.55|203.3.44.67</a></para>
                /// </summary>
                [NameInMap("DNSHijackWhitelist")]
                [Validation(Required=false)]
                public string DNSHijackWhitelist { get; set; }

                /// <summary>
                /// <para>Specifies whether to disable the cache. Valid values: 0: no. 1: yes. Default value: 1.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("DisableCache")]
                [Validation(Required=false)]
                public int? DisableCache { get; set; }

                /// <summary>
                /// <para>Specifies whether to accept compressed files based on the HTTP Accept-Encoding request header. Valid values: 0: no. 1: yes. Default value: 0.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("DisableCompression")]
                [Validation(Required=false)]
                public int? DisableCompression { get; set; }

                /// <summary>
                /// <para>The elements not to be loaded in the page loading process.</para>
                /// 
                /// <b>Example:</b>
                /// <para>a.jpg</para>
                /// </summary>
                [NameInMap("ElementBlacklist")]
                [Validation(Required=false)]
                public string ElementBlacklist { get; set; }

                /// <summary>
                /// <para>Specifies whether to exclude invalid IP addresses. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: no</description></item>
                /// <item><description>0: yes</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("FilterInvalidIP")]
                [Validation(Required=false)]
                public int? FilterInvalidIP { get; set; }

                /// <summary>
                /// <para>The total number of elements on the page.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("FlowHijackJumpTimes")]
                [Validation(Required=false)]
                public int? FlowHijackJumpTimes { get; set; }

                /// <summary>
                /// <para>The keyword that is used to identify hijacking. Asterisks (\*) are allowed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>aliyun</para>
                /// </summary>
                [NameInMap("FlowHijackLogo")]
                [Validation(Required=false)]
                public string FlowHijackLogo { get; set; }

                /// <summary>
                /// <para>Specifies whether to ignore SSL certificate errors during browsing. Valid values: 0: no. 1: yes. Default value: 1.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("IgnoreCertificateError")]
                [Validation(Required=false)]
                public int? IgnoreCertificateError { get; set; }

                /// <summary>
                /// <para>The monitoring timeout period. Unit: milliseconds. Minimum value: 5000. Maximum value: 300000. Default value: 40000.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20000</para>
                /// </summary>
                [NameInMap("MonitorTimeout")]
                [Validation(Required=false)]
                public long? MonitorTimeout { get; set; }

                /// <summary>
                /// <para>Elements that are not included in the whitelist and appear on the page are manipulated. These elements can be pop-up ads, floating ads, and page redirection.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://www.aliyun.com:%7C/cc/bb/a.gif%7C/vv/bb/cc.jpg">www.aliyun.com:|/cc/bb/a.gif|/vv/bb/cc.jpg</a></para>
                /// </summary>
                [NameInMap("PageTamper")]
                [Validation(Required=false)]
                public string PageTamper { get; set; }

                /// <summary>
                /// <para>Specifies whether to continue browsing after redirection. Valid values: 0: no. 1: yes. Default value: 1.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Redirection")]
                [Validation(Required=false)]
                public int? Redirection { get; set; }

                /// <summary>
                /// <para>The time threshold that is used to define a slow element. Unit: milliseconds. Default value: 5000. Minimum value: 1. Maximum value: 300000.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5000</para>
                /// </summary>
                [NameInMap("SlowElementThreshold")]
                [Validation(Required=false)]
                public long? SlowElementThreshold { get; set; }

                /// <summary>
                /// <para>The URL of the website.</para>
                /// 
                /// <b>Example:</b>
                /// <para>https://********</para>
                /// </summary>
                [NameInMap("TargetUrl")]
                [Validation(Required=false)]
                public string TargetUrl { get; set; }

                /// <summary>
                /// <para>An arbitrary string in the source code of the page for verification. If the source code returned by the client contains a string that is in the blacklist, the 650 error code is reported, which indicates that the string fails to be verified. Separate multiple strings with vertical bars (|).</para>
                /// 
                /// <b>Example:</b>
                /// <para>error</para>
                /// </summary>
                [NameInMap("VerifyStringBlacklist")]
                [Validation(Required=false)]
                public string VerifyStringBlacklist { get; set; }

                /// <summary>
                /// <para>An arbitrary string in the source code of the page for verification. If the source code returned by the client contains a string that is not in the whitelist, the 650 error code is reported, which indicates that the string fails to be verified. Separate multiple strings with vertical bars (|).</para>
                /// 
                /// <b>Example:</b>
                /// <para>success</para>
                /// </summary>
                [NameInMap("VerifyStringWhitelist")]
                [Validation(Required=false)]
                public string VerifyStringWhitelist { get; set; }

                /// <summary>
                /// <para>The maximum waiting time. Unit: milliseconds. Default value: 5000. Minimum value: 5000. Maximum value: 300000.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5000</para>
                /// </summary>
                [NameInMap("WaitCompletionTime")]
                [Validation(Required=false)]
                public long? WaitCompletionTime { get; set; }

            }

        }

        /// <summary>
        /// <para>The list of monitoring points.</para>
        /// </summary>
        [NameInMap("Monitors")]
        [Validation(Required=false)]
        public List<UpdateTimingSyntheticTaskRequestMonitors> Monitors { get; set; }
        public class UpdateTimingSyntheticTaskRequestMonitors : TeaModel {
            /// <summary>
            /// <para>The city code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100001</para>
            /// </summary>
            [NameInMap("CityCode")]
            [Validation(Required=false)]
            public string CityCode { get; set; }

            /// <summary>
            /// <para>The client type of the monitoring point. Valid values: 1: data center. 2: Internet. 3: mobile device. 4: ECS instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("ClientType")]
            [Validation(Required=false)]
            public int? ClientType { get; set; }

            /// <summary>
            /// <para>The carrier code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("OperatorCode")]
            [Validation(Required=false)]
            public string OperatorCode { get; set; }

        }

        /// <summary>
        /// <para>The name of the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AlibabaCloud DNS Task</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmxyexli2****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The list of tags.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<UpdateTimingSyntheticTaskRequestTags> Tags { get; set; }
        public class UpdateTimingSyntheticTaskRequestTags : TeaModel {
            /// <summary>
            /// <para>The key of the tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>key</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>value</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The ID of the synthetic monitoring task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5308a2691f59422c8c3b7aeccxxxxxxx</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
