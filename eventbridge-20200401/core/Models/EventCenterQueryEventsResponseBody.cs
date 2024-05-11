// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class EventCenterQueryEventsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public EventCenterQueryEventsResponseBodyData Data { get; set; }
        public class EventCenterQueryEventsResponseBodyData : TeaModel {
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            [NameInMap("Table")]
            [Validation(Required=false)]
            public List<EventCenterQueryEventsResponseBodyDataTable> Table { get; set; }
            public class EventCenterQueryEventsResponseBodyDataTable : TeaModel {
                [NameInMap("RowData")]
                [Validation(Required=false)]
                public Dictionary<string, object> RowData { get; set; }

            }

            [NameInMap("TimeSeries")]
            [Validation(Required=false)]
            public List<EventCenterQueryEventsResponseBodyDataTimeSeries> TimeSeries { get; set; }
            public class EventCenterQueryEventsResponseBodyDataTimeSeries : TeaModel {
                [NameInMap("RowData")]
                [Validation(Required=false)]
                public Dictionary<string, object> RowData { get; set; }

                [NameInMap("Time")]
                [Validation(Required=false)]
                public string Time { get; set; }

            }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
