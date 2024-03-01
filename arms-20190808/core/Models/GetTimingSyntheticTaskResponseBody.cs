// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GetTimingSyntheticTaskResponseBody : TeaModel {
        /// <summary>
        /// The status code returned. The status code 200 indicates that the request was successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        /// <summary>
        /// The struct returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetTimingSyntheticTaskResponseBodyData Data { get; set; }
        public class GetTimingSyntheticTaskResponseBodyData : TeaModel {
            /// <summary>
            /// The list of assertions.
            /// </summary>
            [NameInMap("AvailableAssertions")]
            [Validation(Required=false)]
            public List<GetTimingSyntheticTaskResponseBodyDataAvailableAssertions> AvailableAssertions { get; set; }
            public class GetTimingSyntheticTaskResponseBodyDataAvailableAssertions : TeaModel {
                /// <summary>
                /// The expected value.
                /// </summary>
                [NameInMap("Expect")]
                [Validation(Required=false)]
                public string Expect { get; set; }

                /// <summary>
                /// The condition. gt: greater than. gte: greater than or equal to. lt: less than. lte: less than or equal to. eq: equal to. neq: not equal to. ctn: contain. nctn: does not contain. exist: exist. n_exist: does not exist. belong: belong to. n_belong: does not belong to. reg_match: regular expression.
                /// </summary>
                [NameInMap("Operator")]
                [Validation(Required=false)]
                public string Operator { get; set; }

                /// <summary>
                /// The check target. If you set the type parameter to HttpResCode, HttpResBody, or HttpResponseTime, you do not need to set the target parameter. If you set the type parameter to HttpResHead, you must specify the key in the header. If you set the type parameter to HttpResBodyJson, use jsonPath.
                /// </summary>
                [NameInMap("Target")]
                [Validation(Required=false)]
                public string Target { get; set; }

                /// <summary>
                /// The assertion type. Valid values: HttpResCode, HttpResHead, HttpResBody, HttpResBodyJson, HttpResponseTime, IcmpPackLoss (packet loss rate), IcmpPackMaxLatency (maximum packet latency), IcmpPackAvgLatency (average packet latency), TraceRouteHops (number of hops), DnsARecord (A record), DnsCName (CNAME), websiteTTFB (time to first packet), websiteTTLB (time to last packet), websiteFST (first paint time), websiteFFST (first meaningful paint), websiteOnload (full loaded time). For more information, see the following description.
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// The general settings.
            /// </summary>
            [NameInMap("CommonSetting")]
            [Validation(Required=false)]
            public GetTimingSyntheticTaskResponseBodyDataCommonSetting CommonSetting { get; set; }
            public class GetTimingSyntheticTaskResponseBodyDataCommonSetting : TeaModel {
                /// <summary>
                /// The custom host.
                /// </summary>
                [NameInMap("CustomHost")]
                [Validation(Required=false)]
                public GetTimingSyntheticTaskResponseBodyDataCommonSettingCustomHost CustomHost { get; set; }
                public class GetTimingSyntheticTaskResponseBodyDataCommonSettingCustomHost : TeaModel {
                    /// <summary>
                    /// The list of hosts.
                    /// </summary>
                    [NameInMap("Hosts")]
                    [Validation(Required=false)]
                    public List<GetTimingSyntheticTaskResponseBodyDataCommonSettingCustomHostHosts> Hosts { get; set; }
                    public class GetTimingSyntheticTaskResponseBodyDataCommonSettingCustomHostHosts : TeaModel {
                        /// <summary>
                        /// The domain name.
                        /// </summary>
                        [NameInMap("Domain")]
                        [Validation(Required=false)]
                        public string Domain { get; set; }

                        /// <summary>
                        /// The IP version. Valid values:
                        /// 
                        /// *   0: A version is automatically selected.
                        /// *   1: IPv4
                        /// *   2: IPv6
                        /// </summary>
                        [NameInMap("IpType")]
                        [Validation(Required=false)]
                        public int? IpType { get; set; }

                        /// <summary>
                        /// The list of IP addresses.
                        /// </summary>
                        [NameInMap("Ips")]
                        [Validation(Required=false)]
                        public List<string> Ips { get; set; }

                    }

                    /// <summary>
                    /// The selection mode. 0: Random. 1: Polling.
                    /// </summary>
                    [NameInMap("SelectType")]
                    [Validation(Required=false)]
                    public int? SelectType { get; set; }

                }

                [NameInMap("CustomVPCSetting")]
                [Validation(Required=false)]
                public GetTimingSyntheticTaskResponseBodyDataCommonSettingCustomVPCSetting CustomVPCSetting { get; set; }
                public class GetTimingSyntheticTaskResponseBodyDataCommonSettingCustomVPCSetting : TeaModel {
                    [NameInMap("RegionId")]
                    [Validation(Required=false)]
                    public string RegionId { get; set; }

                    [NameInMap("SecureGroupId")]
                    [Validation(Required=false)]
                    public string SecureGroupId { get; set; }

                    [NameInMap("VSwitchId")]
                    [Validation(Required=false)]
                    public string VSwitchId { get; set; }

                    [NameInMap("VpcId")]
                    [Validation(Required=false)]
                    public string VpcId { get; set; }

                }

                /// <summary>
                /// The IP version. Valid values:
                /// 
                /// *   0: A version is automatically selected.
                /// *   1: IPv4
                /// *   2: IPv6
                /// </summary>
                [NameInMap("IpType")]
                [Validation(Required=false)]
                public int? IpType { get; set; }

                /// <summary>
                /// 是否开启链路追踪。
                /// </summary>
                [NameInMap("IsOpenTrace")]
                [Validation(Required=false)]
                public bool? IsOpenTrace { get; set; }

                /// <summary>
                /// Specifies whether to evenly distribute monitoring samples. Valid values:
                /// 
                /// *   0: No
                /// *   1: Yes
                /// </summary>
                [NameInMap("MonitorSamples")]
                [Validation(Required=false)]
                public int? MonitorSamples { get; set; }

                /// <summary>
                /// 链路追踪客户端类型：
                /// 
                /// - 0：ARMS Agent
                /// - 1：OpenTelemetry
                /// - 2：Jaeger
                /// </summary>
                [NameInMap("TraceClientType")]
                [Validation(Required=false)]
                public int? TraceClientType { get; set; }

                /// <summary>
                /// 链路数据上报region。
                /// </summary>
                [NameInMap("XtraceRegion")]
                [Validation(Required=false)]
                public string XtraceRegion { get; set; }

            }

            /// <summary>
            /// The custom cycle.
            /// </summary>
            [NameInMap("CustomPeriod")]
            [Validation(Required=false)]
            public GetTimingSyntheticTaskResponseBodyDataCustomPeriod CustomPeriod { get; set; }
            public class GetTimingSyntheticTaskResponseBodyDataCustomPeriod : TeaModel {
                /// <summary>
                /// The hour at which the test ends. Valid values: 0 to 24.
                /// </summary>
                [NameInMap("EndHour")]
                [Validation(Required=false)]
                public long? EndHour { get; set; }

                /// <summary>
                /// The hour at which the test starts. Valid values: 0 to 24.
                /// </summary>
                [NameInMap("StartHour")]
                [Validation(Required=false)]
                public long? StartHour { get; set; }

            }

            /// <summary>
            /// The detection frequency. Valid values: 1m, 5m, 10m, 15m, 20m, 30m, 1h, 2h, 3h, 4h, 6h, 8h, 12h, and 24h.
            /// </summary>
            [NameInMap("Frequency")]
            [Validation(Required=false)]
            public string Frequency { get; set; }

            /// <summary>
            /// The detection point type. 1: PC. 2: mobile device.
            /// </summary>
            [NameInMap("MonitorCategory")]
            [Validation(Required=false)]
            public long? MonitorCategory { get; set; }

            /// <summary>
            /// The monitoring configurations.
            /// </summary>
            [NameInMap("MonitorConf")]
            [Validation(Required=false)]
            public GetTimingSyntheticTaskResponseBodyDataMonitorConf MonitorConf { get; set; }
            public class GetTimingSyntheticTaskResponseBodyDataMonitorConf : TeaModel {
                /// <summary>
                /// The HTTP(S) synthetic test parameters.
                /// </summary>
                [NameInMap("ApiHTTP")]
                [Validation(Required=false)]
                public GetTimingSyntheticTaskResponseBodyDataMonitorConfApiHTTP ApiHTTP { get; set; }
                public class GetTimingSyntheticTaskResponseBodyDataMonitorConfApiHTTP : TeaModel {
                    [NameInMap("CheckCert")]
                    [Validation(Required=false)]
                    public bool? CheckCert { get; set; }

                    /// <summary>
                    /// The connection timeout period. Unit: milliseconds. Default value: 5000. Minimum value: 1000. Maximum value: 300000.
                    /// </summary>
                    [NameInMap("ConnectTimeout")]
                    [Validation(Required=false)]
                    public long? ConnectTimeout { get; set; }

                    /// <summary>
                    /// The request method.
                    /// 
                    /// *   POST
                    /// *   GET
                    /// </summary>
                    [NameInMap("Method")]
                    [Validation(Required=false)]
                    public string Method { get; set; }

                    /// <summary>
                    /// The HTTP request body.
                    /// </summary>
                    [NameInMap("RequestBody")]
                    [Validation(Required=false)]
                    public GetTimingSyntheticTaskResponseBodyDataMonitorConfApiHTTPRequestBody RequestBody { get; set; }
                    public class GetTimingSyntheticTaskResponseBodyDataMonitorConfApiHTTPRequestBody : TeaModel {
                        /// <summary>
                        /// The content of the request body. Format: JSON string. The parameter is required if the type parameter is set to text/plain, application/json, application/xml, or text/html. Format: JSON string.
                        /// </summary>
                        [NameInMap("Content")]
                        [Validation(Required=false)]
                        public string Content { get; set; }

                        /// <summary>
                        /// The type of the request body. Valid values: text/plain, application/json, application/x-www-form-urlencoded, multipart/form-data, application/xml, and text/html.
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                    /// <summary>
                    /// The HTTP request header.
                    /// </summary>
                    [NameInMap("RequestHeaders")]
                    [Validation(Required=false)]
                    public Dictionary<string, string> RequestHeaders { get; set; }

                    /// <summary>
                    /// The URL for synthetic monitoring.
                    /// </summary>
                    [NameInMap("TargetUrl")]
                    [Validation(Required=false)]
                    public string TargetUrl { get; set; }

                    /// <summary>
                    /// The timeout period. Unit: milliseconds. Default value: 10000. Minimum value: 1000. Maximum value: 300000.
                    /// </summary>
                    [NameInMap("Timeout")]
                    [Validation(Required=false)]
                    public long? Timeout { get; set; }

                }

                /// <summary>
                /// The file download parameters.
                /// </summary>
                [NameInMap("FileDownload")]
                [Validation(Required=false)]
                public GetTimingSyntheticTaskResponseBodyDataMonitorConfFileDownload FileDownload { get; set; }
                public class GetTimingSyntheticTaskResponseBodyDataMonitorConfFileDownload : TeaModel {
                    /// <summary>
                    /// The connection timeout period. Unit: milliseconds. Minimum value: 1000. Maximum value: 120000. Default value: 5000.
                    /// </summary>
                    [NameInMap("ConnectionTimeout")]
                    [Validation(Required=false)]
                    public long? ConnectionTimeout { get; set; }

                    /// <summary>
                    /// The content of the custom request header.
                    /// </summary>
                    [NameInMap("CustomHeaderContent")]
                    [Validation(Required=false)]
                    public Dictionary<string, string> CustomHeaderContent { get; set; }

                    /// <summary>
                    /// The kernel type.
                    /// 
                    /// *   1: curl
                    /// *   0: WinInet
                    /// </summary>
                    [NameInMap("DownloadKernel")]
                    [Validation(Required=false)]
                    public long? DownloadKernel { get; set; }

                    /// <summary>
                    /// Specifies whether to ignore CA certificate authentication errors. 0: No. 1: Yes. Default value: 1.
                    /// </summary>
                    [NameInMap("IgnoreCertificateAuthError")]
                    [Validation(Required=false)]
                    public int? IgnoreCertificateAuthError { get; set; }

                    /// <summary>
                    /// Specifies whether to ignore certificate revocation errors. 0: No. 1: Yes. Default value: 1.
                    /// </summary>
                    [NameInMap("IgnoreCertificateCanceledError")]
                    [Validation(Required=false)]
                    public int? IgnoreCertificateCanceledError { get; set; }

                    /// <summary>
                    /// Specifies whether to ignore certificate invalidity. 0: No. 1: Yes. Default value: 1.
                    /// </summary>
                    [NameInMap("IgnoreCertificateOutOfDateError")]
                    [Validation(Required=false)]
                    public int? IgnoreCertificateOutOfDateError { get; set; }

                    /// <summary>
                    /// Specifies whether to ignore certificate status errors. 0: No. 1: Yes. Default value: 1.
                    /// </summary>
                    [NameInMap("IgnoreCertificateStatusError")]
                    [Validation(Required=false)]
                    public int? IgnoreCertificateStatusError { get; set; }

                    /// <summary>
                    /// Specifies whether to ignore certificate incredibility. 0: No. 1: Yes. Default value: 1.
                    /// </summary>
                    [NameInMap("IgnoreCertificateUntrustworthyError")]
                    [Validation(Required=false)]
                    public int? IgnoreCertificateUntrustworthyError { get; set; }

                    /// <summary>
                    /// Specifies whether to ignore certificate usage errors. 0: No. 1: Yes. Default value: 1.
                    /// </summary>
                    [NameInMap("IgnoreCertificateUsingError")]
                    [Validation(Required=false)]
                    public int? IgnoreCertificateUsingError { get; set; }

                    /// <summary>
                    /// Specifies whether to ignore host invalidity. 0: No. 1: Yes. Default value: 1.
                    /// </summary>
                    [NameInMap("IgnoreInvalidHostError")]
                    [Validation(Required=false)]
                    public int? IgnoreInvalidHostError { get; set; }

                    /// <summary>
                    /// The monitoring timeout period. Unit: milliseconds. Minimum value: 1000. Maximum value: 120000. Default value: 60000.
                    /// </summary>
                    [NameInMap("MonitorTimeout")]
                    [Validation(Required=false)]
                    public long? MonitorTimeout { get; set; }

                    /// <summary>
                    /// The QUIC protocol type.
                    /// 
                    /// *   1: http1
                    /// *   2: http2
                    /// *   3: http3
                    /// </summary>
                    [NameInMap("QuickProtocol")]
                    [Validation(Required=false)]
                    public long? QuickProtocol { get; set; }

                    /// <summary>
                    /// Specifies whether to support redirection. 0: No. 1: Yes. Default value: 1.
                    /// </summary>
                    [NameInMap("Redirection")]
                    [Validation(Required=false)]
                    public int? Redirection { get; set; }

                    /// <summary>
                    /// The file download URL.
                    /// </summary>
                    [NameInMap("TargetUrl")]
                    [Validation(Required=false)]
                    public string TargetUrl { get; set; }

                    /// <summary>
                    /// The maximum file size of a single transfer. Unit: KB. Minimum value: 1. Maximum value: 20480. Valid values: 2048.
                    /// </summary>
                    [NameInMap("TransmissionSize")]
                    [Validation(Required=false)]
                    public long? TransmissionSize { get; set; }

                    /// <summary>
                    /// 验证关键词。
                    /// </summary>
                    [NameInMap("ValidateKeywords")]
                    [Validation(Required=false)]
                    public string ValidateKeywords { get; set; }

                    /// <summary>
                    /// 验证方式。
                    /// 
                    /// - 0：不验证 
                    /// - 1：验证字符串 
                    /// - 2：MD5验证
                    /// </summary>
                    [NameInMap("VerifyWay")]
                    [Validation(Required=false)]
                    public int? VerifyWay { get; set; }

                    /// <summary>
                    /// DNS劫持白名单。匹配规则支持IP、IP通配符、子网掩码和CNAME，可以填写多个匹配规则，多个匹配规则以竖线（|）隔开。例如：www.aliyun.com:203.0.3.55|203.3.44.67，表示www.aliyun.com域名下除203.0.3.55和203.3.44.67之外的其他IP都是被劫持的。
                    /// </summary>
                    [NameInMap("WhiteList")]
                    [Validation(Required=false)]
                    public string WhiteList { get; set; }

                }

                /// <summary>
                /// The DNS synthetic test parameters. This parameter is required if the TaskType parameter is set to 3.
                /// </summary>
                [NameInMap("NetDNS")]
                [Validation(Required=false)]
                public GetTimingSyntheticTaskResponseBodyDataMonitorConfNetDNS NetDNS { get; set; }
                public class GetTimingSyntheticTaskResponseBodyDataMonitorConfNetDNS : TeaModel {
                    /// <summary>
                    /// The IP version of the DNS server. 0: IPv4. 1: IPv6. 2: A version is automatically selected. Default value: 0.
                    /// </summary>
                    [NameInMap("DnsServerIpType")]
                    [Validation(Required=false)]
                    public int? DnsServerIpType { get; set; }

                    /// <summary>
                    /// The IP address of the DNS server. Default value: 114.114.114.114.
                    /// </summary>
                    [NameInMap("NsServer")]
                    [Validation(Required=false)]
                    public string NsServer { get; set; }

                    /// <summary>
                    /// The DNS query. 0: recursive, 1: iterative. Default value: 0.
                    /// </summary>
                    [NameInMap("QueryMethod")]
                    [Validation(Required=false)]
                    public int? QueryMethod { get; set; }

                    /// <summary>
                    /// The destination domain name.
                    /// </summary>
                    [NameInMap("TargetUrl")]
                    [Validation(Required=false)]
                    public string TargetUrl { get; set; }

                    /// <summary>
                    /// The timeout period for the DNS synthetic test. Unit: milliseconds. The minimum value is 1000 and the maximum value is 45000. Default value: 5000.
                    /// </summary>
                    [NameInMap("Timeout")]
                    [Validation(Required=false)]
                    public long? Timeout { get; set; }

                }

                /// <summary>
                /// The ICMP synthetic test parameters. This parameter is required if the TaskType parameter is set to 1.
                /// </summary>
                [NameInMap("NetICMP")]
                [Validation(Required=false)]
                public GetTimingSyntheticTaskResponseBodyDataMonitorConfNetICMP NetICMP { get; set; }
                public class GetTimingSyntheticTaskResponseBodyDataMonitorConfNetICMP : TeaModel {
                    /// <summary>
                    /// The interval at which ICMP packets are sent. Unit: milliseconds. Minimum value: 200. Maximum value: 2000. Default value: 200.
                    /// </summary>
                    [NameInMap("Interval")]
                    [Validation(Required=false)]
                    public int? Interval { get; set; }

                    /// <summary>
                    /// The number of ICMP packets that are sent. Minimum value: 1. Maximum value: 50. Default value: 4.
                    /// </summary>
                    [NameInMap("PackageNum")]
                    [Validation(Required=false)]
                    public int? PackageNum { get; set; }

                    /// <summary>
                    /// The size of each ICMP packet. Unit: bytes. Valid values: 32, 64, 128, 256, 512, 1024.
                    /// </summary>
                    [NameInMap("PackageSize")]
                    [Validation(Required=false)]
                    public int? PackageSize { get; set; }

                    /// <summary>
                    /// Specifies whether to split ICMP packets. Default value: true.
                    /// </summary>
                    [NameInMap("SplitPackage")]
                    [Validation(Required=false)]
                    public bool? SplitPackage { get; set; }

                    /// <summary>
                    /// The destination host IP address or domain name
                    /// </summary>
                    [NameInMap("TargetUrl")]
                    [Validation(Required=false)]
                    public string TargetUrl { get; set; }

                    /// <summary>
                    /// The timeout period for the TCP synthetic test. Unit: milliseconds. Minimum value: 1000. Maximum value: 300000. Default value: 20000.
                    /// </summary>
                    [NameInMap("Timeout")]
                    [Validation(Required=false)]
                    public long? Timeout { get; set; }

                    /// <summary>
                    /// Specifies whether to enable the tracert command. Default value: true.
                    /// </summary>
                    [NameInMap("TracertEnable")]
                    [Validation(Required=false)]
                    public bool? TracertEnable { get; set; }

                    /// <summary>
                    /// The maximum number of hops for tracert. Minimum value: 1. Maximum value: 128. Default value: 64.
                    /// </summary>
                    [NameInMap("TracertNumMax")]
                    [Validation(Required=false)]
                    public int? TracertNumMax { get; set; }

                    /// <summary>
                    /// The timeout period of tracert. Unit: milliseconds. Minimum value: 1000. Maximum value: 300000. Default value: 60000.
                    /// </summary>
                    [NameInMap("TracertTimeout")]
                    [Validation(Required=false)]
                    public long? TracertTimeout { get; set; }

                }

                /// <summary>
                /// The TCP synthetic tests parameters. This parameter is required if the TaskType parameter is set to 2.
                /// </summary>
                [NameInMap("NetTCP")]
                [Validation(Required=false)]
                public GetTimingSyntheticTaskResponseBodyDataMonitorConfNetTCP NetTCP { get; set; }
                public class GetTimingSyntheticTaskResponseBodyDataMonitorConfNetTCP : TeaModel {
                    /// <summary>
                    /// The number of TCP connections that are established in a test. Minimum value: 1. Maximum value: 16. Default value: 4.
                    /// </summary>
                    [NameInMap("ConnectTimes")]
                    [Validation(Required=false)]
                    public int? ConnectTimes { get; set; }

                    /// <summary>
                    /// The interval at which TCP connections are established. Unit: milliseconds. Minimum value: 200. Maximum value: 10000. Default value: 200.
                    /// </summary>
                    [NameInMap("Interval")]
                    [Validation(Required=false)]
                    public long? Interval { get; set; }

                    /// <summary>
                    /// The destination host IP address.
                    /// </summary>
                    [NameInMap("TargetUrl")]
                    [Validation(Required=false)]
                    public string TargetUrl { get; set; }

                    /// <summary>
                    /// The timeout period for the TCP synthetic test. Unit: milliseconds. Minimum value: 1000. Maximum value: 300000. Default value: 20000.
                    /// </summary>
                    [NameInMap("Timeout")]
                    [Validation(Required=false)]
                    public long? Timeout { get; set; }

                    /// <summary>
                    /// Specifies whether to enable the tracert command. Default value: true.
                    /// </summary>
                    [NameInMap("TracertEnable")]
                    [Validation(Required=false)]
                    public bool? TracertEnable { get; set; }

                    /// <summary>
                    /// The maximum number of hops for tracert. Minimum value: 1. Maximum value: 128. Default value: 20.
                    /// </summary>
                    [NameInMap("TracertNumMax")]
                    [Validation(Required=false)]
                    public int? TracertNumMax { get; set; }

                    /// <summary>
                    /// The timeout period of tracert. Unit: milliseconds. Minimum value: 1000. Maximum value: 300000. Default value: 60000.
                    /// </summary>
                    [NameInMap("TracertTimeout")]
                    [Validation(Required=false)]
                    public long? TracertTimeout { get; set; }

                }

                /// <summary>
                /// 流媒体拨测配置。
                /// </summary>
                [NameInMap("Stream")]
                [Validation(Required=false)]
                public GetTimingSyntheticTaskResponseBodyDataMonitorConfStream Stream { get; set; }
                public class GetTimingSyntheticTaskResponseBodyDataMonitorConfStream : TeaModel {
                    /// <summary>
                    /// 自定义header，JSON Map格式。
                    /// </summary>
                    [NameInMap("CustomHeaderContent")]
                    [Validation(Required=false)]
                    public Dictionary<string, string> CustomHeaderContent { get; set; }

                    /// <summary>
                    /// 播放器，不传默认12。
                    /// 
                    /// - 12：VLC
                    /// - 2：FlashPlayer
                    /// </summary>
                    [NameInMap("PlayerType")]
                    [Validation(Required=false)]
                    public int? PlayerType { get; set; }

                    /// <summary>
                    /// 资源地址类型：
                    /// 
                    /// - 1：资源地址。
                    /// - 0：页面地址。不传默认0。
                    /// </summary>
                    [NameInMap("StreamAddressType")]
                    [Validation(Required=false)]
                    public int? StreamAddressType { get; set; }

                    /// <summary>
                    /// 监测时长，单位秒，最长支持60s，不传默认60。
                    /// </summary>
                    [NameInMap("StreamMonitorTimeout")]
                    [Validation(Required=false)]
                    public int? StreamMonitorTimeout { get; set; }

                    /// <summary>
                    /// 音视频标志：0-视频，1-音频。
                    /// </summary>
                    [NameInMap("StreamType")]
                    [Validation(Required=false)]
                    public int? StreamType { get; set; }

                    /// <summary>
                    /// 流媒体资源地址。
                    /// </summary>
                    [NameInMap("TargetUrl")]
                    [Validation(Required=false)]
                    public string TargetUrl { get; set; }

                    /// <summary>
                    /// DNS劫持白名单。匹配规则支持IP、IP通配符、子网掩码和CNAME，可以填写多个匹配规则，多个匹配规则以竖线（|）隔开。例如：www.aliyun.com:203.0.3.55|203.3.44.67，表示www.aliyun.com域名下除203.0.3.55和203.3.44.67之外的其他IP都是被劫持的。
                    /// </summary>
                    [NameInMap("WhiteList")]
                    [Validation(Required=false)]
                    public string WhiteList { get; set; }

                }

                /// <summary>
                /// The website-speed measurement parameters.
                /// </summary>
                [NameInMap("Website")]
                [Validation(Required=false)]
                public GetTimingSyntheticTaskResponseBodyDataMonitorConfWebsite Website { get; set; }
                public class GetTimingSyntheticTaskResponseBodyDataMonitorConfWebsite : TeaModel {
                    /// <summary>
                    /// Specifies whether to automatically scroll up and down the screen to load a page. 0: No. 1: Yes. Default value: 0.
                    /// </summary>
                    [NameInMap("AutomaticScrolling")]
                    [Validation(Required=false)]
                    public int? AutomaticScrolling { get; set; }

                    /// <summary>
                    /// Specifies whether to create a custom header. 0: No. 1: The first packet is modified. 2: All packets are modified. Default value: 0.
                    /// </summary>
                    [NameInMap("CustomHeader")]
                    [Validation(Required=false)]
                    public int? CustomHeader { get; set; }

                    /// <summary>
                    /// The custom header. Format: JSON map.
                    /// </summary>
                    [NameInMap("CustomHeaderContent")]
                    [Validation(Required=false)]
                    public Dictionary<string, string> CustomHeaderContent { get; set; }

                    /// <summary>
                    /// 域名（例如www.aliyun.com）解析时，解析出的IP地址或者CNAME不在DNS劫持白名单内，用户就会访问失败或者返回一个非Aliyun的目标IP；若解析结果中的IP或者CNAME在DNS白名单内，则会被认定为没有发生DNS劫持。
                    /// 
                    /// 填写格式：域名:匹配规则。匹配规则支持IP、IP通配符、子网掩码和CNAME，可以填写多个匹配规则，多个匹配规则以竖线（|）隔开。例如：www.aliyun.com:203.0.3.55|203.3.44.67，表示www.aliyun.com域名下除203.0.3.55和203.3.44.67之外的其他IP都是被劫持的。
                    /// </summary>
                    [NameInMap("DNSHijackWhitelist")]
                    [Validation(Required=false)]
                    public string DNSHijackWhitelist { get; set; }

                    /// <summary>
                    /// Specifies whether to disable the cache. 0: No. 1: Yes. Default value: 1.
                    /// </summary>
                    [NameInMap("DisableCache")]
                    [Validation(Required=false)]
                    public int? DisableCache { get; set; }

                    /// <summary>
                    /// Specifies whether to accept compressed files based on the HTTP Accept-Encoding request header. 0: No. 1: Yes. Default value: 0.
                    /// </summary>
                    [NameInMap("DisableCompression")]
                    [Validation(Required=false)]
                    public int? DisableCompression { get; set; }

                    /// <summary>
                    /// 在页面加载过程中如果出现元素黑名单中配置的元素，不会请求加载该元素 。
                    /// </summary>
                    [NameInMap("ElementBlacklist")]
                    [Validation(Required=false)]
                    public string ElementBlacklist { get; set; }

                    /// <summary>
                    /// Specifies whether to exclude invalid IP addresses.
                    /// 
                    /// *   1: No
                    /// *   0: Yes
                    /// </summary>
                    [NameInMap("FilterInvalidIP")]
                    [Validation(Required=false)]
                    public int? FilterInvalidIP { get; set; }

                    /// <summary>
                    /// 识别元素：设置浏览页面元素总个数。
                    /// </summary>
                    [NameInMap("FlowHijackJumpTimes")]
                    [Validation(Required=false)]
                    public int? FlowHijackJumpTimes { get; set; }

                    /// <summary>
                    /// 劫持标识：设置匹配的关键信息。填写劫持判断关键字或关键元素，允许带星号（*）。
                    /// </summary>
                    [NameInMap("FlowHijackLogo")]
                    [Validation(Required=false)]
                    public string FlowHijackLogo { get; set; }

                    /// <summary>
                    /// Specifies whether to ignore SSL certificate errors during browsing. 0: No. 1: Yes. Default value: 1.
                    /// </summary>
                    [NameInMap("IgnoreCertificateError")]
                    [Validation(Required=false)]
                    public int? IgnoreCertificateError { get; set; }

                    /// <summary>
                    /// The monitoring timeout period. Unit: milliseconds. Default value: 20000. Minimum value: 5000. Maximum value: 300000.
                    /// </summary>
                    [NameInMap("MonitorTimeout")]
                    [Validation(Required=false)]
                    public int? MonitorTimeout { get; set; }

                    /// <summary>
                    /// 监测页面出现了域名设置之外的元素都属于页面被篡改。常见的表现形式为弹出广告、浮动广告、跳转等。
                    /// 
                    /// 填写格式：域名:元素。元素支持填写通配符，可以填写多个元素，多个元素以竖线（|）隔开。例如：www.aliyun.com:|/cc/bb/a.gif|/vv/bb/cc.jpg，表示www.aliyun.com域名下除基础文档、/cc/bb/a.gif和/vv/bb/cc.jpg之外的其他元素都属于页面被篡改。
                    /// </summary>
                    [NameInMap("PageTamper")]
                    [Validation(Required=false)]
                    public string PageTamper { get; set; }

                    /// <summary>
                    /// Specifies whether to continue browsing after redirection. 0: No, 1:Yes. Default value: 1.
                    /// </summary>
                    [NameInMap("Redirection")]
                    [Validation(Required=false)]
                    public int? Redirection { get; set; }

                    /// <summary>
                    /// The time threshold that is used to define a slow element. Unit: milliseconds. Default value: 5000. Minimum value: 1. Maximum value: 300000.
                    /// </summary>
                    [NameInMap("SlowElementThreshold")]
                    [Validation(Required=false)]
                    public long? SlowElementThreshold { get; set; }

                    /// <summary>
                    /// The destination URL.
                    /// </summary>
                    [NameInMap("TargetUrl")]
                    [Validation(Required=false)]
                    public string TargetUrl { get; set; }

                    /// <summary>
                    /// 验证字符串即监测页面源代码中的某个任意字符串。若客户端返回的源码中包含任一黑名单中的字符串则报650验证字符串失败的错误。多个字符串以竖线（|）隔开。
                    /// </summary>
                    [NameInMap("VerifyStringBlacklist")]
                    [Validation(Required=false)]
                    public string VerifyStringBlacklist { get; set; }

                    /// <summary>
                    /// 验证字符串即监测页面源代码中的某个任意字符串。客户端返回的源码必须包含所有白名单中的字符串，否则报650验证字符串失败的错误。多个字符串以竖线（|）隔开。
                    /// </summary>
                    [NameInMap("VerifyStringWhitelist")]
                    [Validation(Required=false)]
                    public string VerifyStringWhitelist { get; set; }

                    /// <summary>
                    /// The maximum waiting time. Unit: milliseconds. Default value: 5000. Minimum value: 5000. Maximum value: 300000.
                    /// </summary>
                    [NameInMap("WaitCompletionTime")]
                    [Validation(Required=false)]
                    public long? WaitCompletionTime { get; set; }

                }

            }

            /// <summary>
            /// The list of monitoring points.
            /// </summary>
            [NameInMap("Monitors")]
            [Validation(Required=false)]
            public List<GetTimingSyntheticTaskResponseBodyDataMonitors> Monitors { get; set; }
            public class GetTimingSyntheticTaskResponseBodyDataMonitors : TeaModel {
                /// <summary>
                /// The city code.
                /// </summary>
                [NameInMap("CityCode")]
                [Validation(Required=false)]
                public string CityCode { get; set; }

                /// <summary>
                /// The client type of the monitoring point. Valid values: 1: data center. 2: Internet. 3: mobile device. 4: ECS instance.
                /// </summary>
                [NameInMap("ClientType")]
                [Validation(Required=false)]
                public int? ClientType { get; set; }

                /// <summary>
                /// The carrier code.
                /// </summary>
                [NameInMap("OperatorCode")]
                [Validation(Required=false)]
                public string OperatorCode { get; set; }

            }

            /// <summary>
            /// The name of the task.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The region ID.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The ID of the resource group.
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// CREATING: The task is being created. RUNNING: The task is running. PARTIAL_RUNNING: The task is partially running. STOP: The task is stopped. LIMIT_STOP: The task is stopped due to quota insufficiency. EXCEPTION: The task is abnormal. DELETE: The task is deleted. DELETE_EXCEPTION: The task failed to be deleted.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The tag.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<GetTimingSyntheticTaskResponseBodyDataTags> Tags { get; set; }
            public class GetTimingSyntheticTaskResponseBodyDataTags : TeaModel {
                /// <summary>
                /// The key of the tag.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The value of the tag.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// The ID of the synthetic monitoring task.
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// The type of the task. Valid values:
            /// 
            /// ICMP TCP DNS HTTP Website speed measurement File download
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public int? TaskType { get; set; }

        }

        /// <summary>
        /// The message returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
