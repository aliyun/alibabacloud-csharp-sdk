// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20210422.Models
{
    public class SearchEventsResponseBody : TeaModel {
        [NameInMap("IsTrigger")]
        [Validation(Required=false)]
        public int? IsTrigger { get; set; }

        [NameInMap("PageBean")]
        [Validation(Required=false)]
        public SearchEventsResponseBodyPageBean PageBean { get; set; }
        public class SearchEventsResponseBodyPageBean : TeaModel {
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

                [NameInMap("AlertRule")]
                [Validation(Required=false)]
                public string AlertRule { get; set; }

                [NameInMap("AlertType")]
                [Validation(Required=false)]
                public int? AlertType { get; set; }

                [NameInMap("EventLevel")]
                [Validation(Required=false)]
                public string EventLevel { get; set; }

                [NameInMap("EventTime")]
                [Validation(Required=false)]
                public long? EventTime { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("Links")]
                [Validation(Required=false)]
                public List<string> Links { get; set; }

                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

            }

            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
