// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeEventsResponseBody : TeaModel {
        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// An array that consists of the anomalous events.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeEventsResponseBodyItems> Items { get; set; }
        public class DescribeEventsResponseBodyItems : TeaModel {
            /// <summary>
            /// The time when an alert was triggered for the anomalous event. The value is a UNIX timestamp. Unit: milliseconds.
            /// </summary>
            [NameInMap("AlertTime")]
            [Validation(Required=false)]
            public long? AlertTime { get; set; }

            /// <summary>
            /// Indicates whether the detection of anomalous events is enhanced. If the detection of anomalous events is enhanced, the detection accuracy and the rate of triggering alerts for anomalous events are improved. Valid values:
            /// 
            /// *   true: yes
            /// *   false: no
            /// </summary>
            [NameInMap("Backed")]
            [Validation(Required=false)]
            public bool? Backed { get; set; }

            /// <summary>
            /// The display name of the account that is used to handle the anomalous event.
            /// </summary>
            [NameInMap("DealDisplayName")]
            [Validation(Required=false)]
            public string DealDisplayName { get; set; }

            /// <summary>
            /// The username of the account that is used to handle the anomalous event.
            /// </summary>
            [NameInMap("DealLoginName")]
            [Validation(Required=false)]
            public string DealLoginName { get; set; }

            /// <summary>
            /// The time when the anomalous event was handled. The value is a UNIX timestamp. Unit: milliseconds.
            /// </summary>
            [NameInMap("DealTime")]
            [Validation(Required=false)]
            public long? DealTime { get; set; }

            /// <summary>
            /// The ID of the account that is used to handle the anomalous event.
            /// </summary>
            [NameInMap("DealUserId")]
            [Validation(Required=false)]
            public long? DealUserId { get; set; }

            /// <summary>
            /// The display name of the account that triggered the anomalous event.
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// The time when the anomalous event occurred. The value is a UNIX timestamp. Unit: milliseconds.
            /// </summary>
            [NameInMap("EventTime")]
            [Validation(Required=false)]
            public long? EventTime { get; set; }

            /// <summary>
            /// The ID of the anomalous event.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// The username of the account that triggered the anomalous event.
            /// </summary>
            [NameInMap("LoginName")]
            [Validation(Required=false)]
            public string LoginName { get; set; }

            /// <summary>
            /// The name of the service in which the anomalous event was detected.
            /// </summary>
            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            /// <summary>
            /// The handling status for the anomalous event. Valid values:
            /// 
            /// *   0: unhandled
            /// *   1: confirmed
            /// *   2: marked as false positive
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// The name of the handling status for the anomalous event.
            /// </summary>
            [NameInMap("StatusName")]
            [Validation(Required=false)]
            public string StatusName { get; set; }

            /// <summary>
            /// The code of the anomalous event subtype.
            /// </summary>
            [NameInMap("SubTypeCode")]
            [Validation(Required=false)]
            public string SubTypeCode { get; set; }

            /// <summary>
            /// The name of the anomalous event subtype.
            /// </summary>
            [NameInMap("SubTypeName")]
            [Validation(Required=false)]
            public string SubTypeName { get; set; }

            /// <summary>
            /// The name of the destination service in an anomalous data flow.
            /// </summary>
            [NameInMap("TargetProductCode")]
            [Validation(Required=false)]
            public string TargetProductCode { get; set; }

            /// <summary>
            /// The code of the anomalous event type.
            /// </summary>
            [NameInMap("TypeCode")]
            [Validation(Required=false)]
            public string TypeCode { get; set; }

            /// <summary>
            /// The name of the anomalous event type.
            /// </summary>
            [NameInMap("TypeName")]
            [Validation(Required=false)]
            public string TypeName { get; set; }

            /// <summary>
            /// The ID of the account that triggered the anomalous event.
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public long? UserId { get; set; }

            /// <summary>
            /// The severity of the anomalous event.
            /// 
            /// *   **1**: low
            /// *   **2**: medium
            /// *   **3**: high
            /// </summary>
            [NameInMap("WarnLevel")]
            [Validation(Required=false)]
            public int? WarnLevel { get; set; }

        }

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
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
