// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListInstanceHistoryEventsResponseBody : TeaModel {
        [NameInMap("Headers")]
        [Validation(Required=false)]
        public ListInstanceHistoryEventsResponseBodyHeaders Headers { get; set; }
        public class ListInstanceHistoryEventsResponseBodyHeaders : TeaModel {
            [NameInMap("X-Total-Count")]
            [Validation(Required=false)]
            public long? XTotalCount { get; set; }
            [NameInMap("X-Total-Failed")]
            [Validation(Required=false)]
            public long? XTotalFailed { get; set; }
            [NameInMap("X-Total-Success")]
            [Validation(Required=false)]
            public long? XTotalSuccess { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListInstanceHistoryEventsResponseBodyResult> Result { get; set; }
        public class ListInstanceHistoryEventsResponseBodyResult : TeaModel {
            [NameInMap("actionList")]
            [Validation(Required=false)]
            public List<string> ActionList { get; set; }

            [NameInMap("eventCreateTime")]
            [Validation(Required=false)]
            public string EventCreateTime { get; set; }

            [NameInMap("eventCycleStatus")]
            [Validation(Required=false)]
            public string EventCycleStatus { get; set; }

            [NameInMap("eventExecuteTime")]
            [Validation(Required=false)]
            public string EventExecuteTime { get; set; }

            [NameInMap("eventFinashTime")]
            [Validation(Required=false)]
            public string EventFinashTime { get; set; }

            [NameInMap("eventLevel")]
            [Validation(Required=false)]
            public string EventLevel { get; set; }

            [NameInMap("eventType")]
            [Validation(Required=false)]
            public string EventType { get; set; }

            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("nodeIP")]
            [Validation(Required=false)]
            public string NodeIP { get; set; }

            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

    }

}
