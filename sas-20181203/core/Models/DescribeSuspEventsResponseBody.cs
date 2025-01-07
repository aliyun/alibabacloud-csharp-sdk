// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeSuspEventsResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of entries returned on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
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
        /// <para>The information about the alert events.</para>
        /// </summary>
        [NameInMap("SuspEvents")]
        [Validation(Required=false)]
        public List<DescribeSuspEventsResponseBodySuspEvents> SuspEvents { get; set; }
        public class DescribeSuspEventsResponseBodySuspEvents : TeaModel {
            /// <summary>
            /// <para>Indicates whether the alert event was analyzed offline.</para>
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
            /// <para>The name of the alert.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Login with unusual location</para>
            /// </summary>
            [NameInMap("AlarmEventNameDisplay")]
            [Validation(Required=false)]
            public string AlarmEventNameDisplay { get; set; }

            /// <summary>
            /// <para>The type of the alert event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Unusual Logon</para>
            /// </summary>
            [NameInMap("AlarmEventType")]
            [Validation(Required=false)]
            public string AlarmEventType { get; set; }

            /// <summary>
            /// <para>The display name of the type of the alert event.</para>
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
            /// <para>Indicates whether you can handle the alert event online, such as quarantining the source file of the malicious process. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("CanBeDealOnLine")]
            [Validation(Required=false)]
            public bool? CanBeDealOnLine { get; set; }

            /// <summary>
            /// <para>Indicates whether you can cancel marking the alert event as a false positive. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("CanCancelFault")]
            [Validation(Required=false)]
            public bool? CanCancelFault { get; set; }

            /// <summary>
            /// <para>Indicates whether the safeguard mode for major activities is enabled for the server. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("ContainHwMode")]
            [Validation(Required=false)]
            public bool? ContainHwMode { get; set; }

            /// <summary>
            /// <para>The ID of the container.</para>
            /// 
            /// <b>Example:</b>
            /// <para>container_1648601865161_14925_02_000****</para>
            /// </summary>
            [NameInMap("ContainerId")]
            [Validation(Required=false)]
            public string ContainerId { get; set; }

            /// <summary>
            /// <para>The ID of the container image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sha256:2e5a3b0ae5f452b3cb458789a9a7542ef40035a84318469a8528c5e444db1****</para>
            /// </summary>
            [NameInMap("ContainerImageId")]
            [Validation(Required=false)]
            public string ContainerImageId { get; set; }

            /// <summary>
            /// <para>The name of the container image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>centos7_apache:v1.0.1</para>
            /// </summary>
            [NameInMap("ContainerImageName")]
            [Validation(Required=false)]
            public string ContainerImageName { get; set; }

            /// <summary>
            /// <para>The source of data. This parameter can be ignored.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aegis_suspicious_****</para>
            /// </summary>
            [NameInMap("DataSource")]
            [Validation(Required=false)]
            public string DataSource { get; set; }

            /// <summary>
            /// <para>The impact of the alert event.</para>
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
                /// <para>The type of the alert event.</para>
                /// 
                /// <b>Example:</b>
                /// <para>text</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The path of the alert event.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/etc/crontab</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

                /// <summary>
                /// <para>The display name of the path of the alert event.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/etc/crontab</para>
                /// </summary>
                [NameInMap("ValueDisplay")]
                [Validation(Required=false)]
                public string ValueDisplay { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether the alert event can be detected by cloud sandbox. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("DisplaySandboxResult")]
            [Validation(Required=false)]
            public bool? DisplaySandboxResult { get; set; }

            /// <summary>
            /// <para>The note information about the alert event.</para>
            /// </summary>
            [NameInMap("EventNotes")]
            [Validation(Required=false)]
            public List<DescribeSuspEventsResponseBodySuspEventsEventNotes> EventNotes { get; set; }
            public class DescribeSuspEventsResponseBodySuspEventsEventNotes : TeaModel {
                /// <summary>
                /// <para>The note.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test</para>
                /// </summary>
                [NameInMap("Note")]
                [Validation(Required=false)]
                public string Note { get; set; }

                /// <summary>
                /// <para>The ID of the note.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("NoteId")]
                [Validation(Required=false)]
                public long? NoteId { get; set; }

                /// <summary>
                /// <para>The time when the note was created.</para>
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
            /// <item><description><b>1</b>: pending handling</description></item>
            /// <item><description><b>2</b>: ignored</description></item>
            /// <item><description><b>4</b>: confirmed</description></item>
            /// <item><description><b>8</b>: marked as a false positive</description></item>
            /// <item><description><b>16</b>: handling</description></item>
            /// <item><description><b>32</b>: handled</description></item>
            /// <item><description><b>64</b>: expired</description></item>
            /// <item><description><b>604</b>: marked as a false positive by the system</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
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
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
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
            /// <para>The instance ID of the affected asset.</para>
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
            /// <para>k8s-daily</para>
            /// </summary>
            [NameInMap("K8sClusterName")]
            [Validation(Required=false)]
            public string K8sClusterName { get; set; }

            /// <summary>
            /// <para>The namespace of the Kubernetes cluster.</para>
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
            /// <para>Indicates whether the large model analysis tag is supported. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("LargeModel")]
            [Validation(Required=false)]
            public bool? LargeModel { get; set; }

            /// <summary>
            /// <para>The time when the alert event was last detected.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2018-09-26 01:51:01</para>
            /// </summary>
            [NameInMap("LastTime")]
            [Validation(Required=false)]
            public string LastTime { get; set; }

            /// <summary>
            /// <para>The timestamp when the alert event was last detected. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1631699497000</para>
            /// </summary>
            [NameInMap("LastTimeStamp")]
            [Validation(Required=false)]
            public long? LastTimeStamp { get; set; }

            /// <summary>
            /// <para>The severity of the alert event. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>serious</b></description></item>
            /// <item><description><b>suspicious</b></description></item>
            /// <item><description><b>remind</b></description></item>
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
            /// <item><description><b>open</b></description></item>
            /// <item><description><b>close</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>open</para>
            /// </summary>
            [NameInMap("MaliciousRuleStatus")]
            [Validation(Required=false)]
            public string MaliciousRuleStatus { get; set; }

            /// <summary>
            /// <para>The tags of the alert events.</para>
            /// </summary>
            [NameInMap("MarkList")]
            [Validation(Required=false)]
            public List<string> MarkList { get; set; }

            /// <summary>
            /// <para>The advanced whitelist rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{\&quot;uuid\&quot;:\&quot;ALL\&quot;,\&quot;field\&quot;:\&quot;gmtModified\&quot;,\&quot;operate\&quot;:\&quot;contains\&quot;,\&quot;fieldValue\&quot;:\&quot;222\&quot;}]</para>
            /// </summary>
            [NameInMap("MarkMisRules")]
            [Validation(Required=false)]
            public string MarkMisRules { get; set; }

            /// <summary>
            /// <para>The complete name of the alert event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Unusual Logon-Login with unusual location</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The time when the alert event was first detected.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2018-09-26 01:51:01</para>
            /// </summary>
            [NameInMap("OccurrenceTime")]
            [Validation(Required=false)]
            public string OccurrenceTime { get; set; }

            /// <summary>
            /// <para>The timestamp when the alert event was first detected. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1631699497000</para>
            /// </summary>
            [NameInMap("OccurrenceTimeStamp")]
            [Validation(Required=false)]
            public long? OccurrenceTimeStamp { get; set; }

            /// <summary>
            /// <para>The handling result code of the alert event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>kill_and_quara.Success</para>
            /// </summary>
            [NameInMap("OperateErrorCode")]
            [Validation(Required=false)]
            public string OperateErrorCode { get; set; }

            /// <summary>
            /// <para>The handing result message of the alert event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("OperateMsg")]
            [Validation(Required=false)]
            public string OperateMsg { get; set; }

            /// <summary>
            /// <para>The handling timestamp of the alert event. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1631699497000</para>
            /// </summary>
            [NameInMap("OperateTime")]
            [Validation(Required=false)]
            public long? OperateTime { get; set; }

            /// <summary>
            /// <para>The edition of Security Center in which the alert event can be detected. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Basic edition</description></item>
            /// <item><description><b>1</b>: Enterprise edition</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SaleVersion")]
            [Validation(Required=false)]
            public string SaleVersion { get; set; }

            /// <summary>
            /// <para>The ID of the associated alert event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>270789</para>
            /// </summary>
            [NameInMap("SecurityEventIds")]
            [Validation(Required=false)]
            public string SecurityEventIds { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account within which an alert is generated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>196072141348****</para>
            /// </summary>
            [NameInMap("SourceAliUid")]
            [Validation(Required=false)]
            public long? SourceAliUid { get; set; }

            /// <summary>
            /// <para>The stage at which the attack is detected.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;[&quot;authority_maintenance&quot;]&quot;</para>
            /// </summary>
            [NameInMap("Stages")]
            [Validation(Required=false)]
            public string Stages { get; set; }

            /// <summary>
            /// <para>The display name of the attack stage.</para>
            /// </summary>
            [NameInMap("TacticItems")]
            [Validation(Required=false)]
            public List<DescribeSuspEventsResponseBodySuspEventsTacticItems> TacticItems { get; set; }
            public class DescribeSuspEventsResponseBodySuspEventsTacticItems : TeaModel {
                /// <summary>
                /// <para>The tactic name of ATT\&amp;CK.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Malicious scripts-Malicious script code execution</para>
                /// </summary>
                [NameInMap("TacticDisplayName")]
                [Validation(Required=false)]
                public string TacticDisplayName { get; set; }

                /// <summary>
                /// <para>The stage information about ATT\&amp;CK.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TA0001</para>
                /// </summary>
                [NameInMap("TacticId")]
                [Validation(Required=false)]
                public string TacticId { get; set; }

            }

            /// <summary>
            /// <para>The unique key of the alert.</para>
            /// 
            /// <b>Example:</b>
            /// <para>e17e****</para>
            /// </summary>
            [NameInMap("UniqueInfo")]
            [Validation(Required=false)]
            public string UniqueInfo { get; set; }

            /// <summary>
            /// <para>The unique ID of the associated instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bf6b30d3-eea8-4924-9f0a-****</para>
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

            /// <summary>
            /// <para>The ID of the cluster.</para>
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
