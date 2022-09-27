// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListInstanceHistoryEventsRequest : TeaModel {
        [NameInMap("eventCreateEndTime")]
        [Validation(Required=false)]
        public string EventCreateEndTime { get; set; }

        [NameInMap("eventCreateStartTime")]
        [Validation(Required=false)]
        public string EventCreateStartTime { get; set; }

        [NameInMap("eventCycleStatus")]
        [Validation(Required=false)]
        public List<string> EventCycleStatus { get; set; }

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
        public List<string> EventLevel { get; set; }

        [NameInMap("eventType")]
        [Validation(Required=false)]
        public List<string> EventType { get; set; }

        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("nodeIP")]
        [Validation(Required=false)]
        public string NodeIP { get; set; }

        [NameInMap("page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        [NameInMap("size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

    }

}
