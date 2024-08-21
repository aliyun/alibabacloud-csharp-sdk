// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class CreateSyntheticTaskRequest : TeaModel {
        /// <summary>
        /// The common parameters.
        /// </summary>
        [NameInMap("CommonParam")]
        [Validation(Required=false)]
        public CreateSyntheticTaskRequestCommonParam CommonParam { get; set; }
        public class CreateSyntheticTaskRequestCommonParam : TeaModel {
            /// <summary>
            /// Specifies whether to create an alert rule.
            /// 
            /// *   1: creates an alert.
            /// *   0: does not create an alert.
            /// </summary>
            [NameInMap("AlarmFlag")]
            [Validation(Required=false)]
            public string AlarmFlag { get; set; }

            /// <summary>
            /// The alert parameters.
            /// </summary>
            [NameInMap("AlertList")]
            [Validation(Required=false)]
            public List<CreateSyntheticTaskRequestCommonParamAlertList> AlertList { get; set; }
            public class CreateSyntheticTaskRequestCommonParamAlertList : TeaModel {
                /// <summary>
                /// Specifies whether the condition must be met.
                /// </summary>
                [NameInMap("IsCritical")]
                [Validation(Required=false)]
                public long? IsCritical { get; set; }

                /// <summary>
                /// The name of the alert rule.
                /// 
                /// For network synthetic monitoring, use the following names:
                /// 
                /// *   Latency: PING_SET
                /// *   Packet loss rate: PING_LOST_RATE
                /// *   Hijacking: HIJACKPER
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// Specifies how the condition is evaluated. Valid values:
                /// 
                /// *   1: greater than
                /// *   0: less than
                /// </summary>
                [NameInMap("Symbols")]
                [Validation(Required=false)]
                public long? Symbols { get; set; }

            }

            /// <summary>
            /// The ID of the alert recipient. Separate multiple recipients with commas (,).
            /// </summary>
            [NameInMap("AlertNotifierId")]
            [Validation(Required=false)]
            public string AlertNotifierId { get; set; }

            /// <summary>
            /// The ID of the notification policy.
            /// </summary>
            [NameInMap("AlertPolicyId")]
            [Validation(Required=false)]
            public string AlertPolicyId { get; set; }

            /// <summary>
            /// Specifies whether to evenly distribute monitoring samples. Valid values:
            /// 
            /// *   0: no
            /// *   1: yes
            /// </summary>
            [NameInMap("MonitorSamples")]
            [Validation(Required=false)]
            public long? MonitorSamples { get; set; }

            /// <summary>
            /// The time when execution starts.
            /// </summary>
            [NameInMap("StartExecutionTime")]
            [Validation(Required=false)]
            public long? StartExecutionTime { get; set; }

        }

        /// <summary>
        /// The file download task.
        /// </summary>
        [NameInMap("Download")]
        [Validation(Required=false)]
        public CreateSyntheticTaskRequestDownload Download { get; set; }
        public class CreateSyntheticTaskRequestDownload : TeaModel {
            /// <summary>
            /// The connection timeout period.
            /// </summary>
            [NameInMap("ConnectionTimeout")]
            [Validation(Required=false)]
            public double? ConnectionTimeout { get; set; }

            /// <summary>
            /// The items to be ignored in a certificate error. Pass the values of the check boxes that are separated with vertical bars (|).
            /// </summary>
            [NameInMap("DownloadCustomHeaderContent")]
            [Validation(Required=false)]
            public string DownloadCustomHeaderContent { get; set; }

            /// <summary>
            /// The custom host mode.
            /// 
            /// *   1: round robin
            /// *   0: random
            /// </summary>
            [NameInMap("DownloadCustomHost")]
            [Validation(Required=false)]
            public long? DownloadCustomHost { get; set; }

            /// <summary>
            /// The custom host IP address. You can enter multiple IP addresses. Separate the IP addresses with commas (,).
            /// </summary>
            [NameInMap("DownloadCustomHostIp")]
            [Validation(Required=false)]
            public string DownloadCustomHostIp { get; set; }

            /// <summary>
            /// The items to be ignored in a certificate error. Pass the values of the check boxes that are separated with vertical bars (|).
            /// </summary>
            [NameInMap("DownloadIgnoreCertificateError")]
            [Validation(Required=false)]
            public string DownloadIgnoreCertificateError { get; set; }

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
            /// Specifies whether to support redirection.
            /// </summary>
            [NameInMap("DownloadRedirection")]
            [Validation(Required=false)]
            public long? DownloadRedirection { get; set; }

            /// <summary>
            /// The size of the download file. Unit: KB.
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
            /// The QUIC protocol type.
            /// 
            /// *   1: http1
            /// *   2: http2
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
            /// The verification method.
            /// 
            /// *   0: no verification
            /// *   1: string verification
            /// *   2: MD5 verification
            /// </summary>
            [NameInMap("VerifyWay")]
            [Validation(Required=false)]
            public long? VerifyWay { get; set; }

            /// <summary>
            /// The whitelist for DNS hijacking.
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
        public CreateSyntheticTaskRequestExtendInterval ExtendInterval { get; set; }
        public class CreateSyntheticTaskRequestExtendInterval : TeaModel {
            /// <summary>
            /// The day on which synthetic monitoring is performed.
            /// </summary>
            [NameInMap("Days")]
            [Validation(Required=false)]
            public List<long?> Days { get; set; }

            /// <summary>
            /// The hour at which synthetic monitoring ends.
            /// </summary>
            [NameInMap("EndHour")]
            [Validation(Required=false)]
            public long? EndHour { get; set; }

            /// <summary>
            /// The minute at which synthetic monitoring ends.
            /// </summary>
            [NameInMap("EndMinute")]
            [Validation(Required=false)]
            public long? EndMinute { get; set; }

            /// <summary>
            /// The time when synthetic monitoring ends. The format is `yyyy-MM-dd HH`.
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

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
            /// The time when synthetic monitoring starts. The format is `yyyy-MM-dd HH`.
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
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("IntervalTime")]
        [Validation(Required=false)]
        public string IntervalTime { get; set; }

        /// <summary>
        /// The interval type.
        /// 
        /// *   0: daily
        /// *   1: custom frequency
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("IntervalType")]
        [Validation(Required=false)]
        public string IntervalType { get; set; }

        /// <summary>
        /// The IP address type:
        /// 
        /// *   0: an automatic IP address
        /// *   1: IPv4
        /// *   2: IPv6
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("IpType")]
        [Validation(Required=false)]
        public long? IpType { get; set; }

        /// <summary>
        /// The list of monitoring points.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("MonitorList")]
        [Validation(Required=false)]
        public List<CreateSyntheticTaskRequestMonitorList> MonitorList { get; set; }
        public class CreateSyntheticTaskRequestMonitorList : TeaModel {
            /// <summary>
            /// The ID of the city to which the monitoring point belongs.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("CityCode")]
            [Validation(Required=false)]
            public long? CityCode { get; set; }

            /// <summary>
            /// The carrier type:
            /// 
            /// *   IDC
            /// *   LastMilie
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("MonitorType")]
            [Validation(Required=false)]
            public long? MonitorType { get; set; }

            /// <summary>
            /// The ID of the carrier.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("NetServiceId")]
            [Validation(Required=false)]
            public long? NetServiceId { get; set; }

        }

        /// <summary>
        /// The monitoring items that are associated with the browse tasks.
        /// </summary>
        [NameInMap("Navigation")]
        [Validation(Required=false)]
        public CreateSyntheticTaskRequestNavigation Navigation { get; set; }
        public class CreateSyntheticTaskRequestNavigation : TeaModel {
            /// <summary>
            /// The whitelist for DNS hijacking.
            /// </summary>
            [NameInMap("DNSHijackWhiteList")]
            [Validation(Required=false)]
            public string DNSHijackWhiteList { get; set; }

            /// <summary>
            /// The element blacklist.
            /// </summary>
            [NameInMap("ElementBlacklist")]
            [Validation(Required=false)]
            public string ElementBlacklist { get; set; }

            /// <summary>
            /// Specifies whether to execute ActiveX.
            /// 
            /// *   3: yes
            /// *   0: no
            /// 
            /// >  This parameter is supported only by IE Full Elements.
            /// </summary>
            [NameInMap("ExecuteActiveX")]
            [Validation(Required=false)]
            public long? ExecuteActiveX { get; set; }

            /// <summary>
            /// Specifies whether to run applets.
            /// 
            /// *   1: yes
            /// *   0: no
            /// 
            /// >  This parameter is supported only by IE Full Elements.
            /// </summary>
            [NameInMap("ExecuteApplication")]
            [Validation(Required=false)]
            public long? ExecuteApplication { get; set; }

            /// <summary>
            /// Specifies whether to execute scripts.
            /// 
            /// *   1: yes
            /// *   0: no
            /// 
            /// >  This parameter is supported only by IE Full Elements.
            /// </summary>
            [NameInMap("ExecuteScript")]
            [Validation(Required=false)]
            public long? ExecuteScript { get; set; }

            /// <summary>
            /// Specifies whether to filter invalid IP addresses.
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
            /// The timeout period of monitoring. Unit: seconds.
            /// </summary>
            [NameInMap("MonitorTimeout")]
            [Validation(Required=false)]
            public string MonitorTimeout { get; set; }

            /// <summary>
            /// Specifies whether to automatically scroll up and down the screen to load a page.
            /// 
            /// *   1: yes
            /// *   0: no
            /// </summary>
            [NameInMap("NavAutomaticScrolling")]
            [Validation(Required=false)]
            public string NavAutomaticScrolling { get; set; }

            /// <summary>
            /// The method that is used to customize the header. Valid values:
            /// 
            /// *   0: disables the customer header.
            /// *   1: modifies the first package.
            /// *   2: modifies all packages.
            /// </summary>
            [NameInMap("NavCustomHeader")]
            [Validation(Required=false)]
            public string NavCustomHeader { get; set; }

            /// <summary>
            /// The format of the custom header. You can specify multiple fields. Separate the fields with vertical bars (|).
            /// </summary>
            [NameInMap("NavCustomHeaderContent")]
            [Validation(Required=false)]
            public string NavCustomHeaderContent { get; set; }

            /// <summary>
            /// The custom host mode.
            /// 
            /// *   1: round robin
            /// *   0: random
            /// </summary>
            [NameInMap("NavCustomHost")]
            [Validation(Required=false)]
            public long? NavCustomHost { get; set; }

            /// <summary>
            /// The custom host IP address. You can enter multiple IP addresses. Separate the IP addresses with commas (,).
            /// </summary>
            [NameInMap("NavCustomHostIp")]
            [Validation(Required=false)]
            public string NavCustomHostIp { get; set; }

            /// <summary>
            /// Specifies whether to disable caching.
            /// 
            /// *   1: disable
            /// *   0: enable
            /// </summary>
            [NameInMap("NavDisableCache")]
            [Validation(Required=false)]
            public long? NavDisableCache { get; set; }

            /// <summary>
            /// Specifies whether to enable the feature of using the Accept-Encoding field to determine whether to accept compressed files.
            /// 
            /// *   1: disable
            /// *   0: enable
            /// </summary>
            [NameInMap("NavDisableCompression")]
            [Validation(Required=false)]
            public string NavDisableCompression { get; set; }

            /// <summary>
            /// Specifies whether to ignore certificate errors during certificate verification in the SSL handshake and continue browsing.
            /// 
            /// *   1: ignore
            /// *   0: does not ignore
            /// </summary>
            [NameInMap("NavIgnoreCertificateError")]
            [Validation(Required=false)]
            public long? NavIgnoreCertificateError { get; set; }

            /// <summary>
            /// Specifies whether to continue browsing after a redirection occurs.
            /// 
            /// *   1: yes
            /// *   0: no
            /// </summary>
            [NameInMap("NavRedirection")]
            [Validation(Required=false)]
            public long? NavRedirection { get; set; }

            /// <summary>
            /// Specifies whether to return the elements on the page.
            /// 
            /// *   1: no. Returns the basic document data.
            /// *   2: yes. Returns all document data.
            /// </summary>
            [NameInMap("NavReturnElement")]
            [Validation(Required=false)]
            public long? NavReturnElement { get; set; }

            /// <summary>
            /// The web page defacement.
            /// </summary>
            [NameInMap("PageTamper")]
            [Validation(Required=false)]
            public string PageTamper { get; set; }

            /// <summary>
            /// The process ID.
            /// </summary>
            [NameInMap("ProcessName")]
            [Validation(Required=false)]
            public string ProcessName { get; set; }

            /// <summary>
            /// The domain name of the QUIC request element.
            /// 
            /// >  This parameter is supported by all elements of only Chrome
            /// </summary>
            [NameInMap("QUICDomain")]
            [Validation(Required=false)]
            public string QUICDomain { get; set; }

            /// <summary>
            /// The Quick UDP Internet Connections (QUIC) protocol version. Default value: 0. Valid values:
            /// 
            /// *
            /// *   35
            /// *   39
            /// *   43
            /// *   44
            /// 
            /// >  This parameter is supported by all elements of only Chrome
            /// </summary>
            [NameInMap("QUICVersion")]
            [Validation(Required=false)]
            public long? QUICVersion { get; set; }

            /// <summary>
            /// Specifies whether to return the request header.
            /// 
            /// *   0: does not return the response header.
            /// *   1: returns the basic document header.
            /// *   2: returns all headers.
            /// </summary>
            [NameInMap("RequestHeader")]
            [Validation(Required=false)]
            public long? RequestHeader { get; set; }

            /// <summary>
            /// The method that is used to return the response header. Valid values:
            /// 
            /// *   0: does not return the response header.
            /// *   1: returns the basic document header.
            /// *   2: returns all headers.
            /// </summary>
            [NameInMap("ResponseHeader")]
            [Validation(Required=false)]
            public long? ResponseHeader { get; set; }

            /// <summary>
            /// The time threshold that is used to define a slow element. Unit: seconds.
            /// </summary>
            [NameInMap("SlowElementThreshold")]
            [Validation(Required=false)]
            public double? SlowElementThreshold { get; set; }

            /// <summary>
            /// The blacklist for string verification.
            /// </summary>
            [NameInMap("VerifyStringBlacklist")]
            [Validation(Required=false)]
            public string VerifyStringBlacklist { get; set; }

            /// <summary>
            /// The whitelist for string verification.
            /// </summary>
            [NameInMap("VerifyStringWhiteList")]
            [Validation(Required=false)]
            public string VerifyStringWhiteList { get; set; }

            /// <summary>
            /// The timeout period of waiting for the monitoring to complete.
            /// </summary>
            [NameInMap("WaitCompletionTime")]
            [Validation(Required=false)]
            public double? WaitCompletionTime { get; set; }

        }

        /// <summary>
        /// The network synthetic monitoring task.
        /// </summary>
        [NameInMap("Net")]
        [Validation(Required=false)]
        public CreateSyntheticTaskRequestNet Net { get; set; }
        public class CreateSyntheticTaskRequestNet : TeaModel {
            /// <summary>
            /// The DNS server.
            /// </summary>
            [NameInMap("NetDNSNs")]
            [Validation(Required=false)]
            public string NetDNSNs { get; set; }

            /// <summary>
            /// The DNS query method. Valid values:
            /// 
            /// *   1: recursion
            /// *   2: iteration
            /// </summary>
            [NameInMap("NetDNSQueryMethod")]
            [Validation(Required=false)]
            public long? NetDNSQueryMethod { get; set; }

            /// <summary>
            /// The IP address type of the DNS server.
            /// 
            /// *   0: IPv4
            /// *   1: IPv6
            /// *   2: an automatic IP address
            /// </summary>
            [NameInMap("NetDNSServer")]
            [Validation(Required=false)]
            public long? NetDNSServer { get; set; }

            /// <summary>
            /// Specifies whether to enable domain name system (DNS) monitoring.
            /// 
            /// *   0: Off.
            /// *   1: On. You must set DNS parameters if you want to enable DNS monitoring.
            /// </summary>
            [NameInMap("NetDNSSwitch")]
            [Validation(Required=false)]
            public long? NetDNSSwitch { get; set; }

            /// <summary>
            /// The timeout period of DNS monitoring. Default value: 5 seconds. Valid values: 0 to 45 seconds.
            /// </summary>
            [NameInMap("NetDNSTimeout")]
            [Validation(Required=false)]
            public long? NetDNSTimeout { get; set; }

            /// <summary>
            /// Specifies whether to display the data in the DIG format. Valid values:
            /// 
            /// *   0: no
            /// *   1: yes
            /// </summary>
            [NameInMap("NetDigSwitch")]
            [Validation(Required=false)]
            public long? NetDigSwitch { get; set; }

            /// <summary>
            /// The protocol type. Valid values:
            /// 
            /// *   0: ICMP
            /// *   1: TCP
            /// </summary>
            [NameInMap("NetICMPActive")]
            [Validation(Required=false)]
            public long? NetICMPActive { get; set; }

            /// <summary>
            /// Specifies whether to split packages.
            /// 
            /// *   0: no
            /// *   1: yes
            /// </summary>
            [NameInMap("NetICMPDataCut")]
            [Validation(Required=false)]
            public long? NetICMPDataCut { get; set; }

            /// <summary>
            /// The interval at which the network synthetic monitoring task is executed. Unit: seconds.
            /// </summary>
            [NameInMap("NetICMPInterval")]
            [Validation(Required=false)]
            public long? NetICMPInterval { get; set; }

            /// <summary>
            /// The number of packages.
            /// </summary>
            [NameInMap("NetICMPNum")]
            [Validation(Required=false)]
            public long? NetICMPNum { get; set; }

            /// <summary>
            /// The package size.
            /// </summary>
            [NameInMap("NetICMPSize")]
            [Validation(Required=false)]
            public long? NetICMPSize { get; set; }

            /// <summary>
            /// Specifies whether to enable ping monitoring.
            /// 
            /// *   0: Off.
            /// *   1: On. You must set Internet control message protocol (ICMP) parameters if you want to enable ping monitoring.
            /// </summary>
            [NameInMap("NetICMPSwitch")]
            [Validation(Required=false)]
            public long? NetICMPSwitch { get; set; }

            /// <summary>
            /// The timeout period of Ping monitoring.
            /// </summary>
            [NameInMap("NetICMPTimeout")]
            [Validation(Required=false)]
            public long? NetICMPTimeout { get; set; }

            /// <summary>
            /// The maximum number of active monitoring points.
            /// </summary>
            [NameInMap("NetTraceRouteNum")]
            [Validation(Required=false)]
            public long? NetTraceRouteNum { get; set; }

            /// <summary>
            /// Specifies whether to enable tracert monitoring.
            /// 
            /// *   0: Off.
            /// *   1: On. You must set the tracert parameters if you want to enable tracert monitoring.
            /// </summary>
            [NameInMap("NetTraceRouteSwitch")]
            [Validation(Required=false)]
            public long? NetTraceRouteSwitch { get; set; }

            /// <summary>
            /// The timeout period of tracert monitoring. Valid values: 0 to 300 seconds.
            /// </summary>
            [NameInMap("NetTraceRouteTimeout")]
            [Validation(Required=false)]
            public long? NetTraceRouteTimeout { get; set; }

            /// <summary>
            /// The whitelist for DNS hijacking. The format is `Domain name: Matching rule`.
            /// 
            /// >  Wireless application protocol (WAP) networks do not support DNS hijacking.
            /// </summary>
            [NameInMap("WhiteList")]
            [Validation(Required=false)]
            public string WhiteList { get; set; }

        }

        /// <summary>
        /// The API performance synthetic monitoring task.
        /// </summary>
        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public CreateSyntheticTaskRequestProtocol Protocol { get; set; }
        public class CreateSyntheticTaskRequestProtocol : TeaModel {
            /// <summary>
            /// The encoding format.
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
            /// The custom host mode.
            /// 
            /// *   1: round robin
            /// *   0: random
            /// </summary>
            [NameInMap("CustomHost")]
            [Validation(Required=false)]
            public long? CustomHost { get; set; }

            /// <summary>
            /// The custom host IP address. You can enter multiple IP addresses. Separate the IP addresses with commas (,).
            /// </summary>
            [NameInMap("CustomHostIp")]
            [Validation(Required=false)]
            public string CustomHostIp { get; set; }

            /// <summary>
            /// The connection timeout period of the protocol. Unit: seconds.
            /// </summary>
            [NameInMap("ProtocolConnectionTime")]
            [Validation(Required=false)]
            public long? ProtocolConnectionTime { get; set; }

            /// <summary>
            /// The timeout period of API performance synthetic monitoring. Unit: seconds.
            /// </summary>
            [NameInMap("ProtocolMonitorTimeout")]
            [Validation(Required=false)]
            public string ProtocolMonitorTimeout { get; set; }

            /// <summary>
            /// The size of the received data. This parameter is required when you set the value of the VerifyWay parameter to 2.
            /// </summary>
            [NameInMap("ReceivedDataSize")]
            [Validation(Required=false)]
            public long? ReceivedDataSize { get; set; }

            /// <summary>
            /// The request content, including the request header and request body.
            /// </summary>
            [NameInMap("RequestContent")]
            [Validation(Required=false)]
            public CreateSyntheticTaskRequestProtocolRequestContent RequestContent { get; set; }
            public class CreateSyntheticTaskRequestProtocolRequestContent : TeaModel {
                /// <summary>
                /// The custom body of a request to initiate an API performance synthetic monitoring task.
                /// </summary>
                [NameInMap("Body")]
                [Validation(Required=false)]
                public CreateSyntheticTaskRequestProtocolRequestContentBody Body { get; set; }
                public class CreateSyntheticTaskRequestProtocolRequestContentBody : TeaModel {
                    /// <summary>
                    /// The data that is passed when the **Mode** parameter is set to **form-data**.
                    /// </summary>
                    [NameInMap("FormData")]
                    [Validation(Required=false)]
                    public List<CreateSyntheticTaskRequestProtocolRequestContentBodyFormData> FormData { get; set; }
                    public class CreateSyntheticTaskRequestProtocolRequestContentBodyFormData : TeaModel {
                        /// <summary>
                        /// The key of **form-data**.
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// The value of **form-data**.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// The language that is selected when the Mode parameter is set to raw.
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
                    /// The data type of the content.
                    /// 
                    /// *   form-data
                    /// *   x-www-form-urlencoded
                    /// *   raw
                    /// </summary>
                    [NameInMap("Mode")]
                    [Validation(Required=false)]
                    public string Mode { get; set; }

                    /// <summary>
                    /// The data that is passed when the **Mode** parameter is set to **raw**.
                    /// </summary>
                    [NameInMap("Raw")]
                    [Validation(Required=false)]
                    public string Raw { get; set; }

                    /// <summary>
                    /// The data that is passed when the **Mode** parameter is set to **x-www-form-urlencoded**.
                    /// </summary>
                    [NameInMap("UrlEncoding")]
                    [Validation(Required=false)]
                    public List<CreateSyntheticTaskRequestProtocolRequestContentBodyUrlEncoding> UrlEncoding { get; set; }
                    public class CreateSyntheticTaskRequestProtocolRequestContentBodyUrlEncoding : TeaModel {
                        /// <summary>
                        /// The key of **x-www-form-urlencoded**.
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// The value of **x-www-form-urlencoded**.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// The custom header of a request to initiate an API performance synthetic monitoring task.
                /// </summary>
                [NameInMap("Header")]
                [Validation(Required=false)]
                public List<CreateSyntheticTaskRequestProtocolRequestContentHeader> Header { get; set; }
                public class CreateSyntheticTaskRequestProtocolRequestContentHeader : TeaModel {
                    /// <summary>
                    /// The key of the request header.
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// The value of the request header.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// The request method.
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
            /// The method that is used to verify the response content.
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
        /// The ID of the region in which the application is located.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The name of the task. To update a synthetic monitoring task, enter the task name and set the **UpdateTask** parameter to **true**.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// The type of the monitoring task. Valid values:
        /// 
        /// 1.  3: web page performance - IE
        /// 2.  34: web Page Performance - Chrome
        /// 3.  0: network quality
        /// 4.  40: file download
        /// 5.  7:API performance
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public long? TaskType { get; set; }

        /// <summary>
        /// Specifies whether to update existing synthetic monitoring tasks.
        /// 
        /// *   true: updates existing synthetic monitoring tasks.
        /// *   false: creates new synthetic monitoring tasks.
        /// </summary>
        [NameInMap("UpdateTask")]
        [Validation(Required=false)]
        public bool? UpdateTask { get; set; }

        /// <summary>
        /// The URL for synthetic monitoring.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
