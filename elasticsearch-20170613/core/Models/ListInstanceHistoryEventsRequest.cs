// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListInstanceHistoryEventsRequest : TeaModel {
        [NameInMap("body")]
        [Validation(Required=false)]
        public List<ListInstanceHistoryEventsRequestBody> Body { get; set; }
        public class ListInstanceHistoryEventsRequestBody : TeaModel {
            [NameInMap("desc")]
            [Validation(Required=false)]
            public bool? Desc { get; set; }

            [NameInMap("sortField")]
            [Validation(Required=false)]
            public string SortField { get; set; }

        }

        [NameInMap("eventCreateEndTime")]
        [Validation(Required=false)]
        public string EventCreateEndTime { get; set; }

        [NameInMap("eventCreateStartTime")]
        [Validation(Required=false)]
        public string EventCreateStartTime { get; set; }

        [NameInMap("eventExecuteEndTime")]
        [Validation(Required=false)]
        public string EventExecuteEndTime { get; set; }

        [NameInMap("eventExecuteStartTime")]
        [Validation(Required=false)]
        public string EventExecuteStartTime { get; set; }

        [NameInMap("eventFinashEndTime")]
        [Validation(Required=false)]
        public string EventFinashEndTime { get; set; }

        [NameInMap("eventFinashStartTime")]
        [Validation(Required=false)]
        public string EventFinashStartTime { get; set; }

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

    }

}
