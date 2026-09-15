// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeSuspEventsResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of entries returned on the current page in a paged query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>The page number of the current page in a paged query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The maximum number of entries per page in a paged query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0D6E20E4-8326-1D03-A553-2182BE9E82F9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The security alert information.</para>
        /// </summary>
        [NameInMap("SuspEvents")]
        [Validation(Required=false)]
        public List<DescribeSuspEventsResponseBodySuspEvents> SuspEvents { get; set; }
        public class DescribeSuspEventsResponseBodySuspEvents : TeaModel {
            /// <summary>
            /// <para>Indicates whether the alert is from offline analysis.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Advanced")]
            [Validation(Required=false)]
            public bool? Advanced { get; set; }

            /// <summary>
            /// <para>The name of the alert event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>login_common_location</para>
            /// </summary>
            [NameInMap("AlarmEventName")]
            [Validation(Required=false)]
            public string AlarmEventName { get; set; }

            /// <summary>
            /// <para>The display name of the alert.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Login with unusual location</para>
            /// </summary>
            [NameInMap("AlarmEventNameDisplay")]
            [Validation(Required=false)]
            public string AlarmEventNameDisplay { get; set; }

            /// <summary>
            /// <para>The alerting event type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Unusual Logon</para>
            /// </summary>
            [NameInMap("AlarmEventType")]
            [Validation(Required=false)]
            public string AlarmEventType { get; set; }

            /// <summary>
            /// <para>The alerting event type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Unusual Logon</para>
            /// </summary>
            [NameInMap("AlarmEventTypeDisplay")]
            [Validation(Required=false)]
            public string AlarmEventTypeDisplay { get; set; }

            /// <summary>
            /// <para>The unique ID of the alert event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8df914418f****</para>
            /// </summary>
            [NameInMap("AlarmUniqueInfo")]
            [Validation(Required=false)]
            public string AlarmUniqueInfo { get; set; }

            /// <summary>
            /// <para>The name of the application to which the alert event belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pro-deploy-tibasic</para>
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// <para>Indicates whether automatic defense is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AutoBreaking")]
            [Validation(Required=false)]
            public bool? AutoBreaking { get; set; }

            /// <summary>
            /// <para>Indicates whether the alert event can be handled online, such as quarantine. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Online handling is supported.</description></item>
            /// <item><description><b>false</b>: Online handling is not supported.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("CanBeDealOnLine")]
            [Validation(Required=false)]
            public bool? CanBeDealOnLine { get; set; }

            /// <summary>
            /// <para>Indicates whether the false positive marking can be unmarked. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Can be unmarked.</description></item>
            /// <item><description><b>false</b>: Cannot be unmarked.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("CanCancelFault")]
            [Validation(Required=false)]
            public bool? CanCancelFault { get; set; }

            /// <summary>
            /// <para>Indicates whether critical event protection mode is enabled for the server. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Enabled.</description></item>
            /// <item><description><b>false</b>: Not enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("ContainHwMode")]
            [Validation(Required=false)]
            public bool? ContainHwMode { get; set; }

            /// <summary>
            /// <para>The container ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>container_1648601865161_14925_02_000****</para>
            /// </summary>
            [NameInMap("ContainerId")]
            [Validation(Required=false)]
            public string ContainerId { get; set; }

            /// <summary>
            /// <para>The container image ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sha256:2e5a3b0ae5f452b3cb458789a9a7542ef40035a84318469a8528c5e444db1****</para>
            /// </summary>
            [NameInMap("ContainerImageId")]
            [Validation(Required=false)]
            public string ContainerImageId { get; set; }

            /// <summary>
            /// <para>The container image name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>centos7_apache:v1.0.1</para>
            /// </summary>
            [NameInMap("ContainerImageName")]
            [Validation(Required=false)]
            public string ContainerImageName { get; set; }

            /// <summary>
            /// <para>The data source. You can ignore this parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aegis_suspicious_****</para>
            /// </summary>
            [NameInMap("DataSource")]
            [Validation(Required=false)]
            public string DataSource { get; set; }

            /// <summary>
            /// <para>The download URL of the deep file analysis report.</para>
            /// <remarks>
            /// <para>Deep file analysis is triggered only for machines that have the AgenticEDR feature enabled.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("DeepAnalyzeReportUrl")]
            [Validation(Required=false)]
            public string DeepAnalyzeReportUrl { get; set; }

            /// <summary>
            /// <para>The description of the impact of the alert event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>webshell</para>
            /// </summary>
            [NameInMap("Desc")]
            [Validation(Required=false)]
            public string Desc { get; set; }

            /// <summary>
            /// <para>The details of the alert event.</para>
            /// </summary>
            [NameInMap("Details")]
            [Validation(Required=false)]
            public List<DescribeSuspEventsResponseBodySuspEventsDetails> Details { get; set; }
            public class DescribeSuspEventsResponseBodySuspEventsDetails : TeaModel {
                /// <summary>
                /// <para>The display name of the alert event.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Login with unusual location</para>
                /// </summary>
                [NameInMap("NameDisplay")]
                [Validation(Required=false)]
                public string NameDisplay { get; set; }

                /// <summary>
                /// <para>The alerting event type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>text</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The path where the alert event occurred.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/etc/crontab</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

                /// <summary>
                /// <para>The path where the alert event occurred.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/etc/crontab</para>
                /// </summary>
                [NameInMap("ValueDisplay")]
                [Validation(Required=false)]
                public string ValueDisplay { get; set; }

            }

            /// <summary>
            /// <para>The discovery source. This is an invalid field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>linux</para>
            /// </summary>
            [NameInMap("DetectSource")]
            [Validation(Required=false)]
            public string DetectSource { get; set; }

            /// <summary>
            /// <para>Indicates whether cloud sandbox detection is supported. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Supported.</description></item>
            /// <item><description><b>false</b>: Not supported.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("DisplaySandboxResult")]
            [Validation(Required=false)]
            public bool? DisplaySandboxResult { get; set; }

            /// <summary>
            /// <para>The notes of the alert event.</para>
            /// </summary>
            [NameInMap("EventNotes")]
            [Validation(Required=false)]
            public List<DescribeSuspEventsResponseBodySuspEventsEventNotes> EventNotes { get; set; }
            public class DescribeSuspEventsResponseBodySuspEventsEventNotes : TeaModel {
                /// <summary>
                /// <para>The note information.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test</para>
                /// </summary>
                [NameInMap("Note")]
                [Validation(Required=false)]
                public string Note { get; set; }

                /// <summary>
                /// <para>The event record ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("NoteId")]
                [Validation(Required=false)]
                public long? NoteId { get; set; }

                /// <summary>
                /// <para>The event record time. Format: YYYY-MM-DD HH:mm:ss.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2018-09-26 01:51:01</para>
                /// </summary>
                [NameInMap("NoteTime")]
                [Validation(Required=false)]
                public string NoteTime { get; set; }

            }

            /// <summary>
            /// <para>The status of the alert event. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: PENDING.</description></item>
            /// <item><description><b>2</b>: IGNORE (ignored).</description></item>
            /// <item><description><b>4</b>: HANDLED (confirmed).</description></item>
            /// <item><description><b>8</b>: FAULT (marked as false positive).</description></item>
            /// <item><description><b>16</b>: DEALING (being handled).</description></item>
            /// <item><description><b>32</b>: DONE (handling completed).</description></item>
            /// <item><description><b>64</b>: EXPIRE (expired).</description></item>
            /// <item><description><b>604</b>: SYSTEM_FAULT (marked as false positive by the system).</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("EventStatus")]
            [Validation(Required=false)]
            public int? EventStatus { get; set; }

            /// <summary>
            /// <para>The subtype of the alert event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>login_common_location</para>
            /// </summary>
            [NameInMap("EventSubType")]
            [Validation(Required=false)]
            public string EventSubType { get; set; }

            /// <summary>
            /// <para>Indicates whether the alert event has tracing information. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Has tracing information.</description></item>
            /// <item><description><b>false</b>: Does not have tracing information.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HasTraceInfo")]
            [Validation(Required=false)]
            public bool? HasTraceInfo { get; set; }

            /// <summary>
            /// <para>The unique ID of the alert event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The UUID of the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>70489fb520cea585ad9761d5a842****</para>
            /// </summary>
            [NameInMap("ImageUuid")]
            [Validation(Required=false)]
            public string ImageUuid { get; set; }

            /// <summary>
            /// <para>The ID of the asset instance affected by the alert event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-9dp6dwsxdl9z5u1e2f****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The name of the associated instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>nginx</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The public IP address of the associated instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.2.XX.XX</para>
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            /// <summary>
            /// <para>The private IP address of the associated instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100.100.XX.XX</para>
            /// </summary>
            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            /// <summary>
            /// <para>The ID of the Kubernetes cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c517b37e1401e4961b3951863a49a****</para>
            /// </summary>
            [NameInMap("K8sClusterId")]
            [Validation(Required=false)]
            public string K8sClusterId { get; set; }

            /// <summary>
            /// <para>The name of the Kubernetes cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-daily</para>
            /// </summary>
            [NameInMap("K8sClusterName")]
            [Validation(Required=false)]
            public string K8sClusterName { get; set; }

            /// <summary>
            /// <para>The Kubernetes namespace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("K8sNamespace")]
            [Validation(Required=false)]
            public string K8sNamespace { get; set; }

            /// <summary>
            /// <para>The ID of the Kubernetes node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-bp14a1ay8e0aa9t0****</para>
            /// </summary>
            [NameInMap("K8sNodeId")]
            [Validation(Required=false)]
            public string K8sNodeId { get; set; }

            /// <summary>
            /// <para>The name of the Kubernetes node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>N/A</para>
            /// </summary>
            [NameInMap("K8sNodeName")]
            [Validation(Required=false)]
            public string K8sNodeName { get; set; }

            /// <summary>
            /// <para>The name of the Kubernetes pod.</para>
            /// 
            /// <b>Example:</b>
            /// <para>myapp-pod</para>
            /// </summary>
            [NameInMap("K8sPodName")]
            [Validation(Required=false)]
            public string K8sPodName { get; set; }

            /// <summary>
            /// <para>Indicates whether large model analysis tagging is supported. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Supported.</description></item>
            /// <item><description><b>false</b>: Not supported.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("LargeModel")]
            [Validation(Required=false)]
            public bool? LargeModel { get; set; }

            /// <summary>
            /// <para>The most recent time when the alert event occurred. Format: YYYY-MM-DD HH:mm:ss.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2018-09-26 01:51:01</para>
            /// </summary>
            [NameInMap("LastTime")]
            [Validation(Required=false)]
            public string LastTime { get; set; }

            /// <summary>
            /// <para>The timestamp of the last occurrence, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1631699497000</para>
            /// </summary>
            [NameInMap("LastTimeStamp")]
            [Validation(Required=false)]
            public long? LastTimeStamp { get; set; }

            /// <summary>
            /// <para>The severity level of the alert event. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>serious</b>: Critical.</description></item>
            /// <item><description><b>suspicious</b>: Suspicious.</description></item>
            /// <item><description><b>remind</b>: Reminder.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>serious</para>
            /// </summary>
            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            /// <summary>
            /// <para>The status of the malicious behavior defense rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>open</b>: Enabled.</description></item>
            /// <item><description><b>close</b>: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>open</para>
            /// </summary>
            [NameInMap("MaliciousRuleStatus")]
            [Validation(Required=false)]
            public string MaliciousRuleStatus { get; set; }

            /// <summary>
            /// <para>The collection of alert event tags.</para>
            /// </summary>
            [NameInMap("MarkList")]
            [Validation(Required=false)]
            public List<string> MarkList { get; set; }

            /// <summary>
            /// <para>The advanced whitelisting rules.</para>
            /// 
            /// <b>Example:</b>
            /// <para><b>1.</b>&amp;nbsp&amp;nbsppath&amp;nbsp&amp;nbspcontain&amp;nbsp&amp;nbsp232&amp;nbsp&amp;nbsp</para>
            /// </summary>
            [NameInMap("MarkMisRules")]
            [Validation(Required=false)]
            public string MarkMisRules { get; set; }

            /// <summary>
            /// <para>The full name of the alert event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Unusual Logon-Login with unusual location</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The time when the alert event first occurred. Format: YYYY-MM-DD HH:mm:ss.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2018-09-26 01:51:01</para>
            /// </summary>
            [NameInMap("OccurrenceTime")]
            [Validation(Required=false)]
            public string OccurrenceTime { get; set; }

            /// <summary>
            /// <para>The timestamp of the first occurrence, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1631699497000</para>
            /// </summary>
            [NameInMap("OccurrenceTimeStamp")]
            [Validation(Required=false)]
            public long? OccurrenceTimeStamp { get; set; }

            /// <summary>
            /// <para>The error code of the alert event operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>kill_and_quara.Success</para>
            /// </summary>
            [NameInMap("OperateErrorCode")]
            [Validation(Required=false)]
            public string OperateErrorCode { get; set; }

            /// <summary>
            /// <para>The remarks of the alert event operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("OperateMsg")]
            [Validation(Required=false)]
            public string OperateMsg { get; set; }

            /// <summary>
            /// <para>The timestamp of the alert event operation, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1631699497000</para>
            /// </summary>
            [NameInMap("OperateTime")]
            [Validation(Required=false)]
            public long? OperateTime { get; set; }

            /// <summary>
            /// <para>The product edition that supports the alert event detection. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Basic edition.</description></item>
            /// <item><description><b>1</b>: Enterprise edition.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SaleVersion")]
            [Validation(Required=false)]
            public string SaleVersion { get; set; }

            /// <summary>
            /// <para>The IDs of the alert events associated with this alert event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>270789</para>
            /// </summary>
            [NameInMap("SecurityEventIds")]
            [Validation(Required=false)]
            public string SecurityEventIds { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud account ID that generated the alert.</para>
            /// 
            /// <b>Example:</b>
            /// <para>196072141348****</para>
            /// </summary>
            [NameInMap("SourceAliUid")]
            [Validation(Required=false)]
            public long? SourceAliUid { get; set; }

            /// <summary>
            /// <para>The attack stages.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;[&quot;authority_maintenance&quot;]&quot;</para>
            /// </summary>
            [NameInMap("Stages")]
            [Validation(Required=false)]
            public string Stages { get; set; }

            /// <summary>
            /// <para>The operation type supported by the alert. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>AI.false_positive</b>: Suspected false positive.</description></item>
            /// <item><description><b>AI.real_attack</b>: Real attack.</description></item>
            /// <item><description><b>AI.Insufficient_information_to_evaluate</b>: Unable to determine.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>AI.real_attack</para>
            /// </summary>
            [NameInMap("SupportOperateCode")]
            [Validation(Required=false)]
            public string SupportOperateCode { get; set; }

            /// <summary>
            /// <para>The display names of the attack stages.</para>
            /// </summary>
            [NameInMap("TacticItems")]
            [Validation(Required=false)]
            public List<DescribeSuspEventsResponseBodySuspEventsTacticItems> TacticItems { get; set; }
            public class DescribeSuspEventsResponseBodySuspEventsTacticItems : TeaModel {
                /// <summary>
                /// <para>The ATT&amp;CK tactic name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Malicious scripts-Malicious script code execution</para>
                /// </summary>
                [NameInMap("TacticDisplayName")]
                [Validation(Required=false)]
                public string TacticDisplayName { get; set; }

                /// <summary>
                /// <para>The ATT&amp;CK attack stage information.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TA0001</para>
                /// </summary>
                [NameInMap("TacticId")]
                [Validation(Required=false)]
                public string TacticId { get; set; }

            }

            /// <summary>
            /// <para>The unique key of the security alert.</para>
            /// 
            /// <b>Example:</b>
            /// <para>e17e****</para>
            /// </summary>
            [NameInMap("UniqueInfo")]
            [Validation(Required=false)]
            public string UniqueInfo { get; set; }

            /// <summary>
            /// <para>The unique identifier of the associated instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bf6b30d3-eea8-4924-9f0a-****</para>
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

            /// <summary>
            /// <para>The cluster ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c2051775877374cccbf68af596e6****</para>
            /// </summary>
            [NameInMap("clusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

        }

        /// <summary>
        /// <para>The total number of alert events.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
