// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RiskManagement20260424.Models
{
    public class DescribeSuspEventsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeSuspEventsResponseBodyData Data { get; set; }
        public class DescribeSuspEventsResponseBodyData : TeaModel {
            [NameInMap("Body")]
            [Validation(Required=false)]
            public DescribeSuspEventsResponseBodyDataBody Body { get; set; }
            public class DescribeSuspEventsResponseBodyDataBody : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("CurrentPage")]
                [Validation(Required=false)]
                public int? CurrentPage { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("PageSize")]
                [Validation(Required=false)]
                public int? PageSize { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>AD2345D1-A498-58AF-97C0-88940AF87CB7</para>
                /// </summary>
                [NameInMap("RequestId")]
                [Validation(Required=false)]
                public string RequestId { get; set; }

                [NameInMap("SuspEvents")]
                [Validation(Required=false)]
                public List<DescribeSuspEventsResponseBodyDataBodySuspEvents> SuspEvents { get; set; }
                public class DescribeSuspEventsResponseBodyDataBodySuspEvents : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("Advanced")]
                    [Validation(Required=false)]
                    public bool? Advanced { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>反弹shell_拦截</para>
                    /// </summary>
                    [NameInMap("AlarmEventName")]
                    [Validation(Required=false)]
                    public string AlarmEventName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Login with unusual location</para>
                    /// </summary>
                    [NameInMap("AlarmEventNameDisplay")]
                    [Validation(Required=false)]
                    public string AlarmEventNameDisplay { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Unusual Logon</para>
                    /// </summary>
                    [NameInMap("AlarmEventType")]
                    [Validation(Required=false)]
                    public string AlarmEventType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Unusual Logon</para>
                    /// </summary>
                    [NameInMap("AlarmEventTypeDisplay")]
                    [Validation(Required=false)]
                    public string AlarmEventTypeDisplay { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>8df914418f****</para>
                    /// </summary>
                    [NameInMap("AlarmUniqueInfo")]
                    [Validation(Required=false)]
                    public string AlarmUniqueInfo { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>dfield-cloud-service-prod</para>
                    /// </summary>
                    [NameInMap("AppName")]
                    [Validation(Required=false)]
                    public string AppName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("AutoBreaking")]
                    [Validation(Required=false)]
                    public bool? AutoBreaking { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("CanBeDealOnLine")]
                    [Validation(Required=false)]
                    public bool? CanBeDealOnLine { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("CanCancelFault")]
                    [Validation(Required=false)]
                    public bool? CanCancelFault { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>c8c87dae64c9947269091f36cfa9adc87</para>
                    /// </summary>
                    [NameInMap("ClusterId")]
                    [Validation(Required=false)]
                    public string ClusterId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("ContainHwMode")]
                    [Validation(Required=false)]
                    public bool? ContainHwMode { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>95878ef8779fae3dd82126812edd910402fc550a72f9bce87e56a4435d018384</para>
                    /// </summary>
                    [NameInMap("ContainerId")]
                    [Validation(Required=false)]
                    public string ContainerId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>sha256:2e5a3b0ae5f452b3cb458789a9a7542ef40035a84318469a8528c5e444db1****</para>
                    /// </summary>
                    [NameInMap("ContainerImageId")]
                    [Validation(Required=false)]
                    public string ContainerImageId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>centos7_apache:v1.0.1</para>
                    /// </summary>
                    [NameInMap("ContainerImageName")]
                    [Validation(Required=false)]
                    public string ContainerImageName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>URL</para>
                    /// </summary>
                    [NameInMap("DataSource")]
                    [Validation(Required=false)]
                    public string DataSource { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>webshell</para>
                    /// </summary>
                    [NameInMap("Desc")]
                    [Validation(Required=false)]
                    public string Desc { get; set; }

                    [NameInMap("Details")]
                    [Validation(Required=false)]
                    public List<DescribeSuspEventsResponseBodyDataBodySuspEventsDetails> Details { get; set; }
                    public class DescribeSuspEventsResponseBodyDataBodySuspEventsDetails : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>login with unusual location</para>
                        /// </summary>
                        [NameInMap("NameDisplay")]
                        [Validation(Required=false)]
                        public string NameDisplay { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>text</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>/etc/crontab</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>/etc/crontab</para>
                        /// </summary>
                        [NameInMap("ValueDisplay")]
                        [Validation(Required=false)]
                        public string ValueDisplay { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <list type="bullet">
                    /// <item><description></description></item>
                    /// </list>
                    /// </summary>
                    [NameInMap("DetectSource")]
                    [Validation(Required=false)]
                    public string DetectSource { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("DisplaySandboxResult")]
                    [Validation(Required=false)]
                    public bool? DisplaySandboxResult { get; set; }

                    [NameInMap("EventNotes")]
                    [Validation(Required=false)]
                    public List<DescribeSuspEventsResponseBodyDataBodySuspEventsEventNotes> EventNotes { get; set; }
                    public class DescribeSuspEventsResponseBodyDataBodySuspEventsEventNotes : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>test</para>
                        /// </summary>
                        [NameInMap("Note")]
                        [Validation(Required=false)]
                        public string Note { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>2859481</para>
                        /// </summary>
                        [NameInMap("NoteId")]
                        [Validation(Required=false)]
                        public long? NoteId { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>2018-09-26 01:51:01</para>
                        /// </summary>
                        [NameInMap("NoteTime")]
                        [Validation(Required=false)]
                        public string NoteTime { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("EventStatus")]
                    [Validation(Required=false)]
                    public int? EventStatus { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>login_common_location</para>
                    /// </summary>
                    [NameInMap("EventSubType")]
                    [Validation(Required=false)]
                    public string EventSubType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("HasTraceInfo")]
                    [Validation(Required=false)]
                    public bool? HasTraceInfo { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>3178</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>ccdab289-9765-47ef-af50-ba6be09aacd6</para>
                    /// </summary>
                    [NameInMap("ImageUuid")]
                    [Validation(Required=false)]
                    public string ImageUuid { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>i-9dp6dwsxdl9z5u1e2f****</para>
                    /// </summary>
                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>nginx</para>
                    /// </summary>
                    [NameInMap("InstanceName")]
                    [Validation(Required=false)]
                    public string InstanceName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>8.137.3*.6</para>
                    /// </summary>
                    [NameInMap("InternetIp")]
                    [Validation(Required=false)]
                    public string InternetIp { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>10.36.*6.149</para>
                    /// </summary>
                    [NameInMap("IntranetIp")]
                    [Validation(Required=false)]
                    public string IntranetIp { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>ce3c41ed427794a7bb3d9da4554fc8039</para>
                    /// </summary>
                    [NameInMap("K8sClusterId")]
                    [Validation(Required=false)]
                    public string K8sClusterId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>testName</para>
                    /// </summary>
                    [NameInMap("K8sClusterName")]
                    [Validation(Required=false)]
                    public string K8sClusterName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>default</para>
                    /// </summary>
                    [NameInMap("K8sNamespace")]
                    [Validation(Required=false)]
                    public string K8sNamespace { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>i-bp14a1ay8e0aa9t0****</para>
                    /// </summary>
                    [NameInMap("K8sNodeId")]
                    [Validation(Required=false)]
                    public string K8sNodeId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>N/A</para>
                    /// </summary>
                    [NameInMap("K8sNodeName")]
                    [Validation(Required=false)]
                    public string K8sNodeName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>myapp-pod</para>
                    /// </summary>
                    [NameInMap("K8sPodName")]
                    [Validation(Required=false)]
                    public string K8sPodName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("LargeModel")]
                    [Validation(Required=false)]
                    public bool? LargeModel { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2018-09-26 01:51:01</para>
                    /// </summary>
                    [NameInMap("LastTime")]
                    [Validation(Required=false)]
                    public string LastTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1631699497000</para>
                    /// </summary>
                    [NameInMap("LastTimeStamp")]
                    [Validation(Required=false)]
                    public long? LastTimeStamp { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>remind</para>
                    /// </summary>
                    [NameInMap("Level")]
                    [Validation(Required=false)]
                    public string Level { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>open</para>
                    /// </summary>
                    [NameInMap("MaliciousRuleStatus")]
                    [Validation(Required=false)]
                    public string MaliciousRuleStatus { get; set; }

                    [NameInMap("MarkList")]
                    [Validation(Required=false)]
                    public List<string> MarkList { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para><b>1.</b>&amp;nbsp&amp;nbsppath&amp;nbsp&amp;nbspcontain&amp;nbsp&amp;nbsp232&amp;nbsp&amp;nbsp</para>
                    /// </summary>
                    [NameInMap("MarkMisRules")]
                    [Validation(Required=false)]
                    public string MarkMisRules { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Unusual Logon-Login with unusual location</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2018-09-26 01:51:01</para>
                    /// </summary>
                    [NameInMap("OccurrenceTime")]
                    [Validation(Required=false)]
                    public string OccurrenceTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1631699497000</para>
                    /// </summary>
                    [NameInMap("OccurrenceTimeStamp")]
                    [Validation(Required=false)]
                    public long? OccurrenceTimeStamp { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>kill_and_quara.Success</para>
                    /// </summary>
                    [NameInMap("OperateErrorCode")]
                    [Validation(Required=false)]
                    public string OperateErrorCode { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>success</para>
                    /// </summary>
                    [NameInMap("OperateMsg")]
                    [Validation(Required=false)]
                    public string OperateMsg { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1631699497000</para>
                    /// </summary>
                    [NameInMap("OperateTime")]
                    [Validation(Required=false)]
                    public long? OperateTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("SaleVersion")]
                    [Validation(Required=false)]
                    public string SaleVersion { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>628978308</para>
                    /// </summary>
                    [NameInMap("SecurityEventIds")]
                    [Validation(Required=false)]
                    public string SecurityEventIds { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>124075**67406</para>
                    /// </summary>
                    [NameInMap("SourceAliUid")]
                    [Validation(Required=false)]
                    public long? SourceAliUid { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>&quot;[&quot;authority_maintenance&quot;]&quot;</para>
                    /// </summary>
                    [NameInMap("Stages")]
                    [Validation(Required=false)]
                    public string Stages { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>AI.false_positive</para>
                    /// </summary>
                    [NameInMap("SupportOperateCode")]
                    [Validation(Required=false)]
                    public string SupportOperateCode { get; set; }

                    [NameInMap("TacticItems")]
                    [Validation(Required=false)]
                    public List<DescribeSuspEventsResponseBodyDataBodySuspEventsTacticItems> TacticItems { get; set; }
                    public class DescribeSuspEventsResponseBodyDataBodySuspEventsTacticItems : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>Malicious scripts-Malicious script code execution</para>
                        /// </summary>
                        [NameInMap("TacticDisplayName")]
                        [Validation(Required=false)]
                        public string TacticDisplayName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>TA0042</para>
                        /// </summary>
                        [NameInMap("TacticId")]
                        [Validation(Required=false)]
                        public string TacticId { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1dfbdf56c5343b63c4854d08ec20e067</para>
                    /// </summary>
                    [NameInMap("UniqueInfo")]
                    [Validation(Required=false)]
                    public string UniqueInfo { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>9A75F21D3993C0A2B094A4AB132890B2</para>
                    /// </summary>
                    [NameInMap("Uuid")]
                    [Validation(Required=false)]
                    public string Uuid { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>72</para>
                /// </summary>
                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public int? TotalCount { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>67BD8435-6624-5484-A75D-170231B51615</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
