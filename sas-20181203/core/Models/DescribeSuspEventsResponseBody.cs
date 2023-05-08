// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeSuspEventsResponseBody : TeaModel {
        /// <summary>
        /// The number of entries returned on the current page.
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// An array that consists of the information about the alert event.
        /// </summary>
        [NameInMap("SuspEvents")]
        [Validation(Required=false)]
        public List<DescribeSuspEventsResponseBodySuspEvents> SuspEvents { get; set; }
        public class DescribeSuspEventsResponseBodySuspEvents : TeaModel {
            /// <summary>
            /// Indicates whether the alert was analyzed offline.
            /// </summary>
            [NameInMap("Advanced")]
            [Validation(Required=false)]
            public bool? Advanced { get; set; }

            /// <summary>
            /// The name of the alert event.
            /// </summary>
            [NameInMap("AlarmEventName")]
            [Validation(Required=false)]
            public string AlarmEventName { get; set; }

            /// <summary>
            /// The description of the alert event to which the alert event is associated.
            /// </summary>
            [NameInMap("AlarmEventNameDisplay")]
            [Validation(Required=false)]
            public string AlarmEventNameDisplay { get; set; }

            /// <summary>
            /// The type of the alert event.
            /// </summary>
            [NameInMap("AlarmEventType")]
            [Validation(Required=false)]
            public string AlarmEventType { get; set; }

            /// <summary>
            /// The type of the alert event.
            /// </summary>
            [NameInMap("AlarmEventTypeDisplay")]
            [Validation(Required=false)]
            public string AlarmEventTypeDisplay { get; set; }

            /// <summary>
            /// The ID of the alert event.
            /// </summary>
            [NameInMap("AlarmUniqueInfo")]
            [Validation(Required=false)]
            public string AlarmUniqueInfo { get; set; }

            /// <summary>
            /// The name of the application to which the alert event belongs.
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// Indicates whether the exception is automatically blocked.
            /// </summary>
            [NameInMap("AutoBreaking")]
            [Validation(Required=false)]
            public bool? AutoBreaking { get; set; }

            /// <summary>
            /// Indicates whether the online handling of the alert event is supported, such as quarantining the source file of the malicious process. Valid values:
            /// 
            /// *   **true**: yes
            /// *   **false**: no
            /// </summary>
            [NameInMap("CanBeDealOnLine")]
            [Validation(Required=false)]
            public bool? CanBeDealOnLine { get; set; }

            /// <summary>
            /// Indicates whether you can cancel marking the alert event as a false positive.
            /// </summary>
            [NameInMap("CanCancelFault")]
            [Validation(Required=false)]
            public bool? CanCancelFault { get; set; }

            /// <summary>
            /// Indicates whether the Safeguard Mode For Major Activities mode is enabled for the server. Valid values:
            /// 
            /// *   **true**: yes
            /// *   **false**: no
            /// </summary>
            [NameInMap("ContainHwMode")]
            [Validation(Required=false)]
            public bool? ContainHwMode { get; set; }

            /// <summary>
            /// The ID of the container.
            /// </summary>
            [NameInMap("ContainerId")]
            [Validation(Required=false)]
            public string ContainerId { get; set; }

            /// <summary>
            /// The ID of the image to which the container belongs.
            /// </summary>
            [NameInMap("ContainerImageId")]
            [Validation(Required=false)]
            public string ContainerImageId { get; set; }

            /// <summary>
            /// The name of the container image.
            /// </summary>
            [NameInMap("ContainerImageName")]
            [Validation(Required=false)]
            public string ContainerImageName { get; set; }

            /// <summary>
            /// The source of data. This parameter can be ignored.
            /// </summary>
            [NameInMap("DataSource")]
            [Validation(Required=false)]
            public string DataSource { get; set; }

            /// <summary>
            /// The impact of the alert event.
            /// </summary>
            [NameInMap("Desc")]
            [Validation(Required=false)]
            public string Desc { get; set; }

            /// <summary>
            /// The details of the alert event.
            /// </summary>
            [NameInMap("Details")]
            [Validation(Required=false)]
            public List<DescribeSuspEventsResponseBodySuspEventsDetails> Details { get; set; }
            public class DescribeSuspEventsResponseBodySuspEventsDetails : TeaModel {
                /// <summary>
                /// The display name of the alert event.
                /// </summary>
                [NameInMap("NameDisplay")]
                [Validation(Required=false)]
                public string NameDisplay { get; set; }

                /// <summary>
                /// The type of the alert event.
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// The path of the alert event.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

                /// <summary>
                /// The display path of the alert event.
                /// </summary>
                [NameInMap("ValueDisplay")]
                [Validation(Required=false)]
                public string ValueDisplay { get; set; }

            }

            /// <summary>
            /// Indicates whether the exception can be detected by cloud sandbox. Valid values:
            /// 
            /// *   **true**: yes
            /// *   **false**: no
            /// </summary>
            [NameInMap("DisplaySandboxResult")]
            [Validation(Required=false)]
            public bool? DisplaySandboxResult { get; set; }

            /// <summary>
            /// An array that consists of the remarks on the exception.
            /// </summary>
            [NameInMap("EventNotes")]
            [Validation(Required=false)]
            public List<DescribeSuspEventsResponseBodySuspEventsEventNotes> EventNotes { get; set; }
            public class DescribeSuspEventsResponseBodySuspEventsEventNotes : TeaModel {
                /// <summary>
                /// The remarks.
                /// </summary>
                [NameInMap("Note")]
                [Validation(Required=false)]
                public string Note { get; set; }

                /// <summary>
                /// The ID of the event record.
                /// </summary>
                [NameInMap("NoteId")]
                [Validation(Required=false)]
                public long? NoteId { get; set; }

                /// <summary>
                /// The time when the event record was created.
                /// </summary>
                [NameInMap("NoteTime")]
                [Validation(Required=false)]
                public string NoteTime { get; set; }

            }

            /// <summary>
            /// The status of the alert event. Valid values:
            /// 
            /// *   **1**: pending handling
            /// *   **2**: ignored
            /// *   **4**: confirmed
            /// *   **8**: marked as a false positive
            /// *   **16**: being handled
            /// *   **32**: handled
            /// *   **64**: expired
            /// </summary>
            [NameInMap("EventStatus")]
            [Validation(Required=false)]
            public int? EventStatus { get; set; }

            /// <summary>
            /// The name of the alert event.
            /// </summary>
            [NameInMap("EventSubType")]
            [Validation(Required=false)]
            public string EventSubType { get; set; }

            /// <summary>
            /// Indicates whether the alert event has trace information. Valid values:
            /// 
            /// *   **true**: yes
            /// *   **false**: no
            /// </summary>
            [NameInMap("HasTraceInfo")]
            [Validation(Required=false)]
            public bool? HasTraceInfo { get; set; }

            /// <summary>
            /// The ID of the alert event.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("ImageUuid")]
            [Validation(Required=false)]
            public string ImageUuid { get; set; }

            /// <summary>
            /// The ID of the affected asset.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The name of the associated instance.
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// The public IP address of the associated instance.
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            /// <summary>
            /// The private IP address of the associated instance.
            /// </summary>
            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            /// <summary>
            /// The ID of the Kubernetes cluster.
            /// </summary>
            [NameInMap("K8sClusterId")]
            [Validation(Required=false)]
            public string K8sClusterId { get; set; }

            /// <summary>
            /// The name of the Kubernetes cluster.
            /// </summary>
            [NameInMap("K8sClusterName")]
            [Validation(Required=false)]
            public string K8sClusterName { get; set; }

            /// <summary>
            /// The namespace of the Kubernetes cluster.
            /// </summary>
            [NameInMap("K8sNamespace")]
            [Validation(Required=false)]
            public string K8sNamespace { get; set; }

            /// <summary>
            /// The ID of the Kubernetes cluster node.
            /// </summary>
            [NameInMap("K8sNodeId")]
            [Validation(Required=false)]
            public string K8sNodeId { get; set; }

            /// <summary>
            /// The name of the Kubernetes cluster node.
            /// </summary>
            [NameInMap("K8sNodeName")]
            [Validation(Required=false)]
            public string K8sNodeName { get; set; }

            /// <summary>
            /// The name of the Kubernetes pod.
            /// </summary>
            [NameInMap("K8sPodName")]
            [Validation(Required=false)]
            public string K8sPodName { get; set; }

            /// <summary>
            /// The time when the alert event was last generated.
            /// </summary>
            [NameInMap("LastTime")]
            [Validation(Required=false)]
            public string LastTime { get; set; }

            /// <summary>
            /// The timestamp when the exception was last detected. Unit: milliseconds.
            /// </summary>
            [NameInMap("LastTimeStamp")]
            [Validation(Required=false)]
            public long? LastTimeStamp { get; set; }

            /// <summary>
            /// The severity of the alert event. Valid values:
            /// 
            /// *   **serious**
            /// *   **suspicious**
            /// *   **remind**
            /// </summary>
            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            /// <summary>
            /// The status of the malicious behavior defense rule. Valid values:
            /// 
            /// *   **open**: enabled
            /// *   **close**: disabled
            /// </summary>
            [NameInMap("MaliciousRuleStatus")]
            [Validation(Required=false)]
            public string MaliciousRuleStatus { get; set; }

            /// <summary>
            /// The advanced whitelist rule.
            /// </summary>
            [NameInMap("MarkMisRules")]
            [Validation(Required=false)]
            public string MarkMisRules { get; set; }

            /// <summary>
            /// The complete name of the alert event.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The time when the alert event was first detected.
            /// </summary>
            [NameInMap("OccurrenceTime")]
            [Validation(Required=false)]
            public string OccurrenceTime { get; set; }

            /// <summary>
            /// The timestamp when the exception was first detected. Unit: milliseconds.
            /// </summary>
            [NameInMap("OccurrenceTimeStamp")]
            [Validation(Required=false)]
            public long? OccurrenceTimeStamp { get; set; }

            /// <summary>
            /// The handling result code of the alert event.
            /// </summary>
            [NameInMap("OperateErrorCode")]
            [Validation(Required=false)]
            public string OperateErrorCode { get; set; }

            /// <summary>
            /// The description of the handing result of the alert event.
            /// </summary>
            [NameInMap("OperateMsg")]
            [Validation(Required=false)]
            public string OperateMsg { get; set; }

            /// <summary>
            /// The handling timestamp of the alert event. Unit: milliseconds.
            /// </summary>
            [NameInMap("OperateTime")]
            [Validation(Required=false)]
            public long? OperateTime { get; set; }

            /// <summary>
            /// The edition of Security Center in which the exception can be detected. Valid values:
            /// 
            /// *   **0**: Basic edition
            /// *   **1**: Enterprise edition
            /// </summary>
            [NameInMap("SaleVersion")]
            [Validation(Required=false)]
            public string SaleVersion { get; set; }

            /// <summary>
            /// The IDs of the associated alert events.
            /// </summary>
            [NameInMap("SecurityEventIds")]
            [Validation(Required=false)]
            public string SecurityEventIds { get; set; }

            /// <summary>
            /// The stage at which the attack is detected.
            /// </summary>
            [NameInMap("Stages")]
            [Validation(Required=false)]
            public string Stages { get; set; }

            /// <summary>
            /// The display name of the attack stage.
            /// </summary>
            [NameInMap("TacticItems")]
            [Validation(Required=false)]
            public List<DescribeSuspEventsResponseBodySuspEventsTacticItems> TacticItems { get; set; }
            public class DescribeSuspEventsResponseBodySuspEventsTacticItems : TeaModel {
                /// <summary>
                /// The tactic name of ATT\&CK.
                /// </summary>
                [NameInMap("TacticDisplayName")]
                [Validation(Required=false)]
                public string TacticDisplayName { get; set; }

                /// <summary>
                /// The stage information about ATT\&CK.
                /// </summary>
                [NameInMap("TacticId")]
                [Validation(Required=false)]
                public string TacticId { get; set; }

            }

            /// <summary>
            /// The unique key of the alert.
            /// </summary>
            [NameInMap("UniqueInfo")]
            [Validation(Required=false)]
            public string UniqueInfo { get; set; }

            /// <summary>
            /// The ID of the associated instance.
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

            /// <summary>
            /// The ID of the cluster.
            /// </summary>
            [NameInMap("clusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

        }

        /// <summary>
        /// The total number of alert events.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
