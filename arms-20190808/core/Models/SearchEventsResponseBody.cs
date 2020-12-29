// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class SearchEventsResponseBody : TeaModel {
        [NameInMap("PageBean")]
        [Validation(Required=false)]
        public SearchEventsResponseBodyPageBean PageBean { get; set; }
        public class SearchEventsResponseBodyPageBean : TeaModel {
            [NameInMap("Event")]
            [Validation(Required=false)]
            public List<SearchEventsResponseBodyPageBeanEvent> Event { get; set; }
            public class SearchEventsResponseBodyPageBeanEvent : TeaModel {
                public long? EventTime { get; set; }
                public List<string> Links { get; set; }
                public string EventLevel { get; set; }
                public string AlertRule { get; set; }
                public string Message { get; set; }
                public int? AlertType { get; set; }
                public string AlertName { get; set; }
                public long? Id { get; set; }
                public long? AlertId { get; set; }
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
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("IsTrigger")]
        [Validation(Required=false)]
        public int? IsTrigger { get; set; }

    }

}
