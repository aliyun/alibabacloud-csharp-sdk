// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GetSyntheticTaskDetailResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The details of the task.
        /// </summary>
        [NameInMap("TaskDetail")]
        [Validation(Required=false)]
        public GetSyntheticTaskDetailResponseBodyTaskDetail TaskDetail { get; set; }
        public class GetSyntheticTaskDetailResponseBodyTaskDetail : TeaModel {
            /// <summary>
            /// The list of common parameters.
            /// </summary>
            [NameInMap("CommonParam")]
            [Validation(Required=false)]
            public GetSyntheticTaskDetailResponseBodyTaskDetailCommonParam CommonParam { get; set; }
            public class GetSyntheticTaskDetailResponseBodyTaskDetailCommonParam : TeaModel {
                /// <summary>
                /// The identifier of the alert.
                /// </summary>
                [NameInMap("AlarmFlag")]
                [Validation(Required=false)]
                public long? AlarmFlag { get; set; }

                /// <summary>
                /// The list of alerts.
                /// </summary>
                [NameInMap("AlertList")]
                [Validation(Required=false)]
                public List<GetSyntheticTaskDetailResponseBodyTaskDetailCommonParamAlertList> AlertList { get; set; }
                public class GetSyntheticTaskDetailResponseBodyTaskDetailCommonParamAlertList : TeaModel {
                    /// <summary>
                    /// The low-risk alert.
                    /// </summary>
                    [NameInMap("GeneralAlert")]
                    [Validation(Required=false)]
                    public string GeneralAlert { get; set; }

                    /// <summary>
                    /// Indicates whether the condition is essential.
                    /// </summary>
                    [NameInMap("IsCritical")]
                    [Validation(Required=false)]
                    public string IsCritical { get; set; }

                    /// <summary>
                    /// The alert name.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The Critical-level alert.
                    /// </summary>
                    [NameInMap("SeriousAlert")]
                    [Validation(Required=false)]
                    public string SeriousAlert { get; set; }

                    /// <summary>
                    /// Greater than or less than.
                    /// </summary>
                    [NameInMap("Symbols")]
                    [Validation(Required=false)]
                    public string Symbols { get; set; }

                }

                /// <summary>
                /// The ID of the alert identifier.
                /// </summary>
                [NameInMap("AlertNotifierId")]
                [Validation(Required=false)]
                public string AlertNotifierId { get; set; }

                /// <summary>
                /// The ID of the alert policy.
                /// </summary>
                [NameInMap("AlertPolicyId")]
                [Validation(Required=false)]
                public string AlertPolicyId { get; set; }

                /// <summary>
                /// The monitoring samples.
                /// </summary>
                [NameInMap("MonitorSamples")]
                [Validation(Required=false)]
                public string MonitorSamples { get; set; }

                /// <summary>
                /// The start time of the execution.
                /// </summary>
                [NameInMap("StartExecutionTime")]
                [Validation(Required=false)]
                public string StartExecutionTime { get; set; }

            }

            /// <summary>
            /// The file download task.
            /// </summary>
            [NameInMap("Download")]
            [Validation(Required=false)]
            public GetSyntheticTaskDetailResponseBodyTaskDetailDownload Download { get; set; }
            public class GetSyntheticTaskDetailResponseBodyTaskDetailDownload : TeaModel {
                /// <summary>
                /// The timeout period of the file download task.
                /// </summary>
                [NameInMap("ConnectionTimeout")]
                [Validation(Required=false)]
                public long? ConnectionTimeout { get; set; }

                /// <summary>
                /// The items to be ignored in a certificate error. Multiple values are concatenated with vertical bars (|).
                /// </summary>
                [NameInMap("DownloadCustomHeaderContent")]
                [Validation(Required=false)]
                public string DownloadCustomHeaderContent { get; set; }

                /// <summary>
                /// The custom host. Valid values:
                /// 
                /// *   1: round robin
                /// *   0: random
                /// </summary>
                [NameInMap("DownloadCustomHost")]
                [Validation(Required=false)]
                public long? DownloadCustomHost { get; set; }

                /// <summary>
                /// The custom IP address of the host. Multiple IP addresses are separated with commas (,).
                /// </summary>
                [NameInMap("DownloadCustomHostIp")]
                [Validation(Required=false)]
                public string DownloadCustomHostIp { get; set; }

                /// <summary>
                /// The kernel type. Valid values:
                /// 
                /// *   1: curl
                /// *   0: WinInet
                /// </summary>
                [NameInMap("DownloadKernel")]
                [Validation(Required=false)]
                public long? DownloadKernel { get; set; }

                /// <summary>
                /// Indicates whether redirection is supported.
                /// </summary>
                [NameInMap("DownloadRedirect")]
                [Validation(Required=false)]
                public long? DownloadRedirect { get; set; }

                /// <summary>
                /// The file size. Unit: KB.
                /// </summary>
                [NameInMap("DownloadTransmissionSize")]
                [Validation(Required=false)]
                public long? DownloadTransmissionSize { get; set; }

                /// <summary>
                /// The monitoring duration.
                /// </summary>
                [NameInMap("MonitorTimeout")]
                [Validation(Required=false)]
                public long? MonitorTimeout { get; set; }

                /// <summary>
                /// The QUIC protocol type. Valid values:
                /// 
                /// *   1: HTTP/1
                /// *   2: HTTP/2
                /// *   3: http3
                /// </summary>
                [NameInMap("QuickProtocol")]
                [Validation(Required=false)]
                public string QuickProtocol { get; set; }

                /// <summary>
                /// The keyword that is used in verification.
                /// </summary>
                [NameInMap("ValidateKeywords")]
                [Validation(Required=false)]
                public string ValidateKeywords { get; set; }

                /// <summary>
                /// The method that is used to verify the response content. Valid values:
                /// 
                /// *   0: no verification.
                /// *   1: exact match with the verification string.
                /// *   2: partial match with the verification string.
                /// *   3: MD5 verification.
                /// </summary>
                [NameInMap("VerifyWay")]
                [Validation(Required=false)]
                public long? VerifyWay { get; set; }

                /// <summary>
                /// The whitelisted objects that are used to avoid DNS hijacking. Format: `<domain name>:<objects>`.
                /// 
                /// >  WAP networks do not support hijacking.
                /// </summary>
                [NameInMap("WhiteList")]
                [Validation(Required=false)]
                public string WhiteList { get; set; }

            }

            /// <summary>
            /// The frequency.
            /// </summary>
            [NameInMap("ExtendInterval")]
            [Validation(Required=false)]
            public GetSyntheticTaskDetailResponseBodyTaskDetailExtendInterval ExtendInterval { get; set; }
            public class GetSyntheticTaskDetailResponseBodyTaskDetailExtendInterval : TeaModel {
                /// <summary>
                /// The day on which synthetic monitoring is performed. Valid values:
                /// 
                /// *   \\-1: every day
                /// *   0: Sunday
                /// *   1: Monday
                /// *   2: Tuesday
                /// *   3: Wednesday
                /// *   4: Thursday
                /// *   5: Friday
                /// *   6: Saturday
                /// </summary>
                [NameInMap("Days")]
                [Validation(Required=false)]
                public List<long?> Days { get; set; }

                /// <summary>
                /// The minute at which synthetic monitoring ends.
                /// </summary>
                [NameInMap("EndMinute")]
                [Validation(Required=false)]
                public long? EndMinute { get; set; }

                /// <summary>
                /// The time when synthetic monitoring ends. Format: `yyyy-MM-dd HH`.
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// The hour at which synthetic monitoring ends.
                /// </summary>
                [NameInMap("Endhour")]
                [Validation(Required=false)]
                public long? Endhour { get; set; }

                /// <summary>
                /// The hour at which synthetic monitoring starts.
                /// </summary>
                [NameInMap("StartHour")]
                [Validation(Required=false)]
                public long? StartHour { get; set; }

                /// <summary>
                /// The minute at which synthetic monitoring starts.
                /// </summary>
                [NameInMap("StartMinute")]
                [Validation(Required=false)]
                public long? StartMinute { get; set; }

                /// <summary>
                /// The time when synthetic monitoring starts. Format: yyyy-MM-dd HH.
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

            }

            /// <summary>
            /// The interval at which synthetic monitoring is performed. Unit: minutes. Valid values:
            /// 
            /// *   1
            /// *   5
            /// *   10
            /// *   15
            /// *   20
            /// *   30
            /// *   60
            /// *   120
            /// *   180
            /// *   240
            /// *   360
            /// *   480
            /// *   720
            /// *   1440
            /// </summary>
            [NameInMap("IntervalTime")]
            [Validation(Required=false)]
            public long? IntervalTime { get; set; }

            /// <summary>
            /// The interval type. Valid values:
            /// 
            /// *   0: daily
            /// *   1: custom frequency
            /// </summary>
            [NameInMap("IntervalType")]
            [Validation(Required=false)]
            public long? IntervalType { get; set; }

            /// <summary>
            /// The IP version. Valid values:
            /// 
            /// *   0: A version is automatically selected.
            /// *   1: IPv4.
            /// *   2: IPv6.
            /// </summary>
            [NameInMap("IpType")]
            [Validation(Required=false)]
            public long? IpType { get; set; }

            /// <summary>
            /// The detection points.
            /// </summary>
            [NameInMap("MonitorList")]
            [Validation(Required=false)]
            public List<GetSyntheticTaskDetailResponseBodyTaskDetailMonitorList> MonitorList { get; set; }
            public class GetSyntheticTaskDetailResponseBodyTaskDetailMonitorList : TeaModel {
                /// <summary>
                /// The city code.
                /// </summary>
                [NameInMap("CityCode")]
                [Validation(Required=false)]
                public long? CityCode { get; set; }

                /// <summary>
                /// The type of the detection point.
                /// </summary>
                [NameInMap("MonitorType")]
                [Validation(Required=false)]
                public long? MonitorType { get; set; }

                /// <summary>
                /// The ID of the network service.
                /// </summary>
                [NameInMap("NetServiceId")]
                [Validation(Required=false)]
                public long? NetServiceId { get; set; }

                /// <summary>
                /// The number of times that the system sends detection requests.
                /// </summary>
                [NameInMap("SendCount")]
                [Validation(Required=false)]
                public long? SendCount { get; set; }

            }

            /// <summary>
            /// The detection points.
            /// </summary>
            [NameInMap("MonitorListString")]
            [Validation(Required=false)]
            public string MonitorListString { get; set; }

            /// <summary>
            /// The browser test task.
            /// </summary>
            [NameInMap("Nav")]
            [Validation(Required=false)]
            public GetSyntheticTaskDetailResponseBodyTaskDetailNav Nav { get; set; }
            public class GetSyntheticTaskDetailResponseBodyTaskDetailNav : TeaModel {
                /// <summary>
                /// The DNS whitelist.
                /// </summary>
                [NameInMap("DnsHijackWhitelist")]
                [Validation(Required=false)]
                public string DnsHijackWhitelist { get; set; }

                /// <summary>
                /// The element blacklist.
                /// </summary>
                [NameInMap("ElementBlacklist")]
                [Validation(Required=false)]
                public string ElementBlacklist { get; set; }

                /// <summary>
                /// Indicates whether ActiveX is executed. Valid values:
                /// 
                /// *   3: yes
                /// *   0: no
                /// 
                /// >  Only IE elements support this parameter.
                /// </summary>
                [NameInMap("ExecuteActiveX")]
                [Validation(Required=false)]
                public long? ExecuteActiveX { get; set; }

                /// <summary>
                /// Indicates whether the applet is executed. Valid values:
                /// 
                /// *   0: no
                /// *   1: yes
                /// </summary>
                [NameInMap("ExecuteApplet")]
                [Validation(Required=false)]
                public long? ExecuteApplet { get; set; }

                /// <summary>
                /// Indicates whether scripts are executed. Valid values:
                /// 
                /// *   1: yes
                /// *   0: no
                /// 
                /// >  Only IE elements support this parameter.
                /// </summary>
                [NameInMap("ExecuteScript")]
                [Validation(Required=false)]
                public long? ExecuteScript { get; set; }

                /// <summary>
                /// Indicates whether invalid IP addresses are excluded. Valid values:
                /// 
                /// *   1: no
                /// *   0: yes
                /// </summary>
                [NameInMap("FilterInvalidIP")]
                [Validation(Required=false)]
                public long? FilterInvalidIP { get; set; }

                /// <summary>
                /// The element that is used in DNS hijacking.
                /// </summary>
                [NameInMap("FlowHijackJumpTimes")]
                [Validation(Required=false)]
                public long? FlowHijackJumpTimes { get; set; }

                /// <summary>
                /// The tag that is used in DNS hijacking.
                /// </summary>
                [NameInMap("FlowHijackLogo")]
                [Validation(Required=false)]
                public string FlowHijackLogo { get; set; }

                /// <summary>
                /// The monitoring timeout period.
                /// </summary>
                [NameInMap("MonitorTimeout")]
                [Validation(Required=false)]
                public long? MonitorTimeout { get; set; }

                /// <summary>
                /// Indicates whether the screen is automatically scrolled up and down to load a page. Valid values:
                /// 
                /// *   1: yes
                /// *   0: no
                /// </summary>
                [NameInMap("NavAutomaticScrolling")]
                [Validation(Required=false)]
                public long? NavAutomaticScrolling { get; set; }

                /// <summary>
                /// Indicates whether a custom header is created. Valid values:
                /// 
                /// *   0: no
                /// *   1: A custom header is created for the first packet.
                /// *   2: A custom header is created for all packets.
                /// </summary>
                [NameInMap("NavCustomHeader")]
                [Validation(Required=false)]
                public string NavCustomHeader { get; set; }

                /// <summary>
                /// The format of the custom header. Multiple fields are separated with vertical bars (|).
                /// </summary>
                [NameInMap("NavCustomHeaderContent")]
                [Validation(Required=false)]
                public string NavCustomHeaderContent { get; set; }

                /// <summary>
                /// The custom host mode. Valid values:
                /// 
                /// *   1: round robin
                /// *   0: random
                /// </summary>
                [NameInMap("NavCustomHost")]
                [Validation(Required=false)]
                public long? NavCustomHost { get; set; }

                /// <summary>
                /// The custom IP address of the host. Multiple IP addresses are separated with commas (,).
                /// </summary>
                [NameInMap("NavCustomHostIp")]
                [Validation(Required=false)]
                public string NavCustomHostIp { get; set; }

                /// <summary>
                /// Indicates whether caching is disabled. Valid values:
                /// 
                /// *   1: Caching is disabled.
                /// *   0: Caching is enabled.
                /// </summary>
                [NameInMap("NavDisableCache")]
                [Validation(Required=false)]
                public long? NavDisableCache { get; set; }

                /// <summary>
                /// Indicates whether compression is disabled. Valid values:
                /// 
                /// *   0: Compression is enabled.
                /// *   1: Compression is disabled.
                /// </summary>
                [NameInMap("NavDisableCompression")]
                [Validation(Required=false)]
                public long? NavDisableCompression { get; set; }

                /// <summary>
                /// Indicates whether certificate errors are ignored during certificate verification in the SSL handshake. Valid values:
                /// 
                /// *   1: yes
                /// *   0: no
                /// </summary>
                [NameInMap("NavIgnoreCertificateError")]
                [Validation(Required=false)]
                public long? NavIgnoreCertificateError { get; set; }

                /// <summary>
                /// Indicates whether redirection is enabled. Valid values:
                /// 
                /// *   0: no
                /// *   1: yes
                /// </summary>
                [NameInMap("NavRedirect")]
                [Validation(Required=false)]
                public long? NavRedirect { get; set; }

                /// <summary>
                /// Indicates whether the elements on the page are returned.
                /// 
                /// *   1: no. The basic document data is returned.
                /// *   2: yes. All document data is returned.
                /// </summary>
                [NameInMap("NavReturnElement")]
                [Validation(Required=false)]
                public long? NavReturnElement { get; set; }

                /// <summary>
                /// The page tampering.
                /// </summary>
                [NameInMap("PageTampering")]
                [Validation(Required=false)]
                public string PageTampering { get; set; }

                /// <summary>
                /// The process ID.
                /// </summary>
                [NameInMap("ProcessName")]
                [Validation(Required=false)]
                public string ProcessName { get; set; }

                /// <summary>
                /// The domain name of the QUIC request element.
                /// </summary>
                [NameInMap("QuicDomain")]
                [Validation(Required=false)]
                public string QuicDomain { get; set; }

                /// <summary>
                /// The QUIC version. Default value: 0. Valid values:
                /// 
                /// *   35
                /// *   39
                /// *   43
                /// *   44
                /// 
                /// >  Only Chrome elements support this parameter.
                /// </summary>
                [NameInMap("QuicVersion")]
                [Validation(Required=false)]
                public long? QuicVersion { get; set; }

                /// <summary>
                /// Indicates whether request headers are returned. Valid values:
                /// 
                /// *   0: no
                /// *   1: The headers of base documents are returned.
                /// *   2: All headers are returned.
                /// </summary>
                [NameInMap("RequestHeader")]
                [Validation(Required=false)]
                public long? RequestHeader { get; set; }

                /// <summary>
                /// The time threshold that is used to define a slow element. Unit: seconds.
                /// </summary>
                [NameInMap("SlowElementThreshold")]
                [Validation(Required=false)]
                public long? SlowElementThreshold { get; set; }

                /// <summary>
                /// The blacklist for string verification.
                /// </summary>
                [NameInMap("VerifyStringBlacklist")]
                [Validation(Required=false)]
                public string VerifyStringBlacklist { get; set; }

                /// <summary>
                /// The whitelist for string verification.
                /// </summary>
                [NameInMap("VerifyStringWhitelist")]
                [Validation(Required=false)]
                public string VerifyStringWhitelist { get; set; }

                /// <summary>
                /// The timeout period of waiting for the monitoring to complete.
                /// </summary>
                [NameInMap("WaitCompletionTime")]
                [Validation(Required=false)]
                public long? WaitCompletionTime { get; set; }

            }

            /// <summary>
            /// The network synthetic monitoring task.
            /// </summary>
            [NameInMap("Net")]
            [Validation(Required=false)]
            public GetSyntheticTaskDetailResponseBodyTaskDetailNet Net { get; set; }
            public class GetSyntheticTaskDetailResponseBodyTaskDetailNet : TeaModel {
                /// <summary>
                /// Indicates whether the data is displayed in the DIG format. Valid values:
                /// 
                /// *   0: no
                /// *   1: yes
                /// </summary>
                [NameInMap("NetDigSwitch")]
                [Validation(Required=false)]
                public long? NetDigSwitch { get; set; }

                /// <summary>
                /// The NS server.
                /// </summary>
                [NameInMap("NetDnsNs")]
                [Validation(Required=false)]
                public string NetDnsNs { get; set; }

                /// <summary>
                /// The DNS query method. Valid values:
                /// 
                /// *   1: recursive
                /// *   2: iterative
                /// </summary>
                [NameInMap("NetDnsQueryMethod")]
                [Validation(Required=false)]
                public string NetDnsQueryMethod { get; set; }

                /// <summary>
                /// The type of the DNS server. Valid values:
                /// 
                /// *   0: ipv4
                /// *   1: ipv6
                /// *   2: A version is automatically selected.
                /// </summary>
                [NameInMap("NetDnsServer")]
                [Validation(Required=false)]
                public long? NetDnsServer { get; set; }

                /// <summary>
                /// Indicates whether DNS test is enabled. Valid values:
                /// 
                /// *   0: no
                /// *   1: yes
                /// </summary>
                [NameInMap("NetDnsSwitch")]
                [Validation(Required=false)]
                public long? NetDnsSwitch { get; set; }

                /// <summary>
                /// The timeout period of DNS requests.
                /// </summary>
                [NameInMap("NetDnsTimeout")]
                [Validation(Required=false)]
                public string NetDnsTimeout { get; set; }

                /// <summary>
                /// The protocol type. Valid values:
                /// 
                /// *   0 : ICMP
                /// *   1 : TCP
                /// </summary>
                [NameInMap("NetIcmpActive")]
                [Validation(Required=false)]
                public long? NetIcmpActive { get; set; }

                /// <summary>
                /// Indicates whether packets are split. Valid values:
                /// 
                /// *   0: no
                /// *   1: yes
                /// </summary>
                [NameInMap("NetIcmpDataCut")]
                [Validation(Required=false)]
                public long? NetIcmpDataCut { get; set; }

                /// <summary>
                /// The interval at which the synthetic monitoring task is executed.
                /// </summary>
                [NameInMap("NetIcmpInterval")]
                [Validation(Required=false)]
                public long? NetIcmpInterval { get; set; }

                /// <summary>
                /// The number of packets.
                /// </summary>
                [NameInMap("NetIcmpNum")]
                [Validation(Required=false)]
                public long? NetIcmpNum { get; set; }

                /// <summary>
                /// The packet size.
                /// </summary>
                [NameInMap("NetIcmpSize")]
                [Validation(Required=false)]
                public long? NetIcmpSize { get; set; }

                /// <summary>
                /// Indicates whether ICMP test is enabled. Valid values:
                /// 
                /// *   0: no.
                /// *   1: yes. If you set this parameter to 1, you must also set the Icmp parameter.
                /// </summary>
                [NameInMap("NetIcmpSwitch")]
                [Validation(Required=false)]
                public long? NetIcmpSwitch { get; set; }

                /// <summary>
                /// The monitoring timeout period.
                /// </summary>
                [NameInMap("NetIcmpTimeout")]
                [Validation(Required=false)]
                public long? NetIcmpTimeout { get; set; }

                /// <summary>
                /// The maximum number of active detection points.
                /// </summary>
                [NameInMap("NetTraceRouteNum")]
                [Validation(Required=false)]
                public long? NetTraceRouteNum { get; set; }

                /// <summary>
                /// Indicates whether Tracert test is enabled. Valid values:
                /// 
                /// *   0: no
                /// *   1: yes. If you set this parameter to 1, you must also set the Tracert parameter.
                /// </summary>
                [NameInMap("NetTraceRouteSwitch")]
                [Validation(Required=false)]
                public long? NetTraceRouteSwitch { get; set; }

                /// <summary>
                /// The monitoring timeout period. Valid values: 0 to 300. Unit: seconds.
                /// </summary>
                [NameInMap("NetTraceRouteTimeout")]
                [Validation(Required=false)]
                public long? NetTraceRouteTimeout { get; set; }

                /// <summary>
                /// The whitelisted objects that are used to avoid DNS hijacking. Format: `<domain name>:<objects>`.
                /// 
                /// >  WAP networks do not support hijacking.
                /// </summary>
                [NameInMap("WhiteList")]
                [Validation(Required=false)]
                public string WhiteList { get; set; }

            }

            /// <summary>
            /// The synthetic monitoring task of the API performance type.
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public GetSyntheticTaskDetailResponseBodyTaskDetailProtocol Protocol { get; set; }
            public class GetSyntheticTaskDetailResponseBodyTaskDetailProtocol : TeaModel {
                /// <summary>
                /// The encoding format. Valid values:
                /// 
                /// *   0: UTF-8
                /// *   1: GBK
                /// *   2: GB2312
                /// *   3: Unicode
                /// </summary>
                [NameInMap("CharacterEncoding")]
                [Validation(Required=false)]
                public long? CharacterEncoding { get; set; }

                /// <summary>
                /// The custom host. Valid values:
                /// 
                /// *   1: round robin
                /// *   0: random
                /// </summary>
                [NameInMap("CustomHost")]
                [Validation(Required=false)]
                public long? CustomHost { get; set; }

                /// <summary>
                /// The custom IP address of the host. Multiple IP addresses are separated with commas (,).
                /// </summary>
                [NameInMap("CustomHostIp")]
                [Validation(Required=false)]
                public string CustomHostIp { get; set; }

                /// <summary>
                /// The timeout period.
                /// </summary>
                [NameInMap("ProtocolConnectionTimeout")]
                [Validation(Required=false)]
                public long? ProtocolConnectionTimeout { get; set; }

                /// <summary>
                /// The timeout period of API performance monitoring. Unit: seconds.
                /// </summary>
                [NameInMap("ProtocolMonitorTimeout")]
                [Validation(Required=false)]
                public long? ProtocolMonitorTimeout { get; set; }

                /// <summary>
                /// The size of the received data. This parameter is returned when **VerifyWay** is set to 2.
                /// </summary>
                [NameInMap("ReceivedDataSize")]
                [Validation(Required=false)]
                public long? ReceivedDataSize { get; set; }

                /// <summary>
                /// The request content, including the header and body.
                /// </summary>
                [NameInMap("RequestContent")]
                [Validation(Required=false)]
                public GetSyntheticTaskDetailResponseBodyTaskDetailProtocolRequestContent RequestContent { get; set; }
                public class GetSyntheticTaskDetailResponseBodyTaskDetailProtocolRequestContent : TeaModel {
                    /// <summary>
                    /// The content of the request body.
                    /// </summary>
                    [NameInMap("Body")]
                    [Validation(Required=false)]
                    public GetSyntheticTaskDetailResponseBodyTaskDetailProtocolRequestContentBody Body { get; set; }
                    public class GetSyntheticTaskDetailResponseBodyTaskDetailProtocolRequestContentBody : TeaModel {
                        /// <summary>
                        /// The data content. This parameter is returned when Mode is set to form-data.
                        /// </summary>
                        [NameInMap("Formdata")]
                        [Validation(Required=false)]
                        public GetSyntheticTaskDetailResponseBodyTaskDetailProtocolRequestContentBodyFormdata Formdata { get; set; }
                        public class GetSyntheticTaskDetailResponseBodyTaskDetailProtocolRequestContentBodyFormdata : TeaModel {
                            /// <summary>
                            /// The key of the **form-data**.
                            /// </summary>
                            [NameInMap("Key")]
                            [Validation(Required=false)]
                            public string Key { get; set; }

                            /// <summary>
                            /// The value of the form-data.
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                        /// <summary>
                        /// The language used when Mode is set to raw. Valid values:
                        /// 
                        /// *   json
                        /// *   xml
                        /// *   javascript
                        /// *   html
                        /// *   text
                        /// </summary>
                        [NameInMap("Language")]
                        [Validation(Required=false)]
                        public string Language { get; set; }

                        /// <summary>
                        /// The type of the content. Valid values:
                        /// 
                        /// *   form-data
                        /// *   x-www-form-urlencoded
                        /// *   raw
                        /// </summary>
                        [NameInMap("Mode")]
                        [Validation(Required=false)]
                        public string Mode { get; set; }

                        /// <summary>
                        /// The data content. This parameter is returned when **Mode** is set to **raw**.
                        /// </summary>
                        [NameInMap("Raw")]
                        [Validation(Required=false)]
                        public string Raw { get; set; }

                        /// <summary>
                        /// The URL of the body content.
                        /// </summary>
                        [NameInMap("Urlencoded")]
                        [Validation(Required=false)]
                        public GetSyntheticTaskDetailResponseBodyTaskDetailProtocolRequestContentBodyUrlencoded Urlencoded { get; set; }
                        public class GetSyntheticTaskDetailResponseBodyTaskDetailProtocolRequestContentBodyUrlencoded : TeaModel {
                            /// <summary>
                            /// The tag key.
                            /// </summary>
                            [NameInMap("Key")]
                            [Validation(Required=false)]
                            public string Key { get; set; }

                            /// <summary>
                            /// The tag value.
                            /// </summary>
                            [NameInMap("Value")]
                            [Validation(Required=false)]
                            public string Value { get; set; }

                        }

                    }

                    /// <summary>
                    /// The request header.
                    /// </summary>
                    [NameInMap("Header")]
                    [Validation(Required=false)]
                    public List<GetSyntheticTaskDetailResponseBodyTaskDetailProtocolRequestContentHeader> Header { get; set; }
                    public class GetSyntheticTaskDetailResponseBodyTaskDetailProtocolRequestContentHeader : TeaModel {
                        /// <summary>
                        /// The key of the header in the request parameters.
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// The value of the header in the request parameters.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// The request method. Valid values:
                    /// 
                    /// *   POST
                    /// *   GET
                    /// </summary>
                    [NameInMap("Method")]
                    [Validation(Required=false)]
                    public string Method { get; set; }

                }

                /// <summary>
                /// The verification string.
                /// </summary>
                [NameInMap("VerifyContent")]
                [Validation(Required=false)]
                public string VerifyContent { get; set; }

                /// <summary>
                /// The method that is used to verify the response content. Valid values:
                /// 
                /// *   0: no verification.
                /// *   1: exact match with the verification string.
                /// *   2: partial match with the verification string.
                /// *   3: MD5 verification.
                /// </summary>
                [NameInMap("VerifyWay")]
                [Validation(Required=false)]
                public long? VerifyWay { get; set; }

            }

            /// <summary>
            /// The ID of the synthetic monitoring task.
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public long? TaskId { get; set; }

            /// <summary>
            /// The name of the task.
            /// </summary>
            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            /// <summary>
            /// The type of the task. Valid values:
            /// 
            /// 1.  3: web page performance - IE
            /// 2.  34: web page performance - Chrome
            /// 3.  0: network quality
            /// 4.  40: file download
            /// 5.  7: API performance
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public long? TaskType { get; set; }

            /// <summary>
            /// The URL for synthetic monitoring.
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

    }

}
