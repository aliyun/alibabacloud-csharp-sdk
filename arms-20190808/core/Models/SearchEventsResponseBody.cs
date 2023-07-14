// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class SearchEventsResponseBody : TeaModel {
        /// <summary>
        /// The process identifier (PID) of the application that is associated with the alert rule.
        /// </summary>
        [NameInMap("IsTrigger")]
        [Validation(Required=false)]
        public int? IsTrigger { get; set; }

        /// <summary>
        /// The event content. The parameter value is a JSON string. Each key indicates a dimension and each value indicates the alert content in the dimension.
        /// </summary>
        [NameInMap("PageBean")]
        [Validation(Required=false)]
        public SearchEventsResponseBodyPageBean PageBean { get; set; }
        public class SearchEventsResponseBodyPageBean : TeaModel {
            /// <summary>
            /// The ID of the event record.
            /// </summary>
            [NameInMap("Event")]
            [Validation(Required=false)]
            public List<SearchEventsResponseBodyPageBeanEvent> Event { get; set; }
            public class SearchEventsResponseBodyPageBeanEvent : TeaModel {
                [NameInMap("AlertId")]
                [Validation(Required=false)]
                public long? AlertId { get; set; }

                [NameInMap("AlertName")]
                [Validation(Required=false)]
                public string AlertName { get; set; }

                /// <summary>
                /// The ID of the request.
                /// </summary>
                [NameInMap("AlertRule")]
                [Validation(Required=false)]
                public string AlertRule { get; set; }

                /// <summary>
                /// The name of the alert rule that is associated with the event.
                /// </summary>
                [NameInMap("AlertType")]
                [Validation(Required=false)]
                public int? AlertType { get; set; }

                /// <summary>
                /// The number of entries to return on each page. Default value: `10`.
                /// </summary>
                [NameInMap("EventLevel")]
                [Validation(Required=false)]
                public string EventLevel { get; set; }

                /// <summary>
                /// The struct returned.
                /// </summary>
                [NameInMap("EventTime")]
                [Validation(Required=false)]
                public long? EventTime { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("Links")]
                [Validation(Required=false)]
                public List<string> Links { get; set; }

                /// <summary>
                /// The condition of the alert rule.
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

            }

            /// <summary>
            /// The number of the page to return. Default value: `1`.
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// The type of the alert rule. Valid values:
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
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The beginning of the time range to query. Specify a UNIX timestamp of the LONG data type, in milliseconds. The default value is 10 minutes before the current time.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// The severity of the event.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
