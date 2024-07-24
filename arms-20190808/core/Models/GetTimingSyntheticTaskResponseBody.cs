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
        /// The returned struct.
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

                /// <summary>
                /// The reserved parameters.
                /// </summary>
                [NameInMap("CustomPrometheusSetting")]
                [Validation(Required=false)]
                public GetTimingSyntheticTaskResponseBodyDataCommonSettingCustomPrometheusSetting CustomPrometheusSetting { get; set; }
                public class GetTimingSyntheticTaskResponseBodyDataCommonSettingCustomPrometheusSetting : TeaModel {
                    /// <summary>
                    /// A reserved parameter.
                    /// </summary>
                    [NameInMap("PrometheusClusterId")]
                    [Validation(Required=false)]
                    public string PrometheusClusterId { get; set; }

                    /// <summary>
                    /// A reserved parameter.
                    /// </summary>
                    [NameInMap("PrometheusClusterRegion")]
                    [Validation(Required=false)]
                    public string PrometheusClusterRegion { get; set; }

                    /// <summary>
                    /// A reserved parameter.
                    /// </summary>
                    [NameInMap("PrometheusLabels")]
                    [Validation(Required=false)]
                    public Dictionary<string, string> PrometheusLabels { get; set; }

                }

                /// <summary>
                /// User VPC information. If the dial-up is to the Alibaba Cloud intranet address, you need to configure the VPC information.
                /// </summary>
                [NameInMap("CustomVPCSetting")]
                [Validation(Required=false)]
                public GetTimingSyntheticTaskResponseBodyDataCommonSettingCustomVPCSetting CustomVPCSetting { get; set; }
                public class GetTimingSyntheticTaskResponseBodyDataCommonSettingCustomVPCSetting : TeaModel {
                    /// <summary>
                    /// The region ID.
                    /// </summary>
                    [NameInMap("RegionId")]
                    [Validation(Required=false)]
                    public string RegionId { get; set; }

                    /// <summary>
                    /// Security group ID. This security group is where the dial-up client is located. The security group limits the inbound and outbound rules of the dial-up client in the VPC. You need to set the inbound rules of the security group where your VPC is located to allow the security group where the dial-up client is located to access. Otherwise, the dial-up client cannot smoothly access the resources in your VPC.
                    /// </summary>
                    [NameInMap("SecureGroupId")]
                    [Validation(Required=false)]
                    public string SecureGroupId { get; set; }

                    /// <summary>
                    /// The vSwitch ID.
                    /// </summary>
                    [NameInMap("VSwitchId")]
                    [Validation(Required=false)]
                    public string VSwitchId { get; set; }

                    /// <summary>
                    /// VPC ID.
                    /// </summary>
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
                /// Whether to enable tracing.
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
                /// Tracing client type:
                /// 
                /// - 0: ARMS Agent
                /// - 1: Open Telemetry
                /// - 2: Jaeger
                /// </summary>
                [NameInMap("TraceClientType")]
                [Validation(Required=false)]
                public int? TraceClientType { get; set; }

                /// <summary>
                /// Tracing data reporting region.
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
                /// The parameters of the HTTP(S) synthetic test.
                /// </summary>
                [NameInMap("ApiHTTP")]
                [Validation(Required=false)]
                public GetTimingSyntheticTaskResponseBodyDataMonitorConfApiHTTP ApiHTTP { get; set; }
                public class GetTimingSyntheticTaskResponseBodyDataMonitorConfApiHTTP : TeaModel {
                    /// <summary>
                    /// Whether to verify the certificate. The default is no.
                    /// </summary>
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
                    /// The ALPN protocol version. You can configure this parameter when you perform an HTTPS synthetic test on a WAP mobile client. Valid values:
                    /// 
                    /// 0: default
                    /// 
                    /// 1: HTTP/1.1
                    /// 
                    /// 2: HTTP/2
                    /// 
                    /// 3: disables the ALPN protocol
                    /// </summary>
                    [NameInMap("ProtocolAlpnProtocol")]
                    [Validation(Required=false)]
                    public int? ProtocolAlpnProtocol { get; set; }

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
                    /// Verify keywords.
                    /// </summary>
                    [NameInMap("ValidateKeywords")]
                    [Validation(Required=false)]
                    public string ValidateKeywords { get; set; }

                    /// <summary>
                    /// Verification method.
                    /// 
                    /// - 0: No verification
                    /// - 1: Verification string
                    /// - 2: MD5 verification
                    /// </summary>
                    [NameInMap("VerifyWay")]
                    [Validation(Required=false)]
                    public int? VerifyWay { get; set; }

                    /// <summary>
                    /// DNS hijacking whitelist. Matching rules support IP, IP wildcard, subnet mask and CNAME. You can fill in multiple matching rules, and multiple matching rules are separated by vertical bars (|). For example: `www.aliyun.com:203.0.3.55|203.3.44.67`, which means that all IPs except 203.0.3.55 and 203.3.44.67 under the www.aliyun.com domain name are hijacked.
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
                /// Streaming media dial test configuration.
                /// </summary>
                [NameInMap("Stream")]
                [Validation(Required=false)]
                public GetTimingSyntheticTaskResponseBodyDataMonitorConfStream Stream { get; set; }
                public class GetTimingSyntheticTaskResponseBodyDataMonitorConfStream : TeaModel {
                    /// <summary>
                    /// Custom header, JSON Map format.
                    /// </summary>
                    [NameInMap("CustomHeaderContent")]
                    [Validation(Required=false)]
                    public Dictionary<string, string> CustomHeaderContent { get; set; }

                    /// <summary>
                    /// Player, default is 12 if not specified.
                    /// 
                    /// - 12: VLC
                    /// - 2: Flash Player
                    /// </summary>
                    [NameInMap("PlayerType")]
                    [Validation(Required=false)]
                    public int? PlayerType { get; set; }

                    /// <summary>
                    /// Resource address type:
                    /// 
                    /// - 1: Resource address.
                    /// - 0: Page address. If not passed, the default value is 0.
                    /// </summary>
                    [NameInMap("StreamAddressType")]
                    [Validation(Required=false)]
                    public int? StreamAddressType { get; set; }

                    /// <summary>
                    /// Monitoring duration, in seconds, supports up to 60 seconds. If not specified, the default value is 60 seconds.
                    /// </summary>
                    [NameInMap("StreamMonitorTimeout")]
                    [Validation(Required=false)]
                    public int? StreamMonitorTimeout { get; set; }

                    /// <summary>
                    /// Audio and video flag:
                    /// 
                    /// - 0: video
                    /// - 1: audio
                    /// </summary>
                    [NameInMap("StreamType")]
                    [Validation(Required=false)]
                    public int? StreamType { get; set; }

                    /// <summary>
                    /// Streaming media resource address.
                    /// </summary>
                    [NameInMap("TargetUrl")]
                    [Validation(Required=false)]
                    public string TargetUrl { get; set; }

                    /// <summary>
                    /// DNS hijacking whitelist. Matching rules support IP, IP wildcard, subnet mask and CNAME. You can fill in multiple matching rules, and multiple matching rules are separated by vertical bars (|). For example: `www.aliyun.com:203.0.3.55|203.3.44.67`, which means that all IPs except 203.0.3.55 and 203.3.44.67 under the www.aliyun.com domain name are hijacked.
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
                    /// When resolving a domain name (such as www.aliyun.com), if the resolved IP address or CNAME is not in the DNS hijacking whitelist, the user will fail to access or return a non-Aliyun target IP; if the IP or CNAME in the resolution result is in the DNS whitelist, it will be deemed that no DNS hijacking has occurred.
                    /// 
                    /// Fill in the format: `domain name: matching rule`. Matching rules support IP, IP wildcard, subnet mask and CNAME. You can fill in multiple matching rules, and multiple matching rules are separated by vertical bars (|). 
                    /// 
                    /// For example: `www.aliyun.com:203.0.3.55|203.3.44.67`, which means that all IPs except 203.0.3.55 and 203.3.44.67 under the www.aliyun.com domain name are hijacked.
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
                    /// If an element configured in the element blacklist appears during page loading, no request will be made to load the element.
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
                    /// Identify elements: Set the total number of elements to browse the page.
                    /// </summary>
                    [NameInMap("FlowHijackJumpTimes")]
                    [Validation(Required=false)]
                    public int? FlowHijackJumpTimes { get; set; }

                    /// <summary>
                    /// Hijacking flag: Set the key information for matching. Fill in the hijacking judgment keyword or key element, and asterisks (*) are allowed.
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
                    /// If any element other than the domain name setting appears on the monitoring page, it means that the page has been tampered. Common manifestations include pop-up ads, floating ads, jumps, etc.
                    /// 
                    /// Fill in the format: `domain name: element`. Elements support wildcards, and multiple elements can be filled in. Multiple elements are separated by vertical bars (|). For example: `www.aliyun.com:|/cc/bb/a.gif|/vv/bb/cc.jpg`, which means that all elements except the basic document, /cc/bb/a.gif and /vv/bb/cc.jpg under the www.aliyun.com domain name are considered to be tampered with.
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
                    /// The verification string is an arbitrary string in the source code of the monitoring page. If the source code returned by the client contains any string in the blacklist, an error 650 &quot;Verification string failed&quot; will be reported. Multiple strings are separated by vertical bars (|).
                    /// </summary>
                    [NameInMap("VerifyStringBlacklist")]
                    [Validation(Required=false)]
                    public string VerifyStringBlacklist { get; set; }

                    /// <summary>
                    /// The verification string is an arbitrary string in the source code of the monitoring page. The source code returned by the client must contain all the strings in the whitelist, otherwise an error 650 &quot;Verification string failed&quot; will be reported. Multiple strings are separated by a vertical bar (|).
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
