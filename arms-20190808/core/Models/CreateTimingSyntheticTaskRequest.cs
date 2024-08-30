// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class CreateTimingSyntheticTaskRequest : TeaModel {
        /// <summary>
        /// The list of assertions.
        /// </summary>
        [NameInMap("AvailableAssertions")]
        [Validation(Required=false)]
        public List<CreateTimingSyntheticTaskRequestAvailableAssertions> AvailableAssertions { get; set; }
        public class CreateTimingSyntheticTaskRequestAvailableAssertions : TeaModel {
            /// <summary>
            /// The expected value.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("Expect")]
            [Validation(Required=false)]
            public string Expect { get; set; }

            /// <summary>
            /// The condition. gt: greater than. gte: greater than or equal to. lt: less than. lte: less than or equal to. eq: equal to. neq: not equal to. ctn: contain. nctn: does not contain. exist: exist. n_exist: does not exist. belong: belong to. n_belong: does not belong to. reg_match: regular expression.
            /// 
            /// This parameter is required.
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
            /// 
            /// This parameter is required.
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
        public CreateTimingSyntheticTaskRequestCommonSetting CommonSetting { get; set; }
        public class CreateTimingSyntheticTaskRequestCommonSetting : TeaModel {
            /// <summary>
            /// The custom host settings.
            /// </summary>
            [NameInMap("CustomHost")]
            [Validation(Required=false)]
            public CreateTimingSyntheticTaskRequestCommonSettingCustomHost CustomHost { get; set; }
            public class CreateTimingSyntheticTaskRequestCommonSettingCustomHost : TeaModel {
                /// <summary>
                /// The list of hosts.
                /// 
                /// This parameter is required.
                /// </summary>
                [NameInMap("Hosts")]
                [Validation(Required=false)]
                public List<CreateTimingSyntheticTaskRequestCommonSettingCustomHostHosts> Hosts { get; set; }
                public class CreateTimingSyntheticTaskRequestCommonSettingCustomHostHosts : TeaModel {
                    /// <summary>
                    /// The domain name.
                    /// 
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("Domain")]
                    [Validation(Required=false)]
                    public string Domain { get; set; }

                    /// <summary>
                    /// The IP version. Valid values:
                    /// 
                    /// *   0: A version is automatically selected.
                    /// *   1: IPv4.
                    /// *   2: IPv6.
                    /// 
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("IpType")]
                    [Validation(Required=false)]
                    public int? IpType { get; set; }

                    /// <summary>
                    /// The list of IP addresses.
                    /// 
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("Ips")]
                    [Validation(Required=false)]
                    public List<string> Ips { get; set; }

                }

                /// <summary>
                /// The selection mode. Valid values:
                /// 
                /// *   0: random
                /// *   1: polling
                /// 
                /// This parameter is required.
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
            public CreateTimingSyntheticTaskRequestCommonSettingCustomPrometheusSetting CustomPrometheusSetting { get; set; }
            public class CreateTimingSyntheticTaskRequestCommonSettingCustomPrometheusSetting : TeaModel {
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
            /// The information about the virtual private cloud (VPC). If the destination URL is an Alibaba Cloud internal endpoint, you need to configure a VPC.
            /// </summary>
            [NameInMap("CustomVPCSetting")]
            [Validation(Required=false)]
            public CreateTimingSyntheticTaskRequestCommonSettingCustomVPCSetting CustomVPCSetting { get; set; }
            public class CreateTimingSyntheticTaskRequestCommonSettingCustomVPCSetting : TeaModel {
                /// <summary>
                /// The region ID.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The ID of the security group to which the client belongs. The security group specifies the inbound and outbound rules of the client for the VPC. You need to allow the security group to which the client belongs to access the security group to which the VPC belongs. Otherwise, the client cannot access resources in the VPC.
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
            /// *   1: IPv4.
            /// *   2: IPv6.
            /// </summary>
            [NameInMap("IpType")]
            [Validation(Required=false)]
            public int? IpType { get; set; }

            /// <summary>
            /// Specifies whether to enable tracing.
            /// </summary>
            [NameInMap("IsOpenTrace")]
            [Validation(Required=false)]
            public bool? IsOpenTrace { get; set; }

            /// <summary>
            /// Specifies whether to evenly distribute monitoring samples. Valid values:
            /// 
            /// *   0: no
            /// *   1: yes
            /// </summary>
            [NameInMap("MonitorSamples")]
            [Validation(Required=false)]
            public int? MonitorSamples { get; set; }

            /// <summary>
            /// The type of the client for tracing. Valid values:
            /// 
            /// *   0: ARMS agent
            /// *   1: OpenTelemetry
            /// *   2: Jaeger
            /// </summary>
            [NameInMap("TraceClientType")]
            [Validation(Required=false)]
            public int? TraceClientType { get; set; }

            /// <summary>
            /// The region to which trace data is reported.
            /// </summary>
            [NameInMap("XtraceRegion")]
            [Validation(Required=false)]
            public string XtraceRegion { get; set; }

        }

        /// <summary>
        /// The general settings.
        /// </summary>
        [NameInMap("CustomPeriod")]
        [Validation(Required=false)]
        public CreateTimingSyntheticTaskRequestCustomPeriod CustomPeriod { get; set; }
        public class CreateTimingSyntheticTaskRequestCustomPeriod : TeaModel {
            /// <summary>
            /// The custom host settings.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("EndHour")]
            [Validation(Required=false)]
            public int? EndHour { get; set; }

            /// <summary>
            /// The list of hosts.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("StartHour")]
            [Validation(Required=false)]
            public int? StartHour { get; set; }

        }

        /// <summary>
        /// The detection frequency. Valid values: 1m, 5m, 10m, 15m, 20m, 30m, 1h, 2h, 3h, 4h, 6h, 8h, 12h, and 24h.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Frequency")]
        [Validation(Required=false)]
        public string Frequency { get; set; }

        /// <summary>
        /// The detection point type. Valid values:
        /// 
        /// - 1: PC
        /// - 2: mobile device
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("MonitorCategory")]
        [Validation(Required=false)]
        public int? MonitorCategory { get; set; }

        /// <summary>
        /// The monitoring configurations.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("MonitorConf")]
        [Validation(Required=false)]
        public CreateTimingSyntheticTaskRequestMonitorConf MonitorConf { get; set; }
        public class CreateTimingSyntheticTaskRequestMonitorConf : TeaModel {
            /// <summary>
            /// The parameters of the HTTP(S) synthetic test.
            /// </summary>
            [NameInMap("ApiHTTP")]
            [Validation(Required=false)]
            public CreateTimingSyntheticTaskRequestMonitorConfApiHTTP ApiHTTP { get; set; }
            public class CreateTimingSyntheticTaskRequestMonitorConfApiHTTP : TeaModel {
                /// <summary>
                /// Specifies whether to verify the certificate. Default value: no.
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
                /// The request method. Valid values: GET and POST.
                /// </summary>
                [NameInMap("Method")]
                [Validation(Required=false)]
                public string Method { get; set; }

                /// <summary>
                /// The ALPN protocol version. You can configure this parameter when you perform an HTTPS synthetic test on a WAP mobile client. Valid values:
                /// 
                /// 0: default
                /// 
                /// 1: http/1.1
                /// 
                /// 2: h2
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
                public CreateTimingSyntheticTaskRequestMonitorConfApiHTTPRequestBody RequestBody { get; set; }
                public class CreateTimingSyntheticTaskRequestMonitorConfApiHTTPRequestBody : TeaModel {
                    /// <summary>
                    /// The content of the request body. Format: JSON string. The parameter is required if the Type parameter is set to text/plain, application/json, application/xml, or text/html. Format: JSON string.
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
                /// The URL or request path for synthetic monitoring.
                /// 
                /// This parameter is required.
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
            /// The parameters of file downloading.
            /// </summary>
            [NameInMap("FileDownload")]
            [Validation(Required=false)]
            public CreateTimingSyntheticTaskRequestMonitorConfFileDownload FileDownload { get; set; }
            public class CreateTimingSyntheticTaskRequestMonitorConfFileDownload : TeaModel {
                /// <summary>
                /// Unit: milliseconds. Minimum value: 1000. Maximum value: 120000. Default value: 5000.
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
                /// The kernel type. Valid values:
                /// 
                /// *   1: curl
                /// *   0: WinInet
                /// 
                /// Default value: 1
                /// </summary>
                [NameInMap("DownloadKernel")]
                [Validation(Required=false)]
                public int? DownloadKernel { get; set; }

                /// <summary>
                /// Specifies whether to ignore CA certificate authentication errors. Valid values: 0: no. 1: yes. Default value: 1.
                /// </summary>
                [NameInMap("IgnoreCertificateAuthError")]
                [Validation(Required=false)]
                public int? IgnoreCertificateAuthError { get; set; }

                /// <summary>
                /// Specifies whether to ignore certificate revocation errors. Valid values: 0: no. 1: yes. Default value: 1.
                /// </summary>
                [NameInMap("IgnoreCertificateCanceledError")]
                [Validation(Required=false)]
                public int? IgnoreCertificateCanceledError { get; set; }

                /// <summary>
                /// Specifies whether to ignore certificate invalidity. Valid values: 0: no. 1: yes. Default value: 1.
                /// </summary>
                [NameInMap("IgnoreCertificateOutOfDateError")]
                [Validation(Required=false)]
                public int? IgnoreCertificateOutOfDateError { get; set; }

                /// <summary>
                /// Specifies whether to ignore certificate status errors. Valid values: 0: no. 1: yes. Default value: 1.
                /// </summary>
                [NameInMap("IgnoreCertificateStatusError")]
                [Validation(Required=false)]
                public int? IgnoreCertificateStatusError { get; set; }

                /// <summary>
                /// Specifies whether to ignore certificate incredibility. Valid values: 0: no. 1: yes. Default value: 1.
                /// </summary>
                [NameInMap("IgnoreCertificateUntrustworthyError")]
                [Validation(Required=false)]
                public int? IgnoreCertificateUntrustworthyError { get; set; }

                /// <summary>
                /// Specifies whether to ignore certificate usage errors. Valid values: 0: no. 1: yes. Default value: 1.
                /// </summary>
                [NameInMap("IgnoreCertificateUsingError")]
                [Validation(Required=false)]
                public int? IgnoreCertificateUsingError { get; set; }

                /// <summary>
                /// Specifies whether to ignore host invalidity. Valid values: 0: no. 1: yes. Default value: 1.
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
                /// The QUIC protocol type. Valid values:
                /// 
                /// *   1: HTTP/1
                /// *   2: HTTP/2
                /// *   3: HTTP/3
                /// 
                /// Default value: 1
                /// </summary>
                [NameInMap("QuickProtocol")]
                [Validation(Required=false)]
                public int? QuickProtocol { get; set; }

                /// <summary>
                /// Specifies whether to support redirection. Valid values: 0: no. 1: yes. Default value: 1.
                /// </summary>
                [NameInMap("Redirection")]
                [Validation(Required=false)]
                public int? Redirection { get; set; }

                /// <summary>
                /// The URL that is used to download the file.
                /// 
                /// This parameter is required.
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
                /// The keyword that is used in verification.
                /// </summary>
                [NameInMap("ValidateKeywords")]
                [Validation(Required=false)]
                public string ValidateKeywords { get; set; }

                /// <summary>
                /// The verification method. Valid values:
                /// 
                /// *   0: no verification
                /// *   1: string verification
                /// *   2: MD5 verification
                /// </summary>
                [NameInMap("VerifyWay")]
                [Validation(Required=false)]
                public int? VerifyWay { get; set; }

                /// <summary>
                /// The whitelisted objects that are used to avoid DNS hijacking. The objects can be IP addresses, wildcard mask, subnet mask, or CNAME records. Separate multiple objects with vertical bars (|). Example: www.aliyun.com:203.0.3.55|203.3.44.67. It indicates that all IP addresses that belong to the www.aliyun.com domain name except 203.0.3.55 and 203.3.44.67 are hijacked.
                /// </summary>
                [NameInMap("WhiteList")]
                [Validation(Required=false)]
                public string WhiteList { get; set; }

            }

            /// <summary>
            /// The parameters of the DNS synthetic test. This parameter is required if the TaskType parameter is set to 3.
            /// </summary>
            [NameInMap("NetDNS")]
            [Validation(Required=false)]
            public CreateTimingSyntheticTaskRequestMonitorConfNetDNS NetDNS { get; set; }
            public class CreateTimingSyntheticTaskRequestMonitorConfNetDNS : TeaModel {
                /// <summary>
                /// The IP version of the DNS server.
                /// 
                /// *   0 (default): IPv4.
                /// *   1: IPv6.
                /// *   2: A version is automatically selected.
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
                /// The DNS query method. Valid values:
                /// 
                /// *   0 (default): recursive
                /// *   1: iterative
                /// </summary>
                [NameInMap("QueryMethod")]
                [Validation(Required=false)]
                public int? QueryMethod { get; set; }

                /// <summary>
                /// The destination domain name.
                /// 
                /// This parameter is required.
                /// </summary>
                [NameInMap("TargetUrl")]
                [Validation(Required=false)]
                public string TargetUrl { get; set; }

                /// <summary>
                /// The timeout period for the DNS synthetic test. Unit: milliseconds. Minimum value: 1000. Maximum value: 45000. Default value: 5000.
                /// </summary>
                [NameInMap("Timeout")]
                [Validation(Required=false)]
                public long? Timeout { get; set; }

            }

            /// <summary>
            /// The parameters of the ICMP synthetic test. This parameter is required if the TaskType parameter is set to 1.
            /// </summary>
            [NameInMap("NetICMP")]
            [Validation(Required=false)]
            public CreateTimingSyntheticTaskRequestMonitorConfNetICMP NetICMP { get; set; }
            public class CreateTimingSyntheticTaskRequestMonitorConfNetICMP : TeaModel {
                /// <summary>
                /// The interval at which ICMP packets are sent. Unit: milliseconds. Minimum value: 200. Maximum value: 2000. Default value: 200.
                /// </summary>
                [NameInMap("Interval")]
                [Validation(Required=false)]
                public long? Interval { get; set; }

                /// <summary>
                /// The number of ICMP packets that are sent. Minimum value: 1. Maximum value: 50. Default value: 4.
                /// </summary>
                [NameInMap("PackageNum")]
                [Validation(Required=false)]
                public int? PackageNum { get; set; }

                /// <summary>
                /// The size of each ICMP packet. Unit: bytes. Valid values: 32, 64, 128, 256, 512, 1024, 1080, and 1450.
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
                /// The destination IP address or domain name.
                /// 
                /// This parameter is required.
                /// </summary>
                [NameInMap("TargetUrl")]
                [Validation(Required=false)]
                public string TargetUrl { get; set; }

                /// <summary>
                /// The timeout period for the ICMP synthetic test. Unit: milliseconds. Minimum value: 1000. Maximum value: 300000. Default value: 20000.
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
                /// The maximum number of hops for the tracert command. Minimum value: 1. Maximum value: 128. Default value: 20.
                /// </summary>
                [NameInMap("TracertNumMax")]
                [Validation(Required=false)]
                public int? TracertNumMax { get; set; }

                /// <summary>
                /// The timeout period of the tracert command. Unit: milliseconds. Minimum value: 1000. Maximum value: 300000. Default value: 60000.
                /// </summary>
                [NameInMap("TracertTimeout")]
                [Validation(Required=false)]
                public long? TracertTimeout { get; set; }

            }

            /// <summary>
            /// The parameters of the TCP synthetic test. This parameter is required if the TaskType parameter is set to 2.
            /// </summary>
            [NameInMap("NetTCP")]
            [Validation(Required=false)]
            public CreateTimingSyntheticTaskRequestMonitorConfNetTCP NetTCP { get; set; }
            public class CreateTimingSyntheticTaskRequestMonitorConfNetTCP : TeaModel {
                /// <summary>
                /// The number of TCP connections that are established. Minimum value: 1. Maximum value: 16. Default value: 4.
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
                /// The IP address of the destination host.
                /// 
                /// This parameter is required.
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
                /// The maximum number of hops for the tracert command. Minimum value: 1. Maximum value: 128. Default value: 20.
                /// </summary>
                [NameInMap("TracertNumMax")]
                [Validation(Required=false)]
                public int? TracertNumMax { get; set; }

                /// <summary>
                /// The timeout period of the tracert command. Unit: milliseconds. Minimum value: 1000. Maximum value: 300000. Default value: 60000.
                /// </summary>
                [NameInMap("TracertTimeout")]
                [Validation(Required=false)]
                public long? TracertTimeout { get; set; }

            }

            /// <summary>
            /// The parameters of the streaming-media synthetic test.
            /// </summary>
            [NameInMap("Stream")]
            [Validation(Required=false)]
            public CreateTimingSyntheticTaskRequestMonitorConfStream Stream { get; set; }
            public class CreateTimingSyntheticTaskRequestMonitorConfStream : TeaModel {
                /// <summary>
                /// The custom header. Format: JSON map.
                /// </summary>
                [NameInMap("CustomHeaderContent")]
                [Validation(Required=false)]
                public Dictionary<string, string> CustomHeaderContent { get; set; }

                /// <summary>
                /// The player. Default value: 12. Valid values:
                /// 
                /// *   12: VLC
                /// *   2: Flash Player
                /// </summary>
                [NameInMap("PlayerType")]
                [Validation(Required=false)]
                public int? PlayerType { get; set; }

                /// <summary>
                /// The address type of the resource. Valid values:
                /// 
                /// *   1: resource URL
                /// *   0 (default): page URL
                /// </summary>
                [NameInMap("StreamAddressType")]
                [Validation(Required=false)]
                public int? StreamAddressType { get; set; }

                /// <summary>
                /// The monitoring duration. Unit: seconds. Maximum and default value: 60.
                /// </summary>
                [NameInMap("StreamMonitorTimeout")]
                [Validation(Required=false)]
                public int? StreamMonitorTimeout { get; set; }

                /// <summary>
                /// Specifies whether the resource is a video or audio. Valid values: 0: video. 1: audio.
                /// </summary>
                [NameInMap("StreamType")]
                [Validation(Required=false)]
                public int? StreamType { get; set; }

                /// <summary>
                /// The resource URL of the streaming media.
                /// </summary>
                [NameInMap("TargetUrl")]
                [Validation(Required=false)]
                public string TargetUrl { get; set; }

                /// <summary>
                /// The whitelisted objects that are used to avoid DNS hijacking. The objects can be IP addresses, wildcard mask, subnet mask, or CNAME records. Separate multiple objects with vertical bars (|). Example: www.aliyun.com:203.0.3.55|203.3.44.67. It indicates that all IP addresses that belong to the www.aliyun.com domain name except 203.0.3.55 and 203.3.44.67 are hijacked.
                /// </summary>
                [NameInMap("WhiteList")]
                [Validation(Required=false)]
                public string WhiteList { get; set; }

            }

            /// <summary>
            /// The parameters of the website speed measurement.
            /// </summary>
            [NameInMap("Website")]
            [Validation(Required=false)]
            public CreateTimingSyntheticTaskRequestMonitorConfWebsite Website { get; set; }
            public class CreateTimingSyntheticTaskRequestMonitorConfWebsite : TeaModel {
                /// <summary>
                /// Specifies whether to automatically scroll up and down the screen to load a page.
                /// 
                /// *   0 (default): no
                /// *   1: yes
                /// </summary>
                [NameInMap("AutomaticScrolling")]
                [Validation(Required=false)]
                public int? AutomaticScrolling { get; set; }

                /// <summary>
                /// Specifies whether to create a custom header.
                /// 
                /// *   0 (default): No custom header is created.
                /// *   1: A custom header is created for the first packet.
                /// *   2: A custom header is created for all packets.
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
                /// If the IP address or CNAME record resolved from a domain name is not included in the DNS whitelist, you cannot access the domain name, or an IP address that belongs to a different domain name is returned. If the IP address or CNAME record is included in the DNS whitelist, DNS hijacking does not occur.
                /// 
                /// Format: \\<domain name>:\\<objects>. The objects can be IP addresses, wildcard mask, subnet mask, or CNAME records. Separate multiple objects with vertical bars (|). Example: www.aliyun.com:203.0.3.55|203.3.44.67. It indicates that all IP addresses that belong to the www.aliyun.com domain name except 203.0.3.55 and 203.3.44.67 are hijacked.
                /// </summary>
                [NameInMap("DNSHijackWhitelist")]
                [Validation(Required=false)]
                public string DNSHijackWhitelist { get; set; }

                /// <summary>
                /// Specifies whether to disable caching.
                /// 
                /// *   0: no
                /// *   1 (default): yes
                /// </summary>
                [NameInMap("DisableCache")]
                [Validation(Required=false)]
                public int? DisableCache { get; set; }

                /// <summary>
                /// Specifies whether to accept compressed files based on the HTTP Accept-Encoding request header. Valid values: 0: no. 1: yes. Default value: 0.
                /// </summary>
                [NameInMap("DisableCompression")]
                [Validation(Required=false)]
                public int? DisableCompression { get; set; }

                /// <summary>
                /// The elements not to be loaded in the page loading process.
                /// </summary>
                [NameInMap("ElementBlacklist")]
                [Validation(Required=false)]
                public string ElementBlacklist { get; set; }

                /// <summary>
                /// Specifies whether to exclude invalid IP addresses. Valid values: 0: yes. 1: no. Default value: 0.
                /// </summary>
                [NameInMap("FilterInvalidIP")]
                [Validation(Required=false)]
                public int? FilterInvalidIP { get; set; }

                /// <summary>
                /// The total number of elements on the page.
                /// </summary>
                [NameInMap("FlowHijackJumpTimes")]
                [Validation(Required=false)]
                public int? FlowHijackJumpTimes { get; set; }

                /// <summary>
                /// The keyword that is used to identify hijacking. Asterisks (\\*) are allowed.
                /// </summary>
                [NameInMap("FlowHijackLogo")]
                [Validation(Required=false)]
                public string FlowHijackLogo { get; set; }

                /// <summary>
                /// Specifies whether to ignore certificate errors during certificate verification in the SSL handshake process and continue browsing. Valid values: 0: no. 1: yes. Default value: 1.
                /// </summary>
                [NameInMap("IgnoreCertificateError")]
                [Validation(Required=false)]
                public int? IgnoreCertificateError { get; set; }

                /// <summary>
                /// The monitoring timeout period. Unit: milliseconds. This parameter is optional. Default value: 20000.
                /// </summary>
                [NameInMap("MonitorTimeout")]
                [Validation(Required=false)]
                public long? MonitorTimeout { get; set; }

                /// <summary>
                /// Elements that are not included in the whitelist and appear on the page are tampered with. These elements can be pop-up ads, floating ads, and page redirection.
                /// 
                /// Format: \\<domain name>:\\<elements>. The elements can be wildcard masks. Separate multiple elements with vertical bars (|). Example: www.aliyun.com:|/cc/bb/a.gif|/vv/bb/cc.jpg. It indicates that all elements that belong to the www.aliyun.com domain name except the basic documents, /cc/bb/a.gif, and /vv/bb/cc.jpg are tampered with.
                /// </summary>
                [NameInMap("PageTamper")]
                [Validation(Required=false)]
                public string PageTamper { get; set; }

                /// <summary>
                /// Specifies whether to continue browsing after redirection. Valid values: 0: no. 1: yes. Default value: 1.
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
                /// The URL of the website.
                /// 
                /// This parameter is required.
                /// </summary>
                [NameInMap("TargetUrl")]
                [Validation(Required=false)]
                public string TargetUrl { get; set; }

                /// <summary>
                /// An arbitrary string in the source code of the page for verification. If the source code returned by the client contains a string that is in the blacklist, the 650 error code is reported, which indicates that the string fails to be verified. Separate multiple strings with vertical bars (|).
                /// </summary>
                [NameInMap("VerifyStringBlacklist")]
                [Validation(Required=false)]
                public string VerifyStringBlacklist { get; set; }

                /// <summary>
                /// An arbitrary string in the source code of the page for verification. If the source code returned by the client contains a string that is not in the whitelist, the 650 error code is reported, which indicates that the string fails to be verified. Separate multiple strings with vertical bars (|).
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
        /// The list of detection points.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Monitors")]
        [Validation(Required=false)]
        public List<CreateTimingSyntheticTaskRequestMonitors> Monitors { get; set; }
        public class CreateTimingSyntheticTaskRequestMonitors : TeaModel {
            /// <summary>
            /// The city code.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("CityCode")]
            [Validation(Required=false)]
            public string CityCode { get; set; }

            /// <summary>
            /// The client type of the detection point. Valid values:
            /// 
            /// - 1: data center
            /// - 2: Internet
            /// - 3: mobile device
            /// - 4: ECS instance
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("ClientType")]
            [Validation(Required=false)]
            public int? ClientType { get; set; }

            /// <summary>
            /// The carrier code.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("OperatorCode")]
            [Validation(Required=false)]
            public string OperatorCode { get; set; }

        }

        /// <summary>
        /// The name of the task.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The region ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The parameter is optional.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The tag list.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<CreateTimingSyntheticTaskRequestTags> Tags { get; set; }
        public class CreateTimingSyntheticTaskRequestTags : TeaModel {
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
        /// The type of the task. Valid values:
        /// 
        /// 1: ICMP. 2: TCP. 3: DNS. 4: HTTP. 5: website speed measurement. 6: file download.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public int? TaskType { get; set; }

    }

}
