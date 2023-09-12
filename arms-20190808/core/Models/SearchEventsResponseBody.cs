// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class SearchEventsResponseBody : TeaModel {
        /// <summary>
        /// Specifies whether the alert event is triggered. If you do not set this parameter, all alert events are queried. Valid values:
        /// 
        /// *   `1`: The event is triggered.
        /// *   `0`: The event is not triggered.
        /// </summary>
        [NameInMap("IsTrigger")]
        [Validation(Required=false)]
        public int? IsTrigger { get; set; }

        /// <summary>
        /// The struct returned.
        /// </summary>
        [NameInMap("PageBean")]
        [Validation(Required=false)]
        public SearchEventsResponseBodyPageBean PageBean { get; set; }
        public class SearchEventsResponseBodyPageBean : TeaModel {
            /// <summary>
            /// The information about the alert events.
            /// </summary>
            [NameInMap("Event")]
            [Validation(Required=false)]
            public List<SearchEventsResponseBodyPageBeanEvent> Event { get; set; }
            public class SearchEventsResponseBodyPageBeanEvent : TeaModel {
                /// <summary>
                /// The ID of the alert rule that is associated with the event.
                /// </summary>
                [NameInMap("AlertId")]
                [Validation(Required=false)]
                public long? AlertId { get; set; }

                /// <summary>
                /// The name of the alert rule that is associated with the event.
                /// </summary>
                [NameInMap("AlertName")]
                [Validation(Required=false)]
                public string AlertName { get; set; }

                /// <summary>
                /// The condition of the alert rule.
                /// </summary>
                [NameInMap("AlertRule")]
                [Validation(Required=false)]
                public string AlertRule { get; set; }

                /// <summary>
                /// The type of the alert rule. This parameter is not returned. Valid values:
                /// 
                /// *   `1`: custom alert rules to monitor drill-down data sets
                /// *   `3`: custom alert rules to monitor tiled data sets
                /// *   `4`: alert rules to monitor the frontend, including the default frontend alert rules
                /// *   `5`: alert rules to monitor applications, including the default application alert rules
                /// *   `6`: the default frontend alert rules
                /// *   `7`: the default application alert rules
                /// *   `8`: Tracing Analysis alert rules
                /// *   `101`: Prometheus alert rules
                /// </summary>
                [NameInMap("AlertType")]
                [Validation(Required=false)]
                public int? AlertType { get; set; }

                /// <summary>
                /// The severity of the event.
                /// </summary>
                [NameInMap("EventLevel")]
                [Validation(Required=false)]
                public string EventLevel { get; set; }

                /// <summary>
                /// The timestamp when the event occurred.
                /// </summary>
                [NameInMap("EventTime")]
                [Validation(Required=false)]
                public long? EventTime { get; set; }

                /// <summary>
                /// The ID of the event record.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// The list of event URLs.
                /// </summary>
                [NameInMap("Links")]
                [Validation(Required=false)]
                public List<string> Links { get; set; }

                /// <summary>
                /// The event content. The parameter value is a JSON string. Each key indicates a dimension and each value indicates the alert content in the dimension.
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

            }

            /// <summary>
            /// The page number of the returned page.
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// The number of entries returned per page.
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
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
