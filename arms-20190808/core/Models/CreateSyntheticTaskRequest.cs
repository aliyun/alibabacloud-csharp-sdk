// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class CreateSyntheticTaskRequest : TeaModel {
        [NameInMap("CommonParam")]
        [Validation(Required=false)]
        public CreateSyntheticTaskRequestCommonParam CommonParam { get; set; }
        public class CreateSyntheticTaskRequestCommonParam : TeaModel {
            [NameInMap("AlarmFlag")]
            [Validation(Required=false)]
            public string AlarmFlag { get; set; }

            [NameInMap("AlertList")]
            [Validation(Required=false)]
            public List<CreateSyntheticTaskRequestCommonParamAlertList> AlertList { get; set; }
            public class CreateSyntheticTaskRequestCommonParamAlertList : TeaModel {
                [NameInMap("IsCritical")]
                [Validation(Required=false)]
                public long? IsCritical { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Symbols")]
                [Validation(Required=false)]
                public long? Symbols { get; set; }

            }

            [NameInMap("AlertNotifierId")]
            [Validation(Required=false)]
            public string AlertNotifierId { get; set; }

            [NameInMap("AlertPolicyId")]
            [Validation(Required=false)]
            public string AlertPolicyId { get; set; }

            [NameInMap("MonitorSamples")]
            [Validation(Required=false)]
            public long? MonitorSamples { get; set; }

            [NameInMap("StartExecutionTime")]
            [Validation(Required=false)]
            public long? StartExecutionTime { get; set; }

        }

        [NameInMap("Download")]
        [Validation(Required=false)]
        public CreateSyntheticTaskRequestDownload Download { get; set; }
        public class CreateSyntheticTaskRequestDownload : TeaModel {
            [NameInMap("ConnectionTimeout")]
            [Validation(Required=false)]
            public double? ConnectionTimeout { get; set; }

            [NameInMap("DownloadCustomHeaderContent")]
            [Validation(Required=false)]
            public string DownloadCustomHeaderContent { get; set; }

            [NameInMap("DownloadCustomHost")]
            [Validation(Required=false)]
            public long? DownloadCustomHost { get; set; }

            [NameInMap("DownloadCustomHostIp")]
            [Validation(Required=false)]
            public string DownloadCustomHostIp { get; set; }

            [NameInMap("DownloadIgnoreCertificateError")]
            [Validation(Required=false)]
            public string DownloadIgnoreCertificateError { get; set; }

            [NameInMap("DownloadKernel")]
            [Validation(Required=false)]
            public long? DownloadKernel { get; set; }

            [NameInMap("DownloadRedirection")]
            [Validation(Required=false)]
            public long? DownloadRedirection { get; set; }

            [NameInMap("DownloadTransmissionSize")]
            [Validation(Required=false)]
            public long? DownloadTransmissionSize { get; set; }

            [NameInMap("MonitorTimeout")]
            [Validation(Required=false)]
            public long? MonitorTimeout { get; set; }

            [NameInMap("QuickProtocol")]
            [Validation(Required=false)]
            public string QuickProtocol { get; set; }

            [NameInMap("ValidateKeywords")]
            [Validation(Required=false)]
            public string ValidateKeywords { get; set; }

            [NameInMap("VerifyWay")]
            [Validation(Required=false)]
            public long? VerifyWay { get; set; }

            [NameInMap("WhiteList")]
            [Validation(Required=false)]
            public string WhiteList { get; set; }

        }

        [NameInMap("ExtendInterval")]
        [Validation(Required=false)]
        public CreateSyntheticTaskRequestExtendInterval ExtendInterval { get; set; }
        public class CreateSyntheticTaskRequestExtendInterval : TeaModel {
            [NameInMap("Days")]
            [Validation(Required=false)]
            public List<long?> Days { get; set; }

            [NameInMap("EndHour")]
            [Validation(Required=false)]
            public long? EndHour { get; set; }

            [NameInMap("EndMinute")]
            [Validation(Required=false)]
            public long? EndMinute { get; set; }

            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            [NameInMap("StartHour")]
            [Validation(Required=false)]
            public long? StartHour { get; set; }

            [NameInMap("StartMinute")]
            [Validation(Required=false)]
            public long? StartMinute { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("IntervalTime")]
        [Validation(Required=false)]
        public string IntervalTime { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("IntervalType")]
        [Validation(Required=false)]
        public string IntervalType { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("IpType")]
        [Validation(Required=false)]
        public long? IpType { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("MonitorList")]
        [Validation(Required=false)]
        public List<CreateSyntheticTaskRequestMonitorList> MonitorList { get; set; }
        public class CreateSyntheticTaskRequestMonitorList : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("CityCode")]
            [Validation(Required=false)]
            public long? CityCode { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("MonitorType")]
            [Validation(Required=false)]
            public long? MonitorType { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("NetServiceId")]
            [Validation(Required=false)]
            public long? NetServiceId { get; set; }

        }

        [NameInMap("Navigation")]
        [Validation(Required=false)]
        public CreateSyntheticTaskRequestNavigation Navigation { get; set; }
        public class CreateSyntheticTaskRequestNavigation : TeaModel {
            [NameInMap("DNSHijackWhiteList")]
            [Validation(Required=false)]
            public string DNSHijackWhiteList { get; set; }

            [NameInMap("ElementBlacklist")]
            [Validation(Required=false)]
            public string ElementBlacklist { get; set; }

            [NameInMap("ExecuteActiveX")]
            [Validation(Required=false)]
            public long? ExecuteActiveX { get; set; }

            [NameInMap("ExecuteApplication")]
            [Validation(Required=false)]
            public long? ExecuteApplication { get; set; }

            [NameInMap("ExecuteScript")]
            [Validation(Required=false)]
            public long? ExecuteScript { get; set; }

            [NameInMap("FilterInvalidIP")]
            [Validation(Required=false)]
            public long? FilterInvalidIP { get; set; }

            [NameInMap("FlowHijackJumpTimes")]
            [Validation(Required=false)]
            public long? FlowHijackJumpTimes { get; set; }

            [NameInMap("FlowHijackLogo")]
            [Validation(Required=false)]
            public string FlowHijackLogo { get; set; }

            [NameInMap("MonitorTimeout")]
            [Validation(Required=false)]
            public string MonitorTimeout { get; set; }

            [NameInMap("NavAutomaticScrolling")]
            [Validation(Required=false)]
            public string NavAutomaticScrolling { get; set; }

            [NameInMap("NavCustomHeader")]
            [Validation(Required=false)]
            public string NavCustomHeader { get; set; }

            [NameInMap("NavCustomHeaderContent")]
            [Validation(Required=false)]
            public string NavCustomHeaderContent { get; set; }

            [NameInMap("NavCustomHost")]
            [Validation(Required=false)]
            public long? NavCustomHost { get; set; }

            [NameInMap("NavCustomHostIp")]
            [Validation(Required=false)]
            public string NavCustomHostIp { get; set; }

            [NameInMap("NavDisableCache")]
            [Validation(Required=false)]
            public long? NavDisableCache { get; set; }

            [NameInMap("NavDisableCompression")]
            [Validation(Required=false)]
            public string NavDisableCompression { get; set; }

            [NameInMap("NavIgnoreCertificateError")]
            [Validation(Required=false)]
            public long? NavIgnoreCertificateError { get; set; }

            [NameInMap("NavRedirection")]
            [Validation(Required=false)]
            public long? NavRedirection { get; set; }

            [NameInMap("NavReturnElement")]
            [Validation(Required=false)]
            public long? NavReturnElement { get; set; }

            [NameInMap("PageTamper")]
            [Validation(Required=false)]
            public string PageTamper { get; set; }

            [NameInMap("ProcessName")]
            [Validation(Required=false)]
            public string ProcessName { get; set; }

            [NameInMap("QUICDomain")]
            [Validation(Required=false)]
            public string QUICDomain { get; set; }

            [NameInMap("QUICVersion")]
            [Validation(Required=false)]
            public long? QUICVersion { get; set; }

            [NameInMap("RequestHeader")]
            [Validation(Required=false)]
            public long? RequestHeader { get; set; }

            [NameInMap("ResponseHeader")]
            [Validation(Required=false)]
            public long? ResponseHeader { get; set; }

            [NameInMap("SlowElementThreshold")]
            [Validation(Required=false)]
            public double? SlowElementThreshold { get; set; }

            [NameInMap("VerifyStringBlacklist")]
            [Validation(Required=false)]
            public string VerifyStringBlacklist { get; set; }

            [NameInMap("VerifyStringWhiteList")]
            [Validation(Required=false)]
            public string VerifyStringWhiteList { get; set; }

            [NameInMap("WaitCompletionTime")]
            [Validation(Required=false)]
            public double? WaitCompletionTime { get; set; }

        }

        [NameInMap("Net")]
        [Validation(Required=false)]
        public CreateSyntheticTaskRequestNet Net { get; set; }
        public class CreateSyntheticTaskRequestNet : TeaModel {
            [NameInMap("NetDNSNs")]
            [Validation(Required=false)]
            public string NetDNSNs { get; set; }

            [NameInMap("NetDNSQueryMethod")]
            [Validation(Required=false)]
            public long? NetDNSQueryMethod { get; set; }

            [NameInMap("NetDNSServer")]
            [Validation(Required=false)]
            public long? NetDNSServer { get; set; }

            [NameInMap("NetDNSSwitch")]
            [Validation(Required=false)]
            public long? NetDNSSwitch { get; set; }

            [NameInMap("NetDNSTimeout")]
            [Validation(Required=false)]
            public long? NetDNSTimeout { get; set; }

            [NameInMap("NetDigSwitch")]
            [Validation(Required=false)]
            public long? NetDigSwitch { get; set; }

            [NameInMap("NetICMPActive")]
            [Validation(Required=false)]
            public long? NetICMPActive { get; set; }

            [NameInMap("NetICMPDataCut")]
            [Validation(Required=false)]
            public long? NetICMPDataCut { get; set; }

            [NameInMap("NetICMPInterval")]
            [Validation(Required=false)]
            public long? NetICMPInterval { get; set; }

            [NameInMap("NetICMPNum")]
            [Validation(Required=false)]
            public long? NetICMPNum { get; set; }

            [NameInMap("NetICMPSize")]
            [Validation(Required=false)]
            public long? NetICMPSize { get; set; }

            [NameInMap("NetICMPSwitch")]
            [Validation(Required=false)]
            public long? NetICMPSwitch { get; set; }

            [NameInMap("NetICMPTimeout")]
            [Validation(Required=false)]
            public long? NetICMPTimeout { get; set; }

            [NameInMap("NetTraceRouteNum")]
            [Validation(Required=false)]
            public long? NetTraceRouteNum { get; set; }

            [NameInMap("NetTraceRouteSwitch")]
            [Validation(Required=false)]
            public long? NetTraceRouteSwitch { get; set; }

            [NameInMap("NetTraceRouteTimeout")]
            [Validation(Required=false)]
            public long? NetTraceRouteTimeout { get; set; }

            [NameInMap("WhiteList")]
            [Validation(Required=false)]
            public string WhiteList { get; set; }

        }

        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public CreateSyntheticTaskRequestProtocol Protocol { get; set; }
        public class CreateSyntheticTaskRequestProtocol : TeaModel {
            [NameInMap("CharacterEncoding")]
            [Validation(Required=false)]
            public long? CharacterEncoding { get; set; }

            [NameInMap("CustomHost")]
            [Validation(Required=false)]
            public long? CustomHost { get; set; }

            [NameInMap("CustomHostIp")]
            [Validation(Required=false)]
            public string CustomHostIp { get; set; }

            [NameInMap("ProtocolConnectionTime")]
            [Validation(Required=false)]
            public long? ProtocolConnectionTime { get; set; }

            [NameInMap("ProtocolMonitorTimeout")]
            [Validation(Required=false)]
            public string ProtocolMonitorTimeout { get; set; }

            [NameInMap("ReceivedDataSize")]
            [Validation(Required=false)]
            public long? ReceivedDataSize { get; set; }

            [NameInMap("RequestContent")]
            [Validation(Required=false)]
            public CreateSyntheticTaskRequestProtocolRequestContent RequestContent { get; set; }
            public class CreateSyntheticTaskRequestProtocolRequestContent : TeaModel {
                [NameInMap("Body")]
                [Validation(Required=false)]
                public CreateSyntheticTaskRequestProtocolRequestContentBody Body { get; set; }
                public class CreateSyntheticTaskRequestProtocolRequestContentBody : TeaModel {
                    [NameInMap("FormData")]
                    [Validation(Required=false)]
                    public List<CreateSyntheticTaskRequestProtocolRequestContentBodyFormData> FormData { get; set; }
                    public class CreateSyntheticTaskRequestProtocolRequestContentBodyFormData : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    [NameInMap("Language")]
                    [Validation(Required=false)]
                    public string Language { get; set; }

                    [NameInMap("Mode")]
                    [Validation(Required=false)]
                    public string Mode { get; set; }

                    [NameInMap("Raw")]
                    [Validation(Required=false)]
                    public string Raw { get; set; }

                    [NameInMap("UrlEncoding")]
                    [Validation(Required=false)]
                    public List<CreateSyntheticTaskRequestProtocolRequestContentBodyUrlEncoding> UrlEncoding { get; set; }
                    public class CreateSyntheticTaskRequestProtocolRequestContentBodyUrlEncoding : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                [NameInMap("Header")]
                [Validation(Required=false)]
                public List<CreateSyntheticTaskRequestProtocolRequestContentHeader> Header { get; set; }
                public class CreateSyntheticTaskRequestProtocolRequestContentHeader : TeaModel {
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("Method")]
                [Validation(Required=false)]
                public string Method { get; set; }

            }

            [NameInMap("VerifyContent")]
            [Validation(Required=false)]
            public string VerifyContent { get; set; }

            [NameInMap("VerifyWay")]
            [Validation(Required=false)]
            public long? VerifyWay { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public long? TaskType { get; set; }

        [NameInMap("UpdateTask")]
        [Validation(Required=false)]
        public bool? UpdateTask { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
