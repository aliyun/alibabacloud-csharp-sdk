// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GetSyntheticTaskDetailResponseBody : TeaModel {
        /// <summary>
        /// 请求ID。
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 任务详情。
        /// </summary>
        [NameInMap("TaskDetail")]
        [Validation(Required=false)]
        public GetSyntheticTaskDetailResponseBodyTaskDetail TaskDetail { get; set; }
        public class GetSyntheticTaskDetailResponseBodyTaskDetail : TeaModel {
            [NameInMap("CommonParam")]
            [Validation(Required=false)]
            public GetSyntheticTaskDetailResponseBodyTaskDetailCommonParam CommonParam { get; set; }
            public class GetSyntheticTaskDetailResponseBodyTaskDetailCommonParam : TeaModel {
                [NameInMap("AlarmFlag")]
                [Validation(Required=false)]
                public long? AlarmFlag { get; set; }

                [NameInMap("AlertList")]
                [Validation(Required=false)]
                public List<GetSyntheticTaskDetailResponseBodyTaskDetailCommonParamAlertList> AlertList { get; set; }
                public class GetSyntheticTaskDetailResponseBodyTaskDetailCommonParamAlertList : TeaModel {
                    [NameInMap("GeneralAlert")]
                    [Validation(Required=false)]
                    public string GeneralAlert { get; set; }

                    [NameInMap("IsCritical")]
                    [Validation(Required=false)]
                    public string IsCritical { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("SeriousAlert")]
                    [Validation(Required=false)]
                    public string SeriousAlert { get; set; }

                    [NameInMap("Symbols")]
                    [Validation(Required=false)]
                    public string Symbols { get; set; }

                }

                [NameInMap("AlertNotifierId")]
                [Validation(Required=false)]
                public string AlertNotifierId { get; set; }

                [NameInMap("AlertPolicyId")]
                [Validation(Required=false)]
                public string AlertPolicyId { get; set; }

                [NameInMap("MonitorSamples")]
                [Validation(Required=false)]
                public string MonitorSamples { get; set; }

                [NameInMap("StartExecutionTime")]
                [Validation(Required=false)]
                public string StartExecutionTime { get; set; }

            }

            /// <summary>
            /// 文件下载任务。
            /// </summary>
            [NameInMap("Download")]
            [Validation(Required=false)]
            public GetSyntheticTaskDetailResponseBodyTaskDetailDownload Download { get; set; }
            public class GetSyntheticTaskDetailResponseBodyTaskDetailDownload : TeaModel {
                [NameInMap("ConnectionTimeout")]
                [Validation(Required=false)]
                public long? ConnectionTimeout { get; set; }

                [NameInMap("DownloadCustomHeaderContent")]
                [Validation(Required=false)]
                public string DownloadCustomHeaderContent { get; set; }

                [NameInMap("DownloadCustomHost")]
                [Validation(Required=false)]
                public long? DownloadCustomHost { get; set; }

                [NameInMap("DownloadCustomHostIp")]
                [Validation(Required=false)]
                public string DownloadCustomHostIp { get; set; }

                [NameInMap("DownloadKernel")]
                [Validation(Required=false)]
                public long? DownloadKernel { get; set; }

                [NameInMap("DownloadRedirect")]
                [Validation(Required=false)]
                public long? DownloadRedirect { get; set; }

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

            /// <summary>
            /// 自定义扩展频率。
            /// </summary>
            [NameInMap("ExtendInterval")]
            [Validation(Required=false)]
            public GetSyntheticTaskDetailResponseBodyTaskDetailExtendInterval ExtendInterval { get; set; }
            public class GetSyntheticTaskDetailResponseBodyTaskDetailExtendInterval : TeaModel {
                /// <summary>
                /// 拨测执行周期。
                /// 
                /// - -1：每天
                /// - 0：周日
                /// - 1：周一
                /// - 2：周二
                /// - 3：周三
                /// - 4：周四
                /// - 5：周五
                /// - 6：周六
                /// </summary>
                [NameInMap("Days")]
                [Validation(Required=false)]
                public List<long?> Days { get; set; }

                /// <summary>
                /// 当天结束分钟数。
                /// </summary>
                [NameInMap("EndMinute")]
                [Validation(Required=false)]
                public long? EndMinute { get; set; }

                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// 当天结束小时数。
                /// </summary>
                [NameInMap("Endhour")]
                [Validation(Required=false)]
                public long? Endhour { get; set; }

                /// <summary>
                /// 当天开始拨测时间的小时数。
                /// </summary>
                [NameInMap("StartHour")]
                [Validation(Required=false)]
                public long? StartHour { get; set; }

                /// <summary>
                /// 当天开始拨测时间的分钟数。
                /// </summary>
                [NameInMap("StartMinute")]
                [Validation(Required=false)]
                public long? StartMinute { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

            }

            /// <summary>
            /// 拨测频率，单位为分钟。可选频率如下：
            /// 
            /// - 1
            /// - 5
            /// - 10
            /// - 15
            /// - 20
            /// - 30
            /// - 60
            /// - 120
            /// - 180
            /// - 240
            /// - 360
            /// - 480
            /// - 720
            /// - 1440
            /// </summary>
            [NameInMap("IntervalTime")]
            [Validation(Required=false)]
            public long? IntervalTime { get; set; }

            [NameInMap("IntervalType")]
            [Validation(Required=false)]
            public long? IntervalType { get; set; }

            [NameInMap("IpType")]
            [Validation(Required=false)]
            public long? IpType { get; set; }

            [NameInMap("MonitorList")]
            [Validation(Required=false)]
            public List<GetSyntheticTaskDetailResponseBodyTaskDetailMonitorList> MonitorList { get; set; }
            public class GetSyntheticTaskDetailResponseBodyTaskDetailMonitorList : TeaModel {
                /// <summary>
                /// 城市编码。
                /// </summary>
                [NameInMap("CityCode")]
                [Validation(Required=false)]
                public long? CityCode { get; set; }

                [NameInMap("MonitorType")]
                [Validation(Required=false)]
                public long? MonitorType { get; set; }

                [NameInMap("NetServiceId")]
                [Validation(Required=false)]
                public long? NetServiceId { get; set; }

                [NameInMap("SendCount")]
                [Validation(Required=false)]
                public long? SendCount { get; set; }

            }

            [NameInMap("MonitorListString")]
            [Validation(Required=false)]
            public string MonitorListString { get; set; }

            [NameInMap("Nav")]
            [Validation(Required=false)]
            public GetSyntheticTaskDetailResponseBodyTaskDetailNav Nav { get; set; }
            public class GetSyntheticTaskDetailResponseBodyTaskDetailNav : TeaModel {
                [NameInMap("DnsHijackWhitelist")]
                [Validation(Required=false)]
                public string DnsHijackWhitelist { get; set; }

                [NameInMap("ElementBlacklist")]
                [Validation(Required=false)]
                public string ElementBlacklist { get; set; }

                [NameInMap("ExecuteActiveX")]
                [Validation(Required=false)]
                public long? ExecuteActiveX { get; set; }

                [NameInMap("ExecuteApplet")]
                [Validation(Required=false)]
                public long? ExecuteApplet { get; set; }

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
                public long? MonitorTimeout { get; set; }

                [NameInMap("NavAutomaticScrolling")]
                [Validation(Required=false)]
                public long? NavAutomaticScrolling { get; set; }

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
                public long? NavDisableCompression { get; set; }

                [NameInMap("NavIgnoreCertificateError")]
                [Validation(Required=false)]
                public long? NavIgnoreCertificateError { get; set; }

                [NameInMap("NavRedirect")]
                [Validation(Required=false)]
                public long? NavRedirect { get; set; }

                [NameInMap("NavReturnElement")]
                [Validation(Required=false)]
                public long? NavReturnElement { get; set; }

                [NameInMap("PageTampering")]
                [Validation(Required=false)]
                public string PageTampering { get; set; }

                [NameInMap("ProcessName")]
                [Validation(Required=false)]
                public string ProcessName { get; set; }

                [NameInMap("QuicDomain")]
                [Validation(Required=false)]
                public string QuicDomain { get; set; }

                [NameInMap("QuicVersion")]
                [Validation(Required=false)]
                public long? QuicVersion { get; set; }

                [NameInMap("RequestHeader")]
                [Validation(Required=false)]
                public long? RequestHeader { get; set; }

                [NameInMap("SlowElementThreshold")]
                [Validation(Required=false)]
                public long? SlowElementThreshold { get; set; }

                [NameInMap("VerifyStringBlacklist")]
                [Validation(Required=false)]
                public string VerifyStringBlacklist { get; set; }

                [NameInMap("VerifyStringWhitelist")]
                [Validation(Required=false)]
                public string VerifyStringWhitelist { get; set; }

                [NameInMap("WaitCompletionTime")]
                [Validation(Required=false)]
                public long? WaitCompletionTime { get; set; }

            }

            [NameInMap("Net")]
            [Validation(Required=false)]
            public GetSyntheticTaskDetailResponseBodyTaskDetailNet Net { get; set; }
            public class GetSyntheticTaskDetailResponseBodyTaskDetailNet : TeaModel {
                [NameInMap("NetDigSwitch")]
                [Validation(Required=false)]
                public long? NetDigSwitch { get; set; }

                [NameInMap("NetDnsNs")]
                [Validation(Required=false)]
                public string NetDnsNs { get; set; }

                [NameInMap("NetDnsQueryMethod")]
                [Validation(Required=false)]
                public string NetDnsQueryMethod { get; set; }

                [NameInMap("NetDnsServer")]
                [Validation(Required=false)]
                public long? NetDnsServer { get; set; }

                [NameInMap("NetDnsSwitch")]
                [Validation(Required=false)]
                public long? NetDnsSwitch { get; set; }

                [NameInMap("NetDnsTimeout")]
                [Validation(Required=false)]
                public string NetDnsTimeout { get; set; }

                [NameInMap("NetIcmpActive")]
                [Validation(Required=false)]
                public long? NetIcmpActive { get; set; }

                [NameInMap("NetIcmpDataCut")]
                [Validation(Required=false)]
                public long? NetIcmpDataCut { get; set; }

                [NameInMap("NetIcmpInterval")]
                [Validation(Required=false)]
                public long? NetIcmpInterval { get; set; }

                [NameInMap("NetIcmpNum")]
                [Validation(Required=false)]
                public long? NetIcmpNum { get; set; }

                [NameInMap("NetIcmpSize")]
                [Validation(Required=false)]
                public long? NetIcmpSize { get; set; }

                [NameInMap("NetIcmpSwitch")]
                [Validation(Required=false)]
                public long? NetIcmpSwitch { get; set; }

                [NameInMap("NetIcmpTimeout")]
                [Validation(Required=false)]
                public long? NetIcmpTimeout { get; set; }

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
            public GetSyntheticTaskDetailResponseBodyTaskDetailProtocol Protocol { get; set; }
            public class GetSyntheticTaskDetailResponseBodyTaskDetailProtocol : TeaModel {
                [NameInMap("CharacterEncoding")]
                [Validation(Required=false)]
                public long? CharacterEncoding { get; set; }

                [NameInMap("CustomHost")]
                [Validation(Required=false)]
                public long? CustomHost { get; set; }

                [NameInMap("CustomHostIp")]
                [Validation(Required=false)]
                public string CustomHostIp { get; set; }

                [NameInMap("ProtocolConnectionTimeout")]
                [Validation(Required=false)]
                public long? ProtocolConnectionTimeout { get; set; }

                [NameInMap("ProtocolMonitorTimeout")]
                [Validation(Required=false)]
                public long? ProtocolMonitorTimeout { get; set; }

                [NameInMap("ReceivedDataSize")]
                [Validation(Required=false)]
                public long? ReceivedDataSize { get; set; }

                [NameInMap("RequestContent")]
                [Validation(Required=false)]
                public GetSyntheticTaskDetailResponseBodyTaskDetailProtocolRequestContent RequestContent { get; set; }
                public class GetSyntheticTaskDetailResponseBodyTaskDetailProtocolRequestContent : TeaModel {
                    [NameInMap("Body")]
                    [Validation(Required=false)]
                    public GetSyntheticTaskDetailResponseBodyTaskDetailProtocolRequestContentBody Body { get; set; }
                    public class GetSyntheticTaskDetailResponseBodyTaskDetailProtocolRequestContentBody : TeaModel {
                        [NameInMap("Formdata")]
                        [Validation(Required=false)]
                        public GetSyntheticTaskDetailResponseBodyTaskDetailProtocolRequestContentBodyFormdata Formdata { get; set; }
                        public class GetSyntheticTaskDetailResponseBodyTaskDetailProtocolRequestContentBodyFormdata : TeaModel {
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

                        [NameInMap("Urlencoded")]
                        [Validation(Required=false)]
                        public GetSyntheticTaskDetailResponseBodyTaskDetailProtocolRequestContentBodyUrlencoded Urlencoded { get; set; }
                        public class GetSyntheticTaskDetailResponseBodyTaskDetailProtocolRequestContentBodyUrlencoded : TeaModel {
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
                    public List<GetSyntheticTaskDetailResponseBodyTaskDetailProtocolRequestContentHeader> Header { get; set; }
                    public class GetSyntheticTaskDetailResponseBodyTaskDetailProtocolRequestContentHeader : TeaModel {
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
            /// 云拨测任务ID。
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public long? TaskId { get; set; }

            /// <summary>
            /// 任务名称。
            /// </summary>
            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public long? TaskType { get; set; }

            /// <summary>
            /// 拨测地址。
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

    }

}
