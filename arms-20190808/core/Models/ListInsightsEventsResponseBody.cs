// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ListInsightsEventsResponseBody : TeaModel {
        /// <summary>
        /// The description of the event.
        /// </summary>
        [NameInMap("InsightsEvents")]
        [Validation(Required=false)]
        public List<ListInsightsEventsResponseBodyInsightsEvents> InsightsEvents { get; set; }
        public class ListInsightsEventsResponseBodyInsightsEvents : TeaModel {
            /// <summary>
            /// The time at which the event occurred. The value is a timestamp.
            /// </summary>
            [NameInMap("Date")]
            [Validation(Required=false)]
            public long? Date { get; set; }

            /// <summary>
            /// The ID of the application associated with the event.
            /// </summary>
            [NameInMap("Desc")]
            [Validation(Required=false)]
            public string Desc { get; set; }

            /// <summary>
            /// Queries the abnormal Insights events within a specified period of time.
            /// </summary>
            [NameInMap("Level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            /// <summary>
            /// auditing
            /// </summary>
            [NameInMap("Pid")]
            [Validation(Required=false)]
            public string Pid { get; set; }

            [NameInMap("ProblemId")]
            [Validation(Required=false)]
            public string ProblemId { get; set; }

            /// <summary>
            /// The overall response time of the \[HTTP] service of the application \[sd] spikes at \[2022-07-27 10:57:00]
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// The time at which the event occurred. The value is a timestamp.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// The title of the event.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
