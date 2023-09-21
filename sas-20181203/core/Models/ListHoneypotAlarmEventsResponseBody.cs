// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListHoneypotAlarmEventsResponseBody : TeaModel {
        /// <summary>
        /// The alert events.
        /// </summary>
        [NameInMap("HoneypotAlarmEvents")]
        [Validation(Required=false)]
        public List<ListHoneypotAlarmEventsResponseBodyHoneypotAlarmEvents> HoneypotAlarmEvents { get; set; }
        public class ListHoneypotAlarmEventsResponseBodyHoneypotAlarmEvents : TeaModel {
            /// <summary>
            /// The event ID.
            /// </summary>
            [NameInMap("AlarmEventId")]
            [Validation(Required=false)]
            public long? AlarmEventId { get; set; }

            /// <summary>
            /// The name of the alert event.
            /// </summary>
            [NameInMap("AlarmEventName")]
            [Validation(Required=false)]
            public string AlarmEventName { get; set; }

            /// <summary>
            /// The type of the alert event.
            /// </summary>
            [NameInMap("AlarmEventType")]
            [Validation(Required=false)]
            public string AlarmEventType { get; set; }

            /// <summary>
            /// The unique identifier of the alert event.
            /// </summary>
            [NameInMap("AlarmUniqueInfo")]
            [Validation(Required=false)]
            public string AlarmUniqueInfo { get; set; }

            /// <summary>
            /// The total number of times that the alert event was generated.
            /// </summary>
            [NameInMap("EventCount")]
            [Validation(Required=false)]
            public int? EventCount { get; set; }

            /// <summary>
            /// The timestamp that indicates the time when the alert event was first detected. Unit: milliseconds.
            /// </summary>
            [NameInMap("FirstTime")]
            [Validation(Required=false)]
            public long? FirstTime { get; set; }

            /// <summary>
            /// The timestamp that indicates the time when the alert event was last detected. Unit: milliseconds.
            /// </summary>
            [NameInMap("LastTime")]
            [Validation(Required=false)]
            public long? LastTime { get; set; }

            /// <summary>
            /// The risk information.
            /// </summary>
            [NameInMap("MergeFieldList")]
            [Validation(Required=false)]
            public List<ListHoneypotAlarmEventsResponseBodyHoneypotAlarmEventsMergeFieldList> MergeFieldList { get; set; }
            public class ListHoneypotAlarmEventsResponseBodyHoneypotAlarmEventsMergeFieldList : TeaModel {
                /// <summary>
                /// The extended value that corresponds to the field key.
                /// </summary>
                [NameInMap("FieldExtInfo")]
                [Validation(Required=false)]
                public string FieldExtInfo { get; set; }

                /// <summary>
                /// The key of the field.
                /// </summary>
                [NameInMap("FieldKey")]
                [Validation(Required=false)]
                public string FieldKey { get; set; }

                /// <summary>
                /// The type of the field. You can ignore this internal parameter.
                /// </summary>
                [NameInMap("FieldType")]
                [Validation(Required=false)]
                public string FieldType { get; set; }

                /// <summary>
                /// The value that corresponds to the field key.
                /// </summary>
                [NameInMap("FieldValue")]
                [Validation(Required=false)]
                public string FieldValue { get; set; }

            }

            /// <summary>
            /// The handling status of the alert event. Valid values:
            /// 
            /// *   **1**: pending
            /// *   **2**: ignored
            /// *   **4**: confirmed
            /// </summary>
            [NameInMap("OperateStatus")]
            [Validation(Required=false)]
            public int? OperateStatus { get; set; }

            /// <summary>
            /// The risk level. Valid values:
            /// 
            /// *   **2**: low
            /// *   **3**: medium
            /// *   **4**: high
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

        }

        /// <summary>
        /// The pagination information.
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListHoneypotAlarmEventsResponseBodyPageInfo PageInfo { get; set; }
        public class ListHoneypotAlarmEventsResponseBodyPageInfo : TeaModel {
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
            /// The number of entries returned per page. Default value: 100.
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
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
