// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeAlarmEventListResponseBody : TeaModel {
        /// <summary>
        /// The pagination information.
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeAlarmEventListResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeAlarmEventListResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// The number of entries returned per page.
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
            /// The number of entries returned per page. Default value: **20**.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// An array that consists of the alert events.
        /// </summary>
        [NameInMap("SuspEvents")]
        [Validation(Required=false)]
        public List<DescribeAlarmEventListResponseBodySuspEvents> SuspEvents { get; set; }
        public class DescribeAlarmEventListResponseBodySuspEvents : TeaModel {
            /// <summary>
            /// The name of the alert event.
            /// </summary>
            [NameInMap("AlarmEventName")]
            [Validation(Required=false)]
            public string AlarmEventName { get; set; }

            /// <summary>
            /// The original parent name of the alert event.
            /// </summary>
            [NameInMap("AlarmEventNameOriginal")]
            [Validation(Required=false)]
            public string AlarmEventNameOriginal { get; set; }

            /// <summary>
            /// The type of the alert event.
            /// </summary>
            [NameInMap("AlarmEventType")]
            [Validation(Required=false)]
            public string AlarmEventType { get; set; }

            /// <summary>
            /// The ID of the alert event.
            /// </summary>
            [NameInMap("AlarmUniqueInfo")]
            [Validation(Required=false)]
            public string AlarmUniqueInfo { get; set; }

            /// <summary>
            /// Indicates whether the online processing of the alert event is supported, such as quarantining the source file of the malicious process, adding the alert event to the whitelist, and ignoring the alert event. Valid values:
            /// 
            /// *   **true**: yes
            /// *   **false**: no
            /// </summary>
            [NameInMap("CanBeDealOnLine")]
            [Validation(Required=false)]
            public bool? CanBeDealOnLine { get; set; }

            /// <summary>
            /// Indicates whether you can cancel marking the alert event as a false positive. Valid values:
            /// 
            /// *   **true**: yes
            /// *   **false**: no
            /// </summary>
            [NameInMap("CanCancelFault")]
            [Validation(Required=false)]
            public bool? CanCancelFault { get; set; }

            /// <summary>
            /// The data source of the alert event.
            /// </summary>
            [NameInMap("DataSource")]
            [Validation(Required=false)]
            public string DataSource { get; set; }

            /// <summary>
            /// Indicates whether the alert event is handled. Valid values:
            /// 
            /// *   **true**: yes
            /// *   **false**: no
            /// </summary>
            [NameInMap("Dealed")]
            [Validation(Required=false)]
            public bool? Dealed { get; set; }

            /// <summary>
            /// The description of the alert event.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The timestamp when the alert event was last detected. Unit: milliseconds.
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// The timestamp when the alert event was last modified. Unit: milliseconds.
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// Indicates whether the alert event has tracing information. Valid values:
            /// 
            /// *   **true**: yes
            /// *   **false**: no
            /// </summary>
            [NameInMap("HasTraceInfo")]
            [Validation(Required=false)]
            public bool? HasTraceInfo { get; set; }

            /// <summary>
            /// The ID of the affected asset.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The name of the affected asset.
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// The public IP address of the affected asset.
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            /// <summary>
            /// The private IP address of the affected asset.
            /// </summary>
            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            /// <summary>
            /// The risk level of the alert event. Valid values:
            /// 
            /// *   **serious**
            /// *   **suspicious**
            /// *   **remind**
            /// </summary>
            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            /// <summary>
            /// The handling result code of the alert event.
            /// </summary>
            [NameInMap("OperateErrorCode")]
            [Validation(Required=false)]
            public string OperateErrorCode { get; set; }

            /// <summary>
            /// The timestamp when the alert event was handled. Unit: milliseconds.
            /// </summary>
            [NameInMap("OperateTime")]
            [Validation(Required=false)]
            public long? OperateTime { get; set; }

            /// <summary>
            /// The edition of Security Center in which the alert event can be detected. Valid values:
            /// 
            /// *   **0**: Basic edition
            /// *   **1**: Advanced edition
            /// *   **2**: Enterprise edition
            /// </summary>
            [NameInMap("SaleVersion")]
            [Validation(Required=false)]
            public string SaleVersion { get; set; }

            /// <summary>
            /// The IDs of the associated exceptions.
            /// </summary>
            [NameInMap("SecurityEventIds")]
            [Validation(Required=false)]
            public string SecurityEventIds { get; set; }

            /// <summary>
            /// The solution to the alert event.
            /// </summary>
            [NameInMap("Solution")]
            [Validation(Required=false)]
            public string Solution { get; set; }

            /// <summary>
            /// The stage at which the attack or intrusion is detected.
            /// </summary>
            [NameInMap("Stages")]
            [Validation(Required=false)]
            public string Stages { get; set; }

            /// <summary>
            /// The timestamp when the alert event starts. Unit: milliseconds.
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// The number of associated exceptions.
            /// </summary>
            [NameInMap("SuspiciousEventCount")]
            [Validation(Required=false)]
            public int? SuspiciousEventCount { get; set; }

            /// <summary>
            /// An array that consists of the stage information about ATT\&CK.
            /// </summary>
            [NameInMap("TacticItems")]
            [Validation(Required=false)]
            public List<DescribeAlarmEventListResponseBodySuspEventsTacticItems> TacticItems { get; set; }
            public class DescribeAlarmEventListResponseBodySuspEventsTacticItems : TeaModel {
                /// <summary>
                /// The tactic name of ATT\&CK.
                /// </summary>
                [NameInMap("TacticDisplayName")]
                [Validation(Required=false)]
                public string TacticDisplayName { get; set; }

                /// <summary>
                /// The tactic ID of ATT\&CK.
                /// </summary>
                [NameInMap("TacticId")]
                [Validation(Required=false)]
                public string TacticId { get; set; }

            }

            /// <summary>
            /// The ID of the associated instance.
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

    }

}
