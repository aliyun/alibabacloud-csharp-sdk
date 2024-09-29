// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GetTimingSyntheticTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code returned. The status code 200 indicates that the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        /// <summary>
        /// <para>The returned struct.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetTimingSyntheticTaskResponseBodyData Data { get; set; }
        public class GetTimingSyntheticTaskResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of assertions.</para>
            /// </summary>
            [NameInMap("AvailableAssertions")]
            [Validation(Required=false)]
            public List<GetTimingSyntheticTaskResponseBodyDataAvailableAssertions> AvailableAssertions { get; set; }
            public class GetTimingSyntheticTaskResponseBodyDataAvailableAssertions : TeaModel {
                /// <summary>
                /// <para>The expected value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Expect")]
                [Validation(Required=false)]
                public string Expect { get; set; }

                /// <summary>
                /// <para>The condition. gt: greater than. gte: greater than or equal to. lt: less than. lte: less than or equal to. eq: equal to. neq: not equal to. ctn: contain. nctn: does not contain. exist: exist. n_exist: does not exist. belong: belong to. n_belong: does not belong to. reg_match: regular expression.</para>
                /// 
                /// <b>Example:</b>
                /// <para>gt</para>
                /// </summary>
                [NameInMap("Operator")]
                [Validation(Required=false)]
                public string Operator { get; set; }

                /// <summary>
                /// <para>The check target. If you set the type parameter to HttpResCode, HttpResBody, or HttpResponseTime, you do not need to set the target parameter. If you set the type parameter to HttpResHead, you must specify the key in the header. If you set the type parameter to HttpResBodyJson, use jsonPath.</para>
                /// 
                /// <b>Example:</b>
                /// <para>key</para>
                /// </summary>
                [NameInMap("Target")]
                [Validation(Required=false)]
                public string Target { get; set; }

                /// <summary>
                /// <para>The assertion type. Valid values: HttpResCode, HttpResHead, HttpResBody, HttpResBodyJson, HttpResponseTime, IcmpPackLoss (packet loss rate), IcmpPackMaxLatency (maximum packet latency), IcmpPackAvgLatency (average packet latency), TraceRouteHops (number of hops), DnsARecord (A record), DnsCName (CNAME), websiteTTFB (time to first packet), websiteTTLB (time to last packet), websiteFST (first paint time), websiteFFST (first meaningful paint), websiteOnload (full loaded time). For more information, see the following description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>websiteTTLB</para>
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
            public GetTimingSyntheticTaskResponseBodyDataCommonSetting CommonSetting { get; set; }
            public class GetTimingSyntheticTaskResponseBodyDataCommonSetting : TeaModel {
                /// <summary>
                /// <para>The custom host.</para>
                /// </summary>
                [NameInMap("CustomHost")]
                [Validation(Required=false)]
                public GetTimingSyntheticTaskResponseBodyDataCommonSettingCustomHost CustomHost { get; set; }
                public class GetTimingSyntheticTaskResponseBodyDataCommonSettingCustomHost : TeaModel {
                    /// <summary>
                    /// <para>The list of hosts.</para>
                    /// </summary>
                    [NameInMap("Hosts")]
                    [Validation(Required=false)]
                    public List<GetTimingSyntheticTaskResponseBodyDataCommonSettingCustomHostHosts> Hosts { get; set; }
                    public class GetTimingSyntheticTaskResponseBodyDataCommonSettingCustomHostHosts : TeaModel {
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
                    /// <para>The selection mode. 0: Random. 1: Polling.</para>
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
                public GetTimingSyntheticTaskResponseBodyDataCommonSettingCustomPrometheusSetting CustomPrometheusSetting { get; set; }
                public class GetTimingSyntheticTaskResponseBodyDataCommonSettingCustomPrometheusSetting : TeaModel {
                    /// <summary>
                    /// <para>A reserved parameter.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Reserved parameter</para>
                    /// </summary>
                    [NameInMap("PrometheusClusterId")]
                    [Validation(Required=false)]
                    public string PrometheusClusterId { get; set; }

                    /// <summary>
                    /// <para>A reserved parameter.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Reserved parameter</para>
                    /// </summary>
                    [NameInMap("PrometheusClusterRegion")]
                    [Validation(Required=false)]
                    public string PrometheusClusterRegion { get; set; }

                    /// <summary>
                    /// <para>A reserved parameter.</para>
                    /// </summary>
                    [NameInMap("PrometheusLabels")]
                    [Validation(Required=false)]
                    public Dictionary<string, string> PrometheusLabels { get; set; }

                }

                /// <summary>
                /// <para>User VPC information. If the dial-up is to the Alibaba Cloud intranet address, you need to configure the VPC information.</para>
                /// </summary>
                [NameInMap("CustomVPCSetting")]
                [Validation(Required=false)]
                public GetTimingSyntheticTaskResponseBodyDataCommonSettingCustomVPCSetting CustomVPCSetting { get; set; }
                public class GetTimingSyntheticTaskResponseBodyDataCommonSettingCustomVPCSetting : TeaModel {
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
                    /// <para>Security group ID. This security group is where the dial-up client is located. The security group limits the inbound and outbound rules of the dial-up client in the VPC. You need to set the inbound rules of the security group where your VPC is located to allow the security group where the dial-up client is located to access. Otherwise, the dial-up client cannot smoothly access the resources in your VPC.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>sg-xxxxxxx</para>
                    /// </summary>
                    [NameInMap("SecureGroupId")]
                    [Validation(Required=false)]
                    public string SecureGroupId { get; set; }

                    /// <summary>
                    /// <para>The vSwitch ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vsw-bp1i0xezblf1yrz4xxxxx</para>
                    /// </summary>
                    [NameInMap("VSwitchId")]
                    [Validation(Required=false)]
                    public string VSwitchId { get; set; }

                    /// <summary>
                    /// <para>VPC ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vpc-2zexy5nae9q2otaxxxx</para>
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
                /// <para>Whether to enable tracing.</para>
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
                /// <item><description>0: No</description></item>
                /// <item><description>1: Yes</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("MonitorSamples")]
                [Validation(Required=false)]
                public int? MonitorSamples { get; set; }

                /// <summary>
                /// <para>Tracing client type:</para>
                /// <list type="bullet">
                /// <item><description>0: ARMS Agent</description></item>
                /// <item><description>1: Open Telemetry</description></item>
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
                /// <para>Tracing data reporting region.</para>
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
            public GetTimingSyntheticTaskResponseBodyDataCustomPeriod CustomPeriod { get; set; }
            public class GetTimingSyntheticTaskResponseBodyDataCustomPeriod : TeaModel {
                /// <summary>
                /// <para>The hour at which the test ends. Valid values: 0 to 24.</para>
                /// 
                /// <b>Example:</b>
                /// <para>22</para>
                /// </summary>
                [NameInMap("EndHour")]
                [Validation(Required=false)]
                public long? EndHour { get; set; }

                /// <summary>
                /// <para>The hour at which the test starts. Valid values: 0 to 24.</para>
                /// 
                /// <b>Example:</b>
                /// <para>14</para>
                /// </summary>
                [NameInMap("StartHour")]
                [Validation(Required=false)]
                public long? StartHour { get; set; }

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
            /// <para>The detection point type. 1: PC. 2: mobile device.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MonitorCategory")]
            [Validation(Required=false)]
            public long? MonitorCategory { get; set; }

            /// <summary>
            /// <para>The monitoring configurations.</para>
            /// </summary>
            [NameInMap("MonitorConf")]
            [Validation(Required=false)]
            public GetTimingSyntheticTaskResponseBodyDataMonitorConf MonitorConf { get; set; }
            public class GetTimingSyntheticTaskResponseBodyDataMonitorConf : TeaModel {
                /// <summary>
                /// <para>The parameters of the HTTP(S) synthetic test.</para>
                /// </summary>
                [NameInMap("ApiHTTP")]
                [Validation(Required=false)]
                public GetTimingSyntheticTaskResponseBodyDataMonitorConfApiHTTP ApiHTTP { get; set; }
                public class GetTimingSyntheticTaskResponseBodyDataMonitorConfApiHTTP : TeaModel {
                    /// <summary>
                    /// <para>Whether to verify the certificate. The default is no.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
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
                    /// <para>The request method.</para>
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
                    /// <para>1: HTTP/1.1</para>
                    /// <para>2: HTTP/2</para>
                    /// <para>3: disables the ALPN protocol</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("ProtocolAlpnProtocol")]
                    [Validation(Required=false)]
                    public int? ProtocolAlpnProtocol { get; set; }

                    /// <summary>
                    /// <para>The HTTP request body.</para>
                    /// </summary>
                    [NameInMap("RequestBody")]
                    [Validation(Required=false)]
                    public GetTimingSyntheticTaskResponseBodyDataMonitorConfApiHTTPRequestBody RequestBody { get; set; }
                    public class GetTimingSyntheticTaskResponseBodyDataMonitorConfApiHTTPRequestBody : TeaModel {
                        /// <summary>
                        /// <para>The content of the request body. Format: JSON string. The parameter is required if the type parameter is set to text/plain, application/json, application/xml, or text/html. Format: JSON string.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>text/plain</para>
                        /// </summary>
                        [NameInMap("Content")]
                        [Validation(Required=false)]
                        public string Content { get; set; }

                        /// <summary>
                        /// <para>The type of the request body. Valid values: text/plain, application/json, application/x-www-form-urlencoded, multipart/form-data, application/xml, and text/html.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>multipart/form-data</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                    /// <summary>
                    /// <para>The HTTP request header.</para>
                    /// </summary>
                    [NameInMap("RequestHeaders")]
                    [Validation(Required=false)]
                    public Dictionary<string, string> RequestHeaders { get; set; }

                    /// <summary>
                    /// <para>The URL for synthetic monitoring.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="http://127.0.0.1:8090/api/list">http://127.0.0.1:8090/api/list</a></para>
                    /// </summary>
                    [NameInMap("TargetUrl")]
                    [Validation(Required=false)]
                    public string TargetUrl { get; set; }

                    /// <summary>
                    /// <para>The timeout period. Unit: milliseconds. Default value: 10000. Minimum value: 1000. Maximum value: 300000.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10000</para>
                    /// </summary>
                    [NameInMap("Timeout")]
                    [Validation(Required=false)]
                    public long? Timeout { get; set; }

                }

                /// <summary>
                /// <para>The file download parameters.</para>
                /// </summary>
                [NameInMap("FileDownload")]
                [Validation(Required=false)]
                public GetTimingSyntheticTaskResponseBodyDataMonitorConfFileDownload FileDownload { get; set; }
                public class GetTimingSyntheticTaskResponseBodyDataMonitorConfFileDownload : TeaModel {
                    /// <summary>
                    /// <para>The connection timeout period. Unit: milliseconds. Minimum value: 1000. Maximum value: 120000. Default value: 5000.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5000</para>
                    /// </summary>
                    [NameInMap("ConnectionTimeout")]
                    [Validation(Required=false)]
                    public long? ConnectionTimeout { get; set; }

                    /// <summary>
                    /// <para>The content of the custom request header.</para>
                    /// </summary>
                    [NameInMap("CustomHeaderContent")]
                    [Validation(Required=false)]
                    public Dictionary<string, string> CustomHeaderContent { get; set; }

                    /// <summary>
                    /// <para>The kernel type.</para>
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
                    public long? DownloadKernel { get; set; }

                    /// <summary>
                    /// <para>Specifies whether to ignore CA certificate authentication errors. 0: No. 1: Yes. Default value: 1.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("IgnoreCertificateAuthError")]
                    [Validation(Required=false)]
                    public int? IgnoreCertificateAuthError { get; set; }

                    /// <summary>
                    /// <para>Specifies whether to ignore certificate revocation errors. 0: No. 1: Yes. Default value: 1.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("IgnoreCertificateCanceledError")]
                    [Validation(Required=false)]
                    public int? IgnoreCertificateCanceledError { get; set; }

                    /// <summary>
                    /// <para>Specifies whether to ignore certificate invalidity. 0: No. 1: Yes. Default value: 1.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("IgnoreCertificateOutOfDateError")]
                    [Validation(Required=false)]
                    public int? IgnoreCertificateOutOfDateError { get; set; }

                    /// <summary>
                    /// <para>Specifies whether to ignore certificate status errors. 0: No. 1: Yes. Default value: 1.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("IgnoreCertificateStatusError")]
                    [Validation(Required=false)]
                    public int? IgnoreCertificateStatusError { get; set; }

                    /// <summary>
                    /// <para>Specifies whether to ignore certificate incredibility. 0: No. 1: Yes. Default value: 1.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("IgnoreCertificateUntrustworthyError")]
                    [Validation(Required=false)]
                    public int? IgnoreCertificateUntrustworthyError { get; set; }

                    /// <summary>
                    /// <para>Specifies whether to ignore certificate usage errors. 0: No. 1: Yes. Default value: 1.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("IgnoreCertificateUsingError")]
                    [Validation(Required=false)]
                    public int? IgnoreCertificateUsingError { get; set; }

                    /// <summary>
                    /// <para>Specifies whether to ignore host invalidity. 0: No. 1: Yes. Default value: 1.</para>
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
                    /// <para>6000</para>
                    /// </summary>
                    [NameInMap("MonitorTimeout")]
                    [Validation(Required=false)]
                    public long? MonitorTimeout { get; set; }

                    /// <summary>
                    /// <para>The QUIC protocol type.</para>
                    /// <list type="bullet">
                    /// <item><description>1: http1</description></item>
                    /// <item><description>2: http2</description></item>
                    /// <item><description>3: http3</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("QuickProtocol")]
                    [Validation(Required=false)]
                    public long? QuickProtocol { get; set; }

                    /// <summary>
                    /// <para>Specifies whether to support redirection. 0: No. 1: Yes. Default value: 1.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Redirection")]
                    [Validation(Required=false)]
                    public int? Redirection { get; set; }

                    /// <summary>
                    /// <para>The file download URL.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>https://********</para>
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
                    /// <para>Verify keywords.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>success</para>
                    /// </summary>
                    [NameInMap("ValidateKeywords")]
                    [Validation(Required=false)]
                    public string ValidateKeywords { get; set; }

                    /// <summary>
                    /// <para>Verification method.</para>
                    /// <list type="bullet">
                    /// <item><description>0: No verification</description></item>
                    /// <item><description>1: Verification string</description></item>
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
                    /// <para>DNS hijacking whitelist. Matching rules support IP, IP wildcard, subnet mask and CNAME. You can fill in multiple matching rules, and multiple matching rules are separated by vertical bars (|). For example: <c>www.aliyun.com:203.0.3.55|203.3.44.67</c>, which means that all IPs except 203.0.3.55 and 203.3.44.67 under the <a href="http://www.aliyun.com">www.aliyun.com</a> domain name are hijacked.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="http://www.aliyun.com:203.0.3.55%7C203.3.44.67">www.aliyun.com:203.0.3.55|203.3.44.67</a></para>
                    /// </summary>
                    [NameInMap("WhiteList")]
                    [Validation(Required=false)]
                    public string WhiteList { get; set; }

                }

                /// <summary>
                /// <para>The DNS synthetic test parameters. This parameter is required if the TaskType parameter is set to 3.</para>
                /// </summary>
                [NameInMap("NetDNS")]
                [Validation(Required=false)]
                public GetTimingSyntheticTaskResponseBodyDataMonitorConfNetDNS NetDNS { get; set; }
                public class GetTimingSyntheticTaskResponseBodyDataMonitorConfNetDNS : TeaModel {
                    /// <summary>
                    /// <para>The IP version of the DNS server. 0: IPv4. 1: IPv6. 2: A version is automatically selected. Default value: 0.</para>
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
                    /// <para>The DNS query. 0: recursive, 1: iterative. Default value: 0.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("QueryMethod")]
                    [Validation(Required=false)]
                    public int? QueryMethod { get; set; }

                    /// <summary>
                    /// <para>The destination domain name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="http://www.aliyun.com">www.aliyun.com</a></para>
                    /// </summary>
                    [NameInMap("TargetUrl")]
                    [Validation(Required=false)]
                    public string TargetUrl { get; set; }

                    /// <summary>
                    /// <para>The timeout period for the DNS synthetic test. Unit: milliseconds. The minimum value is 1000 and the maximum value is 45000. Default value: 5000.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5000</para>
                    /// </summary>
                    [NameInMap("Timeout")]
                    [Validation(Required=false)]
                    public long? Timeout { get; set; }

                }

                /// <summary>
                /// <para>The ICMP synthetic test parameters. This parameter is required if the TaskType parameter is set to 1.</para>
                /// </summary>
                [NameInMap("NetICMP")]
                [Validation(Required=false)]
                public GetTimingSyntheticTaskResponseBodyDataMonitorConfNetICMP NetICMP { get; set; }
                public class GetTimingSyntheticTaskResponseBodyDataMonitorConfNetICMP : TeaModel {
                    /// <summary>
                    /// <para>The interval at which ICMP packets are sent. Unit: milliseconds. Minimum value: 200. Maximum value: 2000. Default value: 200.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>200</para>
                    /// </summary>
                    [NameInMap("Interval")]
                    [Validation(Required=false)]
                    public int? Interval { get; set; }

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
                    /// <para>The size of each ICMP packet. Unit: bytes. Valid values: 32, 64, 128, 256, 512, 1024.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1024</para>
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
                    /// <para>The destination host IP address or domain name</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="http://www.aliyun.com">www.aliyun.com</a></para>
                    /// </summary>
                    [NameInMap("TargetUrl")]
                    [Validation(Required=false)]
                    public string TargetUrl { get; set; }

                    /// <summary>
                    /// <para>The timeout period for the TCP synthetic test. Unit: milliseconds. Minimum value: 1000. Maximum value: 300000. Default value: 20000.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2000</para>
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
                    /// <para>The maximum number of hops for tracert. Minimum value: 1. Maximum value: 128. Default value: 64.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>64</para>
                    /// </summary>
                    [NameInMap("TracertNumMax")]
                    [Validation(Required=false)]
                    public int? TracertNumMax { get; set; }

                    /// <summary>
                    /// <para>The timeout period of tracert. Unit: milliseconds. Minimum value: 1000. Maximum value: 300000. Default value: 60000.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>60000</para>
                    /// </summary>
                    [NameInMap("TracertTimeout")]
                    [Validation(Required=false)]
                    public long? TracertTimeout { get; set; }

                }

                /// <summary>
                /// <para>The TCP synthetic tests parameters. This parameter is required if the TaskType parameter is set to 2.</para>
                /// </summary>
                [NameInMap("NetTCP")]
                [Validation(Required=false)]
                public GetTimingSyntheticTaskResponseBodyDataMonitorConfNetTCP NetTCP { get; set; }
                public class GetTimingSyntheticTaskResponseBodyDataMonitorConfNetTCP : TeaModel {
                    /// <summary>
                    /// <para>The number of TCP connections that are established in a test. Minimum value: 1. Maximum value: 16. Default value: 4.</para>
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
                    /// <para>200</para>
                    /// </summary>
                    [NameInMap("Interval")]
                    [Validation(Required=false)]
                    public long? Interval { get; set; }

                    /// <summary>
                    /// <para>The destination host IP address.</para>
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
                    /// <para>20000</para>
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
                    /// <para>The maximum number of hops for tracert. Minimum value: 1. Maximum value: 128. Default value: 20.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20</para>
                    /// </summary>
                    [NameInMap("TracertNumMax")]
                    [Validation(Required=false)]
                    public int? TracertNumMax { get; set; }

                    /// <summary>
                    /// <para>The timeout period of tracert. Unit: milliseconds. Minimum value: 1000. Maximum value: 300000. Default value: 60000.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>60000</para>
                    /// </summary>
                    [NameInMap("TracertTimeout")]
                    [Validation(Required=false)]
                    public long? TracertTimeout { get; set; }

                }

                /// <summary>
                /// <para>Streaming media dial test configuration.</para>
                /// </summary>
                [NameInMap("Stream")]
                [Validation(Required=false)]
                public GetTimingSyntheticTaskResponseBodyDataMonitorConfStream Stream { get; set; }
                public class GetTimingSyntheticTaskResponseBodyDataMonitorConfStream : TeaModel {
                    /// <summary>
                    /// <para>Custom header, JSON Map format.</para>
                    /// </summary>
                    [NameInMap("CustomHeaderContent")]
                    [Validation(Required=false)]
                    public Dictionary<string, string> CustomHeaderContent { get; set; }

                    /// <summary>
                    /// <para>Player, default is 12 if not specified.</para>
                    /// <list type="bullet">
                    /// <item><description>12: VLC</description></item>
                    /// <item><description>2: Flash Player</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>12</para>
                    /// </summary>
                    [NameInMap("PlayerType")]
                    [Validation(Required=false)]
                    public int? PlayerType { get; set; }

                    /// <summary>
                    /// <para>Resource address type:</para>
                    /// <list type="bullet">
                    /// <item><description>1: Resource address.</description></item>
                    /// <item><description>0: Page address. If not passed, the default value is 0.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("StreamAddressType")]
                    [Validation(Required=false)]
                    public int? StreamAddressType { get; set; }

                    /// <summary>
                    /// <para>Monitoring duration, in seconds, supports up to 60 seconds. If not specified, the default value is 60 seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>30</para>
                    /// </summary>
                    [NameInMap("StreamMonitorTimeout")]
                    [Validation(Required=false)]
                    public int? StreamMonitorTimeout { get; set; }

                    /// <summary>
                    /// <para>Audio and video flag:</para>
                    /// <list type="bullet">
                    /// <item><description>0: video</description></item>
                    /// <item><description>1: audio</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("StreamType")]
                    [Validation(Required=false)]
                    public int? StreamType { get; set; }

                    /// <summary>
                    /// <para>Streaming media resource address.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="http://www.aliyun.com/stream/test.mp4">http://www.aliyun.com/stream/test.mp4</a></para>
                    /// </summary>
                    [NameInMap("TargetUrl")]
                    [Validation(Required=false)]
                    public string TargetUrl { get; set; }

                    /// <summary>
                    /// <para>DNS hijacking whitelist. Matching rules support IP, IP wildcard, subnet mask and CNAME. You can fill in multiple matching rules, and multiple matching rules are separated by vertical bars (|). For example: <c>www.aliyun.com:203.0.3.55|203.3.44.67</c>, which means that all IPs except 203.0.3.55 and 203.3.44.67 under the <a href="http://www.aliyun.com">www.aliyun.com</a> domain name are hijacked.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="http://www.aliyun.com:203.0.3.55%7C203.3.44.67">www.aliyun.com:203.0.3.55|203.3.44.67</a></para>
                    /// </summary>
                    [NameInMap("WhiteList")]
                    [Validation(Required=false)]
                    public string WhiteList { get; set; }

                }

                /// <summary>
                /// <para>The website-speed measurement parameters.</para>
                /// </summary>
                [NameInMap("Website")]
                [Validation(Required=false)]
                public GetTimingSyntheticTaskResponseBodyDataMonitorConfWebsite Website { get; set; }
                public class GetTimingSyntheticTaskResponseBodyDataMonitorConfWebsite : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether to automatically scroll up and down the screen to load a page. 0: No. 1: Yes. Default value: 0.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("AutomaticScrolling")]
                    [Validation(Required=false)]
                    public int? AutomaticScrolling { get; set; }

                    /// <summary>
                    /// <para>Specifies whether to create a custom header. 0: No. 1: The first packet is modified. 2: All packets are modified. Default value: 0.</para>
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
                    /// <para>When resolving a domain name (such as <a href="http://www.aliyun.com">www.aliyun.com</a>), if the resolved IP address or CNAME is not in the DNS hijacking whitelist, the user will fail to access or return a non-Aliyun target IP; if the IP or CNAME in the resolution result is in the DNS whitelist, it will be deemed that no DNS hijacking has occurred.</para>
                    /// <para>Fill in the format: <c>domain name: matching rule</c>. Matching rules support IP, IP wildcard, subnet mask and CNAME. You can fill in multiple matching rules, and multiple matching rules are separated by vertical bars (|). </para>
                    /// <para>For example: <c>www.aliyun.com:203.0.3.55|203.3.44.67</c>, which means that all IPs except 203.0.3.55 and 203.3.44.67 under the <a href="http://www.aliyun.com">www.aliyun.com</a> domain name are hijacked.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="http://www.aliyun.com:203.0.3.55%7C203.3.44.67">www.aliyun.com:203.0.3.55|203.3.44.67</a></para>
                    /// </summary>
                    [NameInMap("DNSHijackWhitelist")]
                    [Validation(Required=false)]
                    public string DNSHijackWhitelist { get; set; }

                    /// <summary>
                    /// <para>Specifies whether to disable the cache. 0: No. 1: Yes. Default value: 1.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("DisableCache")]
                    [Validation(Required=false)]
                    public int? DisableCache { get; set; }

                    /// <summary>
                    /// <para>Specifies whether to accept compressed files based on the HTTP Accept-Encoding request header. 0: No. 1: Yes. Default value: 0.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("DisableCompression")]
                    [Validation(Required=false)]
                    public int? DisableCompression { get; set; }

                    /// <summary>
                    /// <para>If an element configured in the element blacklist appears during page loading, no request will be made to load the element.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="http://www.example.com/a.jpg">www.example.com/a.jpg</a></para>
                    /// </summary>
                    [NameInMap("ElementBlacklist")]
                    [Validation(Required=false)]
                    public string ElementBlacklist { get; set; }

                    /// <summary>
                    /// <para>Specifies whether to exclude invalid IP addresses.</para>
                    /// <list type="bullet">
                    /// <item><description>1: No</description></item>
                    /// <item><description>0: Yes</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("FilterInvalidIP")]
                    [Validation(Required=false)]
                    public int? FilterInvalidIP { get; set; }

                    /// <summary>
                    /// <para>Identify elements: Set the total number of elements to browse the page.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("FlowHijackJumpTimes")]
                    [Validation(Required=false)]
                    public int? FlowHijackJumpTimes { get; set; }

                    /// <summary>
                    /// <para>Hijacking flag: Set the key information for matching. Fill in the hijacking judgment keyword or key element, and asterisks (*) are allowed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>aliyun</para>
                    /// </summary>
                    [NameInMap("FlowHijackLogo")]
                    [Validation(Required=false)]
                    public string FlowHijackLogo { get; set; }

                    /// <summary>
                    /// <para>Specifies whether to ignore SSL certificate errors during browsing. 0: No. 1: Yes. Default value: 1.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("IgnoreCertificateError")]
                    [Validation(Required=false)]
                    public int? IgnoreCertificateError { get; set; }

                    /// <summary>
                    /// <para>The monitoring timeout period. Unit: milliseconds. Default value: 20000. Minimum value: 5000. Maximum value: 300000.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20000</para>
                    /// </summary>
                    [NameInMap("MonitorTimeout")]
                    [Validation(Required=false)]
                    public int? MonitorTimeout { get; set; }

                    /// <summary>
                    /// <para>If any element other than the domain name setting appears on the monitoring page, it means that the page has been tampered. Common manifestations include pop-up ads, floating ads, jumps, etc.</para>
                    /// <para>Fill in the format: <c>domain name: element</c>. Elements support wildcards, and multiple elements can be filled in. Multiple elements are separated by vertical bars (|). For example: <c>www.aliyun.com:|/cc/bb/a.gif|/vv/bb/cc.jpg</c>, which means that all elements except the basic document, /cc/bb/a.gif and /vv/bb/cc.jpg under the <a href="http://www.aliyun.com">www.aliyun.com</a> domain name are considered to be tampered with.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="http://www.aliyun.com:%7C/cc/bb/a.gif%7C/vv/bb/cc.jpg">www.aliyun.com:|/cc/bb/a.gif|/vv/bb/cc.jpg</a></para>
                    /// </summary>
                    [NameInMap("PageTamper")]
                    [Validation(Required=false)]
                    public string PageTamper { get; set; }

                    /// <summary>
                    /// <para>Specifies whether to continue browsing after redirection. 0: No, 1:Yes. Default value: 1.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
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
                    /// <para>The destination URL.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="http://www.aliyun.com">http://www.aliyun.com</a></para>
                    /// </summary>
                    [NameInMap("TargetUrl")]
                    [Validation(Required=false)]
                    public string TargetUrl { get; set; }

                    /// <summary>
                    /// <para>The verification string is an arbitrary string in the source code of the monitoring page. If the source code returned by the client contains any string in the blacklist, an error 650 &quot;Verification string failed&quot; will be reported. Multiple strings are separated by vertical bars (|).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>error</para>
                    /// </summary>
                    [NameInMap("VerifyStringBlacklist")]
                    [Validation(Required=false)]
                    public string VerifyStringBlacklist { get; set; }

                    /// <summary>
                    /// <para>The verification string is an arbitrary string in the source code of the monitoring page. The source code returned by the client must contain all the strings in the whitelist, otherwise an error 650 &quot;Verification string failed&quot; will be reported. Multiple strings are separated by a vertical bar (|).</para>
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
            public List<GetTimingSyntheticTaskResponseBodyDataMonitors> Monitors { get; set; }
            public class GetTimingSyntheticTaskResponseBodyDataMonitors : TeaModel {
                /// <summary>
                /// <para>The city code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>110100</para>
                /// </summary>
                [NameInMap("CityCode")]
                [Validation(Required=false)]
                public string CityCode { get; set; }

                /// <summary>
                /// <para>The client type of the monitoring point. Valid values: 1: data center. 2: Internet. 3: mobile device. 4: ECS instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
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
            /// <para>The ID of the resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>CREATING: The task is being created. RUNNING: The task is running. PARTIAL_RUNNING: The task is partially running. STOP: The task is stopped. LIMIT_STOP: The task is stopped due to quota insufficiency. EXCEPTION: The task is abnormal. DELETE: The task is deleted. DELETE_EXCEPTION: The task failed to be deleted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The tag.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<GetTimingSyntheticTaskResponseBodyDataTags> Tags { get; set; }
            public class GetTimingSyntheticTaskResponseBodyDataTags : TeaModel {
                /// <summary>
                /// <para>The key of the tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>user1</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The value of the tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>myweb</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The ID of the synthetic monitoring task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5308a2691f59422c8c3b7aeccec9cd3b</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The type of the task. Valid values:</para>
            /// <para>ICMP TCP DNS HTTP Website speed measurement File download</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public int? TaskType { get; set; }

        }

        /// <summary>
        /// <para>The message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E13430A6-57A9-56E9-9D8D-28FE8DEBCA40</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
